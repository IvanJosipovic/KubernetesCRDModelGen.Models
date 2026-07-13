#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary>Reservation is the Schema for the Reservations API. A reservation is a mechanism used to guarantee BigQuery slots to users.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ReservationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Reservation>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ReservationList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "reservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Reservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Reservation> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReservationSpecDeletionPolicyEnum>))]
public enum V1beta2ReservationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The configuration parameters for the auto scaling feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecForProviderAutoscale
{
    /// <summary>Number of slots to be scaled when needed.</summary>
    [JsonPropertyName("maxSlots")]
    public double? MaxSlots { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecForProvider
{
    /// <summary>
    /// The configuration parameters for the auto scaling feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscale")]
    public V1beta2ReservationSpecForProviderAutoscale? Autoscale { get; set; }

    /// <summary>Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    [JsonPropertyName("ignoreIdleSlots")]
    public bool? IgnoreIdleSlots { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The current location of the reservation&apos;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [JsonPropertyName("slotCapacity")]
    public double? SlotCapacity { get; set; }
}

/// <summary>
/// The configuration parameters for the auto scaling feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecInitProviderAutoscale
{
    /// <summary>Number of slots to be scaled when needed.</summary>
    [JsonPropertyName("maxSlots")]
    public double? MaxSlots { get; set; }
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
public partial class V1beta2ReservationSpecInitProvider
{
    /// <summary>
    /// The configuration parameters for the auto scaling feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscale")]
    public V1beta2ReservationSpecInitProviderAutoscale? Autoscale { get; set; }

    /// <summary>Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    [JsonPropertyName("ignoreIdleSlots")]
    public bool? IgnoreIdleSlots { get; set; }

    /// <summary>
    /// The current location of the reservation&apos;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [JsonPropertyName("slotCapacity")]
    public double? SlotCapacity { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReservationSpecManagementPoliciesEnum>))]
public enum V1beta2ReservationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReservationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ReservationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReservationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ReservationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ReservationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ReservationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ReservationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ReservationSpec defines the desired state of Reservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationSpec
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
    public V1beta2ReservationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ReservationSpecForProvider ForProvider { get; set; }

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
    public V1beta2ReservationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ReservationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ReservationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ReservationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The configuration parameters for the auto scaling feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationStatusAtProviderAutoscale
{
    /// <summary>
    /// (Output)
    /// The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots].
    /// </summary>
    [JsonPropertyName("currentSlots")]
    public double? CurrentSlots { get; set; }

    /// <summary>Number of slots to be scaled when needed.</summary>
    [JsonPropertyName("maxSlots")]
    public double? MaxSlots { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationStatusAtProviderReplicationStatusError
{
    /// <summary>
    /// (Output)
    /// The status code, which should be an enum value of google.rpc.Code.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>
    /// (Output)
    /// A developer-facing error message, which should be in English.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationStatusAtProviderReplicationStatus
{
    /// <summary>
    /// (Output)
    /// The last error encountered while trying to replicate changes from the primary to the
    /// secondary. This field is only available if the replication has not succeeded since.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("error")]
    public IList<V1beta2ReservationStatusAtProviderReplicationStatusError>? Error { get; set; }

    /// <summary>
    /// (Output)
    /// The time at which the last error was encountered while trying to replicate changes from
    /// the primary to the secondary. This field is only available if the replication has not
    /// succeeded since.
    /// </summary>
    [JsonPropertyName("lastErrorTime")]
    public string? LastErrorTime { get; set; }

    /// <summary>
    /// (Output)
    /// A timestamp corresponding to the last change on the primary that was successfully
    /// replicated to the secondary.
    /// </summary>
    [JsonPropertyName("lastReplicationTime")]
    public string? LastReplicationTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationStatusAtProvider
{
    /// <summary>
    /// The configuration parameters for the auto scaling feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscale")]
    public V1beta2ReservationStatusAtProviderAutoscale? Autoscale { get; set; }

    /// <summary>Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/reservations/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    [JsonPropertyName("ignoreIdleSlots")]
    public bool? IgnoreIdleSlots { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The location where the reservation was originally created. This is set only during the
    /// failover reservation&apos;s creation. All billing charges for the failover reservation will be
    /// applied to this location.
    /// </summary>
    [JsonPropertyName("originalPrimaryLocation")]
    public string? OriginalPrimaryLocation { get; set; }

    /// <summary>
    /// The current location of the reservation&apos;s primary replica. This field is only set for
    /// reservations using the managed disaster recovery feature.
    /// </summary>
    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Disaster Recovery(DR) replication status of the reservation. This is only available for
    /// the primary replicas of DR/failover reservations and provides information about the both the
    /// staleness of the secondary and the last error encountered while trying to replicate changes
    /// from the primary to the secondary. If this field is blank, it means that the reservation is
    /// either not a DR reservation or the reservation is a DR secondary or that any replication
    /// operations on the reservation have succeeded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicationStatus")]
    public IList<V1beta2ReservationStatusAtProviderReplicationStatus>? ReplicationStatus { get; set; }

    /// <summary>
    /// The current location of the reservation&apos;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [JsonPropertyName("slotCapacity")]
    public double? SlotCapacity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReservationStatusConditions
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
public partial class V1beta2ReservationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ReservationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ReservationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Reservation is the Schema for the Reservations API. A reservation is a mechanism used to guarantee BigQuery slots to users.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Reservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ReservationSpec>, IStatus<V1beta2ReservationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Reservation";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "reservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Reservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReservationSpec defines the desired state of Reservation</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ReservationSpec Spec { get; set; }

    /// <summary>ReservationStatus defines the observed state of Reservation.</summary>
    [JsonPropertyName("status")]
    public V1beta2ReservationStatus? Status { get; set; }
}