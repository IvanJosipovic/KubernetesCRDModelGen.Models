#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgenetwork.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeNetworkNetworkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EdgeNetworkNetwork>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeNetworkNetworkList";
    public const string KubeGroup = "edgenetwork.cnrm.cloud.google.com";
    public const string KubePluralName = "edgenetworknetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "edgenetwork.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EdgeNetworkNetworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1EdgeNetworkNetwork objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1EdgeNetworkNetwork> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkNetworkSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkNetworkSpec
{
    /// <summary>Immutable. A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The Google Cloud region to which the target Distributed Cloud Edge zone belongs.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Immutable. IP (L3) MTU value of the network. Default value is &apos;1500&apos;. Possible values are: &apos;1500&apos;, &apos;9000&apos;.</summary>
    [JsonPropertyName("mtu")]
    public int? Mtu { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1EdgeNetworkNetworkSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The networkId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The name of the target Distributed Cloud Edge zone.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeNetworkNetworkStatusConditions
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
public partial class V1beta1EdgeNetworkNetworkStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EdgeNetworkNetworkStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The time when the subnet was created.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &apos;2014-10-02T15:01:23Z&apos; and &apos;2014-10-02T15:01:23.045123456Z&apos;.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// The canonical name of this resource, with format
    /// &apos;projects/{{project}}/locations/{{location}}/zones/{{zone}}/networks/{{network_id}}&apos;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>
    /// The time when the subnet was last updated.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &apos;2014-10-02T15:01:23Z&apos; and &apos;2014-10-02T15:01:23.045123456Z&apos;.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeNetworkNetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EdgeNetworkNetworkSpec>, IStatus<V1beta1EdgeNetworkNetworkStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeNetworkNetwork";
    public const string KubeGroup = "edgenetwork.cnrm.cloud.google.com";
    public const string KubePluralName = "edgenetworknetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "edgenetwork.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EdgeNetworkNetwork";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1EdgeNetworkNetworkSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1EdgeNetworkNetworkStatus? Status { get; set; }
}