#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.longhorn.io;
/// <summary>SnapshotGroup is the Schema for the snapshotgroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SnapshotGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SnapshotGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SnapshotGroupList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "snapshotgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SnapshotGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SnapshotGroup> Items { get; set; }
}

/// <summary>
/// SnapshotGroupMember identifies one member of the group: the volume and the
/// name of its member Snapshot CR, generated at admission.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupSpecMembers
{
    [JsonPropertyName("snapshotName")]
    public required string SnapshotName { get; set; }

    [JsonPropertyName("volumeName")]
    public required string VolumeName { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupSpecVolumeSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// VolumeSelector selects the member volumes by their labels. Exactly one of
/// Volumes or VolumeSelector may be set at creation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupSpecVolumeSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta2SnapshotGroupSpecVolumeSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// SnapshotGroupSpec defines the desired state of the Longhorn SnapshotGroup.
/// The whole spec is immutable after creation: a group is a point-in-time
/// request, so changing members later has no meaning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupSpec
{
    /// <summary>
    /// DeadlineSeconds is the deadline for taking every member snapshot,
    /// measured from the group&apos;s metadata.creationTimestamp. When the field is
    /// omitted, the CRD default applies. Go clients cannot omit the field: an
    /// unset field arrives as 0, and the mutating webhook replaces the 0 with
    /// the default.
    /// </summary>
    [JsonPropertyName("deadlineSeconds")]
    public long? DeadlineSeconds { get; set; }

    /// <summary>
    /// Labels are engine snapshot labels applied to every member (Snapshot
    /// spec.labels). They are not visible to Kubernetes label selectors.
    /// Reserved recurring-job label keys are rejected at admission.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Members is the fixed member set, resolved from Volumes or VolumeSelector
    /// and stamped by the mutating webhook at admission. It may not be set by
    /// the user.
    /// </summary>
    [JsonPropertyName("members")]
    public IList<V1beta2SnapshotGroupSpecMembers>? Members { get; set; }

    /// <summary>
    /// VolumeSelector selects the member volumes by their labels. Exactly one of
    /// Volumes or VolumeSelector may be set at creation.
    /// </summary>
    [JsonPropertyName("volumeSelector")]
    public V1beta2SnapshotGroupSpecVolumeSelector? VolumeSelector { get; set; }

    /// <summary>
    /// Volumes explicitly lists the member volumes. Exactly one of Volumes or
    /// VolumeSelector may be set at creation; the mutating webhook resolves the
    /// selection into Members at admission.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<string>? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupStatusConditions
{
    /// <summary>Last time we probed the condition.</summary>
    [JsonPropertyName("lastProbeTime")]
    public string? LastProbeTime { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// Status is the status of the condition.
    /// Can be True, False, Unknown.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// SnapshotGroupMemberStatus is the observed state of one member, mirrored from
/// its Snapshot CR.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupStatusMembers
{
    /// <summary>
    /// CreationTime is the engine snapshot creation time, mirrored from the
    /// member Snapshot. It is kept when the member is later lost.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// Error is the last member error. A member Snapshot CR that disappeared
    /// after the group became Ready is recorded with the synthetic error
    /// &quot;member snapshot deleted&quot;; an unusable member keeps its own mirrored
    /// error.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// ReadyToUse mirrors the member Snapshot while the group is InProgress.
    /// After the group is Ready, a member later deleted or unusable is recorded
    /// here as false: member entries always tell the per-member truth.
    /// </summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }

    [JsonPropertyName("snapshotName")]
    public required string SnapshotName { get; set; }

    [JsonPropertyName("volumeName")]
    public required string VolumeName { get; set; }
}

/// <summary>SnapshotGroupStatus defines the observed state of the Longhorn SnapshotGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotGroupStatus
{
    /// <summary>
    /// Conditions holds the latest observations of the SnapshotGroup&apos;s state,
    /// such as Degraded.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SnapshotGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CreationTime is the latest member creation time, set when the group
    /// becomes Ready.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>Error is set when the group fails (deadline, name collision).</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// Members is the observed state of every member, one entry per spec
    /// member. It is the primary debugging signal: each entry carries the
    /// member&apos;s last error and creation time.
    /// </summary>
    [JsonPropertyName("members")]
    public IList<V1beta2SnapshotGroupStatusMembers>? Members { get; set; }

    /// <summary>OwnerID is the ID of the node that owns this SnapshotGroup.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>
    /// Phase is the lifecycle phase: empty until the first reconcile, then
    /// InProgress -&gt; Ready | Failed.
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>
    /// ReadyToUse is true when the group is Ready and every member snapshot
    /// is still individually ready: group readiness is the AND of member
    /// readiness, following the Kubernetes VolumeGroupSnapshot convention. It
    /// drops to false when a member is lost or unusable after Ready and
    /// recovers once every member is whole again; the Degraded condition
    /// carries the per-member detail. A failed, partial, or empty group is
    /// never reported ready.
    /// </summary>
    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }
}

/// <summary>SnapshotGroup is the Schema for the snapshotgroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SnapshotGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SnapshotGroupSpec?>, IStatus<V1beta2SnapshotGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SnapshotGroup";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "snapshotgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// SnapshotGroupSpec defines the desired state of the Longhorn SnapshotGroup.
    /// The whole spec is immutable after creation: a group is a point-in-time
    /// request, so changing members later has no meaning.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2SnapshotGroupSpec? Spec { get; set; }

    /// <summary>SnapshotGroupStatus defines the observed state of the Longhorn SnapshotGroup</summary>
    [JsonPropertyName("status")]
    public V1beta2SnapshotGroupStatus? Status { get; set; }
}