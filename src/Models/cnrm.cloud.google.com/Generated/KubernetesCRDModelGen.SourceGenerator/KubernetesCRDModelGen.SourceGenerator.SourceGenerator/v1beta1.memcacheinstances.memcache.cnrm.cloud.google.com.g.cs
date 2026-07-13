#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memcache.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MemcacheInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MemcacheInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MemcacheInstanceList";
    public const string KubeGroup = "memcache.cnrm.cloud.google.com";
    public const string KubePluralName = "memcacheinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memcache.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemcacheInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MemcacheInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MemcacheInstance> Items { get; set; }
}

/// <summary>Required. Start time of the window in UTC time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>
    /// Required. The day of week that maintenance updates occur.
    /// - DAY_OF_WEEK_UNSPECIFIED: The day of the week is unspecified.
    /// - MONDAY: Monday
    /// - TUESDAY: Tuesday
    /// - WEDNESDAY: Wednesday
    /// - THURSDAY: Thursday
    /// - FRIDAY: Friday
    /// - SATURDAY: Saturday
    /// - SUNDAY: Sunday Possible values: [&quot;DAY_OF_WEEK_UNSPECIFIED&quot;, &quot;MONDAY&quot;, &quot;TUESDAY&quot;, &quot;WEDNESDAY&quot;, &quot;THURSDAY&quot;, &quot;FRIDAY&quot;, &quot;SATURDAY&quot;, &quot;SUNDAY&quot;].
    /// </summary>
    [JsonPropertyName("day")]
    public required string Day { get; set; }

    /// <summary>
    /// Required. The length of the maintenance window, ranging from 3 hours to 8 hours.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    /// <summary>Required. Start time of the window in UTC time.</summary>
    [JsonPropertyName("startTime")]
    public required V1beta1MemcacheInstanceSpecMaintenancePolicyWeeklyMaintenanceWindowStartTime StartTime { get; set; }
}

/// <summary>Maintenance policy for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecMaintenancePolicy
{
    /// <summary>
    /// Output only. The time when the policy was created.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Output only. The time when the policy was updated.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Required. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number of weekly_maintenance_windows
    /// is expected to be one.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public required IList<V1beta1MemcacheInstanceSpecMaintenancePolicyWeeklyMaintenanceWindow> WeeklyMaintenanceWindow { get; set; }
}

/// <summary>Immutable. User-specified parameters for this memcache instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecMemcacheParameters
{
    /// <summary>This is a unique ID associated with this set of parameters.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>User-defined set of parameters to use in the memcache process.</summary>
    [JsonPropertyName("params")]
    public IDictionary<string, string>? Params { get; set; }
}

/// <summary>The full name of the network to connect the instance to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecNetworkRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/global/networks/{{value}}`, where {{value}} is the `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Configuration for memcache nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpecNodeConfig
{
    /// <summary>Number of CPUs per node.</summary>
    [JsonPropertyName("cpuCount")]
    public required int CpuCount { get; set; }

    /// <summary>Memory size in Mebibytes for each memcache node.</summary>
    [JsonPropertyName("memorySizeMb")]
    public required int MemorySizeMb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceSpec
{
    /// <summary>A user-visible name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Maintenance policy for an instance.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1MemcacheInstanceSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Immutable. User-specified parameters for this memcache instance.</summary>
    [JsonPropertyName("memcacheParameters")]
    public V1beta1MemcacheInstanceSpecMemcacheParameters? MemcacheParameters { get; set; }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &quot;MEMCACHE_1_5&quot; Possible values: [&quot;MEMCACHE_1_5&quot;].
    /// </summary>
    [JsonPropertyName("memcacheVersion")]
    public string? MemcacheVersion { get; set; }

    /// <summary>The full name of the network to connect the instance to.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1MemcacheInstanceSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. Configuration for memcache nodes.</summary>
    [JsonPropertyName("nodeConfig")]
    public required V1beta1MemcacheInstanceSpecNodeConfig NodeConfig { get; set; }

    /// <summary>Number of nodes in the memcache instance.</summary>
    [JsonPropertyName("nodeCount")]
    public required int NodeCount { get; set; }

    /// <summary>Immutable. The region of the Memcache instance. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Immutable. Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceStatusMaintenanceSchedule
{
    /// <summary>
    /// Output only. The end time of any upcoming scheduled maintenance for this instance.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Output only. The deadline that the maintenance schedule start time
    /// can not go beyond, including reschedule.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>
    /// Output only. The start time of any upcoming scheduled maintenance for this instance.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceStatusMemcacheNodes
{
    /// <summary>Hostname or IP address of the Memcached node used by the clients to connect to the Memcached server on this node.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Identifier of the Memcached node. The node id does not include project or location like the Memcached instance name.</summary>
    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

    /// <summary>The port number of the Memcached server on this node.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Current state of the Memcached node.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Location (GCP Zone) for the Memcached node.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemcacheInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MemcacheInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Endpoint for Discovery API.</summary>
    [JsonPropertyName("discoveryEndpoint")]
    public string? DiscoveryEndpoint { get; set; }

    /// <summary>Output only. Published maintenance schedule.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1MemcacheInstanceStatusMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>The full version of memcached server running on this instance.</summary>
    [JsonPropertyName("memcacheFullVersion")]
    public string? MemcacheFullVersion { get; set; }

    /// <summary>Additional information about the instance state, if available.</summary>
    [JsonPropertyName("memcacheNodes")]
    public IList<V1beta1MemcacheInstanceStatusMemcacheNodes>? MemcacheNodes { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MemcacheInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MemcacheInstanceSpec>, IStatus<V1beta1MemcacheInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MemcacheInstance";
    public const string KubeGroup = "memcache.cnrm.cloud.google.com";
    public const string KubePluralName = "memcacheinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memcache.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemcacheInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1MemcacheInstanceSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1MemcacheInstanceStatus? Status { get; set; }
}