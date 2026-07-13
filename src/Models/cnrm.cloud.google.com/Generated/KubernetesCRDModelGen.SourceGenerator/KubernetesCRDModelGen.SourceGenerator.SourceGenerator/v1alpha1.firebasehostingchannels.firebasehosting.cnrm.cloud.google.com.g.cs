#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firebasehosting.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirebaseHostingChannelList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirebaseHostingChannel>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirebaseHostingChannelList";
    public const string KubeGroup = "firebasehosting.cnrm.cloud.google.com";
    public const string KubePluralName = "firebasehostingchannels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firebasehosting.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirebaseHostingChannelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirebaseHostingChannel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirebaseHostingChannel> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseHostingChannelSpec
{
    /// <summary>
    /// The time at which the channel will be automatically deleted. If null, the channel
    /// will not be automatically deleted. This field is present in the output whether it&apos;s
    /// set directly or via the &apos;ttl&apos; field.
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Immutable. Optional. The channelId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// The number of previous releases to retain on the channel for rollback or other
    /// purposes. Must be a number between 1-100. Defaults to 10 for new channels.
    /// </summary>
    [JsonPropertyName("retainedReleaseCount")]
    public int? RetainedReleaseCount { get; set; }

    /// <summary>Immutable. Required. The ID of the site in which to create this channel.</summary>
    [JsonPropertyName("siteId")]
    public required string SiteId { get; set; }

    /// <summary>
    /// Immutable. Input only. A time-to-live for this channel. Sets &apos;expire_time&apos; to the provided
    /// duration past the time of the request. A duration in seconds with up to nine fractional
    /// digits, terminated by &apos;s&apos;. Example: &quot;86400s&quot; (one day).
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseHostingChannelStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirebaseHostingChannelStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirebaseHostingChannelStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The fully-qualified resource name for the channel, in the format:
    /// sites/SITE_ID/channels/CHANNEL_ID.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirebaseHostingChannel : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirebaseHostingChannelSpec>, IStatus<V1alpha1FirebaseHostingChannelStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirebaseHostingChannel";
    public const string KubeGroup = "firebasehosting.cnrm.cloud.google.com";
    public const string KubePluralName = "firebasehostingchannels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firebasehosting.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirebaseHostingChannel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1FirebaseHostingChannelSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1FirebaseHostingChannelStatus? Status { get; set; }
}