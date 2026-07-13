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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewManagedClusterList : IKubernetesObject<V1ListMeta>, IItems<V20251002previewManagedCluster>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "ManagedClusterList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251002previewManagedCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251002previewManagedCluster> Items { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAadProfile
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
public partial class V20251002previewManagedClusterSpecAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesArtifactStreamingProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
/// not Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesGatewayProfile
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverTypeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverTypeEnum
{
    [EnumMember(Value = "CUDA"), JsonStringEnumMemberName("CUDA")]
    CUDA,
    [EnumMember(Value = "GRID"), JsonStringEnumMemberName("GRID")]
    GRID
}

/// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfile
{
    /// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
    [JsonPropertyName("driver")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum? Driver { get; set; }

    /// <summary>
    /// DriverType: Specify the type of GPU driver to install when creating Windows agent pools. If not provided, AKS selects
    /// the driver based on system compatibility. This cannot be changed once the AgentPool has been created. This cannot be set
    /// on Linux AgentPools. For Linux AgentPools, the driver is selected based on system compatibility.
    /// </summary>
    [JsonPropertyName("driverType")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfileDriverTypeEnum? DriverType { get; set; }
}

/// <summary>
/// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
/// only in creation scenario and not allowed to changed once set. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
/// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesHostGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesKubeletConfigSeccompDefaultEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesKubeletConfigSeccompDefaultEnum
{
    [EnumMember(Value = "RuntimeDefault"), JsonStringEnumMemberName("RuntimeDefault")]
    RuntimeDefault,
    [EnumMember(Value = "Unconfined"), JsonStringEnumMemberName("Unconfined")]
    Unconfined
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesKubeletConfig
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
    public V20251002previewManagedClusterSpecAgentPoolProfilesKubeletConfigSeccompDefaultEnum? SeccompDefault { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum
{
    [EnumMember(Value = "OS"), JsonStringEnumMemberName("OS")]
    OS,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardDestinationEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardDestinationEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardPolicyEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardPolicyEnum
{
    [EnumMember(Value = "Random"), JsonStringEnumMemberName("Random")]
    Random,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin,
    [EnumMember(Value = "Sequential"), JsonStringEnumMemberName("Sequential")]
    Sequential
}

/// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesProtocolEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesProtocolEnum
{
    [EnumMember(Value = "ForceTCP"), JsonStringEnumMemberName("ForceTCP")]
    ForceTCP,
    [EnumMember(Value = "PreferUDP"), JsonStringEnumMemberName("PreferUDP")]
    PreferUDP
}

/// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesQueryLoggingEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesQueryLoggingEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesServeStaleEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesServeStaleEnum
{
    [EnumMember(Value = "Disable"), JsonStringEnumMemberName("Disable")]
    Disable,
    [EnumMember(Value = "Immediate"), JsonStringEnumMemberName("Immediate")]
    Immediate,
    [EnumMember(Value = "Verify"), JsonStringEnumMemberName("Verify")]
    Verify
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardDestinationEnum? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesForwardPolicyEnum? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesProtocolEnum? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesQueryLoggingEnum? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverridesServeStaleEnum? ServeStale { get; set; }

    /// <summary>
    /// ServeStaleDurationInSeconds: Serve stale duration in seconds. See [cache plugin](https://coredns.io/plugins/cache) for
    /// more information.
    /// </summary>
    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>Mode: Mode of enablement for localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileModeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Preferred"), JsonStringEnumMemberName("Preferred")]
    Preferred,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required
}

/// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardDestinationEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardDestinationEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardPolicyEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardPolicyEnum
{
    [EnumMember(Value = "Random"), JsonStringEnumMemberName("Random")]
    Random,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin,
    [EnumMember(Value = "Sequential"), JsonStringEnumMemberName("Sequential")]
    Sequential
}

/// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesProtocolEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesProtocolEnum
{
    [EnumMember(Value = "ForceTCP"), JsonStringEnumMemberName("ForceTCP")]
    ForceTCP,
    [EnumMember(Value = "PreferUDP"), JsonStringEnumMemberName("PreferUDP")]
    PreferUDP
}

/// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesQueryLoggingEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesQueryLoggingEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesServeStaleEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesServeStaleEnum
{
    [EnumMember(Value = "Disable"), JsonStringEnumMemberName("Disable")]
    Disable,
    [EnumMember(Value = "Immediate"), JsonStringEnumMemberName("Immediate")]
    Immediate,
    [EnumMember(Value = "Verify"), JsonStringEnumMemberName("Verify")]
    Verify
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardDestinationEnum? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesForwardPolicyEnum? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesProtocolEnum? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesQueryLoggingEnum? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverridesServeStaleEnum? ServeStale { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfile
{
    /// <summary>
    /// KubeDNSOverrides: KubeDNS overrides apply to DNS traffic from pods with dnsPolicy:ClusterFirst (referred to as KubeDNS
    /// traffic).
    /// </summary>
    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    /// <summary>Mode: Mode of enablement for localDNS.</summary>
    [JsonPropertyName("mode")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileModeEnum? Mode { get; set; }

    /// <summary>
    /// VnetDNSOverrides: VnetDNS overrides apply to DNS traffic from pods with dnsPolicy:default or kubelet (referred to as
    /// VnetDNS traffic).
    /// </summary>
    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Mode: The mode of an agent pool. A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional
/// information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesModeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts
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
    public V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>
    /// ApplicationSecurityGroupsReferences: The IDs of the application security groups which agent pool will associate when
    /// created.
    /// </summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
/// the version will use the latest version of the node customization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNodeCustomizationProfileNodeCustomizationReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNodeCustomizationProfile
{
    /// <summary>
    /// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
    /// the version will use the latest version of the node customization.
    /// </summary>
    [JsonPropertyName("nodeCustomizationReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesNodeCustomizationProfileNodeCustomizationReference? NodeCustomizationReference { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference
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
/// and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
/// creation. For more information see [Ephemeral
/// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesOsSKUEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesOsSKUEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesOsTypeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
/// podSubnetId. The default is &apos;DynamicIndividual&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesPodSubnetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesScaleDownModeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesScaleDownModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>SshAccess: SSH access method of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "EntraId"), JsonStringEnumMemberName("EntraId")]
    EntraId,
    [EnumMember(Value = "LocalUser"), JsonStringEnumMemberName("LocalUser")]
    LocalUser
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesSecurityProfile
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
    public V20251002previewManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum? SshAccess { get; set; }
}

/// <summary>Type: The type of Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesTypeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesTypeEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum
{
    [EnumMember(Value = "Cordon"), JsonStringEnumMemberName("Cordon")]
    Cordon,
    [EnumMember(Value = "Schedule"), JsonStringEnumMemberName("Schedule")]
    Schedule
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettings
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
    public V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
/// BlueGreen.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettingsBlueGreen
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeStrategyEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeStrategyEnum
{
    [EnumMember(Value = "BlueGreen"), JsonStringEnumMemberName("BlueGreen")]
    BlueGreen,
    [EnumMember(Value = "Rolling"), JsonStringEnumMemberName("Rolling")]
    Rolling
}

/// <summary>Current status on a group of nodes of the same vm size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleAutoscale
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale
{
    /// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
/// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
/// pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesVnetSubnetReference
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
public partial class V20251002previewManagedClusterSpecAgentPoolProfilesWindowsProfile
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum>))]
public enum V20251002previewManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum
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

/// <summary>Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAgentPoolProfiles
{
    /// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// CapacityReservationGroupReference: The fully qualified resource ID of the Capacity Reservation Group to provide virtual
    /// machines from a reserved group of Virtual Machines. This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Compute/capacityreservationgroups/{capacityReservationGroupName}&apos;
    /// Customers use it to create an agentpool with a specified CRG. For more information see [Capacity
    /// Reservation](https://learn.microsoft.com/en-us/azure/virtual-machines/capacity-reservation-overview)
    /// </summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesCreationData? CreationData { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
    /// only in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesHostGroupReference? HostGroupReference { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
    /// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesLocalDNSProfile? LocalDNSProfile { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesModeEnum? Mode { get; set; }

    /// <summary>
    /// Name: Unique name of the agent pool profile in the context of the subscription and resource group. Windows agent pool
    /// names must be 6 characters or less.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesOsSKUEnum? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
    /// podSubnetId. The default is &apos;DynamicIndividual&apos;.
    /// </summary>
    [JsonPropertyName("podIPAllocationMode")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum? PodIPAllocationMode { get; set; }

    /// <summary>
    /// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
    /// on the node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
    /// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
    /// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary>
    /// ScaleDownMode: The scale down mode to use when scaling the Agent Pool. This also effects the cluster autoscaler
    /// behavior. If not specified, it defaults to Delete.
    /// </summary>
    [JsonPropertyName("scaleDownMode")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesScaleDownModeEnum? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy. The eviction policy specifies what to do with the
    /// VM when it is evicted. The default is Delete. For more information about eviction see [spot
    /// VMs](https://docs.microsoft.com/azure/virtual-machines/spot-vms)
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesTypeEnum? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
    /// BlueGreen.
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    /// <summary>UpgradeStrategy: Defines the upgrade strategy for the agent pool. The default is Rolling.</summary>
    [JsonPropertyName("upgradeStrategy")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesUpgradeStrategyEnum? UpgradeStrategy { get; set; }

    /// <summary>VirtualMachineNodesStatus: The status of nodes in a VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

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
    public V20251002previewManagedClusterSpecAgentPoolProfilesVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public V20251002previewManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum? WorkloadRuntime { get; set; }
}

/// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAiToolchainOperatorProfile
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
public partial class V20251002previewManagedClusterSpecApiServerAccessProfileSubnetReference
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
public partial class V20251002previewManagedClusterSpecApiServerAccessProfile
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
    public V20251002previewManagedClusterSpecApiServerAccessProfileSubnetReference? SubnetReference { get; set; }
}

/// <summary>
/// Expander: The expander to use when scaling up. If not specified, the default is &apos;random&apos;. See
/// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
/// information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAutoScalerProfileExpanderEnum>))]
public enum V20251002previewManagedClusterSpecAutoScalerProfileExpanderEnum
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
public partial class V20251002previewManagedClusterSpecAutoScalerProfile
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
    public V20251002previewManagedClusterSpecAutoScalerProfileExpanderEnum? Expander { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum>))]
public enum V20251002previewManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum>))]
public enum V20251002previewManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum
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
public partial class V20251002previewManagedClusterSpecAutoUpgradeProfile
{
    /// <summary>NodeOSUpgradeChannel: Node OS Upgrade Channel. Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public V20251002previewManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum? NodeOSUpgradeChannel { get; set; }

    /// <summary>
    /// UpgradeChannel: The upgrade channel for auto upgrade. The default is &apos;none&apos;. For more information see [setting the AKS
    /// cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    [JsonPropertyName("upgradeChannel")]
    public V20251002previewManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum? UpgradeChannel { get; set; }
}

/// <summary>
/// AutoInstrumentation: Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook
/// to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the
/// application. See aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringAutoInstrumentation
{
    /// <summary>Enabled: Indicates if Application Monitoring Auto Instrumentation is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// OpenTelemetryLogs: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and
/// Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryLogs
{
    /// <summary>Enabled: Indicates if Application Monitoring Open Telemetry Logs and traces is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Port: The Open Telemetry host port for Open Telemetry logs and traces. If not specified, the default port is 28331.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// OpenTelemetryMetrics: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container
/// Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
{
    /// <summary>Enabled: Indicates if Application Monitoring Open Telemetry Metrics is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Port: The Open Telemetry host port for Open Telemetry metrics. If not specified, the default port is 28333.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// AppMonitoring: Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics
/// and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoring
{
    /// <summary>
    /// AutoInstrumentation: Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook
    /// to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the
    /// application. See aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("autoInstrumentation")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringAutoInstrumentation? AutoInstrumentation { get; set; }

    /// <summary>
    /// OpenTelemetryLogs: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and
    /// Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryLogs")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryLogs? OpenTelemetryLogs { get; set; }

    /// <summary>
    /// OpenTelemetryMetrics: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container
    /// Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryMetrics")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryMetrics? OpenTelemetryMetrics { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Fully Qualified ARM Resource Id of Azure Log Analytics Workspace for storing
/// Azure Monitor Container Insights Logs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileContainerInsightsLogAnalyticsWorkspaceResourceReference
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
/// ContainerInsights: Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp;
/// stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileContainerInsights
{
    /// <summary>
    /// DisableCustomMetrics: Indicates whether custom metrics collection has to be disabled or not. If not specified the
    /// default is false. No custom metrics will be emitted if this field is false but the container insights enabled field is
    /// false
    /// </summary>
    [JsonPropertyName("disableCustomMetrics")]
    public bool? DisableCustomMetrics { get; set; }

    /// <summary>
    /// DisablePrometheusMetricsScraping: Indicates whether prometheus metrics scraping is disabled or not. If not specified the
    /// default is false. No prometheus metrics will be emitted if this field is false but the container insights enabled field
    /// is false
    /// </summary>
    [JsonPropertyName("disablePrometheusMetricsScraping")]
    public bool? DisablePrometheusMetricsScraping { get; set; }

    /// <summary>Enabled: Indicates if Azure Monitor Container Insights Logs Addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Fully Qualified ARM Resource Id of Azure Log Analytics Workspace for storing
    /// Azure Monitor Container Insights Logs.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileContainerInsightsLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>SyslogPort: The syslog host port. If not specified, the default port is 28330.</summary>
    [JsonPropertyName("syslogPort")]
    public int? SyslogPort { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
/// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics
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
public partial class V20251002previewManagedClusterSpecAzureMonitorProfileMetrics
{
    /// <summary>
    /// Enabled: Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See
    /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>
    /// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    /// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecAzureMonitorProfile
{
    /// <summary>
    /// AppMonitoring: Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics
    /// and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("appMonitoring")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileAppMonitoring? AppMonitoring { get; set; }

    /// <summary>
    /// ContainerInsights: Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp;
    /// stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview.
    /// </summary>
    [JsonPropertyName("containerInsights")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileContainerInsights? ContainerInsights { get; set; }

    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V20251002previewManagedClusterSpecAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>ArtifactSource: The artifact source. The source where the artifacts are downloaded from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecBootstrapProfileArtifactSourceEnum>))]
public enum V20251002previewManagedClusterSpecBootstrapProfileArtifactSourceEnum
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
public partial class V20251002previewManagedClusterSpecBootstrapProfileContainerRegistryReference
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
public partial class V20251002previewManagedClusterSpecBootstrapProfile
{
    /// <summary>ArtifactSource: The artifact source. The source where the artifacts are downloaded from.</summary>
    [JsonPropertyName("artifactSource")]
    public V20251002previewManagedClusterSpecBootstrapProfileArtifactSourceEnum? ArtifactSource { get; set; }

    /// <summary>
    /// ContainerRegistryReference: The resource Id of Azure Container Registry. The registry must have private network access,
    /// premium SKU and zone redundancy.
    /// </summary>
    [JsonPropertyName("containerRegistryReference")]
    public V20251002previewManagedClusterSpecBootstrapProfileContainerRegistryReference? ContainerRegistryReference { get; set; }
}

/// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecCreationDataSourceResourceReference
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
/// CreationData: CreationData to be used to specify the source Snapshot ID if the cluster will be created/upgraded using a
/// snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewManagedClusterSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// DiskEncryptionSetReference: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is
/// of the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecDiskEncryptionSetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecExtendedLocationTypeEnum>))]
public enum V20251002previewManagedClusterSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20251002previewManagedClusterSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>
/// HostedSystemProfile: Settings for hosted system addons. For more information, see
/// https://aka.ms/aks/automatic/systemcomponents.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecHostedSystemProfile
{
    /// <summary>Enabled: Whether to enable hosted system addons for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecHttpProxyConfig
{
    /// <summary>
    /// Enabled: Whether to enable HTTP proxy. When disabled, the specified proxy configuration will be not be set on pods and
    /// nodes.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

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
public partial class V20251002previewManagedClusterSpecIdentityDelegatedResourcesResourceReference
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
public partial class V20251002previewManagedClusterSpecIdentityDelegatedResources
{
    /// <summary>Location: The source resource location - internal use only.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ReferralResource: The delegation id of the referral delegation (optional) - internal use only.</summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewManagedClusterSpecIdentityDelegatedResourcesResourceReference? ResourceReference { get; set; }

    /// <summary>TenantId: The tenant id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Type: The type of identity used for the managed cluster. For more information see [use managed identities in
/// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecIdentityTypeEnum>))]
public enum V20251002previewManagedClusterSpecIdentityTypeEnum
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
public partial class V20251002previewManagedClusterSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20251002previewManagedClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20251002previewManagedClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the managed cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V20251002previewManagedClusterSpecIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary>
    /// Type: The type of identity used for the managed cluster. For more information see [use managed identities in
    /// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
    /// </summary>
    [JsonPropertyName("type")]
    public V20251002previewManagedClusterSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The user identity associated with the managed cluster. This identity will be used in control
    /// plane. Only one user assigned identity is allowed. The keys must be ARM resource IDs in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20251002previewManagedClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIdentityProfileClientIdFromConfig
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
public partial class V20251002previewManagedClusterSpecIdentityProfileObjectIdFromConfig
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
public partial class V20251002previewManagedClusterSpecIdentityProfileResourceReference
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
public partial class V20251002previewManagedClusterSpecIdentityProfile
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewManagedClusterSpecIdentityProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewManagedClusterSpecIdentityProfileObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewManagedClusterSpecIdentityProfileResourceReference? ResourceReference { get; set; }
}

/// <summary>ApplicationLoadBalancer: Settings for the managed Application Load Balancer installation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfileApplicationLoadBalancer
{
    /// <summary>Enabled: Whether to enable Application Load Balancer.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Installation: Configuration for the managed Gateway API installation. If not specified, the default is &apos;Disabled&apos;. See
/// https://aka.ms/k8s-gateway-api for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecIngressProfileGatewayAPIInstallationEnum>))]
public enum V20251002previewManagedClusterSpecIngressProfileGatewayAPIInstallationEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>GatewayAPI: Settings for the managed Gateway API installation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfileGatewayAPI
{
    /// <summary>
    /// Installation: Configuration for the managed Gateway API installation. If not specified, the default is &apos;Disabled&apos;. See
    /// https://aka.ms/k8s-gateway-api for more details.
    /// </summary>
    [JsonPropertyName("installation")]
    public V20251002previewManagedClusterSpecIngressProfileGatewayAPIInstallationEnum? Installation { get; set; }
}

/// <summary>
/// DefaultDomain: Configuration for the Default Domain. This is a unique, autogenerated domain that comes with a signed TLS
/// Certificate allowing for secure HTTPS. See [the Default Domain documentation](https://aka.ms/aks/defaultdomain) for more
/// instructions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfileWebAppRoutingDefaultDomain
{
    /// <summary>Enabled: Whether to enable Default Domain.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum>))]
public enum V20251002previewManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum
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
public partial class V20251002previewManagedClusterSpecIngressProfileWebAppRoutingNginx
{
    /// <summary>DefaultIngressControllerType: Ingress type for the default NginxIngressController custom resource</summary>
    [JsonPropertyName("defaultIngressControllerType")]
    public V20251002previewManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum? DefaultIngressControllerType { get; set; }
}

/// <summary>
/// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
/// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfileWebAppRouting
{
    /// <summary>
    /// DefaultDomain: Configuration for the Default Domain. This is a unique, autogenerated domain that comes with a signed TLS
    /// Certificate allowing for secure HTTPS. See [the Default Domain documentation](https://aka.ms/aks/defaultdomain) for more
    /// instructions.
    /// </summary>
    [JsonPropertyName("defaultDomain")]
    public V20251002previewManagedClusterSpecIngressProfileWebAppRoutingDefaultDomain? DefaultDomain { get; set; }

    /// <summary>
    /// DnsZoneResourceReferences: Resource IDs of the DNS zones to be associated with the Application Routing add-on. Used only
    /// when Application Routing add-on is enabled. Public and private DNS zones can be in different resource groups, but all
    /// public DNS zones must be in the same resource group and all private DNS zones must be in the same resource group.
    /// </summary>
    [JsonPropertyName("dnsZoneResourceReferences")]
    public IList<V20251002previewManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences>? DnsZoneResourceReferences { get; set; }

    /// <summary>Enabled: Whether to enable the Application Routing add-on.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Nginx: Configuration for the default NginxIngressController. See more at
    /// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
    /// </summary>
    [JsonPropertyName("nginx")]
    public V20251002previewManagedClusterSpecIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecIngressProfile
{
    /// <summary>ApplicationLoadBalancer: Settings for the managed Application Load Balancer installation</summary>
    [JsonPropertyName("applicationLoadBalancer")]
    public V20251002previewManagedClusterSpecIngressProfileApplicationLoadBalancer? ApplicationLoadBalancer { get; set; }

    /// <summary>GatewayAPI: Settings for the managed Gateway API installation</summary>
    [JsonPropertyName("gatewayAPI")]
    public V20251002previewManagedClusterSpecIngressProfileGatewayAPI? GatewayAPI { get; set; }

    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V20251002previewManagedClusterSpecIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecLinuxProfileSshPublicKeys
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
public partial class V20251002previewManagedClusterSpecLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public required IList<V20251002previewManagedClusterSpecLinuxProfileSshPublicKeys> PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public required string AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public required V20251002previewManagedClusterSpecLinuxProfileSsh Ssh { get; set; }
}

/// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecMetricsProfileCostAnalysis
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
public partial class V20251002previewManagedClusterSpecMetricsProfile
{
    /// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
    [JsonPropertyName("costAnalysis")]
    public V20251002previewManagedClusterSpecMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// AccelerationMode: Enable advanced network acceleration options. This allows users to configure acceleration using BPF
/// host routing. This can be enabled only with Cilium dataplane. If not specified, the default value is None (no
/// acceleration). The acceleration mode can be changed on a pre-existing cluster. See https://aka.ms/acnsperformance for a
/// detailed explanation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingPerformanceAccelerationModeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingPerformanceAccelerationModeEnum
{
    [EnumMember(Value = "BpfVeth"), JsonStringEnumMemberName("BpfVeth")]
    BpfVeth,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Performance: Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingPerformance
{
    /// <summary>
    /// AccelerationMode: Enable advanced network acceleration options. This allows users to configure acceleration using BPF
    /// host routing. This can be enabled only with Cilium dataplane. If not specified, the default value is None (no
    /// acceleration). The acceleration mode can be changed on a pre-existing cluster. See https://aka.ms/acnsperformance for a
    /// detailed explanation
    /// </summary>
    [JsonPropertyName("accelerationMode")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingPerformanceAccelerationModeEnum? AccelerationMode { get; set; }
}

/// <summary>
/// AdvancedNetworkPolicies: Enable advanced network policies. This allows users to configure Layer 7 network policies
/// (FQDN, HTTP, Kafka). Policies themselves must be configured via the Cilium Network Policy resources, see
/// https://docs.cilium.io/en/latest/security/policy/index.html. This can be enabled only on cilium-based clusters. If not
/// specified, the default value is FQDN if security.enabled is set to true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum
{
    [EnumMember(Value = "FQDN"), JsonStringEnumMemberName("FQDN")]
    FQDN,
    [EnumMember(Value = "L7"), JsonStringEnumMemberName("L7")]
    L7,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// Type: Configures pod-to-pod encryption. This can be enabled only on Cilium-based clusters. If not specified, the default
/// value is None.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryptionTypeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryptionTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "WireGuard"), JsonStringEnumMemberName("WireGuard")]
    WireGuard
}

/// <summary>
/// TransitEncryption: Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed
/// pods will be encrypted when it leaves the node boundary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryption
{
    /// <summary>
    /// Type: Configures pod-to-pod encryption. This can be enabled only on Cilium-based clusters. If not specified, the default
    /// value is None.
    /// </summary>
    [JsonPropertyName("type")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// AdvancedNetworkPolicies: Enable advanced network policies. This allows users to configure Layer 7 network policies
    /// (FQDN, HTTP, Kafka). Policies themselves must be configured via the Cilium Network Policy resources, see
    /// https://docs.cilium.io/en/latest/security/policy/index.html. This can be enabled only on cilium-based clusters. If not
    /// specified, the default value is FQDN if security.enabled is set to true.
    /// </summary>
    [JsonPropertyName("advancedNetworkPolicies")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum? AdvancedNetworkPolicies { get; set; }

    /// <summary>
    /// Enabled: This feature allows user to configure network policy based on DNS (FQDN) names. It can be enabled only on
    /// cilium based clusters. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// TransitEncryption: Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed
    /// pods will be encrypted when it leaves the node boundary.
    /// </summary>
    [JsonPropertyName("transitEncryption")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryption? TransitEncryption { get; set; }
}

/// <summary>
/// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
/// more information see aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworking
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
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Performance: Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.</summary>
    [JsonPropertyName("performance")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingPerformance? Performance { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>To determine if address belongs IPv4 or IPv6 family</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileIpFamiliesEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Scheduler: IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfigSchedulerEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfigSchedulerEnum
{
    [EnumMember(Value = "LeastConnection"), JsonStringEnumMemberName("LeastConnection")]
    LeastConnection,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>IpvsConfig: Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfig
{
    /// <summary>Scheduler: IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html.</summary>
    [JsonPropertyName("scheduler")]
    public V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfigSchedulerEnum? Scheduler { get; set; }

    /// <summary>
    /// TcpFinTimeoutSeconds: The timeout value used for IPVS TCP sessions after receiving a FIN in seconds. Must be a positive
    /// integer value.
    /// </summary>
    [JsonPropertyName("tcpFinTimeoutSeconds")]
    public int? TcpFinTimeoutSeconds { get; set; }

    /// <summary>TcpTimeoutSeconds: The timeout value used for idle IPVS TCP sessions in seconds. Must be a positive integer value.</summary>
    [JsonPropertyName("tcpTimeoutSeconds")]
    public int? TcpTimeoutSeconds { get; set; }

    /// <summary>UdpTimeoutSeconds: The timeout value used for IPVS UDP packets in seconds. Must be a positive integer value.</summary>
    [JsonPropertyName("udpTimeoutSeconds")]
    public int? UdpTimeoutSeconds { get; set; }
}

/// <summary>Mode: Specify which proxy mode to use (&apos;IPTABLES&apos;, &apos;IPVS&apos; or &apos;NFTABLES&apos;)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigModeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigModeEnum
{
    [EnumMember(Value = "IPTABLES"), JsonStringEnumMemberName("IPTABLES")]
    IPTABLES,
    [EnumMember(Value = "IPVS"), JsonStringEnumMemberName("IPVS")]
    IPVS,
    [EnumMember(Value = "NFTABLES"), JsonStringEnumMemberName("NFTABLES")]
    NFTABLES
}

/// <summary>
/// KubeProxyConfig: Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy
/// defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/
/// where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfig
{
    /// <summary>
    /// Enabled: Whether to enable on kube-proxy on the cluster (if no &apos;kubeProxyConfig&apos; exists, kube-proxy is enabled in AKS by
    /// default without these customizations).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IpvsConfig: Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.</summary>
    [JsonPropertyName("ipvsConfig")]
    public V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfig? IpvsConfig { get; set; }

    /// <summary>Mode: Specify which proxy mode to use (&apos;IPTABLES&apos;, &apos;IPVS&apos; or &apos;NFTABLES&apos;)</summary>
    [JsonPropertyName("mode")]
    public V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfigModeEnum? Mode { get; set; }
}

/// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum
{
    [EnumMember(Value = "NodeIP"), JsonStringEnumMemberName("NodeIP")]
    NodeIP,
    [EnumMember(Value = "NodeIPConfiguration"), JsonStringEnumMemberName("NodeIPConfiguration")]
    NodeIPConfiguration
}

/// <summary>ClusterServiceLoadBalancerHealthProbeMode: The health probing behavior for External Traffic Policy Cluster services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileClusterServiceLoadBalancerHealthProbeModeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileClusterServiceLoadBalancerHealthProbeModeEnum
{
    [EnumMember(Value = "ServiceNodePort"), JsonStringEnumMemberName("ServiceNodePort")]
    ServiceNodePort,
    [EnumMember(Value = "Shared"), JsonStringEnumMemberName("Shared")]
    Shared
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs
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
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference
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
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference? Reference { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference
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
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference? Reference { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// AllocatedOutboundPorts: The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000
    /// (inclusive). The default value is 0 which results in Azure dynamically allocating ports.
    /// </summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
    [JsonPropertyName("backendPoolType")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum? BackendPoolType { get; set; }

    /// <summary>ClusterServiceLoadBalancerHealthProbeMode: The health probing behavior for External Traffic Policy Cluster services.</summary>
    [JsonPropertyName("clusterServiceLoadBalancerHealthProbeMode")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileClusterServiceLoadBalancerHealthProbeModeEnum? ClusterServiceLoadBalancerHealthProbeMode { get; set; }

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
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>
/// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
/// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
/// balancer SKUs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileLoadBalancerSkuEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileLoadBalancerSkuEnum
{
    [EnumMember(Value = "basic"), JsonStringEnumMemberName("basic")]
    Basic,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile
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
public partial class V20251002previewManagedClusterSpecNetworkProfileNatGatewayProfile
{
    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V20251002previewManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileNetworkDataplaneEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileNetworkDataplaneEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileNetworkModeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileNetworkModeEnum
{
    [EnumMember(Value = "bridge"), JsonStringEnumMemberName("bridge")]
    Bridge,
    [EnumMember(Value = "transparent"), JsonStringEnumMemberName("transparent")]
    Transparent
}

/// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileNetworkPluginEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileNetworkPluginEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileNetworkPluginModeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileNetworkPluginModeEnum
{
    [EnumMember(Value = "overlay"), JsonStringEnumMemberName("overlay")]
    Overlay
}

/// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileNetworkPolicyEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileNetworkPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfileOutboundTypeEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfileOutboundTypeEnum
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
/// PodLinkLocalAccess: Defines access to special link local addresses (Azure Instance Metadata Service, aka IMDS) for pods
/// with hostNetwork=false. if not specified, the default is &apos;IMDS&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNetworkProfilePodLinkLocalAccessEnum>))]
public enum V20251002previewManagedClusterSpecNetworkProfilePodLinkLocalAccessEnum
{
    [EnumMember(Value = "IMDS"), JsonStringEnumMemberName("IMDS")]
    IMDS,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
/// see https://aka.ms/aks/static-egress-gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfileStaticEgressGatewayProfile
{
    /// <summary>Enabled: Enable Static Egress Gateway addon. Indicates if Static Egress Gateway addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V20251002previewManagedClusterSpecNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

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
    public IList<V20251002previewManagedClusterSpecNetworkProfileIpFamiliesEnum>? IpFamilies { get; set; }

    /// <summary>
    /// KubeProxyConfig: Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy
    /// defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/
    /// where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
    /// </summary>
    [JsonPropertyName("kubeProxyConfig")]
    public V20251002previewManagedClusterSpecNetworkProfileKubeProxyConfig? KubeProxyConfig { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public V20251002previewManagedClusterSpecNetworkProfileLoadBalancerSkuEnum? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V20251002previewManagedClusterSpecNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
    [JsonPropertyName("networkDataplane")]
    public V20251002previewManagedClusterSpecNetworkProfileNetworkDataplaneEnum? NetworkDataplane { get; set; }

    /// <summary>
    /// NetworkMode: The network mode Azure CNI is configured with. This cannot be specified if networkPlugin is anything other
    /// than &apos;azure&apos;.
    /// </summary>
    [JsonPropertyName("networkMode")]
    public V20251002previewManagedClusterSpecNetworkProfileNetworkModeEnum? NetworkMode { get; set; }

    /// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPlugin")]
    public V20251002previewManagedClusterSpecNetworkProfileNetworkPluginEnum? NetworkPlugin { get; set; }

    /// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
    [JsonPropertyName("networkPluginMode")]
    public V20251002previewManagedClusterSpecNetworkProfileNetworkPluginModeEnum? NetworkPluginMode { get; set; }

    /// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPolicy")]
    public V20251002previewManagedClusterSpecNetworkProfileNetworkPolicyEnum? NetworkPolicy { get; set; }

    /// <summary>
    /// OutboundType: The outbound (egress) routing method. This can only be set at cluster creation time and cannot be changed
    /// later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    [JsonPropertyName("outboundType")]
    public V20251002previewManagedClusterSpecNetworkProfileOutboundTypeEnum? OutboundType { get; set; }

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
    /// PodLinkLocalAccess: Defines access to special link local addresses (Azure Instance Metadata Service, aka IMDS) for pods
    /// with hostNetwork=false. if not specified, the default is &apos;IMDS&apos;.
    /// </summary>
    [JsonPropertyName("podLinkLocalAccess")]
    public V20251002previewManagedClusterSpecNetworkProfilePodLinkLocalAccessEnum? PodLinkLocalAccess { get; set; }

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
    public V20251002previewManagedClusterSpecNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>
/// DefaultNodePools: The set of default Karpenter NodePools (CRDs) configured for node provisioning. This field has no
/// effect unless mode is &apos;Auto&apos;. Warning: Changing this from Auto to None on an existing cluster will cause the default
/// Karpenter NodePools to be deleted, which will drain and delete the nodes associated with those pools. It is strongly
/// recommended to not do this unless there are idle nodes ready to take the pods evicted by that action. If not specified,
/// the default is Auto. For more information see aka.ms/aks/nap#node-pools.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum>))]
public enum V20251002previewManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Mode: The node provisioning mode. If not specified, the default is Manual.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNodeProvisioningProfileModeEnum>))]
public enum V20251002previewManagedClusterSpecNodeProvisioningProfileModeEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNodeProvisioningProfile
{
    /// <summary>
    /// DefaultNodePools: The set of default Karpenter NodePools (CRDs) configured for node provisioning. This field has no
    /// effect unless mode is &apos;Auto&apos;. Warning: Changing this from Auto to None on an existing cluster will cause the default
    /// Karpenter NodePools to be deleted, which will drain and delete the nodes associated with those pools. It is strongly
    /// recommended to not do this unless there are idle nodes ready to take the pods evicted by that action. If not specified,
    /// the default is Auto. For more information see aka.ms/aks/nap#node-pools.
    /// </summary>
    [JsonPropertyName("defaultNodePools")]
    public V20251002previewManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum? DefaultNodePools { get; set; }

    /// <summary>Mode: The node provisioning mode. If not specified, the default is Manual.</summary>
    [JsonPropertyName("mode")]
    public V20251002previewManagedClusterSpecNodeProvisioningProfileModeEnum? Mode { get; set; }
}

/// <summary>
/// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
/// &apos;Unrestricted&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum>))]
public enum V20251002previewManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum
{
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "Unrestricted"), JsonStringEnumMemberName("Unrestricted")]
    Unrestricted
}

/// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecNodeResourceGroupProfile
{
    /// <summary>
    /// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
    /// &apos;Unrestricted&apos;
    /// </summary>
    [JsonPropertyName("restrictionLevel")]
    public V20251002previewManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum? RestrictionLevel { get; set; }
}

/// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecOidcIssuerProfile
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
public partial class V20251002previewManagedClusterSpecOperatorSpecConfigMapExpressions
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
public partial class V20251002previewManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile
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
public partial class V20251002previewManagedClusterSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// OIDCIssuerProfile: indicates where the OIDCIssuerProfile config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile? OidcIssuerProfile { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecOperatorSpecSecretExpressions
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
public partial class V20251002previewManagedClusterSpecOperatorSpecSecretsAdminCredentials
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
public partial class V20251002previewManagedClusterSpecOperatorSpecSecretsUserCredentials
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
public partial class V20251002previewManagedClusterSpecOperatorSpecSecrets
{
    /// <summary>
    /// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminCredentials")]
    public V20251002previewManagedClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>
    /// UserCredentials: indicates where the UserCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("userCredentials")]
    public V20251002previewManagedClusterSpecOperatorSpecSecretsUserCredentials? UserCredentials { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20251002previewManagedClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20251002previewManagedClusterSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20251002previewManagedClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20251002previewManagedClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecOwner
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
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig
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
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig
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
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference
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
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public required V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity Identity { get; set; }

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
public partial class V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions
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
public partial class V20251002previewManagedClusterSpecPodIdentityProfile
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
    public IList<V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V20251002previewManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Reference: The ID of the private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecPrivateLinkResourcesReference
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
public partial class V20251002previewManagedClusterSpecPrivateLinkResources
{
    /// <summary>GroupId: The group ID of the resource.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: The name of the private link resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: The ID of the private link resource.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewManagedClusterSpecPrivateLinkResourcesReference? Reference { get; set; }

    /// <summary>RequiredMembers: The RequiredMembers of the resource</summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublicNetworkAccess: PublicNetworkAccess of the managedCluster. Allow or deny public network access for AKS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecPublicNetworkAccessEnum>))]
public enum V20251002previewManagedClusterSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

/// <summary>SchedulerConfigMode: The config customization mode for this scheduler instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstreamSchedulerConfigModeEnum>))]
public enum V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstreamSchedulerConfigModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "ManagedByCRD"), JsonStringEnumMemberName("ManagedByCRD")]
    ManagedByCRD
}

/// <summary>Upstream: The scheduler profile for the upstream scheduler instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstream
{
    /// <summary>SchedulerConfigMode: The config customization mode for this scheduler instance.</summary>
    [JsonPropertyName("schedulerConfigMode")]
    public V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstreamSchedulerConfigModeEnum? SchedulerConfigMode { get; set; }
}

/// <summary>SchedulerInstanceProfiles: Mapping of each scheduler instance to its profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfiles
{
    /// <summary>Upstream: The scheduler profile for the upstream scheduler instance.</summary>
    [JsonPropertyName("upstream")]
    public V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstream? Upstream { get; set; }
}

/// <summary>SchedulerProfile: Profile of the pod scheduler configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSchedulerProfile
{
    /// <summary>SchedulerInstanceProfiles: Mapping of each scheduler instance to its profile.</summary>
    [JsonPropertyName("schedulerInstanceProfiles")]
    public V20251002previewManagedClusterSpecSchedulerProfileSchedulerInstanceProfiles? SchedulerInstanceProfiles { get; set; }
}

/// <summary>
/// KeyVaultNetworkAccess: Network access of the key vault. Network access of key vault. The possible values are `Public`
/// and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault
/// disables public access and enables private link. The default value is `Public`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum>))]
public enum V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum
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
public partial class V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference
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
public partial class V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKms
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
    public V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum? KeyVaultNetworkAccess { get; set; }

    /// <summary>
    /// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
    /// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyVaultResourceReference")]
    public V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference? KeyVaultResourceReference { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
/// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
/// Microsoft Defender is disabled, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference
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

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityClientIdFromConfig
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
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityObjectIdFromConfig
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
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityResourceReference
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

/// <summary>Identity: The identity object used to access the registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentities
{
    /// <summary>
    /// AzureContainerRegistry: The container registry for which the identity will be used; the identity specified here should
    /// have a federated identity credential attached to it.
    /// </summary>
    [JsonPropertyName("azureContainerRegistry")]
    public string? AzureContainerRegistry { get; set; }

    /// <summary>Identity: The identity object used to access the registry</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentity? Identity { get; set; }
}

/// <summary>
/// SecurityGating: Microsoft Defender settings for security gating, validates container images eligibility for deployment
/// based on Defender for Containers security findings. Using Admission Controller, it either audits or prevents the
/// deployment of images that do not meet security standards.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGating
{
    /// <summary>
    /// AllowSecretAccess: In use only while registry access granted by secret rather than managed identity. Set whether to
    /// grant the Defender gating agent access to the cluster&apos;s secrets for pulling images from registries. If secret access is
    /// denied and the registry requires pull secrets, the add-on will not perform any image validation. Default value is false.
    /// </summary>
    [JsonPropertyName("allowSecretAccess")]
    public bool? AllowSecretAccess { get; set; }

    /// <summary>
    /// Enabled: Whether to enable Defender security gating. When enabled, the gating feature will scan container images and
    /// audit or block the deployment of images that do not meet security standards according to the configured security rules.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identities: List of identities that the admission controller will make use of in order to pull security artifacts from
    /// the registry. These are the same identities used by the cluster to pull container images. Each identity provided should
    /// have federated identity credential attached to it.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentities>? Identities { get; set; }
}

/// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileDefender
{
    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
    /// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
    /// Microsoft Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>
    /// SecurityGating: Microsoft Defender settings for security gating, validates container images eligibility for deployment
    /// based on Defender for Containers security findings. Using Admission Controller, it either audits or prevents the
    /// deployment of images that do not meet security standards.
    /// </summary>
    [JsonPropertyName("securityGating")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityGating? SecurityGating { get; set; }

    /// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V20251002previewManagedClusterSpecSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileImageCleaner
{
    /// <summary>Enabled: Whether to enable Image Cleaner on AKS cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IntervalHours: Image Cleaner scanning interval in hours.</summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// ImageIntegrity: Image integrity is a feature that works with Azure Policy to verify image integrity by signature. This
/// will not have any effect unless Azure Policy is applied to enforce image signatures. See
/// https://aka.ms/aks/image-integrity for how to use this feature via policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileImageIntegrity
{
    /// <summary>Enabled: Whether to enable image integrity. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// InfrastructureEncryption: Whether to enable encryption at rest of Kubernetes resource objects using service-managed
/// keys. More information on this can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfileInfrastructureEncryptionEnum>))]
public enum V20251002previewManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfileInfrastructureEncryptionEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// KubernetesResourceObjectEncryptionProfile: Encryption at rest of Kubernetes resource objects. More information on this
/// can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfile
{
    /// <summary>
    /// InfrastructureEncryption: Whether to enable encryption at rest of Kubernetes resource objects using service-managed
    /// keys. More information on this can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption.
    /// </summary>
    [JsonPropertyName("infrastructureEncryption")]
    public V20251002previewManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfileInfrastructureEncryptionEnum? InfrastructureEncryption { get; set; }
}

/// <summary>
/// NodeRestriction: [Node
/// Restriction](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/#noderestriction) settings
/// for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileNodeRestriction
{
    /// <summary>Enabled: Whether to enable Node Restriction</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
/// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V20251002previewManagedClusterSpecSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>
    /// CustomCATrustCertificates: A list of up to 10 base64 encoded CAs that will be added to the trust store on all nodes in
    /// the cluster. For more information see [Custom CA Trust
    /// Certificates](https://learn.microsoft.com/en-us/azure/aks/custom-certificate-authority).
    /// </summary>
    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V20251002previewManagedClusterSpecSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V20251002previewManagedClusterSpecSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// ImageIntegrity: Image integrity is a feature that works with Azure Policy to verify image integrity by signature. This
    /// will not have any effect unless Azure Policy is applied to enforce image signatures. See
    /// https://aka.ms/aks/image-integrity for how to use this feature via policy.
    /// </summary>
    [JsonPropertyName("imageIntegrity")]
    public V20251002previewManagedClusterSpecSecurityProfileImageIntegrity? ImageIntegrity { get; set; }

    /// <summary>
    /// KubernetesResourceObjectEncryptionProfile: Encryption at rest of Kubernetes resource objects. More information on this
    /// can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption
    /// </summary>
    [JsonPropertyName("kubernetesResourceObjectEncryptionProfile")]
    public V20251002previewManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfile? KubernetesResourceObjectEncryptionProfile { get; set; }

    /// <summary>
    /// NodeRestriction: [Node
    /// Restriction](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/#noderestriction) settings
    /// for the security profile.
    /// </summary>
    [JsonPropertyName("nodeRestriction")]
    public V20251002previewManagedClusterSpecSecurityProfileNodeRestriction? NodeRestriction { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V20251002previewManagedClusterSpecSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference
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
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin
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
    public V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>RootCertObjectName: Root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
/// certificates as described here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>
    /// GatewayConfigurationName: Name of the gateway configuration custom resource for the Istio add-on egress gateway. Must be
    /// specified when enabling the Istio egress gateway. Must be deployed in the same namespace that the Istio egress gateway
    /// will be deployed in.
    /// </summary>
    [JsonPropertyName("gatewayConfigurationName")]
    public string? GatewayConfigurationName { get; set; }

    /// <summary>Name: Name of the Istio add-on egress gateway.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace: Namespace that the Istio add-on egress gateway should be deployed in. If unspecified, the default is
    /// aks-istio-egress.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Mode: Mode of an ingress gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum>))]
public enum V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum
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
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>Enabled: Whether to enable the ingress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>Mode: Mode of an ingress gateway.</summary>
    [JsonPropertyName("mode")]
    public required V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum Mode { get; set; }
}

/// <summary>ProxyRedirectionMechanism: Mode of traffic redirection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsProxyRedirectionMechanismEnum>))]
public enum V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsProxyRedirectionMechanismEnum
{
    [EnumMember(Value = "CNIChaining"), JsonStringEnumMemberName("CNIChaining")]
    CNIChaining,
    [EnumMember(Value = "InitContainers"), JsonStringEnumMemberName("InitContainers")]
    InitContainers
}

/// <summary>Components: Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }

    /// <summary>ProxyRedirectionMechanism: Mode of traffic redirection.</summary>
    [JsonPropertyName("proxyRedirectionMechanism")]
    public V20251002previewManagedClusterSpecServiceMeshProfileIstioComponentsProxyRedirectionMechanismEnum? ProxyRedirectionMechanism { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V20251002previewManagedClusterSpecServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V20251002previewManagedClusterSpecServiceMeshProfileIstioComponents? Components { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecServiceMeshProfileModeEnum>))]
public enum V20251002previewManagedClusterSpecServiceMeshProfileModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Istio"), JsonStringEnumMemberName("Istio")]
    Istio
}

/// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V20251002previewManagedClusterSpecServiceMeshProfileIstio? Istio { get; set; }

    /// <summary>Mode: Mode of the service mesh.</summary>
    [JsonPropertyName("mode")]
    public required V20251002previewManagedClusterSpecServiceMeshProfileModeEnum Mode { get; set; }
}

/// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecServicePrincipalProfileSecret
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
public partial class V20251002previewManagedClusterSpecServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    /// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
    [JsonPropertyName("secret")]
    public V20251002previewManagedClusterSpecServicePrincipalProfileSecret? Secret { get; set; }
}

/// <summary>Name: The name of a managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSkuNameEnum>))]
public enum V20251002previewManagedClusterSpecSkuNameEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSkuTierEnum>))]
public enum V20251002previewManagedClusterSpecSkuTierEnum
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
public partial class V20251002previewManagedClusterSpecSku
{
    /// <summary>Name: The name of a managed cluster SKU.</summary>
    [JsonPropertyName("name")]
    public V20251002previewManagedClusterSpecSkuNameEnum? Name { get; set; }

    /// <summary>
    /// Tier: The tier of a managed cluster SKU. If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
    /// </summary>
    [JsonPropertyName("tier")]
    public V20251002previewManagedClusterSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Version: The version of AzureDisk CSI Driver. The default value is v1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V20251002previewManagedClusterSpecStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V20251002previewManagedClusterSpecStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V20251002previewManagedClusterSpecStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V20251002previewManagedClusterSpecStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecSupportPlanEnum>))]
public enum V20251002previewManagedClusterSpecSupportPlanEnum
{
    [EnumMember(Value = "AKSLongTermSupport"), JsonStringEnumMemberName("AKSLongTermSupport")]
    AKSLongTermSupport,
    [EnumMember(Value = "KubernetesOfficial"), JsonStringEnumMemberName("KubernetesOfficial")]
    KubernetesOfficial
}

/// <summary>OverrideSettings: Settings for overrides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecUpgradeSettingsOverrideSettings
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
public partial class V20251002previewManagedClusterSpecUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V20251002previewManagedClusterSpecUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
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
public partial class V20251002previewManagedClusterSpecWindowsProfileAdminPassword
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
public partial class V20251002previewManagedClusterSpecWindowsProfileGmsaProfile
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecWindowsProfileLicenseTypeEnum>))]
public enum V20251002previewManagedClusterSpecWindowsProfileLicenseTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Windows_Server"), JsonStringEnumMemberName("Windows_Server")]
    WindowsServer
}

/// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecWindowsProfile
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
    public V20251002previewManagedClusterSpecWindowsProfileAdminPassword? AdminPassword { get; set; }

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
    public V20251002previewManagedClusterSpecWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary>
    /// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
    /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public V20251002previewManagedClusterSpecWindowsProfileLicenseTypeEnum? LicenseType { get; set; }
}

/// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>AddonAutoscaling: Whether VPA add-on is enabled and configured to scale AKS-managed add-ons.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscalerAddonAutoscalingEnum>))]
public enum V20251002previewManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscalerAddonAutoscalingEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>AddonAutoscaling: Whether VPA add-on is enabled and configured to scale AKS-managed add-ons.</summary>
    [JsonPropertyName("addonAutoscaling")]
    public V20251002previewManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscalerAddonAutoscalingEnum? AddonAutoscaling { get; set; }

    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpecWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V20251002previewManagedClusterSpecWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V20251002previewManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterSpec
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V20251002previewManagedClusterSpecAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V20251002previewManagedClusterSpecAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V20251002previewManagedClusterSpecAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V20251002previewManagedClusterSpecAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V20251002previewManagedClusterSpecApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V20251002previewManagedClusterSpecAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V20251002previewManagedClusterSpecAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V20251002previewManagedClusterSpecAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
    [JsonPropertyName("bootstrapProfile")]
    public V20251002previewManagedClusterSpecBootstrapProfile? BootstrapProfile { get; set; }

    /// <summary>
    /// CreationData: CreationData to be used to specify the source Snapshot ID if the cluster will be created/upgraded using a
    /// snapshot.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewManagedClusterSpecCreationData? CreationData { get; set; }

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
    public V20251002previewManagedClusterSpecDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>DnsPrefix: The DNS prefix of the Managed Cluster. This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>
    /// EnableNamespaceResources: Enable namespace as Azure resource. The default value is false. It can be enabled/disabled on
    /// creation and updating of the managed cluster. See
    /// [https://aka.ms/NamespaceARMResource](https://aka.ms/NamespaceARMResource) for more details on Namespace as a ARM
    /// Resource.
    /// </summary>
    [JsonPropertyName("enableNamespaceResources")]
    public bool? EnableNamespaceResources { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20251002previewManagedClusterSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// FqdnSubdomain: The FQDN subdomain of the private cluster with custom private dns zone. This cannot be updated once the
    /// Managed Cluster has been created.
    /// </summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>
    /// HostedSystemProfile: Settings for hosted system addons. For more information, see
    /// https://aka.ms/aks/automatic/systemcomponents.
    /// </summary>
    [JsonPropertyName("hostedSystemProfile")]
    public V20251002previewManagedClusterSpecHostedSystemProfile? HostedSystemProfile { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V20251002previewManagedClusterSpecHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterSpecIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V20251002previewManagedClusterSpecIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V20251002previewManagedClusterSpecIngressProfile? IngressProfile { get; set; }

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
    public V20251002previewManagedClusterSpecLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V20251002previewManagedClusterSpecMetricsProfile? MetricsProfile { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V20251002previewManagedClusterSpecNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V20251002previewManagedClusterSpecNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewManagedClusterSpecOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251002previewManagedClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251002previewManagedClusterSpecOwner Owner { get; set; }

    /// <summary>
    /// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
    /// integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V20251002previewManagedClusterSpecPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V20251002previewManagedClusterSpecPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary>PublicNetworkAccess: PublicNetworkAccess of the managedCluster. Allow or deny public network access for AKS</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20251002previewManagedClusterSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SchedulerProfile: Profile of the pod scheduler configuration.</summary>
    [JsonPropertyName("schedulerProfile")]
    public V20251002previewManagedClusterSpecSchedulerProfile? SchedulerProfile { get; set; }

    /// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewManagedClusterSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V20251002previewManagedClusterSpecServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V20251002previewManagedClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V20251002previewManagedClusterSpecSku? Sku { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V20251002previewManagedClusterSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public V20251002previewManagedClusterSpecSupportPlanEnum? SupportPlan { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClusterSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewManagedClusterSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V20251002previewManagedClusterSpecWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAadProfile
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
public partial class V20251002previewManagedClusterStatusAddonProfilesIdentity
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
public partial class V20251002previewManagedClusterStatusAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identity: Information of user assigned identity used by this add-on.</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterStatusAddonProfilesIdentity? Identity { get; set; }
}

/// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesArtifactStreamingProfile
{
    /// <summary>
    /// Enabled: Artifact streaming speeds up the cold-start of containers on a node through on-demand image loading. To use
    /// this feature, container images must also enable artifact streaming on ACR. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
/// a snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesCreationData
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesGatewayProfile
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesGpuProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesKubeletConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfileKubeDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfileVnetDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfile
{
    /// <summary>
    /// KubeDNSOverrides: KubeDNS overrides apply to DNS traffic from pods with dnsPolicy:ClusterFirst (referred to as KubeDNS
    /// traffic).
    /// </summary>
    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

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
    public IDictionary<string, V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>ApplicationSecurityGroups: The IDs of the application security groups which agent pool will associate when created.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesNodeCustomizationProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesSecurityProfile
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails>? Details { get; set; }

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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesStatus
{
    /// <summary>
    /// ProvisioningError: The error detail information of the agent pool. Preserves the detailed info of failure. If there was
    /// no error, this field is omitted.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesUpgradeSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesUpgradeSettingsBlueGreen
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleAutoscale
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale
{
    /// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAgentPoolProfilesWindowsProfile
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
public partial class V20251002previewManagedClusterStatusAgentPoolProfiles
{
    /// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesCreationData? CreationData { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
    /// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesLocalDNSProfile? LocalDNSProfile { get; set; }

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

    /// <summary>
    /// Name: Unique name of the agent pool profile in the context of the subscription and resource group. Windows agent pool
    /// names must be 6 characters or less.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesPowerState? PowerState { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesStatus? Status { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Agent Pool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
    /// BlueGreen.
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    /// <summary>UpgradeStrategy: Defines the upgrade strategy for the agent pool. The default is Rolling.</summary>
    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    /// <summary>VirtualMachineNodesStatus: The status of nodes in a VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

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
    public V20251002previewManagedClusterStatusAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAiToolchainOperatorProfile
{
    /// <summary>Enabled: Whether to enable AI toolchain operator to the cluster. Indicates if AI toolchain operator  enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusApiServerAccessProfile
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
public partial class V20251002previewManagedClusterStatusAutoScalerProfile
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
public partial class V20251002previewManagedClusterStatusAutoUpgradeProfile
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
/// AutoInstrumentation: Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook
/// to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the
/// application. See aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringAutoInstrumentation
{
    /// <summary>Enabled: Indicates if Application Monitoring Auto Instrumentation is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// OpenTelemetryLogs: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and
/// Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryLogs
{
    /// <summary>Enabled: Indicates if Application Monitoring Open Telemetry Logs and traces is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Port: The Open Telemetry host port for Open Telemetry logs and traces. If not specified, the default port is 28331.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// OpenTelemetryMetrics: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container
/// Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
{
    /// <summary>Enabled: Indicates if Application Monitoring Open Telemetry Metrics is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Port: The Open Telemetry host port for Open Telemetry metrics. If not specified, the default port is 28333.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// AppMonitoring: Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics
/// and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoring
{
    /// <summary>
    /// AutoInstrumentation: Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook
    /// to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the
    /// application. See aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("autoInstrumentation")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringAutoInstrumentation? AutoInstrumentation { get; set; }

    /// <summary>
    /// OpenTelemetryLogs: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and
    /// Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryLogs")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryLogs? OpenTelemetryLogs { get; set; }

    /// <summary>
    /// OpenTelemetryMetrics: Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container
    /// Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryMetrics")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryMetrics? OpenTelemetryMetrics { get; set; }
}

/// <summary>
/// ContainerInsights: Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp;
/// stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileContainerInsights
{
    /// <summary>
    /// DisableCustomMetrics: Indicates whether custom metrics collection has to be disabled or not. If not specified the
    /// default is false. No custom metrics will be emitted if this field is false but the container insights enabled field is
    /// false
    /// </summary>
    [JsonPropertyName("disableCustomMetrics")]
    public bool? DisableCustomMetrics { get; set; }

    /// <summary>
    /// DisablePrometheusMetricsScraping: Indicates whether prometheus metrics scraping is disabled or not. If not specified the
    /// default is false. No prometheus metrics will be emitted if this field is false but the container insights enabled field
    /// is false
    /// </summary>
    [JsonPropertyName("disablePrometheusMetricsScraping")]
    public bool? DisablePrometheusMetricsScraping { get; set; }

    /// <summary>Enabled: Indicates if Azure Monitor Container Insights Logs Addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// LogAnalyticsWorkspaceResourceId: Fully Qualified ARM Resource Id of Azure Log Analytics Workspace for storing Azure
    /// Monitor Container Insights Logs.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    /// <summary>SyslogPort: The syslog host port. If not specified, the default port is 28330.</summary>
    [JsonPropertyName("syslogPort")]
    public int? SyslogPort { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
/// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics
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
public partial class V20251002previewManagedClusterStatusAzureMonitorProfileMetrics
{
    /// <summary>
    /// Enabled: Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See
    /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    /// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusAzureMonitorProfile
{
    /// <summary>
    /// AppMonitoring: Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics
    /// and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("appMonitoring")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileAppMonitoring? AppMonitoring { get; set; }

    /// <summary>
    /// ContainerInsights: Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp;
    /// stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview.
    /// </summary>
    [JsonPropertyName("containerInsights")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileContainerInsights? ContainerInsights { get; set; }

    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V20251002previewManagedClusterStatusAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusBootstrapProfile
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
public partial class V20251002previewManagedClusterStatusConditions
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
/// CreationData: CreationData to be used to specify the source Snapshot ID if the cluster will be created/upgraded using a
/// snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusCreationData
{
    /// <summary>SourceResourceId: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// HostedSystemProfile: Settings for hosted system addons. For more information, see
/// https://aka.ms/aks/automatic/systemcomponents.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusHostedSystemProfile
{
    /// <summary>Enabled: Whether to enable hosted system addons for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusHttpProxyConfig
{
    /// <summary>
    /// EffectiveNoProxy: A read-only list of all endpoints for which traffic should not be sent to the proxy. This list is a
    /// superset of noProxy and values injected by AKS.
    /// </summary>
    [JsonPropertyName("effectiveNoProxy")]
    public IList<string>? EffectiveNoProxy { get; set; }

    /// <summary>
    /// Enabled: Whether to enable HTTP proxy. When disabled, the specified proxy configuration will be not be set on pods and
    /// nodes.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

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
public partial class V20251002previewManagedClusterStatusIdentityDelegatedResources
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
public partial class V20251002previewManagedClusterStatusIdentityUserAssignedIdentities
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
public partial class V20251002previewManagedClusterStatusIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V20251002previewManagedClusterStatusIdentityDelegatedResources>? DelegatedResources { get; set; }

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
    public IDictionary<string, V20251002previewManagedClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIdentityProfile
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
/// Identity: Managed identity of the Application Load Balancer add-on. This is the identity that should be granted
/// permissions to manage the associated Application Gateway for Containers resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfileApplicationLoadBalancerIdentity
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

/// <summary>ApplicationLoadBalancer: Settings for the managed Application Load Balancer installation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfileApplicationLoadBalancer
{
    /// <summary>Enabled: Whether to enable Application Load Balancer.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identity: Managed identity of the Application Load Balancer add-on. This is the identity that should be granted
    /// permissions to manage the associated Application Gateway for Containers resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterStatusIngressProfileApplicationLoadBalancerIdentity? Identity { get; set; }
}

/// <summary>GatewayAPI: Settings for the managed Gateway API installation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfileGatewayAPI
{
    /// <summary>
    /// Installation: Configuration for the managed Gateway API installation. If not specified, the default is &apos;Disabled&apos;. See
    /// https://aka.ms/k8s-gateway-api for more details.
    /// </summary>
    [JsonPropertyName("installation")]
    public string? Installation { get; set; }
}

/// <summary>
/// DefaultDomain: Configuration for the Default Domain. This is a unique, autogenerated domain that comes with a signed TLS
/// Certificate allowing for secure HTTPS. See [the Default Domain documentation](https://aka.ms/aks/defaultdomain) for more
/// instructions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfileWebAppRoutingDefaultDomain
{
    /// <summary>
    /// DomainName: The unique fully qualified domain name assigned to the cluster. This will not change even if disabled then
    /// reenabled.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Enabled: Whether to enable Default Domain.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Identity: Managed identity of the Application Routing add-on. This is the identity that should be granted permissions,
/// for example, to manage the associated Azure DNS resource and get certificates from Azure Key Vault. See [this overview
/// of the add-on](https://learn.microsoft.com/en-us/azure/aks/web-app-routing?tabs=with-osm) for more instructions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfileWebAppRoutingIdentity
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
public partial class V20251002previewManagedClusterStatusIngressProfileWebAppRoutingNginx
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
public partial class V20251002previewManagedClusterStatusIngressProfileWebAppRouting
{
    /// <summary>
    /// DefaultDomain: Configuration for the Default Domain. This is a unique, autogenerated domain that comes with a signed TLS
    /// Certificate allowing for secure HTTPS. See [the Default Domain documentation](https://aka.ms/aks/defaultdomain) for more
    /// instructions.
    /// </summary>
    [JsonPropertyName("defaultDomain")]
    public V20251002previewManagedClusterStatusIngressProfileWebAppRoutingDefaultDomain? DefaultDomain { get; set; }

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
    public V20251002previewManagedClusterStatusIngressProfileWebAppRoutingIdentity? Identity { get; set; }

    /// <summary>
    /// Nginx: Configuration for the default NginxIngressController. See more at
    /// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
    /// </summary>
    [JsonPropertyName("nginx")]
    public V20251002previewManagedClusterStatusIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusIngressProfile
{
    /// <summary>ApplicationLoadBalancer: Settings for the managed Application Load Balancer installation</summary>
    [JsonPropertyName("applicationLoadBalancer")]
    public V20251002previewManagedClusterStatusIngressProfileApplicationLoadBalancer? ApplicationLoadBalancer { get; set; }

    /// <summary>GatewayAPI: Settings for the managed Gateway API installation</summary>
    [JsonPropertyName("gatewayAPI")]
    public V20251002previewManagedClusterStatusIngressProfileGatewayAPI? GatewayAPI { get; set; }

    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V20251002previewManagedClusterStatusIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusLinuxProfileSshPublicKeys
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
public partial class V20251002previewManagedClusterStatusLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V20251002previewManagedClusterStatusLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public V20251002previewManagedClusterStatusLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusMetricsProfileCostAnalysis
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
public partial class V20251002previewManagedClusterStatusMetricsProfile
{
    /// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
    [JsonPropertyName("costAnalysis")]
    public V20251002previewManagedClusterStatusMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Performance: Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingPerformance
{
    /// <summary>
    /// AccelerationMode: Enable advanced network acceleration options. This allows users to configure acceleration using BPF
    /// host routing. This can be enabled only with Cilium dataplane. If not specified, the default value is None (no
    /// acceleration). The acceleration mode can be changed on a pre-existing cluster. See https://aka.ms/acnsperformance for a
    /// detailed explanation
    /// </summary>
    [JsonPropertyName("accelerationMode")]
    public string? AccelerationMode { get; set; }
}

/// <summary>
/// TransitEncryption: Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed
/// pods will be encrypted when it leaves the node boundary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingSecurityTransitEncryption
{
    /// <summary>
    /// Type: Configures pod-to-pod encryption. This can be enabled only on Cilium-based clusters. If not specified, the default
    /// value is None.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity
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

    /// <summary>
    /// TransitEncryption: Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed
    /// pods will be encrypted when it leaves the node boundary.
    /// </summary>
    [JsonPropertyName("transitEncryption")]
    public V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingSecurityTransitEncryption? TransitEncryption { get; set; }
}

/// <summary>
/// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
/// more information see aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworking
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
    public V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Performance: Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.</summary>
    [JsonPropertyName("performance")]
    public V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingPerformance? Performance { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>IpvsConfig: Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileKubeProxyConfigIpvsConfig
{
    /// <summary>Scheduler: IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html.</summary>
    [JsonPropertyName("scheduler")]
    public string? Scheduler { get; set; }

    /// <summary>
    /// TcpFinTimeoutSeconds: The timeout value used for IPVS TCP sessions after receiving a FIN in seconds. Must be a positive
    /// integer value.
    /// </summary>
    [JsonPropertyName("tcpFinTimeoutSeconds")]
    public int? TcpFinTimeoutSeconds { get; set; }

    /// <summary>TcpTimeoutSeconds: The timeout value used for idle IPVS TCP sessions in seconds. Must be a positive integer value.</summary>
    [JsonPropertyName("tcpTimeoutSeconds")]
    public int? TcpTimeoutSeconds { get; set; }

    /// <summary>UdpTimeoutSeconds: The timeout value used for IPVS UDP packets in seconds. Must be a positive integer value.</summary>
    [JsonPropertyName("udpTimeoutSeconds")]
    public int? UdpTimeoutSeconds { get; set; }
}

/// <summary>
/// KubeProxyConfig: Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy
/// defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/
/// where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileKubeProxyConfig
{
    /// <summary>
    /// Enabled: Whether to enable on kube-proxy on the cluster (if no &apos;kubeProxyConfig&apos; exists, kube-proxy is enabled in AKS by
    /// default without these customizations).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IpvsConfig: Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.</summary>
    [JsonPropertyName("ipvsConfig")]
    public V20251002previewManagedClusterStatusNetworkProfileKubeProxyConfigIpvsConfig? IpvsConfig { get; set; }

    /// <summary>Mode: Specify which proxy mode to use (&apos;IPTABLES&apos;, &apos;IPVS&apos; or &apos;NFTABLES&apos;)</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs
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
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfile
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

    /// <summary>ClusterServiceLoadBalancerHealthProbeMode: The health probing behavior for External Traffic Policy Cluster services.</summary>
    [JsonPropertyName("clusterServiceLoadBalancerHealthProbeMode")]
    public string? ClusterServiceLoadBalancerHealthProbeMode { get; set; }

    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster load balancer.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

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
    public V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile
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
public partial class V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfile
{
    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>
/// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
/// see https://aka.ms/aks/static-egress-gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfileStaticEgressGatewayProfile
{
    /// <summary>Enabled: Enable Static Egress Gateway addon. Indicates if Static Egress Gateway addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V20251002previewManagedClusterStatusNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

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

    /// <summary>
    /// KubeProxyConfig: Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy
    /// defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/
    /// where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
    /// </summary>
    [JsonPropertyName("kubeProxyConfig")]
    public V20251002previewManagedClusterStatusNetworkProfileKubeProxyConfig? KubeProxyConfig { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V20251002previewManagedClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V20251002previewManagedClusterStatusNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

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
    /// PodLinkLocalAccess: Defines access to special link local addresses (Azure Instance Metadata Service, aka IMDS) for pods
    /// with hostNetwork=false. if not specified, the default is &apos;IMDS&apos;.
    /// </summary>
    [JsonPropertyName("podLinkLocalAccess")]
    public string? PodLinkLocalAccess { get; set; }

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
    public V20251002previewManagedClusterStatusNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusNodeProvisioningProfile
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
public partial class V20251002previewManagedClusterStatusNodeResourceGroupProfile
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
public partial class V20251002previewManagedClusterStatusOidcIssuerProfile
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
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity
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
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails
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
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError
{
    /// <summary>Code: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: A list of additional details about the error.</summary>
    [JsonPropertyName("details")]
    public IList<V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails>? Details { get; set; }

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
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError
{
    /// <summary>Error: Details about the error.</summary>
    [JsonPropertyName("error")]
    public V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError? Error { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo
{
    /// <summary>Error: Pod identity assignment error (if any).</summary>
    [JsonPropertyName("error")]
    public V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError? Error { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    /// <summary>Name: The name of the pod identity.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("provisioningInfo")]
    public V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo? ProvisioningInfo { get; set; }

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
public partial class V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions
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
public partial class V20251002previewManagedClusterStatusPodIdentityProfile
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
    public IList<V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V20251002previewManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>PowerState: The Power State of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusPrivateLinkResources
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

/// <summary>Upstream: The scheduler profile for the upstream scheduler instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSchedulerProfileSchedulerInstanceProfilesUpstream
{
    /// <summary>SchedulerConfigMode: The config customization mode for this scheduler instance.</summary>
    [JsonPropertyName("schedulerConfigMode")]
    public string? SchedulerConfigMode { get; set; }
}

/// <summary>SchedulerInstanceProfiles: Mapping of each scheduler instance to its profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSchedulerProfileSchedulerInstanceProfiles
{
    /// <summary>Upstream: The scheduler profile for the upstream scheduler instance.</summary>
    [JsonPropertyName("upstream")]
    public V20251002previewManagedClusterStatusSchedulerProfileSchedulerInstanceProfilesUpstream? Upstream { get; set; }
}

/// <summary>SchedulerProfile: Profile of the pod scheduler configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSchedulerProfile
{
    /// <summary>SchedulerInstanceProfiles: Mapping of each scheduler instance to its profile.</summary>
    [JsonPropertyName("schedulerInstanceProfiles")]
    public V20251002previewManagedClusterStatusSchedulerProfileSchedulerInstanceProfiles? SchedulerInstanceProfiles { get; set; }
}

/// <summary>
/// AzureKeyVaultKms: Azure Key Vault [key management
/// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileAzureKeyVaultKms
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

/// <summary>Identity: The identity object used to access the registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentitiesIdentity
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
public partial class V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentities
{
    /// <summary>
    /// AzureContainerRegistry: The container registry for which the identity will be used; the identity specified here should
    /// have a federated identity credential attached to it.
    /// </summary>
    [JsonPropertyName("azureContainerRegistry")]
    public string? AzureContainerRegistry { get; set; }

    /// <summary>Identity: The identity object used to access the registry</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentitiesIdentity? Identity { get; set; }
}

/// <summary>
/// SecurityGating: Microsoft Defender settings for security gating, validates container images eligibility for deployment
/// based on Defender for Containers security findings. Using Admission Controller, it either audits or prevents the
/// deployment of images that do not meet security standards.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGating
{
    /// <summary>
    /// AllowSecretAccess: In use only while registry access granted by secret rather than managed identity. Set whether to
    /// grant the Defender gating agent access to the cluster&apos;s secrets for pulling images from registries. If secret access is
    /// denied and the registry requires pull secrets, the add-on will not perform any image validation. Default value is false.
    /// </summary>
    [JsonPropertyName("allowSecretAccess")]
    public bool? AllowSecretAccess { get; set; }

    /// <summary>
    /// Enabled: Whether to enable Defender security gating. When enabled, the gating feature will scan container images and
    /// audit or block the deployment of images that do not meet security standards according to the configured security rules.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identities: List of identities that the admission controller will make use of in order to pull security artifacts from
    /// the registry. These are the same identities used by the cluster to pull container images. Each identity provided should
    /// have federated identity credential attached to it.
    /// </summary>
    [JsonPropertyName("identities")]
    public IList<V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentities>? Identities { get; set; }
}

/// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileDefender
{
    /// <summary>
    /// LogAnalyticsWorkspaceResourceId: Resource ID of the Log Analytics workspace to be associated with Microsoft Defender.
    /// When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft
    /// Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    /// <summary>
    /// SecurityGating: Microsoft Defender settings for security gating, validates container images eligibility for deployment
    /// based on Defender for Containers security findings. Using Admission Controller, it either audits or prevents the
    /// deployment of images that do not meet security standards.
    /// </summary>
    [JsonPropertyName("securityGating")]
    public V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityGating? SecurityGating { get; set; }

    /// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V20251002previewManagedClusterStatusSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileImageCleaner
{
    /// <summary>Enabled: Whether to enable Image Cleaner on AKS cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IntervalHours: Image Cleaner scanning interval in hours.</summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// ImageIntegrity: Image integrity is a feature that works with Azure Policy to verify image integrity by signature. This
/// will not have any effect unless Azure Policy is applied to enforce image signatures. See
/// https://aka.ms/aks/image-integrity for how to use this feature via policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileImageIntegrity
{
    /// <summary>Enabled: Whether to enable image integrity. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// KubernetesResourceObjectEncryptionProfile: Encryption at rest of Kubernetes resource objects. More information on this
/// can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileKubernetesResourceObjectEncryptionProfile
{
    /// <summary>
    /// InfrastructureEncryption: Whether to enable encryption at rest of Kubernetes resource objects using service-managed
    /// keys. More information on this can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption.
    /// </summary>
    [JsonPropertyName("infrastructureEncryption")]
    public string? InfrastructureEncryption { get; set; }
}

/// <summary>
/// NodeRestriction: [Node
/// Restriction](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/#noderestriction) settings
/// for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileNodeRestriction
{
    /// <summary>Enabled: Whether to enable Node Restriction</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
/// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V20251002previewManagedClusterStatusSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>
    /// CustomCATrustCertificates: A list of up to 10 base64 encoded CAs that will be added to the trust store on all nodes in
    /// the cluster. For more information see [Custom CA Trust
    /// Certificates](https://learn.microsoft.com/en-us/azure/aks/custom-certificate-authority).
    /// </summary>
    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V20251002previewManagedClusterStatusSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V20251002previewManagedClusterStatusSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// ImageIntegrity: Image integrity is a feature that works with Azure Policy to verify image integrity by signature. This
    /// will not have any effect unless Azure Policy is applied to enforce image signatures. See
    /// https://aka.ms/aks/image-integrity for how to use this feature via policy.
    /// </summary>
    [JsonPropertyName("imageIntegrity")]
    public V20251002previewManagedClusterStatusSecurityProfileImageIntegrity? ImageIntegrity { get; set; }

    /// <summary>
    /// KubernetesResourceObjectEncryptionProfile: Encryption at rest of Kubernetes resource objects. More information on this
    /// can be found under https://aka.ms/aks/kubernetesResourceObjectEncryption
    /// </summary>
    [JsonPropertyName("kubernetesResourceObjectEncryptionProfile")]
    public V20251002previewManagedClusterStatusSecurityProfileKubernetesResourceObjectEncryptionProfile? KubernetesResourceObjectEncryptionProfile { get; set; }

    /// <summary>
    /// NodeRestriction: [Node
    /// Restriction](https://kubernetes.io/docs/reference/access-authn-authz/admission-controllers/#noderestriction) settings
    /// for the security profile.
    /// </summary>
    [JsonPropertyName("nodeRestriction")]
    public V20251002previewManagedClusterStatusSecurityProfileNodeRestriction? NodeRestriction { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V20251002previewManagedClusterStatusSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin
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
/// certificates as described here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V20251002previewManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// GatewayConfigurationName: Name of the gateway configuration custom resource for the Istio add-on egress gateway. Must be
    /// specified when enabling the Istio egress gateway. Must be deployed in the same namespace that the Istio egress gateway
    /// will be deployed in.
    /// </summary>
    [JsonPropertyName("gatewayConfigurationName")]
    public string? GatewayConfigurationName { get; set; }

    /// <summary>Name: Name of the Istio add-on egress gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace: Namespace that the Istio add-on egress gateway should be deployed in. If unspecified, the default is
    /// aks-istio-egress.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways
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
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V20251002previewManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V20251002previewManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }

    /// <summary>ProxyRedirectionMechanism: Mode of traffic redirection.</summary>
    [JsonPropertyName("proxyRedirectionMechanism")]
    public string? ProxyRedirectionMechanism { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V20251002previewManagedClusterStatusServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V20251002previewManagedClusterStatusServiceMeshProfileIstioComponents? Components { get; set; }

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
public partial class V20251002previewManagedClusterStatusServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V20251002previewManagedClusterStatusServiceMeshProfileIstio? Istio { get; set; }

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
public partial class V20251002previewManagedClusterStatusServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Sku: The managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSku
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
public partial class V20251002previewManagedClusterStatusStatusProvisioningErrorAdditionalInfo
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
public partial class V20251002previewManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo
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
public partial class V20251002previewManagedClusterStatusStatusProvisioningErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V20251002previewManagedClusterStatusStatusProvisioningError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClusterStatusStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V20251002previewManagedClusterStatusStatusProvisioningErrorDetails>? Details { get; set; }

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
public partial class V20251002previewManagedClusterStatusStatus
{
    /// <summary>
    /// ProvisioningError: The error details information of the managed cluster. Preserves the detailed info of failure. If
    /// there was no error, this field is omitted.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V20251002previewManagedClusterStatusStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Version: The version of AzureDisk CSI Driver. The default value is v1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V20251002previewManagedClusterStatusStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V20251002previewManagedClusterStatusStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V20251002previewManagedClusterStatusStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V20251002previewManagedClusterStatusStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusSystemData
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
public partial class V20251002previewManagedClusterStatusUpgradeSettingsOverrideSettings
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
public partial class V20251002previewManagedClusterStatusUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V20251002previewManagedClusterStatusUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusWindowsProfileGmsaProfile
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
public partial class V20251002previewManagedClusterStatusWindowsProfile
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
    public V20251002previewManagedClusterStatusWindowsProfileGmsaProfile? GmsaProfile { get; set; }

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
public partial class V20251002previewManagedClusterStatusWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>AddonAutoscaling: Whether VPA add-on is enabled and configured to scale AKS-managed add-ons.</summary>
    [JsonPropertyName("addonAutoscaling")]
    public string? AddonAutoscaling { get; set; }

    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatusWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V20251002previewManagedClusterStatusWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V20251002previewManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClusterStatus
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V20251002previewManagedClusterStatusAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V20251002previewManagedClusterStatusAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V20251002previewManagedClusterStatusAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V20251002previewManagedClusterStatusAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V20251002previewManagedClusterStatusApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V20251002previewManagedClusterStatusAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V20251002previewManagedClusterStatusAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V20251002previewManagedClusterStatusAzureMonitorProfile? AzureMonitorProfile { get; set; }

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
    public V20251002previewManagedClusterStatusBootstrapProfile? BootstrapProfile { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20251002previewManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CreationData: CreationData to be used to specify the source Snapshot ID if the cluster will be created/upgraded using a
    /// snapshot.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewManagedClusterStatusCreationData? CreationData { get; set; }

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
    /// ETag: If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.
    /// Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in
    /// the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header
    /// fields.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>
    /// EnableNamespaceResources: Enable namespace as Azure resource. The default value is false. It can be enabled/disabled on
    /// creation and updating of the managed cluster. See
    /// [https://aka.ms/NamespaceARMResource](https://aka.ms/NamespaceARMResource) for more details on Namespace as a ARM
    /// Resource.
    /// </summary>
    [JsonPropertyName("enableNamespaceResources")]
    public bool? EnableNamespaceResources { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20251002previewManagedClusterStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Fqdn: The FQDN of the master pool.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// FqdnSubdomain: The FQDN subdomain of the private cluster with custom private dns zone. This cannot be updated once the
    /// Managed Cluster has been created.
    /// </summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>
    /// HostedSystemProfile: Settings for hosted system addons. For more information, see
    /// https://aka.ms/aks/automatic/systemcomponents.
    /// </summary>
    [JsonPropertyName("hostedSystemProfile")]
    public V20251002previewManagedClusterStatusHostedSystemProfile? HostedSystemProfile { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V20251002previewManagedClusterStatusHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20251002previewManagedClusterStatusIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V20251002previewManagedClusterStatusIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V20251002previewManagedClusterStatusIngressProfile? IngressProfile { get; set; }

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
    public V20251002previewManagedClusterStatusLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaxAgentPools: The max number of agent pools for the managed cluster.</summary>
    [JsonPropertyName("maxAgentPools")]
    public int? MaxAgentPools { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V20251002previewManagedClusterStatusMetricsProfile? MetricsProfile { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V20251002previewManagedClusterStatusNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V20251002previewManagedClusterStatusNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewManagedClusterStatusOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
    /// integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V20251002previewManagedClusterStatusPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PowerState: The Power State of the cluster.</summary>
    [JsonPropertyName("powerState")]
    public V20251002previewManagedClusterStatusPowerState? PowerState { get; set; }

    /// <summary>PrivateFQDN: The FQDN of private cluster.</summary>
    [JsonPropertyName("privateFQDN")]
    public string? PrivateFQDN { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V20251002previewManagedClusterStatusPrivateLinkResources>? PrivateLinkResources { get; set; }

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

    /// <summary>SchedulerProfile: Profile of the pod scheduler configuration.</summary>
    [JsonPropertyName("schedulerProfile")]
    public V20251002previewManagedClusterStatusSchedulerProfile? SchedulerProfile { get; set; }

    /// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewManagedClusterStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V20251002previewManagedClusterStatusServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V20251002previewManagedClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V20251002previewManagedClusterStatusSku? Sku { get; set; }

    /// <summary>Status: Contains read-only information about the Managed Cluster.</summary>
    [JsonPropertyName("status")]
    public V20251002previewManagedClusterStatusStatus? Status { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V20251002previewManagedClusterStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20251002previewManagedClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClusterStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewManagedClusterStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V20251002previewManagedClusterStatusWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V20251002previewManagedClusterSpec?>, IStatus<V20251002previewManagedClusterStatus?>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20251002previewManagedClusterSpec? Spec { get; set; }

    /// <summary>Managed cluster.</summary>
    [JsonPropertyName("status")]
    public V20251002previewManagedClusterStatus? Status { get; set; }
}