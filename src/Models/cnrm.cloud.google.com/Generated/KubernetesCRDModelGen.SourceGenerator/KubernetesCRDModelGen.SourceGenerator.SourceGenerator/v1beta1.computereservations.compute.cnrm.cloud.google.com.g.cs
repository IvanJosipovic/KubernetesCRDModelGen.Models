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
/// <summary>ComputeReservation is the Schema for the ComputeReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeReservationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeReservation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeReservationList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computereservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeReservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeReservation> Items { get; set; }
}

/// <summary>The resource reference that defaults to Project if Kind is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecShareSettingsProjectMapKeyRef
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
public partial class V1beta1ComputeReservationSpecShareSettingsProjectMapValueProjectIDRef
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
public partial class V1beta1ComputeReservationSpecShareSettingsProjectMapValue
{
    /// <summary>The project ID, should be same as the key of this project config in the parent map.</summary>
    [JsonPropertyName("projectIDRef")]
    public V1beta1ComputeReservationSpecShareSettingsProjectMapValueProjectIDRef? ProjectIDRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecShareSettingsProjectMap
{
    /// <summary>The resource reference that defaults to Project if Kind is not specified.</summary>
    [JsonPropertyName("keyRef")]
    public required V1beta1ComputeReservationSpecShareSettingsProjectMapKeyRef KeyRef { get; set; }

    [JsonPropertyName("value")]
    public V1beta1ComputeReservationSpecShareSettingsProjectMapValue? Value { get; set; }
}

/// <summary>The share setting for reservations and sole tenancy node groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecShareSettings
{
    /// <summary>A map of key(i.e. project or other shared resources) and associated project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.</summary>
    [JsonPropertyName("projectMap")]
    public IList<V1beta1ComputeReservationSpecShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>Immutable. Type of sharing for this shared-reservation Check the ShareType enum for the list of possible values.</summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesGuestAccelerators
{
    /// <summary>Immutable. The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public required int AcceleratorCount { get; set; }

    /// <summary>Immutable. The full or partial URL of the accelerator type to attach to this instance. For example: &apos;projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100&apos; If you are creating an instance template, specify only the accelerator name.</summary>
    [JsonPropertyName("acceleratorType")]
    public required string AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesLocalSsds
{
    /// <summary>Immutable. The size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public required int DiskSizeGb { get; set; }

    /// <summary>Immutable. The disk interface to use for attaching this disk. Default value: &quot;SCSI&quot; Possible values: [&quot;SCSI&quot;, &quot;NVME&quot;].</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>Immutable. The instance properties for the reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservationInstanceProperties
{
    /// <summary>Immutable. Guest accelerator type and count.</summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>Immutable. The amount of local ssd to reserve with each instance. This reserves disks of type &apos;local-ssd&apos;.</summary>
    [JsonPropertyName("localSsds")]
    public IList<V1beta1ComputeReservationSpecSpecificReservationInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>Immutable. The name of the machine type to reserve.</summary>
    [JsonPropertyName("machineType")]
    public required string MachineType { get; set; }

    /// <summary>Immutable. The minimum CPU platform for the reservation. For example, &apos; &quot;Intel Skylake&quot; &apos;. See the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones) for information on available CPU platforms.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }
}

/// <summary>Reservation for instances with specific machine shapes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpecSpecificReservation
{
    /// <summary>The number of resources that are allocated.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>How many instances are in use.</summary>
    [JsonPropertyName("inUseCount")]
    public int? InUseCount { get; set; }

    /// <summary>Immutable. The instance properties for the reservation.</summary>
    [JsonPropertyName("instanceProperties")]
    public required V1beta1ComputeReservationSpecSpecificReservationInstanceProperties InstanceProperties { get; set; }
}

/// <summary>ComputeReservationSpec defines the desired state of ComputeReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationSpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The share setting for reservations and sole tenancy node groups.</summary>
    [JsonPropertyName("shareSettings")]
    public V1beta1ComputeReservationSpecShareSettings? ShareSettings { get; set; }

    /// <summary>Reservation for instances with specific machine shapes.</summary>
    [JsonPropertyName("specificReservation")]
    public required V1beta1ComputeReservationSpecSpecificReservation SpecificReservation { get; set; }

    /// <summary>Immutable. When set to true, only VMs that target this reservation by name can consume this reservation. Otherwise, it can be consumed by VMs with affinity for any reservation. Defaults to false.</summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }

    /// <summary>Immutable. The zone where the reservation is made.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationStatusConditions
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

/// <summary>ComputeReservationStatus defines the config connector machine state of ComputeReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeReservationStatus
{
    /// <summary>Full or partial URL to a parent commitment. This field displays for reservations that are tied to a commitment.</summary>
    [JsonPropertyName("commitment")]
    public string? Commitment { get; set; }

    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeReservationStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A unique specifier for the ComputeReservation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The status of the reservation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ComputeReservation is the Schema for the ComputeReservation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeReservationSpec>, IStatus<V1beta1ComputeReservationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeReservation";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computereservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeReservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeReservationSpec defines the desired state of ComputeReservation</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeReservationSpec Spec { get; set; }

    /// <summary>ComputeReservationStatus defines the config connector machine state of ComputeReservation</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeReservationStatus? Status { get; set; }
}