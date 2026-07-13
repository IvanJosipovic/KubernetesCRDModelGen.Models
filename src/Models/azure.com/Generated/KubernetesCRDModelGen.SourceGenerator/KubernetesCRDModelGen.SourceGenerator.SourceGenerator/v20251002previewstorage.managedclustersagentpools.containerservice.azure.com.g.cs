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
/// Storage version of v20251002preview.ManagedClustersAgentPool
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewstorageManagedClustersAgentPoolList : IKubernetesObject<V1ListMeta>, IItems<V20251002previewstorageManagedClustersAgentPool>
{
    public const string KubeApiVersion = "v20251002previewstorage";
    public const string KubeKind = "ManagedClustersAgentPoolList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251002previewstorageManagedClustersAgentPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251002previewstorageManagedClustersAgentPool> Items { get; set; }
}

/// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecArtifactStreamingProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

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
public partial class V20251002previewstorageManagedClustersAgentPoolSpecCapacityReservationGroupReference
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
public partial class V20251002previewstorageManagedClustersAgentPoolSpecCreationDataSourceResourceReference
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
/// Storage version of v20251002preview.CreationData
/// Data used when creating a target resource from a source resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolGatewayProfile
/// Profile of the managed cluster gateway agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecGatewayProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPPrefixSize")]
    public int? PublicIPPrefixSize { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.GPUProfile
/// GPU settings for the Agent Pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecGpuProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("driverType")]
    public string? DriverType { get; set; }
}

/// <summary>
/// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
/// only in creation scenario and not allowed to changed once set. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
/// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecHostGroupReference
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
/// Storage version of v20251002preview.KubeletConfig
/// Kubelet configurations of agent nodes. See [AKS custom node
/// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecKubeletConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    [JsonPropertyName("seccompDefault")]
    public string? SeccompDefault { get; set; }

    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SysctlConfig
/// Sysctl settings for Linux agent nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecLinuxOSConfigSysctls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LinuxOSConfig
/// OS configurations of Linux agent nodes. See [AKS custom node
/// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecLinuxOSConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SysctlConfig
    /// Sysctl settings for Linux agent nodes.
    /// </summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewstorageManagedClustersAgentPoolSpecLinuxOSConfigSysctls? Sysctls { get; set; }

    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSProfile
/// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
/// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PortRange
/// The port range.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences
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
/// Storage version of v20251002preview.IPTag
/// Contains the IPTag associated with the object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolNetworkProfile
/// Network settings of an agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
/// the version will use the latest version of the node customization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNodeCustomizationProfileNodeCustomizationReference
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
/// Storage version of v20251002preview.NodeCustomizationProfile
/// Settings to determine the node customization used to provision nodes in a pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNodeCustomizationProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
    /// the version will use the latest version of the node customization.
    /// </summary>
    [JsonPropertyName("nodeCustomizationReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecNodeCustomizationProfileNodeCustomizationReference? NodeCustomizationReference { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecNodePublicIPPrefixReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpecSecretExpressions
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
/// Storage version of v20251002preview.ManagedClustersAgentPoolOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/ManagedCluster resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
/// on the node subnet (see vnetSubnetID for more details). This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecPodSubnetReference
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
/// Storage version of v20251002preview.PowerState
/// Describes the Power State of the cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecPowerState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecProximityPlacementGroupReference
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
/// Storage version of v20251002preview.AgentPoolSecurityProfile
/// The security settings of an agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }

    [JsonPropertyName("sshAccess")]
    public string? SshAccess { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolUpgradeSettings
/// Settings for upgrading an agentpool
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecUpgradeSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    [JsonPropertyName("maxBlockedNodes")]
    public string? MaxBlockedNodes { get; set; }

    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }

    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings
/// Settings for blue-green upgrade on an agentpool
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecUpgradeSettingsBlueGreen
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("batchSoakDurationInMinutes")]
    public int? BatchSoakDurationInMinutes { get; set; }

    [JsonPropertyName("drainBatchSize")]
    public string? DrainBatchSize { get; set; }

    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    [JsonPropertyName("finalSoakDurationInMinutes")]
    public int? FinalSoakDurationInMinutes { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachineNodes
/// Current status on a group of nodes of the same vm size.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachineNodesStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AutoScaleProfile
/// Specifications on auto-scaling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScaleAutoscale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManualScaleProfile
/// Specifications on number of machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScaleManual
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ScaleProfile
/// Specifications on how to scale a VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AutoScaleProfile
    /// Specifications on auto-scaling.
    /// </summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    [JsonPropertyName("manual")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachinesProfile
/// Specifications on VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ScaleProfile
    /// Specifications on how to scale a VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("scale")]
    public V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
/// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
/// pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecVnetSubnetReference
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
/// Storage version of v20251002preview.AgentPoolWindowsProfile
/// The Windows agent pool&apos;s specific profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpecWindowsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClustersAgentPool_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

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
    public V20251002previewstorageManagedClustersAgentPoolSpecCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClustersAgentPoolSpecCreationData? CreationData { get; set; }

    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolGatewayProfile
    /// Profile of the managed cluster gateway agent pool.
    /// </summary>
    [JsonPropertyName("gatewayProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecGatewayProfile? GatewayProfile { get; set; }

    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.GPUProfile
    /// GPU settings for the Agent Pool.
    /// </summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
    /// only in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecHostGroupReference? HostGroupReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubeletConfig
    /// Kubelet configurations of agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewstorageManagedClustersAgentPoolSpecKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LinuxOSConfig
    /// OS configurations of Linux agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewstorageManagedClustersAgentPoolSpecLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LocalDNSProfile
    /// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
    /// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecLocalDNSProfile? LocalDNSProfile { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolNetworkProfile
    /// Network settings of an agent pool.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.NodeCustomizationProfile
    /// Settings to determine the node customization used to provision nodes in a pool.
    /// </summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

    [JsonPropertyName("nodeInitializationTaints")]
    public IList<string>? NodeInitializationTaints { get; set; }

    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClustersAgentPoolOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251002previewstorageManagedClustersAgentPoolSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/ManagedCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251002previewstorageManagedClustersAgentPoolSpecOwner Owner { get; set; }

    [JsonPropertyName("podIPAllocationMode")]
    public string? PodIPAllocationMode { get; set; }

    /// <summary>
    /// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
    /// on the node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.PowerState
    /// Describes the Power State of the cluster
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewstorageManagedClustersAgentPoolSpecPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolSecurityProfile
    /// The security settings of an agent pool.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecSecurityProfile? SecurityProfile { get; set; }

    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolUpgradeSettings
    /// Settings for upgrading an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewstorageManagedClustersAgentPoolSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings
    /// Settings for blue-green upgrade on an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewstorageManagedClustersAgentPoolSpecUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.VirtualMachinesProfile
    /// Specifications on VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
    /// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
    /// pods, otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V20251002previewstorageManagedClustersAgentPoolSpecVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolWindowsProfile
    /// The Windows agent pool&apos;s specific profile.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClustersAgentPoolSpecWindowsProfile? WindowsProfile { get; set; }

    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusArtifactStreamingProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusConditions
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
/// Storage version of v20251002preview.CreationData_STATUS
/// Data used when creating a target resource from a source resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolGatewayProfile_STATUS
/// Profile of the managed cluster gateway agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusGatewayProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPPrefixSize")]
    public int? PublicIPPrefixSize { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.GPUProfile_STATUS
/// GPU settings for the Agent Pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusGpuProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("driverType")]
    public string? DriverType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.KubeletConfig_STATUS
/// Kubelet configurations of agent nodes. See [AKS custom node
/// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusKubeletConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    [JsonPropertyName("seccompDefault")]
    public string? SeccompDefault { get; set; }

    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SysctlConfig_STATUS
/// Sysctl settings for Linux agent nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusLinuxOSConfigSysctls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LinuxOSConfig_STATUS
/// OS configurations of Linux agent nodes. See [AKS custom node
/// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusLinuxOSConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SysctlConfig_STATUS
    /// Sysctl settings for Linux agent nodes.
    /// </summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewstorageManagedClustersAgentPoolStatusLinuxOSConfigSysctls? Sysctls { get; set; }

    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride_STATUS
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfileKubeDNSOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride_STATUS
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfileVnetDNSOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSProfile_STATUS
/// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
/// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PortRange_STATUS
/// The port range.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IPTag_STATUS
/// Contains the IPTag associated with the object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolNetworkProfile_STATUS
/// Network settings of an agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.NodeCustomizationProfile_STATUS
/// Settings to determine the node customization used to provision nodes in a pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusNodeCustomizationProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nodeCustomizationId")]
    public string? NodeCustomizationId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PowerState_STATUS
/// Describes the Power State of the cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusPowerState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolSecurityProfile_STATUS
/// The security settings of an agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }

    [JsonPropertyName("sshAccess")]
    public string? SshAccess { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20251002preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolStatus_STATUS
/// Contains read-only information about the Agent Pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V20251002previewstorageManagedClustersAgentPoolStatusStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolUpgradeSettings_STATUS
/// Settings for upgrading an agentpool
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusUpgradeSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    [JsonPropertyName("maxBlockedNodes")]
    public string? MaxBlockedNodes { get; set; }

    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }

    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings_STATUS
/// Settings for blue-green upgrade on an agentpool
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusUpgradeSettingsBlueGreen
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("batchSoakDurationInMinutes")]
    public int? BatchSoakDurationInMinutes { get; set; }

    [JsonPropertyName("drainBatchSize")]
    public string? DrainBatchSize { get; set; }

    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    [JsonPropertyName("finalSoakDurationInMinutes")]
    public int? FinalSoakDurationInMinutes { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachineNodes_STATUS
/// Current status on a group of nodes of the same vm size.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachineNodesStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AutoScaleProfile_STATUS
/// Specifications on auto-scaling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScaleAutoscale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManualScaleProfile_STATUS
/// Specifications on number of machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScaleManual
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ScaleProfile_STATUS
/// Specifications on how to scale a VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AutoScaleProfile_STATUS
    /// Specifications on auto-scaling.
    /// </summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    [JsonPropertyName("manual")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachinesProfile_STATUS
/// Specifications on VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ScaleProfile_STATUS
    /// Specifications on how to scale a VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("scale")]
    public V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolWindowsProfile_STATUS
/// The Windows agent pool&apos;s specific profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatusWindowsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClustersAgentPool_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClustersAgentPoolStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile_STATUS</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    [JsonPropertyName("capacityReservationGroupID")]
    public string? CapacityReservationGroupID { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData_STATUS
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClustersAgentPoolStatusCreationData? CreationData { get; set; }

    [JsonPropertyName("currentOrchestratorVersion")]
    public string? CurrentOrchestratorVersion { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolGatewayProfile_STATUS
    /// Profile of the managed cluster gateway agent pool.
    /// </summary>
    [JsonPropertyName("gatewayProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusGatewayProfile? GatewayProfile { get; set; }

    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.GPUProfile_STATUS
    /// GPU settings for the Agent Pool.
    /// </summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusGpuProfile? GpuProfile { get; set; }

    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubeletConfig_STATUS
    /// Kubelet configurations of agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewstorageManagedClustersAgentPoolStatusKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LinuxOSConfig_STATUS
    /// OS configurations of Linux agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewstorageManagedClustersAgentPoolStatusLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LocalDNSProfile_STATUS
    /// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
    /// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusLocalDNSProfile? LocalDNSProfile { get; set; }

    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolNetworkProfile_STATUS
    /// Network settings of an agent pool.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.NodeCustomizationProfile_STATUS
    /// Settings to determine the node customization used to provision nodes in a pool.
    /// </summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

    [JsonPropertyName("nodeImageVersion")]
    public string? NodeImageVersion { get; set; }

    [JsonPropertyName("nodeInitializationTaints")]
    public IList<string>? NodeInitializationTaints { get; set; }

    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    [JsonPropertyName("nodePublicIPPrefixID")]
    public string? NodePublicIPPrefixID { get; set; }

    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("podIPAllocationMode")]
    public string? PodIPAllocationMode { get; set; }

    [JsonPropertyName("podSubnetID")]
    public string? PodSubnetID { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.PowerState_STATUS
    /// Describes the Power State of the cluster
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewstorageManagedClustersAgentPoolStatusPowerState? PowerState { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("proximityPlacementGroupID")]
    public string? ProximityPlacementGroupID { get; set; }

    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolSecurityProfile_STATUS
    /// The security settings of an agent pool.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusSecurityProfile? SecurityProfile { get; set; }

    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolStatus_STATUS
    /// Contains read-only information about the Agent Pool.
    /// </summary>
    [JsonPropertyName("status")]
    public V20251002previewstorageManagedClustersAgentPoolStatusStatus? Status { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20251002previewstorageManagedClustersAgentPoolStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolUpgradeSettings_STATUS
    /// Settings for upgrading an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewstorageManagedClustersAgentPoolStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings_STATUS
    /// Settings for blue-green upgrade on an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewstorageManagedClustersAgentPoolStatusUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.VirtualMachinesProfile_STATUS
    /// Specifications on VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolWindowsProfile_STATUS
    /// The Windows agent pool&apos;s specific profile.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClustersAgentPoolStatusWindowsProfile? WindowsProfile { get; set; }

    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClustersAgentPool
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewstorageManagedClustersAgentPool : IKubernetesObject<V1ObjectMeta>, ISpec<V20251002previewstorageManagedClustersAgentPoolSpec?>, IStatus<V20251002previewstorageManagedClustersAgentPoolStatus?>
{
    public const string KubeApiVersion = "v20251002previewstorage";
    public const string KubeKind = "ManagedClustersAgentPool";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClustersAgentPool_Spec</summary>
    [JsonPropertyName("spec")]
    public V20251002previewstorageManagedClustersAgentPoolSpec? Spec { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClustersAgentPool_STATUS</summary>
    [JsonPropertyName("status")]
    public V20251002previewstorageManagedClustersAgentPoolStatus? Status { get; set; }
}