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
/// <summary>Freight represents a collection of versioned artifacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FreightList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Freight>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FreightList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "freights";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FreightList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Freight objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Freight> Items { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1FreightOriginKindEnum>))]
public enum V1alpha1FreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1FreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ApprovedStage describes a Stage for which Freight has been (manually)
/// approved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightStatusApprovedFor
{
    /// <summary>ApprovedAt is the time at which the Freight was approved for the Stage.</summary>
    [JsonPropertyName("approvedAt")]
    public DateTime? ApprovedAt { get; set; }
}

/// <summary>CurrentStage reflects a Stage&apos;s current use of Freight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightStatusCurrentlyIn
{
    /// <summary>
    /// Since is the time at which the Stage most recently started using the
    /// Freight. This can be used to calculate how long the Freight has been in use
    /// by the Stage.
    /// </summary>
    [JsonPropertyName("since")]
    public DateTime? Since { get; set; }
}

/// <summary>VerifiedStage describes a Stage in which Freight has been verified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightStatusVerifiedIn
{
    /// <summary>
    /// LongestCompletedSoak represents the longest definite time interval wherein
    /// the Freight was in CONTINUOUS use by the Stage. This value is updated as
    /// Freight EXITS the Stage. If the Freight is currently in use by the Stage,
    /// the time elapsed since the Freight ENTERED the Stage is its current soak
    /// time, which may exceed the value of this field.
    /// </summary>
    [JsonPropertyName("longestSoak")]
    public string? LongestSoak { get; set; }

    /// <summary>VerifiedAt is the time at which the Freight was verified in the Stage.</summary>
    [JsonPropertyName("verifiedAt")]
    public DateTime? VerifiedAt { get; set; }
}

/// <summary>Status describes the current status of this Freight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FreightStatus
{
    /// <summary>
    /// ApprovedFor describes the Stages for which this Freight has been approved
    /// preemptively/manually by a user. This is useful for hotfixes, where one
    /// might wish to promote a piece of Freight to a given Stage without
    /// transiting the entire pipeline.
    /// </summary>
    [JsonPropertyName("approvedFor")]
    public IDictionary<string, V1alpha1FreightStatusApprovedFor>? ApprovedFor { get; set; }

    /// <summary>CurrentlyIn describes the Stages in which this Freight is currently in use.</summary>
    [JsonPropertyName("currentlyIn")]
    public IDictionary<string, V1alpha1FreightStatusCurrentlyIn>? CurrentlyIn { get; set; }

    /// <summary>
    /// Metadata is a map of arbitrary metadata associated with the Freight.
    /// This is useful for storing additional information about the Freight
    /// or Promotion that can be shared across steps or stages.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    /// <summary>
    /// VerifiedIn describes the Stages in which this Freight has been verified
    /// through promotion and subsequent health checks.
    /// </summary>
    [JsonPropertyName("verifiedIn")]
    public IDictionary<string, V1alpha1FreightStatusVerifiedIn>? VerifiedIn { get; set; }
}

/// <summary>Freight represents a collection of versioned artifacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Freight : IKubernetesObject<V1ObjectMeta>, IStatus<V1alpha1FreightStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Freight";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "freights";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Freight";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Alias is a human-friendly alias for a piece of Freight. This is an optional
    /// field. A defaulting webhook will sync this field with the value of the
    /// kargo.akuity.io/alias label. When the alias label is not present or differs
    /// from the value of this field, the defaulting webhook will set the label to
    /// the value of this field. If the alias label is present and this field is
    /// empty, the defaulting webhook will set the value of this field to the value
    /// of the alias label. If this field is empty and the alias label is not
    /// present, the defaulting webhook will choose an available alias and assign
    /// it to both the field and label.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1FreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1FreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1FreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1FreightImages>? Images { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public required V1alpha1FreightOrigin Origin { get; set; }

    /// <summary>Status describes the current status of this Freight.</summary>
    [JsonPropertyName("status")]
    public V1alpha1FreightStatus? Status { get; set; }
}