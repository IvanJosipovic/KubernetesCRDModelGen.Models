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
/// <summary>
/// Target represents a single destination -- a cluster, for instance -- that
/// Stages promote Freight to. A Target is descriptive: it holds target-specific
/// values consumed by the promotion steps of Stages that govern it. It defines
/// no promotion steps and no Freight sources of its own and therefore cannot
/// effect any promotion itself. Its status records, per governing Stage, what
/// Freight was last promoted to it and how that Freight is faring there.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TargetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Target>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TargetList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Target objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Target> Items { get; set; }
}

/// <summary>Spec describes the Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetSpec
{
    /// <summary>
    /// Params is a map of arbitrary, target-specific values. Values may be any
    /// valid JSON -- including nested objects and arrays -- so promotion steps
    /// can reference deeply nested data. Promotion steps of Stages that govern
    /// this Target may reference these values by key in their expressions (for
    /// example, target.params.branch or target.params.cluster.region).
    /// </summary>
    [JsonPropertyName("params")]
    public IDictionary<string, JsonNode>? Params { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItemsArtifacts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItemsCharts
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

    /// <summary>
    /// SubscriptionName is the name of the subscription that discovered this
    /// chart. This field is only populated if the subscription was assigned
    /// a name.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItemsCommits
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
    /// SubscriptionName is the name of the subscription that discovered this
    /// commit. This field is only populated if the subscription was assigned
    /// a name.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItemsImages
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
    /// SubscriptionName is the name of the subscription that discovered this
    /// image. This field is only populated if the subscription was assigned
    /// a name.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TargetStatusStagesCurrentFreightItemsOriginKindEnum>))]
public enum V1alpha1TargetStatusStagesCurrentFreightItemsOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItemsOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1TargetStatusStagesCurrentFreightItemsOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// FreightReference is a simplified representation of a piece of Freight -- not
/// a root resource type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightItems
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1TargetStatusStagesCurrentFreightItemsArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1TargetStatusStagesCurrentFreightItemsCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1TargetStatusStagesCurrentFreightItemsCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1TargetStatusStagesCurrentFreightItemsImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1TargetStatusStagesCurrentFreightItemsOrigin? Origin { get; set; }
}

/// <summary>
/// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
/// the Verification process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightVerificationHistoryAnalysisRun
{
    /// <summary>Name is the name of the AnalysisRun.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the AnalysisRun.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>Phase is the last observed phase of the AnalysisRun referenced by Name.</summary>
    [JsonPropertyName("phase")]
    public required string Phase { get; set; }
}

/// <summary>
/// VerificationInfo contains the details of an instance of a Verification
/// process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreightVerificationHistory
{
    /// <summary>
    /// Actor is the name of the entity that initiated or aborted the
    /// Verification process.
    /// </summary>
    [JsonPropertyName("actor")]
    public string? Actor { get; set; }

    /// <summary>
    /// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
    /// the Verification process.
    /// </summary>
    [JsonPropertyName("analysisRun")]
    public V1alpha1TargetStatusStagesCurrentFreightVerificationHistoryAnalysisRun? AnalysisRun { get; set; }

    /// <summary>FinishTime is the time at which the Verification process finished.</summary>
    [JsonPropertyName("finishTime")]
    public DateTime? FinishTime { get; set; }

    /// <summary>ID is the identifier of the Verification process.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message may contain additional information about why the verification
    /// process is in its current phase.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Phase describes the current phase of the Verification process. Generally,
    /// this will be a reflection of the underlying AnalysisRun&apos;s phase, however,
    /// there are exceptions to this, such as in the case where an AnalysisRun
    /// cannot be launched successfully.
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartTime is the time at which the Verification process was started.</summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>
/// CurrentFreight is the FreightCollection that the Stage&apos;s most recent
/// successful Promotion to this Target rendered. Because a Stage may
/// request Freight from several origins and a single Promotion changes
/// only one of them, this is a collection rather than a single Freight
/// reference: it holds one entry per origin, exactly as the Stage&apos;s own
/// current collection does, so the Target&apos;s full desired state is known
/// even for origins the latest Promotion did not touch.
/// 
/// The collection is copied from the Promotion&apos;s status rather than
/// derived from this Target&apos;s previous state, so a Target that missed a
/// round or was newly discovered converges to the Stage&apos;s desired state
/// on its next successful Promotion. Its ID is deterministic in its
/// contents, so a Target that received the same round as the Stage carries
/// the same ID as the Stage&apos;s current collection; comparing the two tells
/// whether the Target is up to date. Its verification history records
/// verifications of this Freight on this Target specifically.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesCurrentFreight
{
    /// <summary>
    /// ID is a unique and deterministically calculated identifier for the
    /// FreightCollection. It is updated on each use of the UpdateOrPush method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Freight is a map of FreightReference objects, indexed by their Warehouse
    /// origin.
    /// </summary>
    [JsonPropertyName("items")]
    public IDictionary<string, V1alpha1TargetStatusStagesCurrentFreightItems>? Items { get; set; }

    /// <summary>
    /// VerificationHistory is a stack of recent VerificationInfo. By default,
    /// the last ten VerificationInfo are stored.
    /// </summary>
    [JsonPropertyName("verificationHistory")]
    public IList<V1alpha1TargetStatusStagesCurrentFreightVerificationHistory>? VerificationHistory { get; set; }
}

/// <summary>
/// Health is the Target&apos;s health with respect to this Stage&apos;s Freight, as
/// last assessed by executing HealthChecks. It is absent until the first
/// assessment. Health is an ongoing observation rather than a Promotion
/// outcome: it is reassessed periodically and whenever the systems the
/// health checks observe change, so it may become Unhealthy long after the
/// Promotion that produced CurrentFreight succeeded.
/// 
/// A target-aware Stage does not assess health itself. Its own health is
/// an aggregate of this field across every Target it governs: Healthy only
/// when each is Healthy and on the Stage&apos;s current Freight, Unhealthy when
/// any is not, Unknown while any has yet to be assessed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesHealth
{
    /// <summary>
    /// Config is the opaque configuration of all health checks performed on this
    /// Stage.
    /// </summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>
    /// Issues clarifies why a Stage in any state other than Healthy is in that
    /// state. This field will always be the empty when a Stage is Healthy.
    /// </summary>
    [JsonPropertyName("issues")]
    public IList<string>? Issues { get; set; }

    /// <summary>Output is the opaque output of all health checks performed on this Stage.</summary>
    [JsonPropertyName("output")]
    public JsonNode? Output { get; set; }

    /// <summary>Status describes the health of the Stage.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// HealthCheckStep describes a health check directive which can be executed by
/// a Stage to verify the health of a Promotion result.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStagesHealthChecks
{
    /// <summary>Config is the configuration for the directive.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public required string Uses { get; set; }
}

/// <summary>
/// TargetStageStatus describes a Target&apos;s state with respect to a single Stage
/// that governs it: the Freight that Stage last successfully promoted to the
/// Target, the health checks that Promotion left behind, and the Target&apos;s
/// current health as assessed from them. It is the per-Target counterpart of
/// the current Freight, health, and verification state a Stage keeps for
/// itself.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatusStages
{
    /// <summary>
    /// CurrentFreight is the FreightCollection that the Stage&apos;s most recent
    /// successful Promotion to this Target rendered. Because a Stage may
    /// request Freight from several origins and a single Promotion changes
    /// only one of them, this is a collection rather than a single Freight
    /// reference: it holds one entry per origin, exactly as the Stage&apos;s own
    /// current collection does, so the Target&apos;s full desired state is known
    /// even for origins the latest Promotion did not touch.
    /// 
    /// The collection is copied from the Promotion&apos;s status rather than
    /// derived from this Target&apos;s previous state, so a Target that missed a
    /// round or was newly discovered converges to the Stage&apos;s desired state
    /// on its next successful Promotion. Its ID is deterministic in its
    /// contents, so a Target that received the same round as the Stage carries
    /// the same ID as the Stage&apos;s current collection; comparing the two tells
    /// whether the Target is up to date. Its verification history records
    /// verifications of this Freight on this Target specifically.
    /// </summary>
    [JsonPropertyName("currentFreight")]
    public V1alpha1TargetStatusStagesCurrentFreight? CurrentFreight { get; set; }

    /// <summary>
    /// Health is the Target&apos;s health with respect to this Stage&apos;s Freight, as
    /// last assessed by executing HealthChecks. It is absent until the first
    /// assessment. Health is an ongoing observation rather than a Promotion
    /// outcome: it is reassessed periodically and whenever the systems the
    /// health checks observe change, so it may become Unhealthy long after the
    /// Promotion that produced CurrentFreight succeeded.
    /// 
    /// A target-aware Stage does not assess health itself. Its own health is
    /// an aggregate of this field across every Target it governs: Healthy only
    /// when each is Healthy and on the Stage&apos;s current Freight, Unhealthy when
    /// any is not, Unknown while any has yet to be assessed.
    /// </summary>
    [JsonPropertyName("health")]
    public V1alpha1TargetStatusStagesHealth? Health { get; set; }

    /// <summary>
    /// HealthChecks are the health check directives produced by the steps of
    /// the Stage&apos;s most recent successful Promotion to this Target -- for
    /// instance, which Argo CD Applications that Promotion updated and to what
    /// revisions. They are the input from which Health is assessed, and they
    /// are recorded here because Health must be reassessed for as long as
    /// CurrentFreight remains on the Target, while the Promotion that produced
    /// them is eventually garbage collected. A Stage keeps the same
    /// information for itself in its lastPromotion.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1alpha1TargetStatusStagesHealthChecks>? HealthChecks { get; set; }
}

/// <summary>Status describes the current status of the Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetStatus
{
    /// <summary>
    /// Stages records the Target&apos;s state with respect to each Stage that
    /// governs it, keyed by Stage name. A Target may be governed by several
    /// Stages at once, each promoting its own Freight to it, so everything
    /// observed about the Target is scoped to the Stage that observed it.
    /// This mirrors how Freight status keys currentlyIn, verifiedIn, and
    /// approvedFor by Stage name.
    /// 
    /// An entry exists only once a Promotion from that Stage to this Target
    /// has succeeded. A Stage that governs the Target but has never promoted
    /// to it has no entry.
    /// </summary>
    [JsonPropertyName("stages")]
    public IDictionary<string, V1alpha1TargetStatusStages>? Stages { get; set; }
}

/// <summary>
/// Target represents a single destination -- a cluster, for instance -- that
/// Stages promote Freight to. A Target is descriptive: it holds target-specific
/// values consumed by the promotion steps of Stages that govern it. It defines
/// no promotion steps and no Freight sources of its own and therefore cannot
/// effect any promotion itself. Its status records, per governing Stage, what
/// Freight was last promoted to it and how that Freight is faring there.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Target : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TargetSpec?>, IStatus<V1alpha1TargetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Target";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Target";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec describes the Target.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TargetSpec? Spec { get; set; }

    /// <summary>Status describes the current status of the Target.</summary>
    [JsonPropertyName("status")]
    public V1alpha1TargetStatus? Status { get; set; }
}