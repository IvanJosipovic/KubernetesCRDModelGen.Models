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
/// Storage version of v20251002preview.ManagedCluster
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewstorageManagedClusterList : IKubernetesObject<V1ListMeta>, IItems<V20251002previewstorageManagedCluster>
{
    public const string KubeApiVersion = "v20251002previewstorage";
    public const string KubeKind = "ManagedClusterList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251002previewstorageManagedCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251002previewstorageManagedCluster> Items { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAADProfile
/// AADProfile specifies attributes for Azure Active Directory integration. For more details see [managed AAD on
/// AKS](https://docs.microsoft.com/azure/aks/managed-aad).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAadProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAddonProfile
/// A Kubernetes add-on profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAddonProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesArtifactStreamingProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference
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
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolGatewayProfile
/// Profile of the managed cluster gateway agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesGatewayProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesGpuProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesHostGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesKubeletConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesLinuxOSConfig
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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PortRange
/// The port range.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
/// the version will use the latest version of the node customization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodeCustomizationProfileNodeCustomizationReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodeCustomizationProfile
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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodeCustomizationProfileNodeCustomizationReference? NodeCustomizationReference { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference
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
/// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
/// on the node subnet (see vnetSubnetID for more details). This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesPodSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesPowerState
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesSecurityProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesUpgradeSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesUpgradeSettingsBlueGreen
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleAutoscale
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale
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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    [JsonPropertyName("manual")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachinesProfile
/// Specifications on VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile
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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
/// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
/// pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesVnetSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfilesWindowsProfile
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

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAgentPoolProfile
/// Profile for the container service agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAgentPoolProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesCreationData? CreationData { get; set; }

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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.GPUProfile
    /// GPU settings for the Agent Pool.
    /// </summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
    /// only in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesHostGroupReference? HostGroupReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubeletConfig
    /// Kubelet configurations of agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LinuxOSConfig
    /// OS configurations of Linux agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LocalDNSProfile
    /// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
    /// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesLocalDNSProfile? LocalDNSProfile { get; set; }

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
    /// Storage version of v20251002preview.AgentPoolNetworkProfile
    /// Network settings of an agent pool.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.NodeCustomizationProfile
    /// Settings to determine the node customization used to provision nodes in a pool.
    /// </summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

    [JsonPropertyName("nodeInitializationTaints")]
    public IList<string>? NodeInitializationTaints { get; set; }

    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

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

    /// <summary>
    /// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
    /// on the node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.PowerState
    /// Describes the Power State of the cluster
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

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
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings
    /// Settings for blue-green upgrade on an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.VirtualMachinesProfile
    /// Specifications on VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
    /// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
    /// pods, otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolWindowsProfile
    /// The Windows agent pool&apos;s specific profile.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClusterSpecAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAIToolchainOperatorProfile
/// When enabling the operator, a set of AKS managed CRDs and controllers will be installed in the cluster. The operator
/// automates the deployment of OSS models for inference and/or training purposes. It provides a set of preset models and
/// enables distributed inference against them.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAiToolchainOperatorProfile
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
/// SubnetReference: The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new
/// cluster with BYO Vnet, or when updating an existing cluster to enable apiserver vnet integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecApiServerAccessProfileSubnetReference
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
/// Storage version of v20251002preview.ManagedClusterAPIServerAccessProfile
/// Access profile for managed cluster API server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecApiServerAccessProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    [JsonPropertyName("enableVnetIntegration")]
    public bool? EnableVnetIntegration { get; set; }

    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }

    /// <summary>
    /// SubnetReference: The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new
    /// cluster with BYO Vnet, or when updating an existing cluster to enable apiserver vnet integration.
    /// </summary>
    [JsonPropertyName("subnetReference")]
    public V20251002previewstorageManagedClusterSpecApiServerAccessProfileSubnetReference? SubnetReference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPropertiesAutoScalerProfile
/// Parameters to be applied to the cluster-autoscaler when enabled
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAutoScalerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAutoUpgradeProfile
/// Auto upgrade profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAutoUpgradeProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation
/// Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument
/// Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringAutoInstrumentation
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
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs
/// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects
/// OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
/// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects
/// OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoring
/// Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces
/// through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoring
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation
    /// Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument
    /// Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("autoInstrumentation")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringAutoInstrumentation? AutoInstrumentation { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs
    /// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects
    /// OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryLogs")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryLogs? OpenTelemetryLogs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
    /// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects
    /// OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryMetrics")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoringOpenTelemetryMetrics? OpenTelemetryMetrics { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Fully Qualified ARM Resource Id of Azure Log Analytics Workspace for storing
/// Azure Monitor Container Insights Logs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileContainerInsightsLogAnalyticsWorkspaceResourceReference
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
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileContainerInsights
/// Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See
/// aka.ms/AzureMonitorContainerInsights for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileContainerInsights
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableCustomMetrics")]
    public bool? DisableCustomMetrics { get; set; }

    [JsonPropertyName("disablePrometheusMetricsScraping")]
    public bool? DisablePrometheusMetricsScraping { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Fully Qualified ARM Resource Id of Azure Log Analytics Workspace for storing
    /// Azure Monitor Container Insights Logs.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileContainerInsightsLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    [JsonPropertyName("syslogPort")]
    public int? SyslogPort { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileKubeStateMetrics
/// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
/// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileMetrics
/// Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
/// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
/// aka.ms/AzureManagedPrometheus for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfileMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileKubeStateMetrics
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    /// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfile
/// Azure Monitor addon profiles for monitoring the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecAzureMonitorProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoring
    /// Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces
    /// through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("appMonitoring")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileAppMonitoring? AppMonitoring { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileContainerInsights
    /// Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See
    /// aka.ms/AzureMonitorContainerInsights for an overview.
    /// </summary>
    [JsonPropertyName("containerInsights")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileContainerInsights? ContainerInsights { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileMetrics
    /// Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>
/// ContainerRegistryReference: The resource Id of Azure Container Registry. The registry must have private network access,
/// premium SKU and zone redundancy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecBootstrapProfileContainerRegistryReference
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
/// Storage version of v20251002preview.ManagedClusterBootstrapProfile
/// The bootstrap profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecBootstrapProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("artifactSource")]
    public string? ArtifactSource { get; set; }

    /// <summary>
    /// ContainerRegistryReference: The resource Id of Azure Container Registry. The registry must have private network access,
    /// premium SKU and zone redundancy.
    /// </summary>
    [JsonPropertyName("containerRegistryReference")]
    public V20251002previewstorageManagedClusterSpecBootstrapProfileContainerRegistryReference? ContainerRegistryReference { get; set; }
}

/// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecCreationDataSourceResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewstorageManagedClusterSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// DiskEncryptionSetReference: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is
/// of the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecDiskEncryptionSetReference
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
/// Storage version of v20251002preview.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterHostedSystemProfile
/// Settings for hosted system addons.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecHostedSystemProfile
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
/// Storage version of v20251002preview.ManagedClusterHTTPProxyConfig
/// Cluster HTTP proxy configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecHttpProxyConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityDelegatedResourcesResourceReference
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
/// Storage version of v20251002preview.DelegatedResource
/// Delegated resource properties - internal use only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityDelegatedResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewstorageManagedClusterSpecIdentityDelegatedResourcesResourceReference? ResourceReference { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20251002preview.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20251002previewstorageManagedClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIdentity
/// Identity for the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V20251002previewstorageManagedClusterSpecIdentityDelegatedResources>? DelegatedResources { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20251002previewstorageManagedClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityProfileClientIdFromConfig
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

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityProfileObjectIdFromConfig
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
public partial class V20251002previewstorageManagedClusterSpecIdentityProfileResourceReference
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
/// Storage version of v20251002preview.UserAssignedIdentity
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIdentityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecIdentityProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecIdentityProfileObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewstorageManagedClusterSpecIdentityProfileResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfileApplicationLoadBalancer
/// Application Load Balancer settings for the ingress profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileApplicationLoadBalancer
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

/// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileGatewayConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileGatewayAPI
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("installation")]
    public string? Installation { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterIngressDefaultDomainProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingDefaultDomain
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences
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

/// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileNginx</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingNginx
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultIngressControllerType")]
    public string? DefaultIngressControllerType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfileWebAppRouting
/// Application Routing add-on settings for the ingress profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfileWebAppRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressDefaultDomainProfile</summary>
    [JsonPropertyName("defaultDomain")]
    public V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingDefaultDomain? DefaultDomain { get; set; }

    [JsonPropertyName("dnsZoneResourceReferences")]
    public IList<V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences>? DnsZoneResourceReferences { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileNginx</summary>
    [JsonPropertyName("nginx")]
    public V20251002previewstorageManagedClusterSpecIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfile
/// Ingress profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecIngressProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfileApplicationLoadBalancer
    /// Application Load Balancer settings for the ingress profile.
    /// </summary>
    [JsonPropertyName("applicationLoadBalancer")]
    public V20251002previewstorageManagedClusterSpecIngressProfileApplicationLoadBalancer? ApplicationLoadBalancer { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileGatewayConfiguration</summary>
    [JsonPropertyName("gatewayAPI")]
    public V20251002previewstorageManagedClusterSpecIngressProfileGatewayAPI? GatewayAPI { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfileWebAppRouting
    /// Application Routing add-on settings for the ingress profile.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V20251002previewstorageManagedClusterSpecIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceSshPublicKey
/// Contains information about SSH certificate public key data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecLinuxProfileSshPublicKeys
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceSshConfiguration
/// SSH configuration for Linux-based VMs running on Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecLinuxProfileSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V20251002previewstorageManagedClusterSpecLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceLinuxProfile
/// Profile for Linux VMs in the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecLinuxProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceSshConfiguration
    /// SSH configuration for Linux-based VMs running on Azure.
    /// </summary>
    [JsonPropertyName("ssh")]
    public V20251002previewstorageManagedClusterSpecLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterCostAnalysis
/// The cost analysis configuration for the cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecMetricsProfileCostAnalysis
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
/// Storage version of v20251002preview.ManagedClusterMetricsProfile
/// The metrics profile for the ManagedCluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecMetricsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterCostAnalysis
    /// The cost analysis configuration for the cluster
    /// </summary>
    [JsonPropertyName("costAnalysis")]
    public V20251002previewstorageManagedClusterSpecMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingObservability
/// Observability profile to enable advanced network metrics and flow logs with historical contexts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingObservability
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
/// Storage version of v20251002preview.AdvancedNetworkingPerformance
/// Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingPerformance
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accelerationMode")]
    public string? AccelerationMode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingSecurityTransitEncryption
/// Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed pods will be
/// encrypted when it leaves the node boundary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingSecurity
/// Security profile to enable security features on cilium based cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedNetworkPolicies")]
    public string? AdvancedNetworkPolicies { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingSecurityTransitEncryption
    /// Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed pods will be
    /// encrypted when it leaves the node boundary.
    /// </summary>
    [JsonPropertyName("transitEncryption")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityTransitEncryption? TransitEncryption { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworking
/// Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see
/// aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingObservability
    /// Observability profile to enable advanced network metrics and flow logs with historical contexts.
    /// </summary>
    [JsonPropertyName("observability")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingPerformance
    /// Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.
    /// </summary>
    [JsonPropertyName("performance")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingPerformance? Performance { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingSecurity
    /// Security profile to enable security features on cilium based cluster.
    /// </summary>
    [JsonPropertyName("security")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfigIpvsConfig
/// Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scheduler")]
    public string? Scheduler { get; set; }

    [JsonPropertyName("tcpFinTimeoutSeconds")]
    public int? TcpFinTimeoutSeconds { get; set; }

    [JsonPropertyName("tcpTimeoutSeconds")]
    public int? TcpTimeoutSeconds { get; set; }

    [JsonPropertyName("udpTimeoutSeconds")]
    public int? UdpTimeoutSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfig
/// Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior.
/// See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is
/// represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileKubeProxyConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfigIpvsConfig
    /// Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.
    /// </summary>
    [JsonPropertyName("ipvsConfig")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileKubeProxyConfigIpvsConfig? IpvsConfig { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileManagedOutboundIPs
/// Desired managed outbound IPs for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference
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
/// Storage version of v20251002preview.ResourceReference
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPPrefixes
/// Desired outbound IP Prefix resources for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPPrefixes")]
    public IList<V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference
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
/// Storage version of v20251002preview.ResourceReference
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPs
/// Desired outbound IP resources for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPs")]
    public IList<V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfile
/// Profile of the managed cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    [JsonPropertyName("clusterServiceLoadBalancerHealthProbeMode")]
    public string? ClusterServiceLoadBalancerHealthProbeMode { get; set; }

    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileManagedOutboundIPs
    /// Desired managed outbound IPs for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPPrefixes
    /// Desired outbound IP Prefix resources for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPs
    /// Desired outbound IP resources for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("outboundIPs")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterManagedOutboundIPProfile
/// Profile of the managed outbound IP resources of the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterNATGatewayProfile
/// Profile of the managed cluster NAT gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileNatGatewayProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterManagedOutboundIPProfile
    /// Profile of the managed outbound IP resources of the managed cluster.
    /// </summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStaticEgressGatewayProfile
/// The Static Egress Gateway addon configuration for the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfileStaticEgressGatewayProfile
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
/// Storage version of v20251002preview.ContainerServiceNetworkProfile
/// Profile of network configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworking
    /// Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see
    /// aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfig
    /// Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior.
    /// See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is
    /// represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
    /// </summary>
    [JsonPropertyName("kubeProxyConfig")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileKubeProxyConfig? KubeProxyConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfile
    /// Profile of the managed cluster load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterNATGatewayProfile
    /// Profile of the managed cluster NAT gateway.
    /// </summary>
    [JsonPropertyName("natGatewayProfile")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    [JsonPropertyName("podLinkLocalAccess")]
    public string? PodLinkLocalAccess { get; set; }

    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStaticEgressGatewayProfile
    /// The Static Egress Gateway addon configuration for the cluster.
    /// </summary>
    [JsonPropertyName("staticEgressGatewayProfile")]
    public V20251002previewstorageManagedClusterSpecNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterNodeProvisioningProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNodeProvisioningProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultNodePools")]
    public string? DefaultNodePools { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterNodeResourceGroupProfile
/// Node resource group lockdown profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecNodeResourceGroupProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterOIDCIssuerProfile
/// The OIDC issuer profile of the Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOidcIssuerProfile
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecConfigMapExpressions
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
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile
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

/// <summary>Storage version of v20251002preview.ManagedClusterOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewstorageManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile? OidcIssuerProfile { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecSecretsAdminCredentials
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecSecretsUserCredentials
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

/// <summary>Storage version of v20251002preview.ManagedClusterOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("adminCredentials")]
    public V20251002previewstorageManagedClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("userCredentials")]
    public V20251002previewstorageManagedClusterSpecOperatorSpecSecretsUserCredentials? UserCredentials { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20251002previewstorageManagedClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V20251002previewstorageManagedClusterSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20251002previewstorageManagedClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V20251002previewstorageManagedClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig
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

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig
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
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference
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
/// Storage version of v20251002preview.UserAssignedIdentity
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentity
/// Details about the pod identity assigned to the Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityException
/// A pod identity exception, which allows pods with certain labels to access the Azure Instance Metadata Service (IMDS)
/// endpoint without being intercepted by the node-managed identity (NMI) server. See [disable AAD Pod Identity for a
/// specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("podLabels")]
    public IDictionary<string, string>? PodLabels { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityProfile
/// The pod identity profile of the Managed Cluster. See [use AAD pod
/// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPodIdentityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V20251002previewstorageManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Reference: The ID of the private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPrivateLinkResourcesReference
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
/// Storage version of v20251002preview.PrivateLinkResource
/// A private link resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecPrivateLinkResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: The ID of the private link resource.</summary>
    [JsonPropertyName("reference")]
    public V20251002previewstorageManagedClusterSpecPrivateLinkResourcesReference? Reference { get; set; }

    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerInstanceProfile
/// The scheduler profile for a single scheduler instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstream
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("schedulerConfigMode")]
    public string? SchedulerConfigMode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerProfileSchedulerInstanceProfiles
/// Mapping of each scheduler instance to its profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSchedulerProfileSchedulerInstanceProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerInstanceProfile
    /// The scheduler profile for a single scheduler instance.
    /// </summary>
    [JsonPropertyName("upstream")]
    public V20251002previewstorageManagedClusterSpecSchedulerProfileSchedulerInstanceProfilesUpstream? Upstream { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerProfile
/// The pod scheduler profile for the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSchedulerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerProfileSchedulerInstanceProfiles
    /// Mapping of each scheduler instance to its profile.
    /// </summary>
    [JsonPropertyName("schedulerInstanceProfiles")]
    public V20251002previewstorageManagedClusterSpecSchedulerProfileSchedulerInstanceProfiles? SchedulerInstanceProfiles { get; set; }
}

/// <summary>
/// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
/// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference
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
/// Storage version of v20251002preview.AzureKeyVaultKms
/// Azure Key Vault key management service settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileAzureKeyVaultKms
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }

    /// <summary>
    /// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
    /// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyVaultResourceReference")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference? KeyVaultResourceReference { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
/// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
/// Microsoft Defender is disabled, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference
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
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityClientIdFromConfig
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

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityObjectIdFromConfig
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
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityResourceReference
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
/// Storage version of v20251002preview.UserAssignedIdentity
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGatingIdentitiesItem</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureContainerRegistry")]
    public string? AzureContainerRegistry { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentitiesIdentity? Identity { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGating
/// Microsoft Defender settings for security gating, validates container images eligibility for deployment based on Defender
/// for Containers security findings. Using Admission Controller, it either audits or prevents the deployment of images that
/// do not meet security standards.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGating
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowSecretAccess")]
    public bool? AllowSecretAccess { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("identities")]
    public IList<V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGatingIdentities>? Identities { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityMonitoring
/// Microsoft Defender settings for the security profile threat detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityMonitoring
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefender
/// Microsoft Defender settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileDefender
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
    /// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
    /// Microsoft Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGating
    /// Microsoft Defender settings for security gating, validates container images eligibility for deployment based on Defender
    /// for Containers security findings. Using Admission Controller, it either audits or prevents the deployment of images that
    /// do not meet security standards.
    /// </summary>
    [JsonPropertyName("securityGating")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityGating? SecurityGating { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityMonitoring
    /// Microsoft Defender settings for the security profile threat detection.
    /// </summary>
    [JsonPropertyName("securityMonitoring")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileImageCleaner
/// Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here
/// are settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileImageCleaner
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileImageIntegrity
/// Image integrity related settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileImageIntegrity
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
/// Storage version of v20251002preview.KubernetesResourceObjectEncryptionProfile
/// Encryption at rest of Kubernetes resource objects using service-managed keys. More information on this can be found
/// under https://aka.ms/aks/kubernetesResourceObjectEncryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("infrastructureEncryption")]
    public string? InfrastructureEncryption { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileNodeRestriction
/// Node Restriction settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileNodeRestriction
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfileWorkloadIdentity
/// Workload identity settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfileWorkloadIdentity
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfile
/// Security profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AzureKeyVaultKms
    /// Azure Key Vault key management service settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefender
    /// Microsoft Defender settings for the security profile.
    /// </summary>
    [JsonPropertyName("defender")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileDefender? Defender { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileImageCleaner
    /// Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here
    /// are settings for the security profile.
    /// </summary>
    [JsonPropertyName("imageCleaner")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileImageIntegrity
    /// Image integrity related settings for the security profile.
    /// </summary>
    [JsonPropertyName("imageIntegrity")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileImageIntegrity? ImageIntegrity { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubernetesResourceObjectEncryptionProfile
    /// Encryption at rest of Kubernetes resource objects using service-managed keys. More information on this can be found
    /// under https://aka.ms/aks/kubernetesResourceObjectEncryption.
    /// </summary>
    [JsonPropertyName("kubernetesResourceObjectEncryptionProfile")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileKubernetesResourceObjectEncryptionProfile? KubernetesResourceObjectEncryptionProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileNodeRestriction
    /// Node Restriction settings for the security profile.
    /// </summary>
    [JsonPropertyName("nodeRestriction")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileNodeRestriction? NodeRestriction { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileWorkloadIdentity
    /// Workload identity settings for the security profile.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V20251002previewstorageManagedClusterSpecSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference
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
/// Storage version of v20251002preview.IstioPluginCertificateAuthority
/// Plugin certificates information for Service Mesh.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference? KeyVaultReference { get; set; }

    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioCertificateAuthority
/// Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described
/// here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioPluginCertificateAuthority
    /// Plugin certificates information for Service Mesh.
    /// </summary>
    [JsonPropertyName("plugin")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioEgressGateway
/// Istio egress gateway configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("gatewayConfigurationName")]
    public string? GatewayConfigurationName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioIngressGateway
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioComponents
/// Istio components configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponents
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("egressGateways")]
    public IList<V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    [JsonPropertyName("ingressGateways")]
    public IList<V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }

    [JsonPropertyName("proxyRedirectionMechanism")]
    public string? ProxyRedirectionMechanism { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioServiceMesh
/// Istio service mesh configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfileIstio
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioCertificateAuthority
    /// Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described
    /// here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioComponents
    /// Istio components configuration.
    /// </summary>
    [JsonPropertyName("components")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfileIstioComponents? Components { get; set; }

    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ServiceMeshProfile
/// Service mesh profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServiceMeshProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioServiceMesh
    /// Istio service mesh configuration.
    /// </summary>
    [JsonPropertyName("istio")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfileIstio? Istio { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServicePrincipalProfileSecret
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
/// Storage version of v20251002preview.ManagedClusterServicePrincipalProfile
/// Information about a service principal identity for the cluster to use for manipulating Azure APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecServicePrincipalProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("secret")]
    public V20251002previewstorageManagedClusterSpecServicePrincipalProfileSecret? Secret { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSKU
/// The SKU of a Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStorageProfileBlobCSIDriver
/// AzureBlob CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecStorageProfileBlobCSIDriver
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
/// Storage version of v20251002preview.ManagedClusterStorageProfileDiskCSIDriver
/// AzureDisk CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecStorageProfileDiskCSIDriver
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStorageProfileFileCSIDriver
/// AzureFile CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecStorageProfileFileCSIDriver
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
/// Storage version of v20251002preview.ManagedClusterStorageProfileSnapshotController
/// Snapshot Controller settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecStorageProfileSnapshotController
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
/// Storage version of v20251002preview.ManagedClusterStorageProfile
/// Storage profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileBlobCSIDriver
    /// AzureBlob CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("blobCSIDriver")]
    public V20251002previewstorageManagedClusterSpecStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileDiskCSIDriver
    /// AzureDisk CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("diskCSIDriver")]
    public V20251002previewstorageManagedClusterSpecStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileFileCSIDriver
    /// AzureFile CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("fileCSIDriver")]
    public V20251002previewstorageManagedClusterSpecStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileSnapshotController
    /// Snapshot Controller settings for the storage profile.
    /// </summary>
    [JsonPropertyName("snapshotController")]
    public V20251002previewstorageManagedClusterSpecStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UpgradeOverrideSettings
/// Settings for overrides when upgrading a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecUpgradeSettingsOverrideSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ClusterUpgradeSettings
/// Settings for upgrading a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecUpgradeSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UpgradeOverrideSettings
    /// Settings for overrides when upgrading a cluster.
    /// </summary>
    [JsonPropertyName("overrideSettings")]
    public V20251002previewstorageManagedClusterSpecUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWindowsProfileAdminPassword
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
/// Storage version of v20251002preview.WindowsGmsaProfile
/// Windows gMSA Profile in the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWindowsProfileGmsaProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWindowsProfile
/// Profile for Windows VMs in the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWindowsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("adminPassword")]
    public V20251002previewstorageManagedClusterSpecWindowsProfileAdminPassword? AdminPassword { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.WindowsGmsaProfile
    /// Windows gMSA Profile in the managed cluster.
    /// </summary>
    [JsonPropertyName("gmsaProfile")]
    public V20251002previewstorageManagedClusterSpecWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileKeda
/// KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfileKeda
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
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler
/// VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addonAutoscaling")]
    public string? AddonAutoscaling { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfile
/// Workload Auto-scaler profile for the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileKeda
    /// KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.
    /// </summary>
    [JsonPropertyName("keda")]
    public V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler
    /// VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.
    /// </summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedCluster_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAADProfile
    /// AADProfile specifies attributes for Azure Active Directory integration. For more details see [managed AAD on
    /// AKS](https://docs.microsoft.com/azure/aks/managed-aad).
    /// </summary>
    [JsonPropertyName("aadProfile")]
    public V20251002previewstorageManagedClusterSpecAadProfile? AadProfile { get; set; }

    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V20251002previewstorageManagedClusterSpecAddonProfiles>? AddonProfiles { get; set; }

    [JsonPropertyName("agentPoolProfiles")]
    public IList<V20251002previewstorageManagedClusterSpecAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAIToolchainOperatorProfile
    /// When enabling the operator, a set of AKS managed CRDs and controllers will be installed in the cluster. The operator
    /// automates the deployment of OSS models for inference and/or training purposes. It provides a set of preset models and
    /// enables distributed inference against them.
    /// </summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V20251002previewstorageManagedClusterSpecAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAPIServerAccessProfile
    /// Access profile for managed cluster API server.
    /// </summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V20251002previewstorageManagedClusterSpecApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPropertiesAutoScalerProfile
    /// Parameters to be applied to the cluster-autoscaler when enabled
    /// </summary>
    [JsonPropertyName("autoScalerProfile")]
    public V20251002previewstorageManagedClusterSpecAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAutoUpgradeProfile
    /// Auto upgrade profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V20251002previewstorageManagedClusterSpecAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfile
    /// Azure Monitor addon profiles for monitoring the managed cluster.
    /// </summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V20251002previewstorageManagedClusterSpecAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterBootstrapProfile
    /// The bootstrap profile.
    /// </summary>
    [JsonPropertyName("bootstrapProfile")]
    public V20251002previewstorageManagedClusterSpecBootstrapProfile? BootstrapProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClusterSpecCreationData? CreationData { get; set; }

    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>
    /// DiskEncryptionSetReference: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is
    /// of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
    /// </summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V20251002previewstorageManagedClusterSpecDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    [JsonPropertyName("enableNamespaceResources")]
    public bool? EnableNamespaceResources { get; set; }

    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20251002previewstorageManagedClusterSpecExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterHostedSystemProfile
    /// Settings for hosted system addons.
    /// </summary>
    [JsonPropertyName("hostedSystemProfile")]
    public V20251002previewstorageManagedClusterSpecHostedSystemProfile? HostedSystemProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterHTTPProxyConfig
    /// Cluster HTTP proxy configuration.
    /// </summary>
    [JsonPropertyName("httpProxyConfig")]
    public V20251002previewstorageManagedClusterSpecHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIdentity
    /// Identity for the managed cluster.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterSpecIdentity? Identity { get; set; }

    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V20251002previewstorageManagedClusterSpecIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfile
    /// Ingress profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("ingressProfile")]
    public V20251002previewstorageManagedClusterSpecIngressProfile? IngressProfile { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceLinuxProfile
    /// Profile for Linux VMs in the container service cluster.
    /// </summary>
    [JsonPropertyName("linuxProfile")]
    public V20251002previewstorageManagedClusterSpecLinuxProfile? LinuxProfile { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterMetricsProfile
    /// The metrics profile for the ManagedCluster.
    /// </summary>
    [JsonPropertyName("metricsProfile")]
    public V20251002previewstorageManagedClusterSpecMetricsProfile? MetricsProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfile
    /// Profile of network configuration.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewstorageManagedClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterNodeProvisioningProfile</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V20251002previewstorageManagedClusterSpecNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterNodeResourceGroupProfile
    /// Node resource group lockdown profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V20251002previewstorageManagedClusterSpecNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterOIDCIssuerProfile
    /// The OIDC issuer profile of the Managed Cluster.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewstorageManagedClusterSpecOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251002previewstorageManagedClusterSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251002previewstorageManagedClusterSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPodIdentityProfile
    /// The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V20251002previewstorageManagedClusterSpecPodIdentityProfile? PodIdentityProfile { get; set; }

    [JsonPropertyName("privateLinkResources")]
    public IList<V20251002previewstorageManagedClusterSpecPrivateLinkResources>? PrivateLinkResources { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerProfile
    /// The pod scheduler profile for the cluster.
    /// </summary>
    [JsonPropertyName("schedulerProfile")]
    public V20251002previewstorageManagedClusterSpecSchedulerProfile? SchedulerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfile
    /// Security profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewstorageManagedClusterSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ServiceMeshProfile
    /// Service mesh profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V20251002previewstorageManagedClusterSpecServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterServicePrincipalProfile
    /// Information about a service principal identity for the cluster to use for manipulating Azure APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V20251002previewstorageManagedClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSKU
    /// The SKU of a Managed Cluster.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20251002previewstorageManagedClusterSpecSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfile
    /// Storage profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V20251002previewstorageManagedClusterSpecStorageProfile? StorageProfile { get; set; }

    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ClusterUpgradeSettings
    /// Settings for upgrading a cluster.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewstorageManagedClusterSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWindowsProfile
    /// Profile for Windows VMs in the managed cluster.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClusterSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfile
    /// Workload Auto-scaler profile for the managed cluster.
    /// </summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V20251002previewstorageManagedClusterSpecWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAADProfile_STATUS
/// AADProfile specifies attributes for Azure Active Directory integration. For more details see [managed AAD on
/// AKS](https://docs.microsoft.com/azure/aks/managed-aad).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAadProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAddonProfilesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAddonProfile_STATUS
/// A Kubernetes add-on profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAddonProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity_STATUS
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusAddonProfilesIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesArtifactStreamingProfile
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
/// Storage version of v20251002preview.CreationData_STATUS
/// Data used when creating a target resource from a source resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesCreationData
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesGatewayProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesGpuProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesKubeletConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesLinuxOSConfig
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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.LocalDNSOverride_STATUS
/// Overrides for localDNS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfileKubeDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfileVnetDNSOverrides
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PortRange_STATUS
/// The port range.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.NodeCustomizationProfile_STATUS
/// Settings to determine the node customization used to provision nodes in a pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesNodeCustomizationProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesPowerState
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesSecurityProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolStatus_STATUS
/// Contains read-only information about the Agent Pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatus
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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolUpgradeSettings_STATUS
/// Settings for upgrading an agentpool
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesUpgradeSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesUpgradeSettingsBlueGreen
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleAutoscale
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale
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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    [JsonPropertyName("manual")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.VirtualMachinesProfile_STATUS
/// Specifications on VirtualMachines agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile
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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AgentPoolWindowsProfile_STATUS
/// The Windows agent pool&apos;s specific profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfilesWindowsProfile
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

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAgentPoolProfile_STATUS
/// Profile for the container service agent pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAgentPoolProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.AgentPoolArtifactStreamingProfile_STATUS</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    [JsonPropertyName("capacityReservationGroupID")]
    public string? CapacityReservationGroupID { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData_STATUS
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesCreationData? CreationData { get; set; }

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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.GPUProfile_STATUS
    /// GPU settings for the Agent Pool.
    /// </summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubeletConfig_STATUS
    /// Kubelet configurations of agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LinuxOSConfig_STATUS
    /// OS configurations of Linux agent nodes. See [AKS custom node
    /// configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.
    /// </summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.LocalDNSProfile_STATUS
    /// Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve performance and
    /// reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesLocalDNSProfile? LocalDNSProfile { get; set; }

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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.NodeCustomizationProfile_STATUS
    /// Settings to determine the node customization used to provision nodes in a pool.
    /// </summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesPowerState? PowerState { get; set; }

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
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolStatus_STATUS
    /// Contains read-only information about the Agent Pool.
    /// </summary>
    [JsonPropertyName("status")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesStatus? Status { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolUpgradeSettings_STATUS
    /// Settings for upgrading an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolBlueGreenUpgradeSettings_STATUS
    /// Settings for blue-green upgrade on an agentpool
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.VirtualMachinesProfile_STATUS
    /// Specifications on VirtualMachines agent pool.
    /// </summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AgentPoolWindowsProfile_STATUS
    /// The Windows agent pool&apos;s specific profile.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClusterStatusAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAIToolchainOperatorProfile_STATUS
/// When enabling the operator, a set of AKS managed CRDs and controllers will be installed in the cluster. The operator
/// automates the deployment of OSS models for inference and/or training purposes. It provides a set of preset models and
/// enables distributed inference against them.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAiToolchainOperatorProfile
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
/// Storage version of v20251002preview.ManagedClusterAPIServerAccessProfile_STATUS
/// Access profile for managed cluster API server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusApiServerAccessProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    [JsonPropertyName("enableVnetIntegration")]
    public bool? EnableVnetIntegration { get; set; }

    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }

    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPropertiesAutoScalerProfile_STATUS
/// Parameters to be applied to the cluster-autoscaler when enabled
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAutoScalerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAutoUpgradeProfile_STATUS
/// Auto upgrade profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAutoUpgradeProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation_STATUS
/// Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument
/// Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringAutoInstrumentation
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
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs_STATUS
/// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects
/// OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics_STATUS
/// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects
/// OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoring_STATUS
/// Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces
/// through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
/// aka.ms/AzureMonitorApplicationMonitoring for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoring
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation_STATUS
    /// Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument
    /// Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("autoInstrumentation")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringAutoInstrumentation? AutoInstrumentation { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs_STATUS
    /// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects
    /// OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryLogs")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryLogs? OpenTelemetryLogs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics_STATUS
    /// Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects
    /// OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("openTelemetryMetrics")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoringOpenTelemetryMetrics? OpenTelemetryMetrics { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileContainerInsights_STATUS
/// Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See
/// aka.ms/AzureMonitorContainerInsights for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileContainerInsights
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableCustomMetrics")]
    public bool? DisableCustomMetrics { get; set; }

    [JsonPropertyName("disablePrometheusMetricsScraping")]
    public bool? DisablePrometheusMetricsScraping { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    [JsonPropertyName("syslogPort")]
    public int? SyslogPort { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileKubeStateMetrics_STATUS
/// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
/// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileMetrics_STATUS
/// Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
/// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
/// aka.ms/AzureManagedPrometheus for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfileMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileKubeStateMetrics_STATUS
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    /// kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterAzureMonitorProfile_STATUS
/// Azure Monitor addon profiles for monitoring the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusAzureMonitorProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileAppMonitoring_STATUS
    /// Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces
    /// through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See
    /// aka.ms/AzureMonitorApplicationMonitoring for an overview.
    /// </summary>
    [JsonPropertyName("appMonitoring")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileAppMonitoring? AppMonitoring { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileContainerInsights_STATUS
    /// Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See
    /// aka.ms/AzureMonitorContainerInsights for an overview.
    /// </summary>
    [JsonPropertyName("containerInsights")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileContainerInsights? ContainerInsights { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfileMetrics_STATUS
    /// Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterBootstrapProfile_STATUS
/// The bootstrap profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusBootstrapProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("artifactSource")]
    public string? ArtifactSource { get; set; }

    [JsonPropertyName("containerRegistryId")]
    public string? ContainerRegistryId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusCreationData
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
/// Storage version of v20251002preview.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterHostedSystemProfile_STATUS
/// Settings for hosted system addons.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusHostedSystemProfile
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
/// Storage version of v20251002preview.ManagedClusterHTTPProxyConfig_STATUS
/// Cluster HTTP proxy configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusHttpProxyConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("effectiveNoProxy")]
    public IList<string>? EffectiveNoProxy { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.DelegatedResource_STATUS
/// Delegated resource properties - internal use only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIdentityDelegatedResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedServiceIdentityUserAssignedIdentitiesValue_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIdentity_STATUS
/// Identity for the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusIdentityDelegatedResources>? DelegatedResources { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIdentityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileApplicationLoadBalancerIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfileApplicationLoadBalancer_STATUS
/// Application Load Balancer settings for the ingress profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileApplicationLoadBalancer
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity_STATUS
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusIngressProfileApplicationLoadBalancerIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileGatewayConfiguration_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileGatewayAPI
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("installation")]
    public string? Installation { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterIngressDefaultDomainProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingDefaultDomain
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileNginx_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingNginx
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultIngressControllerType")]
    public string? DefaultIngressControllerType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfileWebAppRouting_STATUS
/// Application Routing add-on settings for the ingress profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfileWebAppRouting
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressDefaultDomainProfile_STATUS</summary>
    [JsonPropertyName("defaultDomain")]
    public V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingDefaultDomain? DefaultDomain { get; set; }

    [JsonPropertyName("dnsZoneResourceIds")]
    public IList<string>? DnsZoneResourceIds { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity_STATUS
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingIdentity? Identity { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileNginx_STATUS</summary>
    [JsonPropertyName("nginx")]
    public V20251002previewstorageManagedClusterStatusIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterIngressProfile_STATUS
/// Ingress profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusIngressProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfileApplicationLoadBalancer_STATUS
    /// Application Load Balancer settings for the ingress profile.
    /// </summary>
    [JsonPropertyName("applicationLoadBalancer")]
    public V20251002previewstorageManagedClusterStatusIngressProfileApplicationLoadBalancer? ApplicationLoadBalancer { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterIngressProfileGatewayConfiguration_STATUS</summary>
    [JsonPropertyName("gatewayAPI")]
    public V20251002previewstorageManagedClusterStatusIngressProfileGatewayAPI? GatewayAPI { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfileWebAppRouting_STATUS
    /// Application Routing add-on settings for the ingress profile.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V20251002previewstorageManagedClusterStatusIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceSshPublicKey_STATUS
/// Contains information about SSH certificate public key data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusLinuxProfileSshPublicKeys
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceSshConfiguration_STATUS
/// SSH configuration for Linux-based VMs running on Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusLinuxProfileSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V20251002previewstorageManagedClusterStatusLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceLinuxProfile_STATUS
/// Profile for Linux VMs in the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusLinuxProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceSshConfiguration_STATUS
    /// SSH configuration for Linux-based VMs running on Azure.
    /// </summary>
    [JsonPropertyName("ssh")]
    public V20251002previewstorageManagedClusterStatusLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterCostAnalysis_STATUS
/// The cost analysis configuration for the cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusMetricsProfileCostAnalysis
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
/// Storage version of v20251002preview.ManagedClusterMetricsProfile_STATUS
/// The metrics profile for the ManagedCluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusMetricsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterCostAnalysis_STATUS
    /// The cost analysis configuration for the cluster
    /// </summary>
    [JsonPropertyName("costAnalysis")]
    public V20251002previewstorageManagedClusterStatusMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingObservability_STATUS
/// Observability profile to enable advanced network metrics and flow logs with historical contexts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingObservability
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
/// Storage version of v20251002preview.AdvancedNetworkingPerformance_STATUS
/// Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingPerformance
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accelerationMode")]
    public string? AccelerationMode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingSecurityTransitEncryption_STATUS
/// Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed pods will be
/// encrypted when it leaves the node boundary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurityTransitEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworkingSecurity_STATUS
/// Security profile to enable security features on cilium based cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedNetworkPolicies")]
    public string? AdvancedNetworkPolicies { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingSecurityTransitEncryption_STATUS
    /// Encryption configuration for Cilium-based clusters. Once enabled all traffic between Cilium managed pods will be
    /// encrypted when it leaves the node boundary.
    /// </summary>
    [JsonPropertyName("transitEncryption")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurityTransitEncryption? TransitEncryption { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AdvancedNetworking_STATUS
/// Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see
/// aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingObservability_STATUS
    /// Observability profile to enable advanced network metrics and flow logs with historical contexts.
    /// </summary>
    [JsonPropertyName("observability")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingPerformance_STATUS
    /// Profile to enable performance-enhancing features on clusters that use Azure CNI powered by Cilium.
    /// </summary>
    [JsonPropertyName("performance")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingPerformance? Performance { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworkingSecurity_STATUS
    /// Security profile to enable security features on cilium based cluster.
    /// </summary>
    [JsonPropertyName("security")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfigIpvsConfig_STATUS
/// Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileKubeProxyConfigIpvsConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scheduler")]
    public string? Scheduler { get; set; }

    [JsonPropertyName("tcpFinTimeoutSeconds")]
    public int? TcpFinTimeoutSeconds { get; set; }

    [JsonPropertyName("tcpTimeoutSeconds")]
    public int? TcpTimeoutSeconds { get; set; }

    [JsonPropertyName("udpTimeoutSeconds")]
    public int? UdpTimeoutSeconds { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfig_STATUS
/// Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior.
/// See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is
/// represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileKubeProxyConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfigIpvsConfig_STATUS
    /// Holds configuration customizations for IPVS. May only be specified if &apos;mode&apos; is set to &apos;IPVS&apos;.
    /// </summary>
    [JsonPropertyName("ipvsConfig")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileKubeProxyConfigIpvsConfig? IpvsConfig { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ResourceReference_STATUS
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileManagedOutboundIPs_STATUS
/// Desired managed outbound IPs for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ResourceReference_STATUS
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPPrefixes_STATUS
/// Desired outbound IP Prefix resources for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPPrefixes")]
    public IList<V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ResourceReference_STATUS
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPs_STATUS
/// Desired outbound IP resources for the cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicIPs")]
    public IList<V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterLoadBalancerProfile_STATUS
/// Profile of the managed cluster load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    [JsonPropertyName("clusterServiceLoadBalancerHealthProbeMode")]
    public string? ClusterServiceLoadBalancerHealthProbeMode { get; set; }

    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileManagedOutboundIPs_STATUS
    /// Desired managed outbound IPs for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPPrefixes_STATUS
    /// Desired outbound IP Prefix resources for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfileOutboundIPs_STATUS
    /// Desired outbound IP resources for the cluster load balancer.
    /// </summary>
    [JsonPropertyName("outboundIPs")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ResourceReference_STATUS
/// A reference to an Azure resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterManagedOutboundIPProfile_STATUS
/// Profile of the managed outbound IP resources of the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterNATGatewayProfile_STATUS
/// Profile of the managed cluster NAT gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterManagedOutboundIPProfile_STATUS
    /// Profile of the managed outbound IP resources of the managed cluster.
    /// </summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStaticEgressGatewayProfile_STATUS
/// The Static Egress Gateway addon configuration for the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfileStaticEgressGatewayProfile
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
/// Storage version of v20251002preview.ContainerServiceNetworkProfile_STATUS
/// Profile of network configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AdvancedNetworking_STATUS
    /// Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see
    /// aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfileKubeProxyConfig_STATUS
    /// Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior.
    /// See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is
    /// represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be &apos;1-23&apos;.
    /// </summary>
    [JsonPropertyName("kubeProxyConfig")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileKubeProxyConfig? KubeProxyConfig { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterLoadBalancerProfile_STATUS
    /// Profile of the managed cluster load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterNATGatewayProfile_STATUS
    /// Profile of the managed cluster NAT gateway.
    /// </summary>
    [JsonPropertyName("natGatewayProfile")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    [JsonPropertyName("podLinkLocalAccess")]
    public string? PodLinkLocalAccess { get; set; }

    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStaticEgressGatewayProfile_STATUS
    /// The Static Egress Gateway addon configuration for the cluster.
    /// </summary>
    [JsonPropertyName("staticEgressGatewayProfile")]
    public V20251002previewstorageManagedClusterStatusNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterNodeProvisioningProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNodeProvisioningProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultNodePools")]
    public string? DefaultNodePools { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterNodeResourceGroupProfile_STATUS
/// Node resource group lockdown profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusNodeResourceGroupProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterOIDCIssuerProfile_STATUS
/// The OIDC issuer profile of the Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusOidcIssuerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("issuerURL")]
    public string? IssuerURL { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningErrorBody_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningErrorBody_STATUS
/// An error response from the pod identity provisioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningError_STATUS
/// An error response from the pod identity provisioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningErrorBody_STATUS
    /// An error response from the pod identity provisioning.
    /// </summary>
    [JsonPropertyName("error")]
    public V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError? Error { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningInfo_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningError_STATUS
    /// An error response from the pod identity provisioning.
    /// </summary>
    [JsonPropertyName("error")]
    public V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError? Error { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentity_STATUS
/// Details about the pod identity assigned to the Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity_STATUS
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterPodIdentityProvisioningInfo_STATUS</summary>
    [JsonPropertyName("provisioningInfo")]
    public V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo? ProvisioningInfo { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityException_STATUS
/// A pod identity exception, which allows pods with certain labels to access the Azure Instance Metadata Service (IMDS)
/// endpoint without being intercepted by the node-managed identity (NMI) server. See [disable AAD Pod Identity for a
/// specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("podLabels")]
    public IDictionary<string, string>? PodLabels { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterPodIdentityProfile_STATUS
/// The pod identity profile of the Managed Cluster. See [use AAD pod
/// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPodIdentityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V20251002previewstorageManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.PowerState_STATUS
/// Describes the Power State of the cluster
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPowerState
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
/// Storage version of v20251002preview.PrivateLinkResource_STATUS
/// A private link resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusPrivateLinkResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateLinkServiceID")]
    public string? PrivateLinkServiceID { get; set; }

    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerInstanceProfile_STATUS
/// The scheduler profile for a single scheduler instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSchedulerProfileSchedulerInstanceProfilesUpstream
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("schedulerConfigMode")]
    public string? SchedulerConfigMode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerProfileSchedulerInstanceProfiles_STATUS
/// Mapping of each scheduler instance to its profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSchedulerProfileSchedulerInstanceProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerInstanceProfile_STATUS
    /// The scheduler profile for a single scheduler instance.
    /// </summary>
    [JsonPropertyName("upstream")]
    public V20251002previewstorageManagedClusterStatusSchedulerProfileSchedulerInstanceProfilesUpstream? Upstream { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SchedulerProfile_STATUS
/// The pod scheduler profile for the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSchedulerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerProfileSchedulerInstanceProfiles_STATUS
    /// Mapping of each scheduler instance to its profile.
    /// </summary>
    [JsonPropertyName("schedulerInstanceProfiles")]
    public V20251002previewstorageManagedClusterStatusSchedulerProfileSchedulerInstanceProfiles? SchedulerInstanceProfiles { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.AzureKeyVaultKms_STATUS
/// Azure Key Vault key management service settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileAzureKeyVaultKms
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }

    [JsonPropertyName("keyVaultResourceId")]
    public string? KeyVaultResourceId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.UserAssignedIdentity_STATUS
/// Details about a user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentitiesIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGatingIdentitiesItem_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureContainerRegistry")]
    public string? AzureContainerRegistry { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UserAssignedIdentity_STATUS
    /// Details about a user assigned identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentitiesIdentity? Identity { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGating_STATUS
/// Microsoft Defender settings for security gating, validates container images eligibility for deployment based on Defender
/// for Containers security findings. Using Admission Controller, it either audits or prevents the deployment of images that
/// do not meet security standards.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGating
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowSecretAccess")]
    public bool? AllowSecretAccess { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("identities")]
    public IList<V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGatingIdentities>? Identities { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityMonitoring_STATUS
/// Microsoft Defender settings for the security profile threat detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityMonitoring
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfileDefender_STATUS
/// Microsoft Defender settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileDefender
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityGating_STATUS
    /// Microsoft Defender settings for security gating, validates container images eligibility for deployment based on Defender
    /// for Containers security findings. Using Admission Controller, it either audits or prevents the deployment of images that
    /// do not meet security standards.
    /// </summary>
    [JsonPropertyName("securityGating")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityGating? SecurityGating { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefenderSecurityMonitoring_STATUS
    /// Microsoft Defender settings for the security profile threat detection.
    /// </summary>
    [JsonPropertyName("securityMonitoring")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileImageCleaner_STATUS
/// Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here
/// are settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileImageCleaner
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileImageIntegrity_STATUS
/// Image integrity related settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileImageIntegrity
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
/// Storage version of v20251002preview.KubernetesResourceObjectEncryptionProfile_STATUS
/// Encryption at rest of Kubernetes resource objects using service-managed keys. More information on this can be found
/// under https://aka.ms/aks/kubernetesResourceObjectEncryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileKubernetesResourceObjectEncryptionProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("infrastructureEncryption")]
    public string? InfrastructureEncryption { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSecurityProfileNodeRestriction_STATUS
/// Node Restriction settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileNodeRestriction
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfileWorkloadIdentity_STATUS
/// Workload identity settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfileWorkloadIdentity
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
/// Storage version of v20251002preview.ManagedClusterSecurityProfile_STATUS
/// Security profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.AzureKeyVaultKms_STATUS
    /// Azure Key Vault key management service settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileDefender_STATUS
    /// Microsoft Defender settings for the security profile.
    /// </summary>
    [JsonPropertyName("defender")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileDefender? Defender { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileImageCleaner_STATUS
    /// Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here
    /// are settings for the security profile.
    /// </summary>
    [JsonPropertyName("imageCleaner")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileImageIntegrity_STATUS
    /// Image integrity related settings for the security profile.
    /// </summary>
    [JsonPropertyName("imageIntegrity")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileImageIntegrity? ImageIntegrity { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.KubernetesResourceObjectEncryptionProfile_STATUS
    /// Encryption at rest of Kubernetes resource objects using service-managed keys. More information on this can be found
    /// under https://aka.ms/aks/kubernetesResourceObjectEncryption.
    /// </summary>
    [JsonPropertyName("kubernetesResourceObjectEncryptionProfile")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileKubernetesResourceObjectEncryptionProfile? KubernetesResourceObjectEncryptionProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileNodeRestriction_STATUS
    /// Node Restriction settings for the security profile.
    /// </summary>
    [JsonPropertyName("nodeRestriction")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileNodeRestriction? NodeRestriction { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfileWorkloadIdentity_STATUS
    /// Workload identity settings for the security profile.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V20251002previewstorageManagedClusterStatusSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioPluginCertificateAuthority_STATUS
/// Plugin certificates information for Service Mesh.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioCertificateAuthority_STATUS
/// Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described
/// here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioPluginCertificateAuthority_STATUS
    /// Plugin certificates information for Service Mesh.
    /// </summary>
    [JsonPropertyName("plugin")]
    public V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioEgressGateway_STATUS
/// Istio egress gateway configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("gatewayConfigurationName")]
    public string? GatewayConfigurationName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioIngressGateway_STATUS
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioComponents_STATUS
/// Istio components configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponents
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("egressGateways")]
    public IList<V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    [JsonPropertyName("ingressGateways")]
    public IList<V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }

    [JsonPropertyName("proxyRedirectionMechanism")]
    public string? ProxyRedirectionMechanism { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.IstioServiceMesh_STATUS
/// Istio service mesh configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfileIstio
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioCertificateAuthority_STATUS
    /// Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described
    /// here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioComponents_STATUS
    /// Istio components configuration.
    /// </summary>
    [JsonPropertyName("components")]
    public V20251002previewstorageManagedClusterStatusServiceMeshProfileIstioComponents? Components { get; set; }

    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ServiceMeshProfile_STATUS
/// Service mesh profile for a managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServiceMeshProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.IstioServiceMesh_STATUS
    /// Istio service mesh configuration.
    /// </summary>
    [JsonPropertyName("istio")]
    public V20251002previewstorageManagedClusterStatusServiceMeshProfileIstio? Istio { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterServicePrincipalProfile_STATUS
/// Information about a service principal identity for the cluster to use for manipulating Azure APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusServicePrincipalProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterSKU_STATUS
/// The SKU of a Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStatusProvisioningErrorAdditionalInfo
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStatusProvisioningErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStatusProvisioningError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewstorageManagedClusterStatusStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V20251002previewstorageManagedClusterStatusStatusProvisioningErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStatus_STATUS
/// Contains read-only information about the Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStatus
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
    public V20251002previewstorageManagedClusterStatusStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStorageProfileBlobCSIDriver_STATUS
/// AzureBlob CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStorageProfileBlobCSIDriver
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
/// Storage version of v20251002preview.ManagedClusterStorageProfileDiskCSIDriver_STATUS
/// AzureDisk CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStorageProfileDiskCSIDriver
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterStorageProfileFileCSIDriver_STATUS
/// AzureFile CSI Driver settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStorageProfileFileCSIDriver
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
/// Storage version of v20251002preview.ManagedClusterStorageProfileSnapshotController_STATUS
/// Snapshot Controller settings for the storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStorageProfileSnapshotController
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
/// Storage version of v20251002preview.ManagedClusterStorageProfile_STATUS
/// Storage profile for the container service cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileBlobCSIDriver_STATUS
    /// AzureBlob CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("blobCSIDriver")]
    public V20251002previewstorageManagedClusterStatusStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileDiskCSIDriver_STATUS
    /// AzureDisk CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("diskCSIDriver")]
    public V20251002previewstorageManagedClusterStatusStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileFileCSIDriver_STATUS
    /// AzureFile CSI Driver settings for the storage profile.
    /// </summary>
    [JsonPropertyName("fileCSIDriver")]
    public V20251002previewstorageManagedClusterStatusStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfileSnapshotController_STATUS
    /// Snapshot Controller settings for the storage profile.
    /// </summary>
    [JsonPropertyName("snapshotController")]
    public V20251002previewstorageManagedClusterStatusStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusSystemData
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
/// Storage version of v20251002preview.UpgradeOverrideSettings_STATUS
/// Settings for overrides when upgrading a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusUpgradeSettingsOverrideSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ClusterUpgradeSettings_STATUS
/// Settings for upgrading a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusUpgradeSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.UpgradeOverrideSettings_STATUS
    /// Settings for overrides when upgrading a cluster.
    /// </summary>
    [JsonPropertyName("overrideSettings")]
    public V20251002previewstorageManagedClusterStatusUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.WindowsGmsaProfile_STATUS
/// Windows gMSA Profile in the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusWindowsProfileGmsaProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWindowsProfile_STATUS
/// Profile for Windows VMs in the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusWindowsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.WindowsGmsaProfile_STATUS
    /// Windows gMSA Profile in the managed cluster.
    /// </summary>
    [JsonPropertyName("gmsaProfile")]
    public V20251002previewstorageManagedClusterStatusWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileKeda_STATUS
/// KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfileKeda
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
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler_STATUS
/// VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addonAutoscaling")]
    public string? AddonAutoscaling { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfile_STATUS
/// Workload Auto-scaler profile for the managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileKeda_STATUS
    /// KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.
    /// </summary>
    [JsonPropertyName("keda")]
    public V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler_STATUS
    /// VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.
    /// </summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedCluster_STATUS
/// Managed cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewstorageManagedClusterStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAADProfile_STATUS
    /// AADProfile specifies attributes for Azure Active Directory integration. For more details see [managed AAD on
    /// AKS](https://docs.microsoft.com/azure/aks/managed-aad).
    /// </summary>
    [JsonPropertyName("aadProfile")]
    public V20251002previewstorageManagedClusterStatusAadProfile? AadProfile { get; set; }

    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusAddonProfiles>? AddonProfiles { get; set; }

    [JsonPropertyName("agentPoolProfiles")]
    public IList<V20251002previewstorageManagedClusterStatusAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAIToolchainOperatorProfile_STATUS
    /// When enabling the operator, a set of AKS managed CRDs and controllers will be installed in the cluster. The operator
    /// automates the deployment of OSS models for inference and/or training purposes. It provides a set of preset models and
    /// enables distributed inference against them.
    /// </summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V20251002previewstorageManagedClusterStatusAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAPIServerAccessProfile_STATUS
    /// Access profile for managed cluster API server.
    /// </summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V20251002previewstorageManagedClusterStatusApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPropertiesAutoScalerProfile_STATUS
    /// Parameters to be applied to the cluster-autoscaler when enabled
    /// </summary>
    [JsonPropertyName("autoScalerProfile")]
    public V20251002previewstorageManagedClusterStatusAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAutoUpgradeProfile_STATUS
    /// Auto upgrade profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V20251002previewstorageManagedClusterStatusAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterAzureMonitorProfile_STATUS
    /// Azure Monitor addon profiles for monitoring the managed cluster.
    /// </summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V20251002previewstorageManagedClusterStatusAzureMonitorProfile? AzureMonitorProfile { get; set; }

    [JsonPropertyName("azurePortalFQDN")]
    public string? AzurePortalFQDN { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterBootstrapProfile_STATUS
    /// The bootstrap profile.
    /// </summary>
    [JsonPropertyName("bootstrapProfile")]
    public V20251002previewstorageManagedClusterStatusBootstrapProfile? BootstrapProfile { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20251002previewstorageManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.CreationData_STATUS
    /// Data used when creating a target resource from a source resource.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V20251002previewstorageManagedClusterStatusCreationData? CreationData { get; set; }

    [JsonPropertyName("currentKubernetesVersion")]
    public string? CurrentKubernetesVersion { get; set; }

    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    [JsonPropertyName("diskEncryptionSetID")]
    public string? DiskEncryptionSetID { get; set; }

    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("enableNamespaceResources")]
    public bool? EnableNamespaceResources { get; set; }

    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20251002previewstorageManagedClusterStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterHostedSystemProfile_STATUS
    /// Settings for hosted system addons.
    /// </summary>
    [JsonPropertyName("hostedSystemProfile")]
    public V20251002previewstorageManagedClusterStatusHostedSystemProfile? HostedSystemProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterHTTPProxyConfig_STATUS
    /// Cluster HTTP proxy configuration.
    /// </summary>
    [JsonPropertyName("httpProxyConfig")]
    public V20251002previewstorageManagedClusterStatusHttpProxyConfig? HttpProxyConfig { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIdentity_STATUS
    /// Identity for the managed cluster.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20251002previewstorageManagedClusterStatusIdentity? Identity { get; set; }

    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V20251002previewstorageManagedClusterStatusIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterIngressProfile_STATUS
    /// Ingress profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("ingressProfile")]
    public V20251002previewstorageManagedClusterStatusIngressProfile? IngressProfile { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceLinuxProfile_STATUS
    /// Profile for Linux VMs in the container service cluster.
    /// </summary>
    [JsonPropertyName("linuxProfile")]
    public V20251002previewstorageManagedClusterStatusLinuxProfile? LinuxProfile { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("maxAgentPools")]
    public int? MaxAgentPools { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterMetricsProfile_STATUS
    /// The metrics profile for the ManagedCluster.
    /// </summary>
    [JsonPropertyName("metricsProfile")]
    public V20251002previewstorageManagedClusterStatusMetricsProfile? MetricsProfile { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ContainerServiceNetworkProfile_STATUS
    /// Profile of network configuration.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewstorageManagedClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedClusterNodeProvisioningProfile_STATUS</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V20251002previewstorageManagedClusterStatusNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterNodeResourceGroupProfile_STATUS
    /// Node resource group lockdown profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V20251002previewstorageManagedClusterStatusNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterOIDCIssuerProfile_STATUS
    /// The OIDC issuer profile of the Managed Cluster.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V20251002previewstorageManagedClusterStatusOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterPodIdentityProfile_STATUS
    /// The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V20251002previewstorageManagedClusterStatusPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.PowerState_STATUS
    /// Describes the Power State of the cluster
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewstorageManagedClusterStatusPowerState? PowerState { get; set; }

    [JsonPropertyName("privateFQDN")]
    public string? PrivateFQDN { get; set; }

    [JsonPropertyName("privateLinkResources")]
    public IList<V20251002previewstorageManagedClusterStatusPrivateLinkResources>? PrivateLinkResources { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("resourceUID")]
    public string? ResourceUID { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SchedulerProfile_STATUS
    /// The pod scheduler profile for the cluster.
    /// </summary>
    [JsonPropertyName("schedulerProfile")]
    public V20251002previewstorageManagedClusterStatusSchedulerProfile? SchedulerProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSecurityProfile_STATUS
    /// Security profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewstorageManagedClusterStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ServiceMeshProfile_STATUS
    /// Service mesh profile for a managed cluster.
    /// </summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V20251002previewstorageManagedClusterStatusServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterServicePrincipalProfile_STATUS
    /// Information about a service principal identity for the cluster to use for manipulating Azure APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V20251002previewstorageManagedClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterSKU_STATUS
    /// The SKU of a Managed Cluster.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20251002previewstorageManagedClusterStatusSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStatus_STATUS
    /// Contains read-only information about the Managed Cluster.
    /// </summary>
    [JsonPropertyName("status")]
    public V20251002previewstorageManagedClusterStatusStatus? Status { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterStorageProfile_STATUS
    /// Storage profile for the container service cluster.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V20251002previewstorageManagedClusterStatusStorageProfile? StorageProfile { get; set; }

    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20251002previewstorageManagedClusterStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ClusterUpgradeSettings_STATUS
    /// Settings for upgrading a cluster.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewstorageManagedClusterStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWindowsProfile_STATUS
    /// Profile for Windows VMs in the managed cluster.
    /// </summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewstorageManagedClusterStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedClusterWorkloadAutoScalerProfile_STATUS
    /// Workload Auto-scaler profile for the managed cluster.
    /// </summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V20251002previewstorageManagedClusterStatusWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>
/// Storage version of v20251002preview.ManagedCluster
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewstorageManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V20251002previewstorageManagedClusterSpec?>, IStatus<V20251002previewstorageManagedClusterStatus?>
{
    public const string KubeApiVersion = "v20251002previewstorage";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20251002preview.ManagedCluster_Spec</summary>
    [JsonPropertyName("spec")]
    public V20251002previewstorageManagedClusterSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20251002preview.ManagedCluster_STATUS
    /// Managed cluster.
    /// </summary>
    [JsonPropertyName("status")]
    public V20251002previewstorageManagedClusterStatus? Status { get; set; }
}