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
/// <summary>EngineImage is where Longhorn stores engine image object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EngineImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2EngineImage>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EngineImageList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "engineimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EngineImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2EngineImage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2EngineImage> Items { get; set; }
}

/// <summary>EngineImageSpec defines the desired state of the Longhorn engine image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineImageSpec
{
    [JsonPropertyName("image")]
    public required string Image { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineImageStatusConditions
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

/// <summary>EngineImageStatus defines the observed state of the Longhorn engine image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineImageStatus
{
    [JsonPropertyName("buildDate")]
    public string? BuildDate { get; set; }

    [JsonPropertyName("cliAPIMinVersion")]
    public int? CliAPIMinVersion { get; set; }

    [JsonPropertyName("cliAPIVersion")]
    public int? CliAPIVersion { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2EngineImageStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("controllerAPIMinVersion")]
    public int? ControllerAPIMinVersion { get; set; }

    [JsonPropertyName("controllerAPIVersion")]
    public int? ControllerAPIVersion { get; set; }

    [JsonPropertyName("dataFormatMinVersion")]
    public int? DataFormatMinVersion { get; set; }

    [JsonPropertyName("dataFormatVersion")]
    public int? DataFormatVersion { get; set; }

    [JsonPropertyName("gitCommit")]
    public string? GitCommit { get; set; }

    [JsonPropertyName("incompatible")]
    public bool? Incompatible { get; set; }

    [JsonPropertyName("noRefSince")]
    public string? NoRefSince { get; set; }

    [JsonPropertyName("nodeDeploymentMap")]
    public IDictionary<string, bool>? NodeDeploymentMap { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("refCount")]
    public int? RefCount { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EngineImage is where Longhorn stores engine image object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EngineImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EngineImageSpec?>, IStatus<V1beta2EngineImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EngineImage";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "engineimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EngineImage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EngineImageSpec defines the desired state of the Longhorn engine image</summary>
    [JsonPropertyName("spec")]
    public V1beta2EngineImageSpec? Spec { get; set; }

    /// <summary>EngineImageStatus defines the observed state of the Longhorn engine image</summary>
    [JsonPropertyName("status")]
    public V1beta2EngineImageStatus? Status { get; set; }
}