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
/// Promotion represents a request to transition a particular Stage into a
/// particular Freight.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PromotionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Promotion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PromotionList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "promotions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PromotionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Promotion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Promotion> Items { get; set; }
}

/// <summary>Retry is the retry policy for this step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpecStepsRetry
{
    /// <summary>
    /// ErrorThreshold is the number of consecutive times the step must fail (for
    /// any reason) before retries are abandoned and the entire Promotion is marked
    /// as failed.
    /// 
    /// If this field is set to 0, the effective default will be a step-specific
    /// one. If no step-specific default exists (i.e. is also 0), the effective
    /// default will be the system-wide default of 1.
    /// 
    /// A value of 1 will cause the Promotion to be marked as failed after just
    /// a single failure; i.e. no retries will be attempted.
    /// 
    /// There is no option to specify an infinite number of retries using a value
    /// such as -1.
    /// 
    /// In a future release, Kargo is likely to become capable of distinguishing
    /// between recoverable and non-recoverable step failures. At that time, it is
    /// planned that unrecoverable failures will not be subject to this threshold
    /// and will immediately cause the Promotion to be marked as failed without
    /// further condition.
    /// </summary>
    [JsonPropertyName("errorThreshold")]
    public int? ErrorThreshold { get; set; }

    /// <summary>
    /// Timeout is the soft maximum interval in which a step that returns a Running
    /// status (which typically indicates it&apos;s waiting for something to happen)
    /// may be retried.
    /// 
    /// The maximum is a soft one because the check for whether the interval has
    /// elapsed occurs AFTER the step has run. This effectively means a step may
    /// run ONCE beyond the close of the interval.
    /// 
    /// If this field is set to nil, the effective default will be a step-specific
    /// one. If no step-specific default exists (i.e. is also nil), the effective
    /// default will be the system-wide default of 0.
    /// 
    /// A value of 0 will cause the step to be retried indefinitely unless the
    /// ErrorThreshold is reached.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// Kind is the type of the PromotionTask. Can be either PromotionTask or
/// ClusterPromotionTask, default is PromotionTask.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PromotionSpecStepsTaskKindEnum>))]
public enum V1alpha1PromotionSpecStepsTaskKindEnum
{
    [EnumMember(Value = "PromotionTask"), JsonStringEnumMemberName("PromotionTask")]
    PromotionTask,
    [EnumMember(Value = "ClusterPromotionTask"), JsonStringEnumMemberName("ClusterPromotionTask")]
    ClusterPromotionTask
}

/// <summary>
/// Task is a reference to a PromotionTask that should be inflated into a
/// Promotion when it is built from a PromotionTemplate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpecStepsTask
{
    /// <summary>
    /// Kind is the type of the PromotionTask. Can be either PromotionTask or
    /// ClusterPromotionTask, default is PromotionTask.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1alpha1PromotionSpecStepsTaskKindEnum? Kind { get; set; }

    /// <summary>Name is the name of the (Cluster)PromotionTask.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ExpressionVariable describes a single variable that may be referenced by
/// expressions in the context of a ClusterPromotionTask, PromotionTask,
/// Promotion, AnalysisRun arguments, or other objects that support expressions.
/// 
/// It is used to pass information to the expression evaluation engine, and to
/// allow for dynamic evaluation of expressions based on the variable values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpecStepsVars
{
    /// <summary>Name is the name of the variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the value of the variable. It is allowed to utilize expressions
    /// in the value.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PromotionStep describes a directive to be executed as part of a Promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpecSteps
{
    /// <summary>As is the alias this step can be referred to as.</summary>
    [JsonPropertyName("as")]
    public string? As { get; set; }

    /// <summary>
    /// Config is opaque configuration for the PromotionStep that is understood
    /// only by each PromotionStep&apos;s implementation. It is legal to utilize
    /// expressions in defining values at any level of this block.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>
    /// ContinueOnError is a boolean value that, if set to true, will cause the
    /// Promotion to continue executing the next step even if this step fails. It
    /// also will not permit this failure to impact the overall status of the
    /// Promotion.
    /// </summary>
    [JsonPropertyName("continueOnError")]
    public bool? ContinueOnError { get; set; }

    /// <summary>
    /// If is an optional expression that, if present, must evaluate to a boolean
    /// value. If the expression evaluates to false, the step will be skipped.
    /// If the expression does not evaluate to a boolean value, the step will be
    /// considered to have failed.
    /// </summary>
    [JsonPropertyName("if")]
    public string? If { get; set; }

    /// <summary>Retry is the retry policy for this step.</summary>
    [JsonPropertyName("retry")]
    public V1alpha1PromotionSpecStepsRetry? Retry { get; set; }

    /// <summary>
    /// Task is a reference to a PromotionTask that should be inflated into a
    /// Promotion when it is built from a PromotionTemplate.
    /// </summary>
    [JsonPropertyName("task")]
    public V1alpha1PromotionSpecStepsTask? Task { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public string? Uses { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced by expressions in
    /// the step&apos;s Config. The values override the values specified in the
    /// PromotionSpec.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1PromotionSpecStepsVars>? Vars { get; set; }
}

/// <summary>
/// ExpressionVariable describes a single variable that may be referenced by
/// expressions in the context of a ClusterPromotionTask, PromotionTask,
/// Promotion, AnalysisRun arguments, or other objects that support expressions.
/// 
/// It is used to pass information to the expression evaluation engine, and to
/// allow for dynamic evaluation of expressions based on the variable values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpecVars
{
    /// <summary>Name is the name of the variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the value of the variable. It is allowed to utilize expressions
    /// in the value.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Spec describes the desired transition of a specific Stage into a specific
/// Freight.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionSpec
{
    /// <summary>
    /// Freight specifies the piece of Freight to be promoted into the Stage
    /// referenced by the Stage field.
    /// </summary>
    [JsonPropertyName("freight")]
    public required string Freight { get; set; }

    /// <summary>
    /// Stage specifies the name of the Stage to which this Promotion
    /// applies. The Stage referenced by this field MUST be in the same
    /// namespace as the Promotion.
    /// </summary>
    [JsonPropertyName("stage")]
    public required string Stage { get; set; }

    /// <summary>
    /// Steps specifies the directives to be executed as part of this Promotion.
    /// The order in which the directives are executed is the order in which they
    /// are listed in this field.
    /// </summary>
    [JsonPropertyName("steps")]
    public required IList<V1alpha1PromotionSpecSteps> Steps { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced by expressions in
    /// promotion steps.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1PromotionSpecVars>? Vars { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightArtifacts
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
public partial class V1alpha1PromotionStatusFreightCharts
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
public partial class V1alpha1PromotionStatusFreightCommits
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
public partial class V1alpha1PromotionStatusFreightImages
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PromotionStatusFreightOriginKindEnum>))]
public enum V1alpha1PromotionStatusFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1PromotionStatusFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreight
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1PromotionStatusFreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1PromotionStatusFreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1PromotionStatusFreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1PromotionStatusFreightImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1PromotionStatusFreightOrigin? Origin { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollectionItemsArtifacts
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
public partial class V1alpha1PromotionStatusFreightCollectionItemsCharts
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
public partial class V1alpha1PromotionStatusFreightCollectionItemsCommits
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
public partial class V1alpha1PromotionStatusFreightCollectionItemsImages
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PromotionStatusFreightCollectionItemsOriginKindEnum>))]
public enum V1alpha1PromotionStatusFreightCollectionItemsOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollectionItemsOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1PromotionStatusFreightCollectionItemsOriginKindEnum Kind { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollectionItems
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1PromotionStatusFreightCollectionItemsArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1PromotionStatusFreightCollectionItemsCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1PromotionStatusFreightCollectionItemsCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1PromotionStatusFreightCollectionItemsImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1PromotionStatusFreightCollectionItemsOrigin? Origin { get; set; }
}

/// <summary>
/// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
/// the Verification process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollectionVerificationHistoryAnalysisRun
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollectionVerificationHistory
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
    public V1alpha1PromotionStatusFreightCollectionVerificationHistoryAnalysisRun? AnalysisRun { get; set; }

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
/// FreightCollection contains the details of the piece of Freight referenced
/// by this Promotion as well as any additional Freight that is carried over
/// from the target Stage&apos;s current state.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusFreightCollection
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
    public IDictionary<string, V1alpha1PromotionStatusFreightCollectionItems>? Items { get; set; }

    /// <summary>
    /// VerificationHistory is a stack of recent VerificationInfo. By default,
    /// the last ten VerificationInfo are stored.
    /// </summary>
    [JsonPropertyName("verificationHistory")]
    public IList<V1alpha1PromotionStatusFreightCollectionVerificationHistory>? VerificationHistory { get; set; }
}

/// <summary>
/// HealthCheckStep describes a health check directive which can be executed by
/// a Stage to verify the health of a Promotion result.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusHealthChecks
{
    /// <summary>Config is the configuration for the directive.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public required string Uses { get; set; }
}

/// <summary>
/// StepExecutionMetadata tracks metadata pertaining to the execution of
/// a promotion step.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatusStepExecutionMetadata
{
    /// <summary>Alias is the alias of the step.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// ContinueOnError is a boolean value that, if set to true, will cause the
    /// Promotion to continue executing the next step even if this step fails. It
    /// also will not permit this failure to impact the overall status of the
    /// Promotion.
    /// </summary>
    [JsonPropertyName("continueOnError")]
    public bool? ContinueOnError { get; set; }

    /// <summary>ErrorCount tracks consecutive failed attempts to execute the step.</summary>
    [JsonPropertyName("errorCount")]
    public int? ErrorCount { get; set; }

    /// <summary>
    /// FinishedAt is the time at which the final attempt to execute the step
    /// completed.
    /// </summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Message is a display message about the step, including any errors.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// StartedAt is the time at which the first attempt to execute the step
    /// began.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>Status is the high-level outcome of the step.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Status describes the current state of the transition represented by this
/// Promotion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PromotionStatus
{
    /// <summary>
    /// CurrentStep is the index of the current promotion step being executed. This
    /// permits steps that have already run successfully to be skipped on
    /// subsequent reconciliations attempts.
    /// </summary>
    [JsonPropertyName("currentStep")]
    public long? CurrentStep { get; set; }

    /// <summary>FinishedAt is the time when the promotion was completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
    [JsonPropertyName("freight")]
    public V1alpha1PromotionStatusFreight? Freight { get; set; }

    /// <summary>
    /// FreightCollection contains the details of the piece of Freight referenced
    /// by this Promotion as well as any additional Freight that is carried over
    /// from the target Stage&apos;s current state.
    /// </summary>
    [JsonPropertyName("freightCollection")]
    public V1alpha1PromotionStatusFreightCollection? FreightCollection { get; set; }

    /// <summary>
    /// HealthChecks contains the health check directives to be executed after
    /// the Promotion has completed.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1alpha1PromotionStatusHealthChecks>? HealthChecks { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>
    /// Message is a display message about the promotion, including any errors
    /// preventing the Promotion controller from executing this Promotion.
    /// i.e. If the Phase field has a value of Failed, this field can be expected
    /// to explain why.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Phase describes where the Promotion currently is in its lifecycle.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartedAt is the time when the promotion started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// State stores the state of the promotion process between reconciliation
    /// attempts.
    /// </summary>
    [JsonPropertyName("state")]
    public JsonNode? State { get; set; }

    /// <summary>
    /// StepExecutionMetadata tracks metadata pertaining to the execution
    /// of individual promotion steps.
    /// </summary>
    [JsonPropertyName("stepExecutionMetadata")]
    public IList<V1alpha1PromotionStatusStepExecutionMetadata>? StepExecutionMetadata { get; set; }
}

/// <summary>
/// Promotion represents a request to transition a particular Stage into a
/// particular Freight.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Promotion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PromotionSpec>, IStatus<V1alpha1PromotionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Promotion";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "promotions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Promotion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Spec describes the desired transition of a specific Stage into a specific
    /// Freight.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1PromotionSpec Spec { get; set; }

    /// <summary>
    /// Status describes the current state of the transition represented by this
    /// Promotion.
    /// </summary>
    [JsonPropertyName("status")]
    public V1alpha1PromotionStatus? Status { get; set; }
}