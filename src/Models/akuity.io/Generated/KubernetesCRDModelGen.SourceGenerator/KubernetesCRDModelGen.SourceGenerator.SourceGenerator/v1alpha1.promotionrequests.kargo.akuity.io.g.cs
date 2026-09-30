#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kargo.akuity.io;
/// <summary>
/// PromotionRequest expresses the intent to promote a piece of Freight to a
/// specific set of Targets. Its Stage and Freight are fixed for its lifetime,
/// giving it a single freight transition to represent from start to terminal
/// state; only its list of Targets may change, so that Targets discovered after
/// creation can still be included.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PromotionRequestList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PromotionRequest>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PromotionRequestList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "promotionrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PromotionRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PromotionRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PromotionRequest> Items { get; set; }
}

/// <summary>
/// PromotionRequestTarget names a Target that a PromotionRequest promotes
/// Freight to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestSpecTargets
{
    /// <summary>Name is the name of the Target.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Spec describes the Stage, the Freight, and the Targets of the
/// PromotionRequest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestSpec
{
    /// <summary>
    /// Freight specifies the piece of Freight promoted by the Stage.
    /// The Freight MUST be in the same namespace as the PromotionRequest.
    /// </summary>
    [JsonPropertyName("freight")]
    public required string Freight { get; set; }

    /// <summary>
    /// Stage specifies the name of the Stage that promotes the Freight.
    /// The Stage MUST be in the same namespace as the PromotionRequest.
    /// </summary>
    [JsonPropertyName("stage")]
    public required string Stage { get; set; }

    /// <summary>
    /// Targets names the Targets to which this PromotionRequest promotes Freight.
    /// Each Target MUST be in the same namespace as the PromotionRequest. The
    /// list may be empty, which records that the governing Stage governed no
    /// Targets when the PromotionRequest was created -- distinct from the field
    /// being absent, which asks for it to be resolved.
    /// 
    /// This is a resolved list, not a selector: the Stage&apos;s target selectors are
    /// evaluated once, at creation, and the result recorded here. The membership
    /// of the PromotionRequest is therefore a snapshot of what the Stage governed
    /// at that moment, and its threshold and terminal state are computed against
    /// it rather than against a selector that could match differently later.
    /// 
    /// This is the only mutable field in the spec. The governing Stage owns it,
    /// and may add Targets to an in-flight PromotionRequest so that Targets
    /// discovered after creation can still receive the Freight. Target names MUST
    /// be unique; this is enforced by the validating webhook rather than by the
    /// schema, since a list-map&apos;s per-item ownership tracking would roughly
    /// double the storage cost of every entry.
    /// </summary>
    [JsonPropertyName("targets")]
    public required IList<V1alpha1PromotionRequestSpecTargets> Targets { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PromotionRequestStatusConditionsStatusEnum>))]
public enum V1alpha1PromotionRequestStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha1PromotionRequestStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Summary aggregates the phases of this PromotionRequest&apos;s child Promotions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestStatusSummary
{
    /// <summary>Aborted is the number of child Promotions in the Aborted phase.</summary>
    [JsonPropertyName("aborted")]
    public int? Aborted { get; set; }

    /// <summary>Errored is the number of child Promotions in the Errored phase.</summary>
    [JsonPropertyName("errored")]
    public int? Errored { get; set; }

    /// <summary>Failed is the number of child Promotions in the Failed phase.</summary>
    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary>Pending is the number of child Promotions in the Pending phase.</summary>
    [JsonPropertyName("pending")]
    public int? Pending { get; set; }

    /// <summary>Running is the number of child Promotions in the Running phase.</summary>
    [JsonPropertyName("running")]
    public int? Running { get; set; }

    /// <summary>Succeeded is the number of child Promotions in the Succeeded phase.</summary>
    [JsonPropertyName("succeeded")]
    public int? Succeeded { get; set; }
}

/// <summary>
/// PromotionRequestTargetStatus records the state of a single Target selected
/// by a PromotionRequest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestStatusTargets
{
    /// <summary>Name is the name of the Target.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Phase is the phase of that Promotion.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>
    /// Promotion is the name of the child Promotion currently promoting the
    /// Freight to this Target. Empty if none has been created yet.
    /// </summary>
    [JsonPropertyName("promotion")]
    public string? Promotion { get; set; }
}

/// <summary>
/// Status describes the per-Target progress and the aggregate state of the
/// PromotionRequest&apos;s Promotions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionRequestStatus
{
    /// <summary>
    /// Conditions contains the last observations of the PromotionRequest&apos;s current
    /// state.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PromotionRequestStatusConditions>? Conditions { get; set; }

    /// <summary>FinishedAt is the time at which the PromotionRequest completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>
    /// Message is a display message explaining the current Phase: what the
    /// PromotionRequest is waiting on, how far its fan-out has progressed, or
    /// why it did not succeed. i.e. If the Phase field has a value of Failed or
    /// Errored, this field can be expected to explain why.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the generation of the spec last reconciled.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Phase is a high-level summary of the PromotionRequest&apos;s lifecycle.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartedAt is the time at which the PromotionRequest started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>Summary aggregates the phases of this PromotionRequest&apos;s child Promotions.</summary>
    [JsonPropertyName("summary")]
    public V1alpha1PromotionRequestStatusSummary? Summary { get; set; }

    /// <summary>
    /// Targets records progress against spec.targets: one entry per Target, with
    /// the child Promotion promoting to it and that Promotion&apos;s phase. Entries
    /// appear as the reconciler acts on each Target in spec.targets.
    /// 
    /// The list is atomic rather than a map keyed by name: the reconciler is its
    /// only writer, so per-item ownership tracking in managedFields would only
    /// inflate the object -- roughly doubling the storage cost of each entry --
    /// without ever being used to merge.
    /// </summary>
    [JsonPropertyName("targets")]
    public IList<V1alpha1PromotionRequestStatusTargets>? Targets { get; set; }
}

/// <summary>
/// PromotionRequest expresses the intent to promote a piece of Freight to a
/// specific set of Targets. Its Stage and Freight are fixed for its lifetime,
/// giving it a single freight transition to represent from start to terminal
/// state; only its list of Targets may change, so that Targets discovered after
/// creation can still be included.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PromotionRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PromotionRequestSpec>, IStatus<V1alpha1PromotionRequestStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PromotionRequest";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "promotionrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PromotionRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Spec describes the Stage, the Freight, and the Targets of the
    /// PromotionRequest.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1PromotionRequestSpec Spec { get; set; }

    /// <summary>
    /// Status describes the per-Target progress and the aggregate state of the
    /// PromotionRequest&apos;s Promotions.
    /// </summary>
    [JsonPropertyName("status")]
    public V1alpha1PromotionRequestStatus? Status { get; set; }
}