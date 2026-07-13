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
/// <summary>SupportBundle is where Longhorn stores support bundle object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SupportBundleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SupportBundle>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SupportBundleList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "supportbundles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SupportBundleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SupportBundle objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SupportBundle> Items { get; set; }
}

/// <summary>SupportBundleSpec defines the desired state of the Longhorn SupportBundle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SupportBundleSpec
{
    /// <summary>A brief description of the issue</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>The issue URL</summary>
    [JsonPropertyName("issueURL")]
    public string? IssueURL { get; set; }

    /// <summary>The preferred responsible controller node ID.</summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SupportBundleStatusConditions
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

/// <summary>SupportBundleStatus defines the observed state of the Longhorn SupportBundle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SupportBundleStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta2SupportBundleStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("filesize")]
    public long? Filesize { get; set; }

    /// <summary>The support bundle manager image</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The support bundle manager IP</summary>
    [JsonPropertyName("managerIP")]
    public string? ManagerIP { get; set; }

    /// <summary>The current responsible controller node ID</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>SupportBundle is where Longhorn stores support bundle object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SupportBundle : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SupportBundleSpec?>, IStatus<V1beta2SupportBundleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SupportBundle";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "supportbundles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SupportBundle";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SupportBundleSpec defines the desired state of the Longhorn SupportBundle</summary>
    [JsonPropertyName("spec")]
    public V1beta2SupportBundleSpec? Spec { get; set; }

    /// <summary>SupportBundleStatus defines the observed state of the Longhorn SupportBundle</summary>
    [JsonPropertyName("status")]
    public V1beta2SupportBundleStatus? Status { get; set; }
}