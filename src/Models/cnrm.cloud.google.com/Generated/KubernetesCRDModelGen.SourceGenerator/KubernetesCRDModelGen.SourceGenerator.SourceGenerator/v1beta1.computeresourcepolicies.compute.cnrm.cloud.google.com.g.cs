#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeResourcePolicy is the Schema for the ComputeResourcePolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeResourcePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeResourcePolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeResourcePolicyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeresourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeResourcePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeResourcePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeResourcePolicy> Items { get; set; }
}

/// <summary>Immutable. Replication consistency group for asynchronous disk replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecDiskConsistencyGroupPolicy
{
    /// <summary>Immutable. Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Immutable. Resource policy for instances used for placement configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecGroupPlacementPolicy
{
    /// <summary>Immutable. The number of availability domains instances will be spread across. If two instances are in different availability domain, they will not be put in the same low latency network.</summary>
    [JsonPropertyName("availabilityDomainCount")]
    public int? AvailabilityDomainCount { get; set; }

    /// <summary>Immutable. Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network. Specify &apos;COLLOCATED&apos; to enable collocation. Can only be specified with &apos;vm_count&apos;. If compute instances are created with a COLLOCATED policy, then exactly &apos;vm_count&apos; instances must be created at the same time with the resource policy attached. Possible values: [&quot;COLLOCATED&quot;].</summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Immutable. Specifies the number of max logical switches.</summary>
    [JsonPropertyName("maxDistance")]
    public int? MaxDistance { get; set; }

    /// <summary>Immutable. Number of VMs in this placement group. Google does not recommend that you use this field unless you use a compact policy and you want your policy to work only if it contains this exact number of VMs.</summary>
    [JsonPropertyName("vmCount")]
    public int? VmCount { get; set; }
}

/// <summary>Immutable. Specifies the schedule for starting instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Immutable. Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }
}

/// <summary>Immutable. Specifies the schedule for stopping instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Immutable. Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }
}

/// <summary>Immutable. Resource policy for scheduling instance operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecInstanceSchedulePolicy
{
    /// <summary>Immutable. The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>Immutable. The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Immutable. Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }

    /// <summary>Immutable. Specifies the schedule for starting instances.</summary>
    [JsonPropertyName("vmStartSchedule")]
    public V1beta1ComputeResourcePolicySpecInstanceSchedulePolicyVmStartSchedule? VmStartSchedule { get; set; }

    /// <summary>Immutable. Specifies the schedule for stopping instances.</summary>
    [JsonPropertyName("vmStopSchedule")]
    public V1beta1ComputeResourcePolicySpecInstanceSchedulePolicyVmStopSchedule? VmStopSchedule { get; set; }
}

/// <summary>Immutable. Retention policy applied to snapshots created by this resource policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Immutable. Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public required int MaxRetentionDays { get; set; }

    /// <summary>Immutable. Specifies the behavior to apply to scheduled snapshots when the source disk is deleted. Default value: &quot;KEEP_AUTO_SNAPSHOTS&quot; Possible values: [&quot;KEEP_AUTO_SNAPSHOTS&quot;, &quot;APPLY_RETENTION_POLICY&quot;].</summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}

/// <summary>Immutable. The policy will execute every nth day at the specified time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Immutable. Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public required int DaysInCycle { get; set; }

    /// <summary>Immutable. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.</summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }
}

/// <summary>Immutable. The policy will execute every nth hour starting at the specified time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>Immutable. The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public required int HoursInCycle { get; set; }

    /// <summary>Immutable. Time within the window to start the operations. It must be in an hourly format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00] GMT. eg: 21:00.</summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>Immutable. The day of the week to create the snapshot. e.g. MONDAY Possible values: [&quot;MONDAY&quot;, &quot;TUESDAY&quot;, &quot;WEDNESDAY&quot;, &quot;THURSDAY&quot;, &quot;FRIDAY&quot;, &quot;SATURDAY&quot;, &quot;SUNDAY&quot;].</summary>
    [JsonPropertyName("day")]
    public required string Day { get; set; }

    /// <summary>Immutable. Time within the window to start the operations. It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }
}

/// <summary>Immutable. Allows specifying a snapshot time for each day of the week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>Immutable. May contain up to seven (one for each day of the week) snapshot times.</summary>
    [JsonPropertyName("dayOfWeeks")]
    public required IList<V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks> DayOfWeeks { get; set; }
}

/// <summary>Immutable. Contains one of an &apos;hourlySchedule&apos;, &apos;dailySchedule&apos;, or &apos;weeklySchedule&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicySchedule
{
    /// <summary>Immutable. The policy will execute every nth day at the specified time.</summary>
    [JsonPropertyName("dailySchedule")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleDailySchedule? DailySchedule { get; set; }

    /// <summary>Immutable. The policy will execute every nth hour starting at the specified time.</summary>
    [JsonPropertyName("hourlySchedule")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleHourlySchedule? HourlySchedule { get; set; }

    /// <summary>Immutable. Allows specifying a snapshot time for each day of the week.</summary>
    [JsonPropertyName("weeklySchedule")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyScheduleWeeklySchedule? WeeklySchedule { get; set; }
}

/// <summary>Immutable. Properties with which the snapshots are created, such as labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>Immutable. Chain name that the snapshot is created in.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Immutable. Whether to perform a &apos;guest aware&apos; snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>Immutable. A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. Cloud Storage bucket location to store the auto snapshot (regional or multi-regional).</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary>Immutable. Policy for creating snapshots of persistent disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicy
{
    /// <summary>Immutable. Retention policy applied to snapshots created by this resource policy.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicyRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>Immutable. Contains one of an &apos;hourlySchedule&apos;, &apos;dailySchedule&apos;, or &apos;weeklySchedule&apos;.</summary>
    [JsonPropertyName("schedule")]
    public required V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicySchedule Schedule { get; set; }

    /// <summary>Immutable. Properties with which the snapshots are created, such as labels.</summary>
    [JsonPropertyName("snapshotProperties")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicySnapshotProperties? SnapshotProperties { get; set; }
}

/// <summary>ComputeResourcePolicySpec defines the desired state of ComputeResourcePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicySpec
{
    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Replication consistency group for asynchronous disk replication.</summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public V1beta1ComputeResourcePolicySpecDiskConsistencyGroupPolicy? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>Immutable. Resource policy for instances used for placement configuration.</summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public V1beta1ComputeResourcePolicySpecGroupPlacementPolicy? GroupPlacementPolicy { get; set; }

    /// <summary>Immutable. Resource policy for scheduling instance operations.</summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public V1beta1ComputeResourcePolicySpecInstanceSchedulePolicy? InstanceSchedulePolicy { get; set; }

    /// <summary>Immutable. Region where resource policy resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Policy for creating snapshots of persistent disks.</summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public V1beta1ComputeResourcePolicySpecSnapshotSchedulePolicy? SnapshotSchedulePolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicyStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicyStatusObservedState
{
    /// <summary>[Output Only] Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>[Output Only] The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>[Output Only] The status of resource policy creation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ComputeResourcePolicyStatus defines the config connector machine state of ComputeResourcePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeResourcePolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeResourcePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComputeResourcePolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ComputeResourcePolicyStatusObservedState? ObservedState { get; set; }

    /// <summary>The server-defined URL of this resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeResourcePolicy is the Schema for the ComputeResourcePolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeResourcePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeResourcePolicySpec>, IStatus<V1beta1ComputeResourcePolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeResourcePolicy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeresourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeResourcePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeResourcePolicySpec defines the desired state of ComputeResourcePolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeResourcePolicySpec Spec { get; set; }

    /// <summary>ComputeResourcePolicyStatus defines the config connector machine state of ComputeResourcePolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeResourcePolicyStatus? Status { get; set; }
}