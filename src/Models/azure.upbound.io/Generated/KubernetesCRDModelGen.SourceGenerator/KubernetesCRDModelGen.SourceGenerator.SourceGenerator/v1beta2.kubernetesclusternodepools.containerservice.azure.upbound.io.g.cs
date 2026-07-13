#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.upbound.io;
/// <summary>KubernetesClusterNodePool is the Schema for the KubernetesClusterNodePools API. Manages a Node Pool within a Kubernetes Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2KubernetesClusterNodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2KubernetesClusterNodePool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "KubernetesClusterNodePoolList";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusternodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubernetesClusterNodePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2KubernetesClusterNodePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2KubernetesClusterNodePool> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecDeletionPolicyEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelector
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
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A sysctl_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled?</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderLinuxOsConfigSysctlConfig? SysctlConfig { get; set; }

    /// <summary>Specifies the Transparent Huge Page configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePage")]
    public string? TransparentHugePage { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A node_network_profile block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta2KubernetesClusterNodePoolSpecForProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelector
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
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A upgrade_settings block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The maximum number or percentage of nodes which can be unavailable during the upgrade.</summary>
    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }

    /// <summary>Specifies the action when a node is undrainable during upgrade. Possible values are Cordon and Schedule. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelector
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
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecForProvider
{
    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies whether to install the GPU Driver for the nodes. Possible values are Install and None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuDriver")]
    public string? GpuDriver { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>The ID of the Kubernetes Cluster where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdRef")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRef? KubernetesClusterIdRef { get; set; }

    /// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdSelector")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelector? KubernetesClusterIdSelector { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderLinuxOsConfig? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderNodeNetworkProfile? NodeNetworkProfile { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won&apos;t auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version&apos;s latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, AzureLinux3, Ubuntu, Ubuntu2204, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise it forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the node pool when one of the relevant properties are updated.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1beta2KubernetesClusterNodePoolSpecForProviderWindowsProfile? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer and WasmWasi.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>A sysctl_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled?</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderLinuxOsConfigSysctlConfig? SysctlConfig { get; set; }

    /// <summary>Specifies the Transparent Huge Page configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePage")]
    public string? TransparentHugePage { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A node_network_profile block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta2KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelector
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
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A upgrade_settings block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The maximum number or percentage of nodes which can be unavailable during the upgrade.</summary>
    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }

    /// <summary>Specifies the action when a node is undrainable during upgrade. Possible values are Cordon and Schedule. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelector
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
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecInitProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
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
public partial class V1beta2KubernetesClusterNodePoolSpecInitProvider
{
    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies whether to install the GPU Driver for the nodes. Possible values are Install and None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuDriver")]
    public string? GpuDriver { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderLinuxOsConfig? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfile? NodeNetworkProfile { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won&apos;t auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version&apos;s latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, AzureLinux3, Ubuntu, Ubuntu2204, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise it forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the node pool when one of the relevant properties are updated.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1beta2KubernetesClusterNodePoolSpecInitProviderWindowsProfile? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer and WasmWasi.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecManagementPoliciesEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2KubernetesClusterNodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>KubernetesClusterNodePoolSpec defines the desired state of KubernetesClusterNodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolSpec
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
    public V1beta2KubernetesClusterNodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2KubernetesClusterNodePoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2KubernetesClusterNodePoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2KubernetesClusterNodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2KubernetesClusterNodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2KubernetesClusterNodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>A sysctl_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled?</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderLinuxOsConfigSysctlConfig? SysctlConfig { get; set; }

    /// <summary>Specifies the Transparent Huge Page configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePage")]
    public string? TransparentHugePage { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A node_network_profile block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta2KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary>A upgrade_settings block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The maximum number or percentage of nodes which can be unavailable during the upgrade.</summary>
    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }

    /// <summary>Specifies the action when a node is undrainable during upgrade. Possible values are Cordon and Schedule. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusAtProvider
{
    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies whether to install the GPU Driver for the nodes. Possible values are Install and None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuDriver")]
    public string? GpuDriver { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>The ID of the Kubernetes Cluster Node Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>The ID of the Kubernetes Cluster where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderLinuxOsConfig? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfile? NodeNetworkProfile { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won&apos;t auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version&apos;s latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, AzureLinux3, Ubuntu, Ubuntu2204, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise it forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the node pool when one of the relevant properties are updated.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1beta2KubernetesClusterNodePoolStatusAtProviderWindowsProfile? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer and WasmWasi.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this property requires specifying temporary_name_for_rotation.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatusConditions
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

/// <summary>KubernetesClusterNodePoolStatus defines the observed state of KubernetesClusterNodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2KubernetesClusterNodePoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2KubernetesClusterNodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2KubernetesClusterNodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KubernetesClusterNodePool is the Schema for the KubernetesClusterNodePools API. Manages a Node Pool within a Kubernetes Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2KubernetesClusterNodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2KubernetesClusterNodePoolSpec>, IStatus<V1beta2KubernetesClusterNodePoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "KubernetesClusterNodePool";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusternodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubernetesClusterNodePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KubernetesClusterNodePoolSpec defines the desired state of KubernetesClusterNodePool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2KubernetesClusterNodePoolSpec Spec { get; set; }

    /// <summary>KubernetesClusterNodePoolStatus defines the observed state of KubernetesClusterNodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta2KubernetesClusterNodePoolStatus? Status { get; set; }
}