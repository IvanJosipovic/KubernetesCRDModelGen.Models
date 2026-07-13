#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>Reservation is the Schema for the Reservations API. Represents a reservation resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReservationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Reservation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReservationList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "reservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Reservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Reservation> Items { get; set; }
}

/// <summary>
/// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderDeleteAfterDuration
{
    /// <summary>Number of nanoseconds for the auto-delete duration.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Number of seconds for the auto-delete duration.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Sharing policy for reservations with Google Cloud managed services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderReservationSharingPolicy
{
    /// <summary>
    /// Sharing config for all Google Cloud services.
    /// Possible values are: ALLOW_ALL, DISALLOW_ALL.
    /// </summary>
    [JsonPropertyName("serviceShareType")]
    public string? ServiceShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderShareSettingsProjectMap
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The project id/number, should be same as the key of this project config in the project map.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// The share setting for reservations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderShareSettings
{
    /// <summary>
    /// A map of project number and project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("projectMap")]
    public IList<V1beta1ReservationSpecForProviderShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>
    /// Type of sharing for this shared-reservation
    /// Possible values are: LOCAL, SPECIFIC_PROJECTS.
    /// </summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationInstancePropertiesGuestAccelerators
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to
    /// this instance.
    /// </summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>
    /// The full or partial URL of the accelerator type to
    /// attach to this instance. For example:
    /// projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100
    /// If you are creating an instance template, specify only the accelerator name.
    /// </summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationInstancePropertiesLocalSsds
{
    /// <summary>The size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The disk interface to use for attaching this disk.
    /// Default value is SCSI.
    /// Possible values are: SCSI, NVME.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>
/// The instance properties for the reservation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationInstanceProperties
{
    /// <summary>
    /// Guest accelerator type and count.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1beta1ReservationSpecForProviderSpecificReservationInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>
    /// The amount of local ssd to reserve with each instance. This
    /// reserves disks of type local-ssd.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localSsds")]
    public IList<V1beta1ReservationSpecForProviderSpecificReservationInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>The name of the machine type to reserve.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The minimum CPU platform for the reservation. For example,
    /// &quot;Intel Skylake&quot;. See
    /// the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones)
    /// for information on available CPU platforms.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum>))]
public enum V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum>))]
public enum V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Reservation for instances with specific machine shapes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProviderSpecificReservation
{
    /// <summary>The number of resources that are allocated.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The instance properties for the reservation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceProperties")]
    public V1beta1ReservationSpecForProviderSpecificReservationInstanceProperties? InstanceProperties { get; set; }

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    [JsonPropertyName("sourceInstanceTemplate")]
    public string? SourceInstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
    [JsonPropertyName("sourceInstanceTemplateRef")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateRef? SourceInstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
    [JsonPropertyName("sourceInstanceTemplateSelector")]
    public V1beta1ReservationSpecForProviderSpecificReservationSourceInstanceTemplateSelector? SourceInstanceTemplateSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecForProvider
{
    /// <summary>
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deleteAfterDuration")]
    public V1beta1ReservationSpecForProviderDeleteAfterDuration? DeleteAfterDuration { get; set; }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [JsonPropertyName("deleteAtTime")]
    public string? DeleteAtTime { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationSharingPolicy")]
    public V1beta1ReservationSpecForProviderReservationSharingPolicy? ReservationSharingPolicy { get; set; }

    /// <summary>
    /// The share setting for reservations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shareSettings")]
    public V1beta1ReservationSpecForProviderShareSettings? ShareSettings { get; set; }

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ReservationSpecForProviderSpecificReservation? SpecificReservation { get; set; }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }

    /// <summary>The zone where the reservation is made.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

/// <summary>
/// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderDeleteAfterDuration
{
    /// <summary>Number of nanoseconds for the auto-delete duration.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Number of seconds for the auto-delete duration.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Sharing policy for reservations with Google Cloud managed services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderReservationSharingPolicy
{
    /// <summary>
    /// Sharing config for all Google Cloud services.
    /// Possible values are: ALLOW_ALL, DISALLOW_ALL.
    /// </summary>
    [JsonPropertyName("serviceShareType")]
    public string? ServiceShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderShareSettingsProjectMap
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The project id/number, should be same as the key of this project config in the project map.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// The share setting for reservations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderShareSettings
{
    /// <summary>
    /// A map of project number and project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("projectMap")]
    public IList<V1beta1ReservationSpecInitProviderShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>
    /// Type of sharing for this shared-reservation
    /// Possible values are: LOCAL, SPECIFIC_PROJECTS.
    /// </summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationInstancePropertiesGuestAccelerators
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to
    /// this instance.
    /// </summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>
    /// The full or partial URL of the accelerator type to
    /// attach to this instance. For example:
    /// projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100
    /// If you are creating an instance template, specify only the accelerator name.
    /// </summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationInstancePropertiesLocalSsds
{
    /// <summary>The size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The disk interface to use for attaching this disk.
    /// Default value is SCSI.
    /// Possible values are: SCSI, NVME.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>
/// The instance properties for the reservation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationInstanceProperties
{
    /// <summary>
    /// Guest accelerator type and count.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1beta1ReservationSpecInitProviderSpecificReservationInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>
    /// The amount of local ssd to reserve with each instance. This
    /// reserves disks of type local-ssd.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localSsds")]
    public IList<V1beta1ReservationSpecInitProviderSpecificReservationInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>The name of the machine type to reserve.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The minimum CPU platform for the reservation. For example,
    /// &quot;Intel Skylake&quot;. See
    /// the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones)
    /// for information on available CPU platforms.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum>))]
public enum V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum>))]
public enum V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Reservation for instances with specific machine shapes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecInitProviderSpecificReservation
{
    /// <summary>The number of resources that are allocated.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The instance properties for the reservation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceProperties")]
    public V1beta1ReservationSpecInitProviderSpecificReservationInstanceProperties? InstanceProperties { get; set; }

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    [JsonPropertyName("sourceInstanceTemplate")]
    public string? SourceInstanceTemplate { get; set; }

    /// <summary>Reference to a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
    [JsonPropertyName("sourceInstanceTemplateRef")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateRef? SourceInstanceTemplateRef { get; set; }

    /// <summary>Selector for a InstanceTemplate in compute to populate sourceInstanceTemplate.</summary>
    [JsonPropertyName("sourceInstanceTemplateSelector")]
    public V1beta1ReservationSpecInitProviderSpecificReservationSourceInstanceTemplateSelector? SourceInstanceTemplateSelector { get; set; }
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
public partial class V1beta1ReservationSpecInitProvider
{
    /// <summary>
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deleteAfterDuration")]
    public V1beta1ReservationSpecInitProviderDeleteAfterDuration? DeleteAfterDuration { get; set; }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [JsonPropertyName("deleteAtTime")]
    public string? DeleteAtTime { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationSharingPolicy")]
    public V1beta1ReservationSpecInitProviderReservationSharingPolicy? ReservationSharingPolicy { get; set; }

    /// <summary>
    /// The share setting for reservations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shareSettings")]
    public V1beta1ReservationSpecInitProviderShareSettings? ShareSettings { get; set; }

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ReservationSpecInitProviderSpecificReservation? SpecificReservation { get; set; }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReservationSpecManagementPoliciesEnum>))]
public enum V1beta1ReservationSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ReservationSpec defines the desired state of Reservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ReservationSpecForProvider ForProvider { get; set; }

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
    public V1beta1ReservationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ReservationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReservationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReservationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderDeleteAfterDuration
{
    /// <summary>Number of nanoseconds for the auto-delete duration.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Number of seconds for the auto-delete duration.</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Sharing policy for reservations with Google Cloud managed services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderReservationSharingPolicy
{
    /// <summary>
    /// Sharing config for all Google Cloud services.
    /// Possible values are: ALLOW_ALL, DISALLOW_ALL.
    /// </summary>
    [JsonPropertyName("serviceShareType")]
    public string? ServiceShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderShareSettingsProjectMap
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The project id/number, should be same as the key of this project config in the project map.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// The share setting for reservations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderShareSettings
{
    /// <summary>
    /// A map of project number and project config. This is only valid when shareType&apos;s value is SPECIFIC_PROJECTS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("projectMap")]
    public IList<V1beta1ReservationStatusAtProviderShareSettingsProjectMap>? ProjectMap { get; set; }

    /// <summary>
    /// Type of sharing for this shared-reservation
    /// Possible values are: LOCAL, SPECIFIC_PROJECTS.
    /// </summary>
    [JsonPropertyName("shareType")]
    public string? ShareType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderSpecificReservationInstancePropertiesGuestAccelerators
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to
    /// this instance.
    /// </summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>
    /// The full or partial URL of the accelerator type to
    /// attach to this instance. For example:
    /// projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100
    /// If you are creating an instance template, specify only the accelerator name.
    /// </summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderSpecificReservationInstancePropertiesLocalSsds
{
    /// <summary>The size of the disk in base-2 GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The disk interface to use for attaching this disk.
    /// Default value is SCSI.
    /// Possible values are: SCSI, NVME.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }
}

/// <summary>
/// The instance properties for the reservation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderSpecificReservationInstanceProperties
{
    /// <summary>
    /// Guest accelerator type and count.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestAccelerators")]
    public IList<V1beta1ReservationStatusAtProviderSpecificReservationInstancePropertiesGuestAccelerators>? GuestAccelerators { get; set; }

    /// <summary>
    /// The amount of local ssd to reserve with each instance. This
    /// reserves disks of type local-ssd.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localSsds")]
    public IList<V1beta1ReservationStatusAtProviderSpecificReservationInstancePropertiesLocalSsds>? LocalSsds { get; set; }

    /// <summary>The name of the machine type to reserve.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The minimum CPU platform for the reservation. For example,
    /// &quot;Intel Skylake&quot;. See
    /// the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones)
    /// for information on available CPU platforms.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }
}

/// <summary>
/// Reservation for instances with specific machine shapes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProviderSpecificReservation
{
    /// <summary>The number of resources that are allocated.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// (Output)
    /// How many instances are in use.
    /// </summary>
    [JsonPropertyName("inUseCount")]
    public double? InUseCount { get; set; }

    /// <summary>
    /// The instance properties for the reservation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instanceProperties")]
    public V1beta1ReservationStatusAtProviderSpecificReservationInstanceProperties? InstanceProperties { get; set; }

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    [JsonPropertyName("sourceInstanceTemplate")]
    public string? SourceInstanceTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusAtProvider
{
    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    [JsonPropertyName("commitment")]
    public string? Commitment { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deleteAfterDuration")]
    public V1beta1ReservationStatusAtProviderDeleteAfterDuration? DeleteAfterDuration { get; set; }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [JsonPropertyName("deleteAtTime")]
    public string? DeleteAtTime { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/reservations/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationSharingPolicy")]
    public V1beta1ReservationStatusAtProviderReservationSharingPolicy? ReservationSharingPolicy { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// The share setting for reservations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shareSettings")]
    public V1beta1ReservationStatusAtProviderShareSettings? ShareSettings { get; set; }

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta1ReservationStatusAtProviderSpecificReservation? SpecificReservation { get; set; }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [JsonPropertyName("specificReservationRequired")]
    public bool? SpecificReservationRequired { get; set; }

    /// <summary>The status of the reservation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The zone where the reservation is made.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatusConditions
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

/// <summary>ReservationStatus defines the observed state of Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReservationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ReservationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReservationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Reservation is the Schema for the Reservations API. Represents a reservation resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Reservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReservationSpec>, IStatus<V1beta1ReservationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Reservation";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "reservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Reservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReservationSpec defines the desired state of Reservation</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ReservationSpec Spec { get; set; }

    /// <summary>ReservationStatus defines the observed state of Reservation.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReservationStatus? Status { get; set; }
}