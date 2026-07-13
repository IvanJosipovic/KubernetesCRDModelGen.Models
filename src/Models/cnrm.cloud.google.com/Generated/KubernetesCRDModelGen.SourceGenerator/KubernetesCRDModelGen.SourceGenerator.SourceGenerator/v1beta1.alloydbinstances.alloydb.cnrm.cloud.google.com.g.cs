#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
/// <summary>AlloyDBInstance is the Schema for the AlloyDBInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlloyDBInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AlloyDBInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlloyDBInstanceList";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlloyDBInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AlloyDBInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AlloyDBInstance> Items { get; set; }
}

/// <summary>The AlloyDBInstance cluster that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecClusterRef
{
    /// <summary>If provided must be in the format `projects/[projectId]/locations/[location]/clusters/[clusterId]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for Managed Connection Pool (MCP).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecConnectionPoolConfig
{
    /// <summary>Optional. Whether to enable Managed Connection Pool (MCP).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. Connection Pool flags, as a list of &quot;key&quot;: &quot;value&quot; pairs.</summary>
    [JsonPropertyName("flags")]
    public IDictionary<string, string>? Flags { get; set; }
}

/// <summary>
/// The type of instance.
/// Possible values: [&quot;PRIMARY&quot;, &quot;READ_POOL&quot;, &quot;SECONDARY&quot;]
/// 
/// For PRIMARY and SECONDARY instances, set the value to refer to the name of the associated cluster.
/// This is recommended because the instance type of primary and secondary instances is tied to the cluster type of the associated cluster.
/// If the secondary cluster is promoted to primary cluster, then the associated secondary instance also becomes primary instance.
/// Example:
/// instanceTypeRef:
///   name: clusterName
/// For instances of type READ_POOL, set the value using external keyword.
/// Example:
/// instanceTypeRef:
///   external: READ_POOL
/// If the instance type is SECONDARY, the delete instance operation does not delete the secondary instance but abandons it instead.
/// Use deletionPolicy = &quot;FORCE&quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecInstanceTypeRef
{
    /// <summary>The type of instance. Possible values: [&quot;PRIMARY&quot;, &quot;READ_POOL&quot;, &quot;SECONDARY&quot;]</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configurations for the machines that host the underlying database engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecMachineConfig
{
    /// <summary>The number of CPU&apos;s in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public int? CpuCount { get; set; }

    /// <summary>Machine type of the VM instance. E.g. &quot;n2-highmem-4&quot;, &quot;n2-highmem-8&quot;, &quot;c4a-highmem-4-lssd&quot;. cpu_count must match the number of vCPUs in the machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorzied network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}

/// <summary>Instance level network configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecNetworkConfig
{
    /// <summary>Optional. A list of external network authorized to access this instance. This field is only allowed to be set when &apos;enablePublicIp&apos; is set to true.</summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta1AlloyDBInstanceSpecNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Optional. Enabling an outbound public IP address to support a database server sending requests out into the internet.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>Optional. Enabling public ip for the instance. If a user wishes to disable this, please also clear the list of the authorized external networks set on the same instance.</summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecObservabilityConfig
{
    /// <summary>Whether assistive experiences are enabled for this AlloyDB instance.</summary>
    [JsonPropertyName("assistiveExperiencesEnabled")]
    public bool? AssistiveExperiencesEnabled { get; set; }

    /// <summary>Observability feature status for an instance. This flag is turned &quot;off&quot; by default.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Query string length. The default value is 10k.</summary>
    [JsonPropertyName("maxQueryStringLength")]
    public int? MaxQueryStringLength { get; set; }

    /// <summary>Preserve comments in query string for an instance. This flag is turned &quot;off&quot; by default.</summary>
    [JsonPropertyName("preserveComments")]
    public bool? PreserveComments { get; set; }

    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 200. Any integer between 0 to 200 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public int? QueryPlansPerMinute { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned &quot;off&quot; by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Track actively running queries on the instance. If not set, this flag is &quot;off&quot; by default.</summary>
    [JsonPropertyName("trackActiveQueries")]
    public bool? TrackActiveQueries { get; set; }

    /// <summary>Track client address for an instance. If not set, default value is &quot;off&quot;.</summary>
    [JsonPropertyName("trackClientAddress")]
    public bool? TrackClientAddress { get; set; }

    /// <summary>Track wait events during query execution for an instance. This flag is turned &quot;on&quot; by default but tracking is enabled only after observability enabled flag is also turned on.</summary>
    [JsonPropertyName("trackWaitEvents")]
    public bool? TrackWaitEvents { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public int? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public int? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned &quot;on&quot; by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpecReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }
}

/// <summary>AlloyDBInstanceSpec defines the desired state of AlloyDBInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceSpec
{
    /// <summary>Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Availability type of an Instance. If empty, defaults to REGIONAL for primary instances.
    /// 
    /// For read pools, availabilityType is always UNSPECIFIED. Instances in the
    /// read pools are evenly distributed across available zones within the region
    /// (i.e. read pools with more than one node will have a node in at least two zones).
    /// Possible values: [&quot;AVAILABILITY_TYPE_UNSPECIFIED&quot;, &quot;ZONAL&quot;, &quot;REGIONAL&quot;].
    /// </summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>The AlloyDBInstance cluster that this resource belongs to.</summary>
    [JsonPropertyName("clusterRef")]
    public required V1beta1AlloyDBInstanceSpecClusterRef ClusterRef { get; set; }

    /// <summary>Configuration for Managed Connection Pool (MCP).</summary>
    [JsonPropertyName("connectionPoolConfig")]
    public V1beta1AlloyDBInstanceSpecConnectionPoolConfig? ConnectionPoolConfig { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>Not recommended. We recommend that you use `instanceTypeRef` instead. The type of the instance. Possible values: [PRIMARY, READ_POOL, SECONDARY]</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// The type of instance.
    /// Possible values: [&quot;PRIMARY&quot;, &quot;READ_POOL&quot;, &quot;SECONDARY&quot;]
    /// 
    /// For PRIMARY and SECONDARY instances, set the value to refer to the name of the associated cluster.
    /// This is recommended because the instance type of primary and secondary instances is tied to the cluster type of the associated cluster.
    /// If the secondary cluster is promoted to primary cluster, then the associated secondary instance also becomes primary instance.
    /// Example:
    /// instanceTypeRef:
    ///   name: clusterName
    /// For instances of type READ_POOL, set the value using external keyword.
    /// Example:
    /// instanceTypeRef:
    ///   external: READ_POOL
    /// If the instance type is SECONDARY, the delete instance operation does not delete the secondary instance but abandons it instead.
    /// Use deletionPolicy = &quot;FORCE&quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// </summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1beta1AlloyDBInstanceSpecInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Configurations for the machines that host the underlying database engine.</summary>
    [JsonPropertyName("machineConfig")]
    public V1beta1AlloyDBInstanceSpecMachineConfig? MachineConfig { get; set; }

    /// <summary>Instance level network configuration.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1AlloyDBInstanceSpecNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("observabilityConfig")]
    public V1beta1AlloyDBInstanceSpecObservabilityConfig? ObservabilityConfig { get; set; }

    [JsonPropertyName("queryInsightsConfig")]
    public V1beta1AlloyDBInstanceSpecQueryInsightsConfig? QueryInsightsConfig { get; set; }

    /// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.</summary>
    [JsonPropertyName("readPoolConfig")]
    public V1beta1AlloyDBInstanceSpecReadPoolConfig? ReadPoolConfig { get; set; }

    /// <summary>Optional. The instanceId of the resource. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output for Managed Connection Pool (MCP).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceStatusObservedStateConnectionPoolConfig
{
    /// <summary>Output only. The number of running poolers per instance.</summary>
    [JsonPropertyName("poolerCount")]
    public int? PoolerCount { get; set; }
}

/// <summary>Observability feature status for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceStatusObservedStateObservabilityConfig
{
    /// <summary>Output only. Track wait event types during query execution for an instance. This flag is turned &quot;on&quot; by default but tracking is enabled only after observability enabled flag is also turned on. This is read-only flag and only modifiable by internal API.</summary>
    [JsonPropertyName("trackWaitEventTypes")]
    public bool? TrackWaitEventTypes { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceStatusObservedState
{
    /// <summary>Output for Managed Connection Pool (MCP).</summary>
    [JsonPropertyName("connectionPoolConfig")]
    public V1beta1AlloyDBInstanceStatusObservedStateConnectionPoolConfig? ConnectionPoolConfig { get; set; }

    /// <summary>Observability feature status for an instance.</summary>
    [JsonPropertyName("observabilityConfig")]
    public V1beta1AlloyDBInstanceStatusObservedStateObservabilityConfig? ObservabilityConfig { get; set; }
}

/// <summary>AlloyDBInstanceStatus defines the config connector machine state of AlloyDBInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlloyDBInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlloyDBInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Time the Instance was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A unique specifier for the AlloyDBInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The IP address for the Instance. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name of the instance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1AlloyDBInstanceStatusObservedState? ObservedState { get; set; }

    /// <summary>The outbound public IP addresses for the instance. This is available ONLY when networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used for outbound connections.</summary>
    [JsonPropertyName("outboundPublicIpAddresses")]
    public IList<string>? OutboundPublicIpAddresses { get; set; }

    /// <summary>The public IP addresses for the Instance. This is available ONLY when networkConfig.enablePublicIp is set to true. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>Set to true if the current state of Instance does not match the user&apos;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the alloydb instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The system-generated UID of the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Time the Instance was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>AlloyDBInstance is the Schema for the AlloyDBInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlloyDBInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AlloyDBInstanceSpec>, IStatus<V1beta1AlloyDBInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlloyDBInstance";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alloydb.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlloyDBInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlloyDBInstanceSpec defines the desired state of AlloyDBInstance</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AlloyDBInstanceSpec Spec { get; set; }

    /// <summary>AlloyDBInstanceStatus defines the config connector machine state of AlloyDBInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1AlloyDBInstanceStatus? Status { get; set; }
}