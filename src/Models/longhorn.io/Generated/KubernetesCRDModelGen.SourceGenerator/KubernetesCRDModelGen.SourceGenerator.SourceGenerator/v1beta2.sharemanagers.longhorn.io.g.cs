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
/// <summary>ShareManager is where Longhorn stores share manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ShareManagerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ShareManager>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ShareManagerList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "sharemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShareManagerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ShareManager objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ShareManager> Items { get; set; }
}

/// <summary>ShareManagerSpec defines the desired state of the Longhorn share manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShareManagerSpec
{
    /// <summary>Share manager image used for creating a share manager pod</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
}

/// <summary>ShareManagerStatus defines the observed state of the Longhorn share manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShareManagerStatus
{
    /// <summary>The image currently used by the share manager pod</summary>
    [JsonPropertyName("currentImage")]
    public string? CurrentImage { get; set; }

    /// <summary>NFS endpoint that can access the mounted filesystem of the volume</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this share manager resource</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The state of the share manager resource</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ShareManager is where Longhorn stores share manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ShareManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ShareManagerSpec?>, IStatus<V1beta2ShareManagerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ShareManager";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "sharemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShareManager";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ShareManagerSpec defines the desired state of the Longhorn share manager</summary>
    [JsonPropertyName("spec")]
    public V1beta2ShareManagerSpec? Spec { get; set; }

    /// <summary>ShareManagerStatus defines the observed state of the Longhorn share manager</summary>
    [JsonPropertyName("status")]
    public V1beta2ShareManagerStatus? Status { get; set; }
}