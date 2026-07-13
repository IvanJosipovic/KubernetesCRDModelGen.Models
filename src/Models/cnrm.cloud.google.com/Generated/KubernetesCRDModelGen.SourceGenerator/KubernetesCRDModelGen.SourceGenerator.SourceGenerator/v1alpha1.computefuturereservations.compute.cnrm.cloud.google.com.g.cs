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
/// <summary>ComputeFutureReservation is the Schema for the ComputeFutureReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeFutureReservationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeFutureReservation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeFutureReservationList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computefuturereservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeFutureReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ComputeFutureReservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ComputeFutureReservation> Items { get; set; }
}

/// <summary>Properties of accelerator resources in this reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecAggregateReservationReservedResourcesAccelerator
{
    /// <summary>Number of accelerators of specified type.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL to accelerator type. e.g. &quot;projects/{PROJECT}/zones/{ZONE}/acceleratorTypes/ct4l&quot;</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecAggregateReservationReservedResources
{
    /// <summary>Properties of accelerator resources in this reservation.</summary>
    [JsonPropertyName("accelerator")]
    public V1alpha1ComputeFutureReservationSpecAggregateReservationReservedResourcesAccelerator? Accelerator { get; set; }
}

/// <summary>Aggregate reservation details for the future reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecAggregateReservation
{
    /// <summary>List of reserved resources (CPUs, memory, accelerators).</summary>
    [JsonPropertyName("reservedResources")]
    public IList<V1alpha1ComputeFutureReservationSpecAggregateReservationReservedResources>? ReservedResources { get; set; }

    /// <summary>The VM family that all instances scheduled against this reservation must belong to. Check the VmFamily enum for the list of possible values.</summary>
    [JsonPropertyName("vmFamily")]
    public string? VmFamily { get; set; }

    /// <summary>The workload type of the instances that will target this reservation. Check the WorkloadType enum for the list of possible values.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>Specifies the duration of auto-created reservations. It represents relative time to future reservation start_time when auto-created reservations will be automatically deleted by Compute Engine. Duration time unit is represented as a count of seconds and fractions of seconds at nanosecond resolution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecAutoCreatedReservationsDuration
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 `seconds` field and a positive `nanos` field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>If not present, then FR will not deliver a new commitment or update an existing commitment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecCommitmentInfo
{
    /// <summary>name of the commitment where capacity is being delivered to.</summary>
    [JsonPropertyName("commitmentName")]
    public string? CommitmentName { get; set; }

    /// <summary>Indicates if a Commitment needs to be created as part of FR delivery. If this field is not present, then no commitment needs to be created. Check the CommitmentPlan enum for the list of possible values.</summary>
    [JsonPropertyName("commitmentPlan")]
    public string? CommitmentPlan { get; set; }

    /// <summary>Only applicable if FR is delivering to the same reservation. If set, all parent commitments will be extended to match the end date of the plan for this commitment. Check the PreviousCommitmentTerms enum for the list of possible values.</summary>
    [JsonPropertyName("previousCommitmentTerms")]
    public string? PreviousCommitmentTerms { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The resource reference that defaults to Project if Kind is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapKeyRef
{
    /// <summary>APIVersion of the referenced resource</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referenced resource</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project ID, should be same as the key of this project config in the parent map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapValueProjectIDRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapValue
{
    /// <summary>The project ID, should be same as the key of this project config in the parent map.</summary>
    [JsonPropertyName("projectIDRef")]
    public V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapValueProjectIDRef? ProjectIDRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecShareSettingsProjectMap
{
    /// <summary>The resource reference that defaults to Project if Kind is not specified.</summary>
    [JsonPropertyName("keyRef")]
    public required V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapKeyRef KeyRef { get; set; }

    [JsonPropertyName("value")]
    public V1alpha1ComputeFutureReservationSpecShareSettingsProjectMapValue? Value { get; set; }
}

/// <summary>List of Projects/Folders to share with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecShareSettings
{
    /// <summary>A map of key(i.e. project or other shared resources) and associated project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.`</summary>
    [JsonPropertyName("projectMap")]
    public IList<V1alpha1ComputeFutureReservationSpecShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>Type of sharing for this shared-reservation Check the ShareType enum for the list of possible values.</summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstancePropertiesGuestAccelerators
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL of the accelerator type resource to attach to this instance. For example:projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100 If you are creating an instance template, specify only the accelerator name. See GPUs on Compute Engine for a full list of accelerator types.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstancePropertiesLocalSsds
{
    /// <summary>Specifies the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGB")]
    public long? DiskSizeGB { get; set; }

    /// <summary>Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default isSCSI. For performance characteristics of SCSI over NVMe, seeLocal SSD performance. Check the Interface enum for the list of possible values.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>Properties of the SKU instances being reserved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstanceProperties
{
    /// <summary>Specifies accelerator type and count.</summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>Specifies amount of local ssd to reserve with each instance. The type of disk is local-ssd.</summary>
    [JsonPropertyName("localSsds")]
    public IList<V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>An opaque location hint used to place the allocation close to other resources. This field is for use by internal tools that use the public API.</summary>
    [JsonPropertyName("locationHint")]
    public string? LocationHint { get; set; }

    /// <summary>Specifies type of machine (name only) which has fixed number of vCPUs and fixed amount of memory. This also includes specifying custom machine type following custom-NUMBER_OF_CPUS-AMOUNT_OF_MEMORY pattern.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum cpu platform the reservation.</summary>
    [JsonPropertyName("minCPUPlatform")]
    public string? MinCPUPlatform { get; set; }
}

/// <summary>Future Reservation configuration to indicate instance properties and total count.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecSpecificSkuProperties
{
    /// <summary>Properties of the SKU instances being reserved.</summary>
    [JsonPropertyName("instanceProperties")]
    public V1alpha1ComputeFutureReservationSpecSpecificSkuPropertiesInstanceProperties? InstanceProperties { get; set; }

    /// <summary>The instance template that will be used to populate the ReservedInstanceProperties of the future reservation</summary>
    [JsonPropertyName("sourceInstanceTemplate")]
    public string? SourceInstanceTemplate { get; set; }

    /// <summary>Total number of instances for which capacity assurance is requested at a future time period.</summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecTimeWindowDuration
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 `seconds` field and a positive `nanos` field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Time window for this Future Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpecTimeWindow
{
    [JsonPropertyName("duration")]
    public V1alpha1ComputeFutureReservationSpecTimeWindowDuration? Duration { get; set; }

    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Start time of the Future Reservation. The start_time is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>ComputeFutureReservationSpec defines the desired state of ComputeFutureReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationSpec
{
    /// <summary>Aggregate reservation details for the future reservation.</summary>
    [JsonPropertyName("aggregateReservation")]
    public V1alpha1ComputeFutureReservationSpecAggregateReservation? AggregateReservation { get; set; }

    /// <summary>Future timestamp when the FR auto-created reservations will be deleted by Compute Engine. Format of this field must be a valid href=&quot;https://www.ietf.org/rfc/rfc3339.txt&quot; &gt;RFC3339 value.</summary>
    [JsonPropertyName("autoCreatedReservationsDeleteTime")]
    public string? AutoCreatedReservationsDeleteTime { get; set; }

    /// <summary>Specifies the duration of auto-created reservations. It represents relative time to future reservation start_time when auto-created reservations will be automatically deleted by Compute Engine. Duration time unit is represented as a count of seconds and fractions of seconds at nanosecond resolution.</summary>
    [JsonPropertyName("autoCreatedReservationsDuration")]
    public V1alpha1ComputeFutureReservationSpecAutoCreatedReservationsDuration? AutoCreatedReservationsDuration { get; set; }

    /// <summary>Setting for enabling or disabling automatic deletion for auto-created reservation. If set to true, auto-created reservations will be deleted at Future Reservation&apos;s end time (default) or at user&apos;s defined timestamp if any of the [auto_created_reservations_delete_time, auto_created_reservations_duration] values is specified. For keeping auto-created reservation indefinitely, this value should be set to false.</summary>
    [JsonPropertyName("autoDeleteAutoCreatedReservations")]
    public bool? AutoDeleteAutoCreatedReservations { get; set; }

    /// <summary>If not present, then FR will not deliver a new commitment or update an existing commitment.</summary>
    [JsonPropertyName("commitmentInfo")]
    public V1alpha1ComputeFutureReservationSpecCommitmentInfo? CommitmentInfo { get; set; }

    /// <summary>Type of the deployment requested as part of future reservation. Check the DeploymentType enum for the list of possible values.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the future reservation.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates if this group of VMs have emergent maintenance enabled.</summary>
    [JsonPropertyName("enableEmergentMaintenance")]
    public bool? EnableEmergentMaintenance { get; set; }

    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Name prefix for the reservations to be created at the time of delivery. The name prefix must comply with RFC1035. Maximum allowed length for name prefix is 20. Automatically created reservations name format will be -date-####.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Planning state before being submitted for evaluation Check the PlanningStatus enum for the list of possible values.</summary>
    [JsonPropertyName("planningStatus")]
    public string? PlanningStatus { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ComputeFutureReservationSpecProjectRef ProjectRef { get; set; }

    /// <summary>The reservation mode which determines reservation-termination behavior and expected pricing. Check the ReservationMode enum for the list of possible values.</summary>
    [JsonPropertyName("reservationMode")]
    public string? ReservationMode { get; set; }

    /// <summary>Name of reservations where the capacity is provisioned at the time of delivery of  future reservations. If the reservation with the given name does not exist already, it is created automatically at the time of Approval with INACTIVE state till specified start-time. Either provide the reservation_name or a name_prefix.</summary>
    [JsonPropertyName("reservationName")]
    public string? ReservationName { get; set; }

    /// <summary>The ComputeFutureReservation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Maintenance information for this reservation Check the SchedulingType enum for the list of possible values.</summary>
    [JsonPropertyName("schedulingType")]
    public string? SchedulingType { get; set; }

    /// <summary>List of Projects/Folders to share with.</summary>
    [JsonPropertyName("shareSettings")]
    public V1alpha1ComputeFutureReservationSpecShareSettings? ShareSettings { get; set; }

    /// <summary>Indicates whether the auto-created reservation can be consumed by VMs with affinity for &quot;any&quot; reservation. If the field is set, then only VMs that target the reservation by name can consume from the delivered reservation.</summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }

    /// <summary>Future Reservation configuration to indicate instance properties and total count.</summary>
    [JsonPropertyName("specificSkuProperties")]
    public V1alpha1ComputeFutureReservationSpecSpecificSkuProperties? SpecificSkuProperties { get; set; }

    /// <summary>Time window for this Future Reservation.</summary>
    [JsonPropertyName("timeWindow")]
    public V1alpha1ComputeFutureReservationSpecTimeWindow? TimeWindow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusConditions
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

/// <summary>Properties of accelerator resources in this reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservationInUseResourcesAccelerator
{
    /// <summary>Number of accelerators of specified type.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL to accelerator type. e.g. &quot;projects/{PROJECT}/zones/{ZONE}/acceleratorTypes/ct4l&quot;</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservationInUseResources
{
    /// <summary>Properties of accelerator resources in this reservation.</summary>
    [JsonPropertyName("accelerator")]
    public V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservationInUseResourcesAccelerator? Accelerator { get; set; }
}

/// <summary>Aggregate reservation details for the future reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservation
{
    /// <summary>Output only. [Output only] List of resources currently in use.</summary>
    [JsonPropertyName("inUseResources")]
    public IList<V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservationInUseResources>? InUseResources { get; set; }
}

/// <summary>Output only. [Output Only] Represents the existing matching usage for the future reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusExistingMatchingUsageInfo
{
    /// <summary>Output only. Count to represent min(FR total_count, matching_reserved_capacity+matching_unreserved_instances)</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Output only. Timestamp when the matching usage was calculated</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>Output only. [Output Only] Represents the matching usage for the future reservation before an amendment was requested.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateExistingMatchingUsageInfo
{
    /// <summary>Output only. Count to represent min(FR total_count, matching_reserved_capacity+matching_unreserved_instances)</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Output only. Timestamp when the matching usage was calculated</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsShareSettingsProjectMap
{
    /// <summary>The project ID, should be same as the key of this project config in the parent map.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Output only. [Output Only] The previous share settings of the Future Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsShareSettings
{
    /// <summary>A map of project id and project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.`</summary>
    [JsonPropertyName("projectMap")]
    public IDictionary<string, V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>Type of sharing for this shared-reservation Check the ShareType enum for the list of possible values.</summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstancePropertiesGuestAccelerators
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Full or partial URL of the accelerator type resource to attach to this instance. For example:projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100 If you are creating an instance template, specify only the accelerator name. See GPUs on Compute Engine for a full list of accelerator types.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstancePropertiesLocalSsds
{
    /// <summary>Specifies the size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGB")]
    public long? DiskSizeGB { get; set; }

    /// <summary>Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default isSCSI. For performance characteristics of SCSI over NVMe, seeLocal SSD performance. Check the Interface enum for the list of possible values.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>Properties of the SKU instances being reserved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstanceProperties
{
    /// <summary>Specifies accelerator type and count.</summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>Specifies amount of local ssd to reserve with each instance. The type of disk is local-ssd.</summary>
    [JsonPropertyName("localSsds")]
    public IList<V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>An opaque location hint used to place the allocation close to other resources. This field is for use by internal tools that use the public API.</summary>
    [JsonPropertyName("locationHint")]
    public string? LocationHint { get; set; }

    /// <summary>Specifies type of machine (name only) which has fixed number of vCPUs and fixed amount of memory. This also includes specifying custom machine type following custom-NUMBER_OF_CPUS-AMOUNT_OF_MEMORY pattern.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Minimum cpu platform the reservation.</summary>
    [JsonPropertyName("minCPUPlatform")]
    public string? MinCPUPlatform { get; set; }
}

/// <summary>Output only. [Output Only] The previous instance related properties of the Future Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuProperties
{
    /// <summary>Properties of the SKU instances being reserved.</summary>
    [JsonPropertyName("instanceProperties")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuPropertiesInstanceProperties? InstanceProperties { get; set; }

    /// <summary>The instance template that will be used to populate the ReservedInstanceProperties of the future reservation</summary>
    [JsonPropertyName("sourceInstanceTemplate")]
    public string? SourceInstanceTemplate { get; set; }

    /// <summary>Total number of instances for which capacity assurance is requested at a future time period.</summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsTimeWindowDuration
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 `seconds` field and a positive `nanos` field. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Output only. [Output Only] The previous time window of the Future Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsTimeWindow
{
    [JsonPropertyName("duration")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsTimeWindowDuration? Duration { get; set; }

    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Start time of the Future Reservation. The start_time is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecs
{
    /// <summary>Output only. [Output Only] The previous share settings of the Future Reservation.</summary>
    [JsonPropertyName("shareSettings")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsShareSettings? ShareSettings { get; set; }

    /// <summary>Output only. [Output Only] The previous instance related properties of the Future Reservation.</summary>
    [JsonPropertyName("specificSkuProperties")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsSpecificSkuProperties? SpecificSkuProperties { get; set; }

    /// <summary>Output only. [Output Only] The previous time window of the Future Reservation.</summary>
    [JsonPropertyName("timeWindow")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecsTimeWindow? TimeWindow { get; set; }
}

/// <summary>Output only. [Output Only] This field represents the future reservation before an amendment was requested. If the amendment is declined, the Future Reservation will be reverted to the last known good state. The last known good state is not set when updating a future reservation whose Procurement Status is DRAFTING.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodState
{
    /// <summary>Output only. [Output Only] The description of the FutureReservation before an amendment was requested.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Output only. [Output Only] Represents the matching usage for the future reservation before an amendment was requested.</summary>
    [JsonPropertyName("existingMatchingUsageInfo")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateExistingMatchingUsageInfo? ExistingMatchingUsageInfo { get; set; }

    [JsonPropertyName("futureReservationSpecs")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodStateFutureReservationSpecs? FutureReservationSpecs { get; set; }

    /// <summary>Output only. [Output Only] The lock time of the FutureReservation before an amendment was requested.</summary>
    [JsonPropertyName("lockTime")]
    public string? LockTime { get; set; }

    /// <summary>Output only. [Output Only] The name prefix of the Future Reservation before an amendment was requested.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Output only. [Output Only] The status of the last known good state for the Future Reservation. Check the ProcurementStatus enum for the list of possible values.</summary>
    [JsonPropertyName("procurementStatus")]
    public string? ProcurementStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatusSpecificSkuProperties
{
    /// <summary>ID of the instance template used to populate the Future Reservation properties.</summary>
    [JsonPropertyName("sourceInstanceTemplateID")]
    public string? SourceInstanceTemplateID { get; set; }
}

/// <summary>Output only. [Output only] Status of the Future Reservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedStateStatus
{
    /// <summary>Output only. [Output Only] The current status of the requested amendment. Check the AmendmentStatus enum for the list of possible values.</summary>
    [JsonPropertyName("amendmentStatus")]
    public string? AmendmentStatus { get; set; }

    /// <summary>Output only. Fully qualified urls of the automatically created reservations at start_time.</summary>
    [JsonPropertyName("autoCreatedReservations")]
    public IList<string>? AutoCreatedReservations { get; set; }

    /// <summary>Output only. [Output Only] Represents the existing matching usage for the future reservation.</summary>
    [JsonPropertyName("existingMatchingUsageInfo")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusExistingMatchingUsageInfo? ExistingMatchingUsageInfo { get; set; }

    /// <summary>Output only. This count indicates the fulfilled capacity so far. This is set during &quot;PROVISIONING&quot; state. This count also includes capacity delivered as part of existing matching reservations.</summary>
    [JsonPropertyName("fulfilledCount")]
    public long? FulfilledCount { get; set; }

    /// <summary>Output only. [Output Only] This field represents the future reservation before an amendment was requested. If the amendment is declined, the Future Reservation will be reverted to the last known good state. The last known good state is not set when updating a future reservation whose Procurement Status is DRAFTING.</summary>
    [JsonPropertyName("lastKnownGoodState")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusLastKnownGoodState? LastKnownGoodState { get; set; }

    /// <summary>Output only. Time when Future Reservation would become LOCKED, after which no modifications to Future Reservation will be allowed. Applicable only after the Future Reservation is in the APPROVED state. The lock_time is an RFC3339 string. The procurement_status will transition to PROCURING state at this time.</summary>
    [JsonPropertyName("lockTime")]
    public string? LockTime { get; set; }

    /// <summary>Output only. Current state of this Future Reservation Check the ProcurementStatus enum for the list of possible values.</summary>
    [JsonPropertyName("procurementStatus")]
    public string? ProcurementStatus { get; set; }

    [JsonPropertyName("specificSkuProperties")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatusSpecificSkuProperties? SpecificSkuProperties { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatusObservedState
{
    /// <summary>Aggregate reservation details for the future reservation.</summary>
    [JsonPropertyName("aggregateReservation")]
    public V1alpha1ComputeFutureReservationStatusObservedStateAggregateReservation? AggregateReservation { get; set; }

    /// <summary>Output only. [Output Only] The creation timestamp for this future reservation in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Output only. [Output Only] A unique identifier for this future reservation. The server defines this identifier.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>Output only. [Output Only] Type of the resource. Alwayscompute#futureReservation for future reservations.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Output only. [Output Only] Server-defined fully-qualified URL for this resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. [Output Only] Server-defined URL for this resource with the resource id.</summary>
    [JsonPropertyName("selfLinkWithID")]
    public string? SelfLinkWithID { get; set; }

    /// <summary>Output only. [Output only] Status of the Future Reservation</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeFutureReservationStatusObservedStateStatus? Status { get; set; }

    /// <summary>Output only. [Output Only] URL of the Zone where this future reservation resides.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>ComputeFutureReservationStatus defines the config connector machine state of ComputeFutureReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeFutureReservationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeFutureReservationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComputeFutureReservation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ComputeFutureReservationStatusObservedState? ObservedState { get; set; }
}

/// <summary>ComputeFutureReservation is the Schema for the ComputeFutureReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeFutureReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeFutureReservationSpec>, IStatus<V1alpha1ComputeFutureReservationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeFutureReservation";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computefuturereservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeFutureReservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeFutureReservationSpec defines the desired state of ComputeFutureReservation</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ComputeFutureReservationSpec Spec { get; set; }

    /// <summary>ComputeFutureReservationStatus defines the config connector machine state of ComputeFutureReservation</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeFutureReservationStatus? Status { get; set; }
}