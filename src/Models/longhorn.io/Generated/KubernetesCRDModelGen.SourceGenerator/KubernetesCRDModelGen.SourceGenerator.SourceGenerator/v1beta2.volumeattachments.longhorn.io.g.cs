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
/// <summary>VolumeAttachment stores attachment information of a Longhorn volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VolumeAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2VolumeAttachment>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VolumeAttachmentList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "volumeattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeAttachmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2VolumeAttachment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2VolumeAttachment> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeAttachmentSpecAttachmentTickets
{
    /// <summary>
    /// A sequence number representing a specific generation of the desired state.
    /// Populated by the system. Read-only.
    /// </summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>The unique ID of this attachment. Used to differentiate different attachments of the same volume.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The node that this attachment is requesting</summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    /// <summary>Optional additional parameter for this attachment</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>VolumeAttachmentSpec defines the desired state of Longhorn VolumeAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeAttachmentSpec
{
    [JsonPropertyName("attachmentTickets")]
    public IDictionary<string, V1beta2VolumeAttachmentSpecAttachmentTickets>? AttachmentTickets { get; set; }

    /// <summary>The name of Longhorn volume of this VolumeAttachment</summary>
    [JsonPropertyName("volume")]
    public required string Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeAttachmentStatusAttachmentTicketStatusesConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeAttachmentStatusAttachmentTicketStatuses
{
    /// <summary>Record any error when trying to fulfill this attachment</summary>
    [JsonPropertyName("conditions")]
    public required IList<V1beta2VolumeAttachmentStatusAttachmentTicketStatusesConditions>? Conditions { get; set; }

    /// <summary>
    /// A sequence number representing a specific generation of the desired state.
    /// Populated by the system. Read-only.
    /// </summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>The unique ID of this attachment. Used to differentiate different attachments of the same volume.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicate whether this attachment ticket has been satisfied</summary>
    [JsonPropertyName("satisfied")]
    public required bool Satisfied { get; set; }
}

/// <summary>VolumeAttachmentStatus defines the observed state of Longhorn VolumeAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeAttachmentStatus
{
    [JsonPropertyName("attachmentTicketStatuses")]
    public IDictionary<string, V1beta2VolumeAttachmentStatusAttachmentTicketStatuses>? AttachmentTicketStatuses { get; set; }
}

/// <summary>VolumeAttachment stores attachment information of a Longhorn volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VolumeAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VolumeAttachmentSpec?>, IStatus<V1beta2VolumeAttachmentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VolumeAttachment";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "volumeattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeAttachment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VolumeAttachmentSpec defines the desired state of Longhorn VolumeAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta2VolumeAttachmentSpec? Spec { get; set; }

    /// <summary>VolumeAttachmentStatus defines the observed state of Longhorn VolumeAttachment</summary>
    [JsonPropertyName("status")]
    public V1beta2VolumeAttachmentStatus? Status { get; set; }
}