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
/// <summary>Warehouse is a source of Freight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WarehouseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Warehouse>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WarehouseList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "warehouses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WarehouseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Warehouse objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Warehouse> Items { get; set; }
}

/// <summary>
/// FreightCreationCriteria defines criteria that must be satisfied for Freight
/// to be created automatically from new artifacts following discovery. This
/// field has no effect when the FreightCreationPolicy is `Manual`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseSpecFreightCreationCriteria
{
    /// <summary>
    /// Expression is an expr-lang expression that must evaluate to true for
    /// Freight to be created automatically from new artifacts following discovery.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>
/// FreightCreationPolicy describes how Freight is created by this Warehouse.
/// This field is optional. When left unspecified, the field is implicitly
/// treated as if its value were &quot;Automatic&quot;.
/// 
/// Accepted values:
/// 
/// - &quot;Automatic&quot;: New Freight is created automatically when any new artifact
///   is discovered.
/// - &quot;Manual&quot;: New Freight is never created automatically.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WarehouseSpecFreightCreationPolicyEnum>))]
public enum V1alpha1WarehouseSpecFreightCreationPolicyEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>Spec describes sources of artifacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseSpec
{
    /// <summary>
    /// FreightCreationCriteria defines criteria that must be satisfied for Freight
    /// to be created automatically from new artifacts following discovery. This
    /// field has no effect when the FreightCreationPolicy is `Manual`.
    /// </summary>
    [JsonPropertyName("freightCreationCriteria")]
    public V1alpha1WarehouseSpecFreightCreationCriteria? FreightCreationCriteria { get; set; }

    /// <summary>
    /// FreightCreationPolicy describes how Freight is created by this Warehouse.
    /// This field is optional. When left unspecified, the field is implicitly
    /// treated as if its value were &quot;Automatic&quot;.
    /// 
    /// Accepted values:
    /// 
    /// - &quot;Automatic&quot;: New Freight is created automatically when any new artifact
    ///   is discovered.
    /// - &quot;Manual&quot;: New Freight is never created automatically.
    /// </summary>
    [JsonPropertyName("freightCreationPolicy")]
    public V1alpha1WarehouseSpecFreightCreationPolicyEnum? FreightCreationPolicy { get; set; }

    /// <summary>
    /// Interval is the reconciliation interval for this Warehouse. On each
    /// reconciliation, the Warehouse will discover new artifacts and optionally
    /// produce new Freight. This field is optional. When left unspecified, the
    /// field is implicitly treated as if its value were &quot;5m0s&quot;.
    /// </summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>
    /// Shard is the name of the shard that this Warehouse belongs to. This is an
    /// optional field. If not specified, the Warehouse will belong to the default
    /// shard. A defaulting webhook will sync this field with the value of the
    /// kargo.akuity.io/shard label. When the shard label is not present or differs
    /// from the value of this field, the defaulting webhook will set the label to
    /// the value of this field. If the shard label is present and this field is
    /// empty, the defaulting webhook will set the value of this field to the value
    /// of the shard label.
    /// </summary>
    [JsonPropertyName("shard")]
    public string? Shard { get; set; }

    /// <summary>
    /// Subscriptions describes sources of artifacts to be included in Freight
    /// produced by this Warehouse.
    /// </summary>
    [JsonPropertyName("subscriptions")]
    public required IList<JsonNode> Subscriptions { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WarehouseStatusConditionsStatusEnum>))]
public enum V1alpha1WarehouseStatusConditionsStatusEnum
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
public partial class V1alpha1WarehouseStatusConditions
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
    public required V1alpha1WarehouseStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// ChartDiscoveryResult represents the result of a chart discovery operation for
/// a ChartSubscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsCharts
{
    /// <summary>Name is the name of the Helm chart, as specified in the ChartSubscription.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL is the repository URL of the Helm chart, as specified in the
    /// ChartSubscription.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public required string RepoURL { get; set; }

    /// <summary>
    /// SemverConstraint is the constraint for which versions were discovered.
    /// This field is optional, and only populated if the ChartSubscription
    /// specifies a SemverConstraint.
    /// </summary>
    [JsonPropertyName("semverConstraint")]
    public string? SemverConstraint { get; set; }

    /// <summary>
    /// Versions is a list of versions discovered by the Warehouse for the
    /// ChartSubscription. An empty list indicates that the discovery operation was
    /// successful, but no versions matching the ChartSubscription criteria were
    /// found.
    /// </summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

/// <summary>
/// DiscoveredCommit represents a commit discovered by a Warehouse for a
/// GitSubscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsGitCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>
    /// Branch is the branch in which the commit was found. This field is
    /// optional, and populated based on the CommitSelectionStrategy of the
    /// GitSubscription.
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// CreatorDate is the commit creation date as specified by the commit, or
    /// the tagger date if the commit belongs to an annotated tag.
    /// </summary>
    [JsonPropertyName("creatorDate")]
    public DateTime? CreatorDate { get; set; }

    /// <summary>ID is the identifier of the commit. This typically is a SHA-1 hash.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Subject is the subject of the commit (i.e. the first line of the commit
    /// message).
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// Tag is the tag that resolved to this commit. This field is optional, and
    /// populated based on the CommitSelectionStrategy of the GitSubscription.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// GitDiscoveryResult represents the result of a Git discovery operation for a
/// GitSubscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsGit
{
    /// <summary>
    /// Commits is a list of commits discovered by the Warehouse for the
    /// GitSubscription. An empty list indicates that the discovery operation was
    /// successful, but no commits matching the GitSubscription criteria were found.
    /// </summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsGitCommits>? Commits { get; set; }

    /// <summary>
    /// RepoURL is the repository URL of the GitSubscription.
    /// 
    /// </summary>
    [JsonPropertyName("repoURL")]
    public required string RepoURL { get; set; }
}

/// <summary>
/// DiscoveredImageReference represents an image reference discovered by a
/// Warehouse for an ImageSubscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsImagesReferences
{
    /// <summary>
    /// Annotations is a map of key-value pairs that provide additional
    /// information about the image.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// CreatedAt is the time the image was created. This field is optional, and
    /// not populated for every ImageSelectionStrategy.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>Digest is the digest of the image.</summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>Tag is the tag of the image.</summary>
    [JsonPropertyName("tag")]
    public required string Tag { get; set; }
}

/// <summary>
/// ImageDiscoveryResult represents the result of an image discovery operation
/// for an ImageSubscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsImages
{
    /// <summary>
    /// Platform is the target platform constraint of the ImageSubscription
    /// for which references were discovered. This field is optional, and
    /// only populated if the ImageSubscription specifies a Platform.
    /// </summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// References is a list of image references discovered by the Warehouse for
    /// the ImageSubscription. An empty list indicates that the discovery
    /// operation was successful, but no images matching the ImageSubscription
    /// criteria were found.
    /// </summary>
    [JsonPropertyName("references")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsImagesReferences>? References { get; set; }

    /// <summary>
    /// RepoURL is the repository URL of the image, as specified in the
    /// ImageSubscription.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public required string RepoURL { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsResultsArtifactReferences
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

/// <summary>
/// DiscoveryResult represents the result of an artifact discovery operation for
/// some subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifactsResults
{
    /// <summary>
    /// ArtifactReferences is a list of references to specific versions of an
    /// artifact.
    /// </summary>
    [JsonPropertyName("artifactReferences")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsResultsArtifactReferences>? ArtifactReferences { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered these
    /// results.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DiscoveredArtifacts holds the artifacts discovered by the Warehouse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatusDiscoveredArtifacts
{
    /// <summary>
    /// Charts holds the charts discovered by the Warehouse for the chart
    /// subscriptions.
    /// </summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsCharts>? Charts { get; set; }

    /// <summary>DiscoveredAt is the time at which the Warehouse discovered the artifacts.</summary>
    [JsonPropertyName("discoveredAt")]
    public DateTime? DiscoveredAt { get; set; }

    /// <summary>
    /// Git holds the commits discovered by the Warehouse for the Git
    /// subscriptions.
    /// </summary>
    [JsonPropertyName("git")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsGit>? Git { get; set; }

    /// <summary>
    /// Images holds the image references discovered by the Warehouse for the
    /// image subscriptions.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsImages>? Images { get; set; }

    /// <summary>Results holds the artifact references discovered by the Warehouse.</summary>
    [JsonPropertyName("results")]
    public IList<V1alpha1WarehouseStatusDiscoveredArtifactsResults>? Results { get; set; }
}

/// <summary>Status describes the Warehouse&apos;s most recently observed state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WarehouseStatus
{
    /// <summary>
    /// Conditions contains the last observations of the Warehouse&apos;s current
    /// state.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WarehouseStatusConditions>? Conditions { get; set; }

    /// <summary>DiscoveredArtifacts holds the artifacts discovered by the Warehouse.</summary>
    [JsonPropertyName("discoveredArtifacts")]
    public V1alpha1WarehouseStatusDiscoveredArtifacts? DiscoveredArtifacts { get; set; }

    /// <summary>
    /// LastFreightID is a reference to the system-assigned identifier (name) of
    /// the most recent Freight produced by the Warehouse.
    /// </summary>
    [JsonPropertyName("lastFreightID")]
    public string? LastFreightID { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that this Warehouse
    /// was reconciled against.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Warehouse is a source of Freight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Warehouse : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WarehouseSpec>, IStatus<V1alpha1WarehouseStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Warehouse";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "warehouses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Warehouse";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec describes sources of artifacts.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1WarehouseSpec Spec { get; set; }

    /// <summary>Status describes the Warehouse&apos;s most recently observed state.</summary>
    [JsonPropertyName("status")]
    public V1alpha1WarehouseStatus? Status { get; set; }
}