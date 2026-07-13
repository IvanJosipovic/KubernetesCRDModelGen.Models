#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.extensions.fluxcd.io;
/// <summary>ArtifactGenerator is the Schema for the artifactgenerators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactGeneratorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ArtifactGenerator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactGeneratorList";
    public const string KubeGroup = "source.extensions.fluxcd.io";
    public const string KubePluralName = "artifactgenerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.extensions.fluxcd.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ArtifactGeneratorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ArtifactGenerator objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ArtifactGenerator> Items { get; set; }
}

/// <summary>
/// Strategy specifies the copy strategy to use.
/// &apos;Overwrite&apos; will overwrite existing files in the destination.
/// &apos;Merge&apos; is for merging YAML files using Helm values merge strategy.
/// &apos;Extract&apos; is for extracting the contents of tarball archives (.tar.gz, .tgz)
/// When using glob patterns, non-tarball files are silently skipped. For single file sources,
/// the file must be a tarball or an error is returned. Directories are not supported.
/// If not specified, defaults to &apos;Overwrite&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ArtifactGeneratorSpecArtifactsCopyStrategyEnum>))]
public enum V1beta1ArtifactGeneratorSpecArtifactsCopyStrategyEnum
{
    [EnumMember(Value = "Overwrite"), JsonStringEnumMemberName("Overwrite")]
    Overwrite,
    [EnumMember(Value = "Merge"), JsonStringEnumMemberName("Merge")]
    Merge,
    [EnumMember(Value = "Extract"), JsonStringEnumMemberName("Extract")]
    Extract
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorSpecArtifactsCopy
{
    /// <summary>
    /// Exclude specifies a list of glob patterns to exclude
    /// files and dirs matched by the &apos;From&apos; field. Patterns are matched
    /// against paths relative to the source alias root or to the non-glob
    /// prefix of &apos;From&apos;. Patterns without a separator (e.g. &quot;*.md&quot;) match
    /// the file name at any depth.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// From specifies the source (by alias) and the glob pattern to match files.
    /// The format is &quot;@&lt;alias&gt;/&lt;glob-pattern&gt; &quot;. When pathPattern is set,
    /// the path may use capture placeholders such as &quot;{app}&quot;.
    /// </summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>
    /// Strategy specifies the copy strategy to use.
    /// &apos;Overwrite&apos; will overwrite existing files in the destination.
    /// &apos;Merge&apos; is for merging YAML files using Helm values merge strategy.
    /// &apos;Extract&apos; is for extracting the contents of tarball archives (.tar.gz, .tgz)
    /// When using glob patterns, non-tarball files are silently skipped. For single file sources,
    /// the file must be a tarball or an error is returned. Directories are not supported.
    /// If not specified, defaults to &apos;Overwrite&apos;.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1beta1ArtifactGeneratorSpecArtifactsCopyStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// To specifies the destination path within the artifact.
    /// The format is &quot;@artifact/path&quot;, the alias &quot;artifact&quot;
    /// refers to the root path of the generated artifact. When pathPattern
    /// is set, the path may use capture placeholders such as &quot;{app}&quot;.
    /// </summary>
    [JsonPropertyName("to")]
    public required string To { get; set; }
}

/// <summary>
/// OutputArtifact defines the desired state of an ExternalArtifact
/// generated by the ArtifactGenerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorSpecArtifacts
{
    /// <summary>
    /// Copy defines a list of copy operations to perform from the sources to the generated artifact.
    /// The copy operations are performed in the order they are listed with existing files
    /// being overwritten by later copy operations.
    /// </summary>
    [JsonPropertyName("copy")]
    public required IList<V1beta1ArtifactGeneratorSpecArtifactsCopy> Copy { get; set; }

    /// <summary>
    /// Name is the name of the generated artifact.
    /// When pathPattern is set, this field may use capture placeholders such as &quot;{app}&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// OriginRevision is used to set the &apos;org.opencontainers.image.revision&apos;
    /// annotation on the generated artifact metadata.
    /// If specified, it must point to an existing source alias in the format &quot;@&lt;alias&gt; &quot;.
    /// If the referenced source has an origin revision (e.g. a Git commit SHA),
    /// it will be used to set the annotation on the generated artifact.
    /// If the referenced source does not have an origin revision, the field is ignored.
    /// </summary>
    [JsonPropertyName("originRevision")]
    public string? OriginRevision { get; set; }

    /// <summary>
    /// Revision is the revision of the generated artifact.
    /// If specified, it must point to an existing source alias in the format &quot;@&lt;alias&gt; &quot;.
    /// If not specified, the revision is automatically set to the digest of the artifact content.
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>
/// CommonMetadata specifies the common labels and annotations that are
/// applied to all resources. Any existing label or annotation will be
/// overridden if its key matches a common one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorSpecCommonMetadata
{
    /// <summary>Annotations to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Kind of the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ArtifactGeneratorSpecSourcesKindEnum>))]
public enum V1beta1ArtifactGeneratorSpecSourcesKindEnum
{
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    HelmChart,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>SourceReference contains the reference to a Flux source-controller resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorSpecSources
{
    /// <summary>
    /// Alias of the source within the ArtifactGenerator context.
    /// The alias must be unique per ArtifactGenerator, and must consist
    /// of lower case alphanumeric characters, underscores, and hyphens.
    /// It must start and end with an alphanumeric character.
    /// </summary>
    [JsonPropertyName("alias")]
    public required string Alias { get; set; }

    /// <summary>Kind of the source.</summary>
    [JsonPropertyName("kind")]
    public required V1beta1ArtifactGeneratorSpecSourcesKindEnum Kind { get; set; }

    /// <summary>Name of the source.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the source.
    /// If not provided, defaults to the same namespace as the ArtifactGenerator.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ArtifactGeneratorSpec defines the desired state of ArtifactGenerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorSpec
{
    /// <summary>OutputArtifacts is a list of output artifacts to be generated.</summary>
    [JsonPropertyName("artifacts")]
    public required IList<V1beta1ArtifactGeneratorSpecArtifacts> Artifacts { get; set; }

    /// <summary>
    /// CommonMetadata specifies the common labels and annotations that are
    /// applied to all resources. Any existing label or annotation will be
    /// overridden if its key matches a common one.
    /// </summary>
    [JsonPropertyName("commonMetadata")]
    public V1beta1ArtifactGeneratorSpecCommonMetadata? CommonMetadata { get; set; }

    /// <summary>
    /// PathPattern specifies a directory traversal pattern to match within the sources.
    /// The format is &quot;@&lt;alias&gt;/&lt;pattern&gt; &quot;. Named captures in the pattern (e.g. &quot;{app}&quot;)
    /// can be used as placeholders in OutputArtifacts fields.
    /// </summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>
    /// Sources is a list of references to the Flux source-controller
    /// resources that will be used to generate the artifact.
    /// </summary>
    [JsonPropertyName("sources")]
    public required IList<V1beta1ArtifactGeneratorSpecSources> Sources { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ArtifactGeneratorStatusConditionsStatusEnum>))]
public enum V1beta1ArtifactGeneratorStatusConditionsStatusEnum
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
public partial class V1beta1ArtifactGeneratorStatusConditions
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
    public required V1beta1ArtifactGeneratorStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// ExternalArtifactReference contains the reference to a
/// generated ExternalArtifact along with its digest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorStatusInventory
{
    /// <summary>Digest of the referent artifact.</summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>Filename is the name of the artifact file.</summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; set; }

    /// <summary>Name of the referent artifact.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent artifact.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ArtifactGeneratorStatus defines the observed state of ArtifactGenerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactGeneratorStatus
{
    /// <summary>Conditions holds the conditions for the ArtifactGenerator.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ArtifactGeneratorStatusConditions>? Conditions { get; set; }

    /// <summary>Inventory contains the list of generated ExternalArtifact references.</summary>
    [JsonPropertyName("inventory")]
    public IList<V1beta1ArtifactGeneratorStatusInventory>? Inventory { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedSourcesDigest is a hash representing the current state of
    /// all the sources referenced by the ArtifactGenerator.
    /// </summary>
    [JsonPropertyName("observedSourcesDigest")]
    public string? ObservedSourcesDigest { get; set; }
}

/// <summary>ArtifactGenerator is the Schema for the artifactgenerators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactGenerator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ArtifactGeneratorSpec?>, IStatus<V1beta1ArtifactGeneratorStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactGenerator";
    public const string KubeGroup = "source.extensions.fluxcd.io";
    public const string KubePluralName = "artifactgenerators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.extensions.fluxcd.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ArtifactGenerator";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ArtifactGeneratorSpec defines the desired state of ArtifactGenerator.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ArtifactGeneratorSpec? Spec { get; set; }

    /// <summary>ArtifactGeneratorStatus defines the observed state of ArtifactGenerator.</summary>
    [JsonPropertyName("status")]
    public V1beta1ArtifactGeneratorStatus? Status { get; set; }
}