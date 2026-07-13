#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>ResourcePolicy is the Schema for the ResourcePolicys API. A policy that can be attached to a resource to specify or schedule actions on that resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourcePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ResourcePolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourcePolicyList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "resourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ResourcePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ResourcePolicy> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicySpecDeletionPolicyEnum>))]
public enum V1beta2ResourcePolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Replication consistency group for asynchronous disk replication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resource policy for instances used for placement configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderGroupPlacementPolicy
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created
    /// with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy
    /// attached.
    /// Possible values are: COLLOCATED.
    /// </summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}

/// <summary>
/// Specifies the schedule for starting instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Specifies the schedule for stopping instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Resource policy for scheduling instance operations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Specifies the schedule for starting instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStartSchedule")]
    public V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicyVmStartSchedule? VmStartSchedule { get; set; }

    /// <summary>
    /// Specifies the schedule for stopping instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStopSchedule")]
    public V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicyVmStopSchedule? VmStopSchedule { get; set; }
}

/// <summary>
/// Retention policy applied to snapshots created by this resource policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>
    /// Specifies the behavior to apply to scheduled snapshots when
    /// the source disk is deleted.
    /// Default value is KEEP_AUTO_SNAPSHOTS.
    /// Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.
    /// </summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}

/// <summary>
/// The policy will execute every nth day at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// The policy will execute every nth hour starting at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>
    /// The day of the week to create the snapshot. e.g. MONDAY
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// Allows specifying a snapshot time for each day of the week.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>
    /// May contain up to seven (one for each day of the week) snapshot times.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}

/// <summary>
/// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicySchedule
{
    /// <summary>
    /// The policy will execute every nth day at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dailySchedule")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleDailySchedule? DailySchedule { get; set; }

    /// <summary>
    /// The policy will execute every nth hour starting at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourlySchedule")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleHourlySchedule? HourlySchedule { get; set; }

    /// <summary>
    /// Allows specifying a snapshot time for each day of the week.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklySchedule")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklySchedule? WeeklySchedule { get; set; }
}

/// <summary>
/// Properties with which the snapshots are created, such as labels.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and comply
    /// with RFC1035.
    /// </summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a &apos;guest aware&apos; snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Cloud Storage bucket location to store the auto snapshot
    /// (regional or multi-regional)
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary>
/// Policy for creating snapshots of persistent disks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicy
{
    /// <summary>
    /// Retention policy applied to snapshots created by this resource policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicyRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>
    /// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicySchedule? Schedule { get; set; }

    /// <summary>
    /// Properties with which the snapshots are created, such as labels.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotProperties")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicySnapshotProperties? SnapshotProperties { get; set; }
}

/// <summary>
/// Represents the workload policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProviderWorkloadPolicy
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set.
    /// Possible values are: BLOCK, CLUSTER, SUBBLOCK.
    /// </summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>
    /// The type of workload policy.
    /// Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecForProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public V1beta2ResourcePolicySpecForProviderDiskConsistencyGroupPolicy? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public V1beta2ResourcePolicySpecForProviderGroupPlacementPolicy? GroupPlacementPolicy { get; set; }

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public V1beta2ResourcePolicySpecForProviderInstanceSchedulePolicy? InstanceSchedulePolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where resource policy resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public V1beta2ResourcePolicySpecForProviderSnapshotSchedulePolicy? SnapshotSchedulePolicy { get; set; }

    /// <summary>
    /// Represents the workload policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workloadPolicy")]
    public V1beta2ResourcePolicySpecForProviderWorkloadPolicy? WorkloadPolicy { get; set; }
}

/// <summary>
/// Replication consistency group for asynchronous disk replication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resource policy for instances used for placement configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderGroupPlacementPolicy
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created
    /// with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy
    /// attached.
    /// Possible values are: COLLOCATED.
    /// </summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}

/// <summary>
/// Specifies the schedule for starting instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Specifies the schedule for stopping instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Resource policy for scheduling instance operations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Specifies the schedule for starting instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStartSchedule")]
    public V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStartSchedule? VmStartSchedule { get; set; }

    /// <summary>
    /// Specifies the schedule for stopping instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStopSchedule")]
    public V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStopSchedule? VmStopSchedule { get; set; }
}

/// <summary>
/// Retention policy applied to snapshots created by this resource policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>
    /// Specifies the behavior to apply to scheduled snapshots when
    /// the source disk is deleted.
    /// Default value is KEEP_AUTO_SNAPSHOTS.
    /// Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.
    /// </summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}

/// <summary>
/// The policy will execute every nth day at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// The policy will execute every nth hour starting at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>
    /// The day of the week to create the snapshot. e.g. MONDAY
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// Allows specifying a snapshot time for each day of the week.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>
    /// May contain up to seven (one for each day of the week) snapshot times.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}

/// <summary>
/// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicySchedule
{
    /// <summary>
    /// The policy will execute every nth day at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dailySchedule")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleDailySchedule? DailySchedule { get; set; }

    /// <summary>
    /// The policy will execute every nth hour starting at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourlySchedule")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleHourlySchedule? HourlySchedule { get; set; }

    /// <summary>
    /// Allows specifying a snapshot time for each day of the week.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklySchedule")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklySchedule? WeeklySchedule { get; set; }
}

/// <summary>
/// Properties with which the snapshots are created, such as labels.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and comply
    /// with RFC1035.
    /// </summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a &apos;guest aware&apos; snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Cloud Storage bucket location to store the auto snapshot
    /// (regional or multi-regional)
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary>
/// Policy for creating snapshots of persistent disks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicy
{
    /// <summary>
    /// Retention policy applied to snapshots created by this resource policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicyRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>
    /// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicySchedule? Schedule { get; set; }

    /// <summary>
    /// Properties with which the snapshots are created, such as labels.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotProperties")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicySnapshotProperties? SnapshotProperties { get; set; }
}

/// <summary>
/// Represents the workload policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProviderWorkloadPolicy
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set.
    /// Possible values are: BLOCK, CLUSTER, SUBBLOCK.
    /// </summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>
    /// The type of workload policy.
    /// Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecInitProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public V1beta2ResourcePolicySpecInitProviderDiskConsistencyGroupPolicy? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public V1beta2ResourcePolicySpecInitProviderGroupPlacementPolicy? GroupPlacementPolicy { get; set; }

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public V1beta2ResourcePolicySpecInitProviderInstanceSchedulePolicy? InstanceSchedulePolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public V1beta2ResourcePolicySpecInitProviderSnapshotSchedulePolicy? SnapshotSchedulePolicy { get; set; }

    /// <summary>
    /// Represents the workload policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workloadPolicy")]
    public V1beta2ResourcePolicySpecInitProviderWorkloadPolicy? WorkloadPolicy { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicySpecManagementPoliciesEnum>))]
public enum V1beta2ResourcePolicySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicySpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResourcePolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResourcePolicySpec defines the desired state of ResourcePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicySpec
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
    public V1beta2ResourcePolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResourcePolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2ResourcePolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResourcePolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResourcePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResourcePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Replication consistency group for asynchronous disk replication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resource policy for instances used for placement configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderGroupPlacementPolicy
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created
    /// with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy
    /// attached.
    /// Possible values are: COLLOCATED.
    /// </summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}

/// <summary>
/// Specifies the schedule for starting instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Specifies the schedule for stopping instances.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Resource policy for scheduling instance operations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Specifies the schedule for starting instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStartSchedule")]
    public V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStartSchedule? VmStartSchedule { get; set; }

    /// <summary>
    /// Specifies the schedule for stopping instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vmStopSchedule")]
    public V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStopSchedule? VmStopSchedule { get; set; }
}

/// <summary>
/// Retention policy applied to snapshots created by this resource policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>
    /// Specifies the behavior to apply to scheduled snapshots when
    /// the source disk is deleted.
    /// Default value is KEEP_AUTO_SNAPSHOTS.
    /// Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.
    /// </summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}

/// <summary>
/// The policy will execute every nth day at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// The policy will execute every nth hour starting at the specified time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>
    /// The day of the week to create the snapshot. e.g. MONDAY
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &quot;HH:MM&quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// Allows specifying a snapshot time for each day of the week.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>
    /// May contain up to seven (one for each day of the week) snapshot times.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}

/// <summary>
/// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicySchedule
{
    /// <summary>
    /// The policy will execute every nth day at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dailySchedule")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleDailySchedule? DailySchedule { get; set; }

    /// <summary>
    /// The policy will execute every nth hour starting at the specified time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourlySchedule")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleHourlySchedule? HourlySchedule { get; set; }

    /// <summary>
    /// Allows specifying a snapshot time for each day of the week.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklySchedule")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklySchedule? WeeklySchedule { get; set; }
}

/// <summary>
/// Properties with which the snapshots are created, such as labels.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and comply
    /// with RFC1035.
    /// </summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a &apos;guest aware&apos; snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Cloud Storage bucket location to store the auto snapshot
    /// (regional or multi-regional)
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

/// <summary>
/// Policy for creating snapshots of persistent disks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicy
{
    /// <summary>
    /// Retention policy applied to snapshots created by this resource policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicyRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>
    /// Contains one of an hourlySchedule, dailySchedule, or weeklySchedule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicySchedule? Schedule { get; set; }

    /// <summary>
    /// Properties with which the snapshots are created, such as labels.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotProperties")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicySnapshotProperties? SnapshotProperties { get; set; }
}

/// <summary>
/// Represents the workload policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProviderWorkloadPolicy
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set.
    /// Possible values are: BLOCK, CLUSTER, SUBBLOCK.
    /// </summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>
    /// The type of workload policy.
    /// Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusAtProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public V1beta2ResourcePolicyStatusAtProviderDiskConsistencyGroupPolicy? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public V1beta2ResourcePolicyStatusAtProviderGroupPlacementPolicy? GroupPlacementPolicy { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/resourcePolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public V1beta2ResourcePolicyStatusAtProviderInstanceSchedulePolicy? InstanceSchedulePolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where resource policy resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public V1beta2ResourcePolicyStatusAtProviderSnapshotSchedulePolicy? SnapshotSchedulePolicy { get; set; }

    /// <summary>
    /// Represents the workload policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workloadPolicy")]
    public V1beta2ResourcePolicyStatusAtProviderWorkloadPolicy? WorkloadPolicy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatusConditions
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

/// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResourcePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResourcePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourcePolicy is the Schema for the ResourcePolicys API. A policy that can be attached to a resource to specify or schedule actions on that resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourcePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResourcePolicySpec>, IStatus<V1beta2ResourcePolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourcePolicy";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "resourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourcePolicySpec defines the desired state of ResourcePolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResourcePolicySpec Spec { get; set; }

    /// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResourcePolicyStatus? Status { get; set; }
}