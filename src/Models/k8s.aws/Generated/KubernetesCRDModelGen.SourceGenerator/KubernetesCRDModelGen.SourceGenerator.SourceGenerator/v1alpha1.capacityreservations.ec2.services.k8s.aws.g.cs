#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.services.k8s.aws;
/// <summary>CapacityReservation is the Schema for the CapacityReservations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CapacityReservationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CapacityReservation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CapacityReservationList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "capacityreservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CapacityReservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CapacityReservation> Items { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CapacityReservationSpec defines the desired state of CapacityReservation.
/// 
/// Describes a Capacity Reservation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationSpec
{
    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("additionalInfo")]
    public string? AdditionalInfo { get; set; }

    /// <summary>The Availability Zone in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The ID of the Availability Zone in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("availabilityZoneID")]
    public string? AvailabilityZoneID { get; set; }

    /// <summary>
    /// Required for future-dated Capacity Reservations only. To create a Capacity
    /// Reservation for immediate use, omit this parameter.
    /// 
    /// Specify a commitment duration, in seconds, for the future-dated Capacity
    /// Reservation.
    /// 
    /// The commitment duration is a minimum duration for which you commit to having
    /// the future-dated Capacity Reservation in the active state in your account
    /// after it has been delivered.
    /// 
    /// For more information, see Commitment duration (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-concepts.html#cr-commitment-duration).
    /// </summary>
    [JsonPropertyName("commitmentDuration")]
    public long? CommitmentDuration { get; set; }

    /// <summary>
    /// Required for future-dated Capacity Reservations only. To create a Capacity
    /// Reservation for immediate use, omit this parameter.
    /// 
    /// Indicates that the requested capacity will be delivered in addition to any
    /// running instances or reserved capacity that you have in your account at the
    /// requested date and time.
    /// 
    /// The only supported value is incremental.
    /// </summary>
    [JsonPropertyName("deliveryPreference")]
    public string? DeliveryPreference { get; set; }

    /// <summary>
    /// Indicates whether the Capacity Reservation supports EBS-optimized instances.
    /// This optimization provides dedicated throughput to Amazon EBS and an optimized
    /// configuration stack to provide optimal I/O performance. This optimization
    /// isn&apos;t available with all instance types. Additional usage charges apply when
    /// using an EBS- optimized instance.
    /// </summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>
    /// The date and time at which the Capacity Reservation expires. When a Capacity
    /// Reservation expires, the reserved capacity is released and you can no longer
    /// launch instances into it. The Capacity Reservation&apos;s state changes to expired
    /// when it reaches its end date and time.
    /// 
    /// You must provide an EndDate value if EndDateType is limited. Omit EndDate
    /// if EndDateType is unlimited.
    /// 
    /// If the EndDateType is limited, the Capacity Reservation is cancelled within
    /// an hour from the specified time. For example, if you specify 5/31/2019, 13:30:55,
    /// the Capacity Reservation is guaranteed to end between 13:30:55 and 14:30:55
    /// on 5/31/2019.
    /// 
    /// If you are requesting a future-dated Capacity Reservation, you can&apos;t specify
    /// an end date and time that is within the commitment duration.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Indicates the way in which the Capacity Reservation ends. A Capacity Reservation
    /// can have one of the following end types:
    /// 
    ///   - unlimited - The Capacity Reservation remains active until you explicitly
    ///     cancel it. Do not provide an EndDate if the EndDateType is unlimited.
    /// 
    ///   - limited - The Capacity Reservation expires automatically at a specified
    ///     date and time. You must provide an EndDate value if the EndDateType value
    ///     is limited.
    /// </summary>
    [JsonPropertyName("endDateType")]
    public string? EndDateType { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public bool? EphemeralStorage { get; set; }

    /// <summary>
    /// The number of instances for which to reserve capacity.
    /// 
    /// You can request future-dated Capacity Reservations for an instance count
    /// with a minimum of 32 vCPUs. For example, if you request a future-dated Capacity
    /// Reservation for m5.xlarge instances, you must request at least 8 instances
    /// (8 * m5.xlarge = 32 vCPUs).
    /// 
    /// Valid range: 1 - 1000
    /// </summary>
    [JsonPropertyName("instanceCount")]
    public required long InstanceCount { get; set; }

    /// <summary>
    /// Indicates the type of instance launches that the Capacity Reservation accepts.
    /// The options include:
    /// 
    ///   - open - The Capacity Reservation automatically matches all instances
    ///     that have matching attributes (instance type, platform, and Availability
    ///     Zone). Instances that have matching attributes run in the Capacity Reservation
    ///     automatically without specifying any additional parameters.
    /// 
    ///   - targeted - The Capacity Reservation only accepts instances that have
    ///     matching attributes (instance type, platform, and Availability Zone),
    ///     and explicitly target the Capacity Reservation. This ensures that only
    ///     permitted instances can use the reserved capacity.
    /// 
    /// If you are requesting a future-dated Capacity Reservation, you must specify
    /// targeted.
    /// 
    /// Default: open
    /// </summary>
    [JsonPropertyName("instanceMatchCriteria")]
    public string? InstanceMatchCriteria { get; set; }

    /// <summary>The type of operating system for which to reserve capacity.</summary>
    [JsonPropertyName("instancePlatform")]
    public required string InstancePlatform { get; set; }

    /// <summary>
    /// The instance type for which to reserve capacity.
    /// 
    /// You can request future-dated Capacity Reservations for instance types in
    /// the C, M, R, I, T, and G instance families only.
    /// 
    /// For more information, see Instance types (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public required string InstanceType { get; set; }

    /// <summary>
    /// Not supported for future-dated Capacity Reservations.
    /// 
    /// The Amazon Resource Name (ARN) of the Outpost on which to create the Capacity
    /// Reservation.
    /// 
    /// Regex Pattern: `^arn:aws([a-z-]+)?:outposts:[a-z\d-]+:\d{12}:outpost/op-[a-f0-9]{17}$`
    /// </summary>
    [JsonPropertyName("outpostARN")]
    public string? OutpostARN { get; set; }

    /// <summary>
    /// Not supported for future-dated Capacity Reservations.
    /// 
    /// The Amazon Resource Name (ARN) of the cluster placement group in which to
    /// create the Capacity Reservation. For more information, see Capacity Reservations
    /// for cluster placement groups (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-cpg.html)
    /// in the Amazon EC2 User Guide.
    /// 
    /// Regex Pattern: `^arn:aws([a-z-]+)?:ec2:[a-z\d-]+:\d{12}:placement-group/^.{1,255}$`
    /// </summary>
    [JsonPropertyName("placementGroupARN")]
    public string? PlacementGroupARN { get; set; }

    /// <summary>
    /// Required for future-dated Capacity Reservations only. To create a Capacity
    /// Reservation for immediate use, omit this parameter.
    /// 
    /// The date and time at which the future-dated Capacity Reservation should become
    /// available for use, in the ISO8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ).
    /// 
    /// You can request a future-dated Capacity Reservation between 5 and 120 days
    /// in advance.
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CapacityReservationSpecTags>? Tags { get; set; }

    /// <summary>
    /// Indicates the tenancy of the Capacity Reservation. A Capacity Reservation
    /// can have one of the following tenancy settings:
    /// 
    ///   - default - The Capacity Reservation is created on hardware that is shared
    ///     with other Amazon Web Services accounts.
    /// 
    ///   - dedicated - The Capacity Reservation is created on single-tenant hardware
    ///     that is dedicated to a single Amazon Web Services account.
    /// </summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>Information about instance capacity usage for a Capacity Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationStatusCapacityAllocations
{
    [JsonPropertyName("allocationType")]
    public string? AllocationType { get; set; }

    [JsonPropertyName("count")]
    public long? Count { get; set; }
}

/// <summary>Information about your commitment for a future-dated Capacity Reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationStatusCommitmentInfo
{
    [JsonPropertyName("commitmentEndDate")]
    public DateTime? CommitmentEndDate { get; set; }

    [JsonPropertyName("committedInstanceCount")]
    public long? CommittedInstanceCount { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CapacityReservationStatus defines the observed state of CapacityReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityReservationStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CapacityReservationStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The remaining capacity. Indicates the number of instances that can be launched
    /// in the Capacity Reservation.
    /// </summary>
    [JsonPropertyName("availableInstanceCount")]
    public long? AvailableInstanceCount { get; set; }

    /// <summary>Information about instance capacity usage.</summary>
    [JsonPropertyName("capacityAllocations")]
    public IList<V1alpha1CapacityReservationStatusCapacityAllocations>? CapacityAllocations { get; set; }

    /// <summary>
    /// The ID of the Capacity Reservation Fleet to which the Capacity Reservation
    /// belongs. Only valid for Capacity Reservations that were created by a Capacity
    /// Reservation Fleet.
    /// </summary>
    [JsonPropertyName("capacityReservationFleetID")]
    public string? CapacityReservationFleetID { get; set; }

    /// <summary>The ID of the Capacity Reservation.</summary>
    [JsonPropertyName("capacityReservationID")]
    public string? CapacityReservationID { get; set; }

    /// <summary>Information about your commitment for a future-dated Capacity Reservation.</summary>
    [JsonPropertyName("commitmentInfo")]
    public V1alpha1CapacityReservationStatusCommitmentInfo? CommitmentInfo { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CapacityReservationStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time the Capacity Reservation was created.</summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the Capacity Reservation.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The type of Capacity Reservation.</summary>
    [JsonPropertyName("reservationType")]
    public string? ReservationType { get; set; }

    /// <summary>
    /// The current state of the Capacity Reservation. A Capacity Reservation can
    /// be in one of the following states:
    /// 
    ///    * active - The capacity is available for use.
    /// 
    ///    * expired - The Capacity Reservation expired automatically at the date
    ///    and time specified in your reservation request. The reserved capacity
    ///    is no longer available for your use.
    /// 
    ///    * cancelled - The Capacity Reservation was canceled. The reserved capacity
    ///    is no longer available for your use.
    /// 
    ///    * pending - The Capacity Reservation request was successful but the capacity
    ///    provisioning is still pending.
    /// 
    ///    * failed - The Capacity Reservation request has failed. A request can
    ///    fail due to request parameters that are not valid, capacity constraints,
    ///    or instance limit constraints. You can view a failed request for 60 minutes.
    /// 
    ///    * scheduled - (Future-dated Capacity Reservations) The future-dated Capacity
    ///    Reservation request was approved and the Capacity Reservation is scheduled
    ///    for delivery on the requested start date.
    /// 
    ///    * payment-pending - (Capacity Blocks) The upfront payment has not been
    ///    processed yet.
    /// 
    ///    * payment-failed - (Capacity Blocks) The upfront payment was not processed
    ///    in the 12-hour time frame. Your Capacity Block was released.
    /// 
    ///    * assessing - (Future-dated Capacity Reservations) Amazon EC2 is assessing
    ///    your request for a future-dated Capacity Reservation.
    /// 
    ///    * delayed - (Future-dated Capacity Reservations) Amazon EC2 encountered
    ///    a delay in provisioning the requested future-dated Capacity Reservation.
    ///    Amazon EC2 is unable to deliver the requested capacity by the requested
    ///    start date and time.
    /// 
    ///    * unsupported - (Future-dated Capacity Reservations) Amazon EC2 can&apos;t
    ///    support the future-dated Capacity Reservation request due to capacity
    ///    constraints. You can view unsupported requests for 30 days. The Capacity
    ///    Reservation will not be delivered.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The total number of instances for which the Capacity Reservation reserves
    /// capacity.
    /// </summary>
    [JsonPropertyName("totalInstanceCount")]
    public long? TotalInstanceCount { get; set; }

    /// <summary>
    /// The ID of the Amazon Web Services account to which billing of the unused
    /// capacity of the Capacity Reservation is assigned.
    /// 
    /// Regex Pattern: `^[0-9]{12}$`
    /// </summary>
    [JsonPropertyName("unusedReservationBillingOwnerID")]
    public string? UnusedReservationBillingOwnerID { get; set; }
}

/// <summary>CapacityReservation is the Schema for the CapacityReservations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CapacityReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CapacityReservationSpec?>, IStatus<V1alpha1CapacityReservationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CapacityReservation";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "capacityreservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityReservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CapacityReservationSpec defines the desired state of CapacityReservation.
    /// 
    /// Describes a Capacity Reservation.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CapacityReservationSpec? Spec { get; set; }

    /// <summary>CapacityReservationStatus defines the observed state of CapacityReservation</summary>
    [JsonPropertyName("status")]
    public V1alpha1CapacityReservationStatus? Status { get; set; }
}