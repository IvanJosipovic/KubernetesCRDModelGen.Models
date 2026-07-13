#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.toolkit.fluxcd.io;
/// <summary>ExternalArtifact is the Schema for the external artifacts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ExternalArtifactList : IKubernetesObject<V1ListMeta>, IItems<V1ExternalArtifact>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ExternalArtifactList";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "externalartifacts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExternalArtifactList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ExternalArtifact objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ExternalArtifact> Items { get; set; }
}

/// <summary>
/// SourceRef points to the Kubernetes custom resource for
/// which the artifact is generated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ExternalArtifactSpecSourceRef
{
    /// <summary>API version of the referent, if not specified the Kubernetes preferred version will be used.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ExternalArtifactSpec defines the desired state of ExternalArtifact</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ExternalArtifactSpec
{
    /// <summary>
    /// SourceRef points to the Kubernetes custom resource for
    /// which the artifact is generated.
    /// </summary>
    [JsonPropertyName("sourceRef")]
    public V1ExternalArtifactSpecSourceRef? SourceRef { get; set; }
}

/// <summary>Artifact represents the output of an ExternalArtifact reconciliation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ExternalArtifactStatusArtifact
{
    /// <summary>Digest is the digest of the file in the form of &apos; &lt;algorithm&gt;:&lt;checksum&gt; &apos;.</summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>
    /// LastUpdateTime is the timestamp corresponding to the last update of the
    /// Artifact.
    /// </summary>
    [JsonPropertyName("lastUpdateTime")]
    public required DateTime LastUpdateTime { get; set; }

    /// <summary>Metadata holds upstream information such as OCI annotations.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Path is the relative file path of the Artifact. It can be used to locate
    /// the file in the root of the Artifact storage on the local file system of
    /// the controller managing the Source.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// Revision is a human-readable identifier traceable in the origin source
    /// system. It can be a Git commit SHA, Git tag, a Helm chart version, etc.
    /// </summary>
    [JsonPropertyName("revision")]
    public required string Revision { get; set; }

    /// <summary>Size is the number of bytes in the file.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// URL is the HTTP address of the Artifact as exposed by the controller
    /// managing the Source. It can be used to retrieve the Artifact for
    /// consumption, e.g. by another controller applying the Artifact contents.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ExternalArtifactStatusConditionsStatusEnum>))]
public enum V1ExternalArtifactStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ExternalArtifactStatusConditions
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
    public required V1ExternalArtifactStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ExternalArtifactStatus defines the observed state of ExternalArtifact</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ExternalArtifactStatus
{
    /// <summary>Artifact represents the output of an ExternalArtifact reconciliation.</summary>
    [JsonPropertyName("artifact")]
    public V1ExternalArtifactStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the ExternalArtifact.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ExternalArtifactStatusConditions>? Conditions { get; set; }
}

/// <summary>ExternalArtifact is the Schema for the external artifacts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ExternalArtifact : IKubernetesObject<V1ObjectMeta>, ISpec<V1ExternalArtifactSpec?>, IStatus<V1ExternalArtifactStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ExternalArtifact";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "externalartifacts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExternalArtifact";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExternalArtifactSpec defines the desired state of ExternalArtifact</summary>
    [JsonPropertyName("spec")]
    public V1ExternalArtifactSpec? Spec { get; set; }

    /// <summary>ExternalArtifactStatus defines the observed state of ExternalArtifact</summary>
    [JsonPropertyName("status")]
    public V1ExternalArtifactStatus? Status { get; set; }
}