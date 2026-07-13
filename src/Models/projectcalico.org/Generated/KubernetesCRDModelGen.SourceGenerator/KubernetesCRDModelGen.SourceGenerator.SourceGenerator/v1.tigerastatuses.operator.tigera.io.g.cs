#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.@operator.tigera.io;
/// <summary>TigeraStatus represents the most recently observed status for Calico or a Calico Enterprise functional area.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1TigeraStatusList : IKubernetesObject<V1ListMeta>, IItems<V1TigeraStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "TigeraStatusList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "tigerastatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TigeraStatusList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1TigeraStatus objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1TigeraStatus> Items { get; set; }
}

/// <summary>TigeraStatusSpec defines the desired state of TigeraStatus</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TigeraStatusSpec
{
}

/// <summary>TigeraStatusCondition represents a condition attached to a particular component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TigeraStatusStatusConditions
{
    /// <summary>The timestamp representing the start time for the current status.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Optionally, a detailed message providing additional context.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// observedGeneration represents the generation that the condition was set based upon.
    /// For instance, if generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A brief reason explaining the condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>The status of the condition. May be True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>The type of condition. May be Available, Progressing, or Degraded.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>TigeraStatusStatus defines the observed state of TigeraStatus</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TigeraStatusStatus
{
    /// <summary>
    /// Conditions represents the latest observed set of conditions for this component. A component may be one or more of
    /// Available, Progressing, or Degraded.
    /// </summary>
    [JsonPropertyName("conditions")]
    public required IList<V1TigeraStatusStatusConditions> Conditions { get; set; }
}

/// <summary>TigeraStatus represents the most recently observed status for Calico or a Calico Enterprise functional area.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1TigeraStatus : IKubernetesObject<V1ObjectMeta>, ISpec<V1TigeraStatusSpec?>, IStatus<V1TigeraStatusStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "TigeraStatus";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "tigerastatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TigeraStatus";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TigeraStatusSpec defines the desired state of TigeraStatus</summary>
    [JsonPropertyName("spec")]
    public V1TigeraStatusSpec? Spec { get; set; }

    /// <summary>TigeraStatusStatus defines the observed state of TigeraStatus</summary>
    [JsonPropertyName("status")]
    public V1TigeraStatusStatus? Status { get; set; }
}