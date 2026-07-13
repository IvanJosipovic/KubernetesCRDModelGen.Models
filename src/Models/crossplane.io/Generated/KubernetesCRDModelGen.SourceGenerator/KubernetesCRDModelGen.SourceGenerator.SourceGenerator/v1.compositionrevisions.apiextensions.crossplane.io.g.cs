#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>
/// A CompositionRevision represents a revision of a Composition. Crossplane
/// creates new revisions when there are changes to the Composition.
/// 
/// Crossplane creates and manages CompositionRevisions. Don&apos;t directly edit
/// CompositionRevisions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CompositionRevisionList : IKubernetesObject<V1ListMeta>, IItems<V1CompositionRevision>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CompositionRevisionList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositionrevisions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CompositionRevisionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1CompositionRevision objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1CompositionRevision> Items { get; set; }
}

/// <summary>
/// CompositeTypeRef specifies the type of composite resource that this
/// composition is compatible with.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecCompositeTypeRef
{
    /// <summary>APIVersion of the type.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>Kind of the type.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }
}

/// <summary>
/// Mode controls what type or &quot;mode&quot; of Composition will be used.
/// 
/// &quot;Pipeline&quot; indicates that a Composition specifies a pipeline of
/// functions, each of which is responsible for producing composed
/// resources that Crossplane should create or update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CompositionRevisionSpecModeEnum>))]
public enum V1CompositionRevisionSpecModeEnum
{
    [EnumMember(Value = "Pipeline"), JsonStringEnumMemberName("Pipeline")]
    Pipeline
}

/// <summary>
/// A SecretRef is a reference to a secret containing credentials that should
/// be supplied to the function.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineCredentialsSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Source of the function credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CompositionRevisionSpecPipelineCredentialsSourceEnum>))]
public enum V1CompositionRevisionSpecPipelineCredentialsSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret
}

/// <summary>
/// FunctionCredentials are optional credentials that a function
/// needs to run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineCredentials
{
    /// <summary>Name of this set of credentials.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret containing credentials that should
    /// be supplied to the function.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1CompositionRevisionSpecPipelineCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the function credentials.</summary>
    [JsonPropertyName("source")]
    public required V1CompositionRevisionSpecPipelineCredentialsSourceEnum Source { get; set; }
}

/// <summary>
/// FunctionRef is a reference to the function this step should
/// execute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineFunctionRef
{
    /// <summary>Name of the referenced Function.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RequiredResourceSelector selects a required resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineRequirementsRequiredResources
{
    /// <summary>APIVersion of the required resource.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>Kind of the required resource.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>
    /// MatchLabels specifies the set of labels to match for finding the
    /// required resource. When specified, Name is ignored.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Name of the required resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the required resource if it is namespaced.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// RequirementName is the unique name to identify this required resource
    /// in the Required Resources map in the function request.
    /// </summary>
    [JsonPropertyName("requirementName")]
    public required string RequirementName { get; set; }
}

/// <summary>RequiredSchemaSelector selects a required OpenAPI schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineRequirementsRequiredSchemas
{
    /// <summary>APIVersion of the resource kind whose schema is required, e.g. &quot;example.org/v1&quot;.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>Kind of resource whose schema is required, e.g. &quot;MyResource&quot;.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>
    /// RequirementName is the unique name to identify this required schema
    /// in the Required Schemas map in the function request.
    /// </summary>
    [JsonPropertyName("requirementName")]
    public required string RequirementName { get; set; }
}

/// <summary>
/// Requirements are resource requirements that will be satisfied before
/// this pipeline step is called for the first time. This allows
/// pre-populating required resources without requiring a function to
/// request them first.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineRequirements
{
    /// <summary>
    /// RequiredResources is a list of resources that must be fetched before
    /// this function is called.
    /// </summary>
    [JsonPropertyName("requiredResources")]
    public IList<V1CompositionRevisionSpecPipelineRequirementsRequiredResources>? RequiredResources { get; set; }

    /// <summary>
    /// RequiredSchemas is a list of OpenAPI schemas that must be fetched before
    /// this function is called.
    /// </summary>
    [JsonPropertyName("requiredSchemas")]
    public IList<V1CompositionRevisionSpecPipelineRequirementsRequiredSchemas>? RequiredSchemas { get; set; }
}

/// <summary>A PipelineStep in a function pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipeline
{
    /// <summary>Credentials are optional credentials that the function needs.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1CompositionRevisionSpecPipelineCredentials>? Credentials { get; set; }

    /// <summary>
    /// FunctionRef is a reference to the function this step should
    /// execute.
    /// </summary>
    [JsonPropertyName("functionRef")]
    public required V1CompositionRevisionSpecPipelineFunctionRef FunctionRef { get; set; }

    /// <summary>
    /// Input is an optional, arbitrary Kubernetes resource (i.e. a resource
    /// with an apiVersion and kind) that will be passed to the function as
    /// the &apos;input&apos; of its RunFunctionRequest.
    /// </summary>
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    /// <summary>
    /// Requirements are resource requirements that will be satisfied before
    /// this pipeline step is called for the first time. This allows
    /// pre-populating required resources without requiring a function to
    /// request them first.
    /// </summary>
    [JsonPropertyName("requirements")]
    public V1CompositionRevisionSpecPipelineRequirements? Requirements { get; set; }

    /// <summary>Step name. Must be unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public required string Step { get; set; }
}

/// <summary>
/// CompositionRevisionSpec specifies the desired state of the composition
/// revision.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpec
{
    /// <summary>
    /// CompositeTypeRef specifies the type of composite resource that this
    /// composition is compatible with.
    /// </summary>
    [JsonPropertyName("compositeTypeRef")]
    public required V1CompositionRevisionSpecCompositeTypeRef CompositeTypeRef { get; set; }

    /// <summary>
    /// Mode controls what type or &quot;mode&quot; of Composition will be used.
    /// 
    /// &quot;Pipeline&quot; indicates that a Composition specifies a pipeline of
    /// functions, each of which is responsible for producing composed
    /// resources that Crossplane should create or update.
    /// </summary>
    [JsonPropertyName("mode")]
    public V1CompositionRevisionSpecModeEnum? Mode { get; set; }

    /// <summary>
    /// Pipeline is a list of function steps that will be used when a
    /// composite resource referring to this composition is created.
    /// 
    /// The Pipeline is only used by the &quot;Pipeline&quot; mode of Composition. It is
    /// ignored by other modes.
    /// </summary>
    [JsonPropertyName("pipeline")]
    public IList<V1CompositionRevisionSpecPipeline>? Pipeline { get; set; }

    /// <summary>
    /// Revision number. Newer revisions have larger numbers.
    /// 
    /// This number can change. When a Composition transitions from state A
    /// -&gt; B -&gt; A there will be only two CompositionRevisions. Crossplane will
    /// edit the original CompositionRevision to change its revision number from
    /// 0 to 2.
    /// </summary>
    [JsonPropertyName("revision")]
    public required long Revision { get; set; }

    /// <summary>
    /// WriteConnectionSecretsToNamespace specifies the namespace in which the
    /// connection secrets of composite resource dynamically provisioned using
    /// this composition will be created.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretsToNamespace")]
    public string? WriteConnectionSecretsToNamespace { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// CompositionRevisionStatus shows the observed state of the composition
/// revision.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1CompositionRevisionStatusConditions>? Conditions { get; set; }
}

/// <summary>
/// A CompositionRevision represents a revision of a Composition. Crossplane
/// creates new revisions when there are changes to the Composition.
/// 
/// Crossplane creates and manages CompositionRevisions. Don&apos;t directly edit
/// CompositionRevisions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CompositionRevision : IKubernetesObject<V1ObjectMeta>, ISpec<V1CompositionRevisionSpec?>, IStatus<V1CompositionRevisionStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CompositionRevision";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositionrevisions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CompositionRevision";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CompositionRevisionSpec specifies the desired state of the composition
    /// revision.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1CompositionRevisionSpec? Spec { get; set; }

    /// <summary>
    /// CompositionRevisionStatus shows the observed state of the composition
    /// revision.
    /// </summary>
    [JsonPropertyName("status")]
    public V1CompositionRevisionStatus? Status { get; set; }
}