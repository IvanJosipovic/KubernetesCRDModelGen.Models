#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentai.cnrm.cloud.google.com;
/// <summary>DocumentAIProcessorVersion is the Schema for the DocumentAIProcessorVersion API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DocumentAIProcessorVersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DocumentAIProcessorVersion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DocumentAIProcessorVersionList";
    public const string KubeGroup = "documentai.cnrm.cloud.google.com";
    public const string KubePluralName = "documentaiprocessorversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DocumentAIProcessorVersionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DocumentAIProcessorVersion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DocumentAIProcessorVersion> Items { get; set; }
}

/// <summary>If set, information about the eventual deprecation of this version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionSpecDeprecationInfo
{
    /// <summary>The time at which this processor version will be deprecated.</summary>
    [JsonPropertyName("deprecationTime")]
    public string? DeprecationTime { get; set; }

    /// <summary>If set, the processor version that will be used as a replacement.</summary>
    [JsonPropertyName("replacementProcessorVersion")]
    public string? ReplacementProcessorVersion { get; set; }
}

/// <summary>The KMS key name used for encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionSpecKmsKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The KMS key version with which data is encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionSpecKmsKeyVersionNameRef
{
    /// <summary>A reference to an externally managed cryptoKeyVersion. Should be in the format `projects/{{kms_project_id}}/locations/{{region}}/keyRings/{{key_ring_id}}/cryptoKeys/{{key}}/cryptoKeyVersions/{{version}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary>ProcessorRef defines the resource reference to DocumentAIProcessor, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionSpecProcessorRef
{
    /// <summary>A reference to an externally managed DocumentAIProcessor resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/processors/{{processorID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DocumentAIProcessor resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DocumentAIProcessor resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DocumentAIProcessorVersionSpec defines the desired state of DocumentAIProcessorVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionSpec
{
    /// <summary>If set, information about the eventual deprecation of this version.</summary>
    [JsonPropertyName("deprecationInfo")]
    public V1alpha1DocumentAIProcessorVersionSpecDeprecationInfo? DeprecationInfo { get; set; }

    /// <summary>The display name of the processor version.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The KMS key name used for encryption.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1alpha1DocumentAIProcessorVersionSpecKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>The KMS key version with which data is encrypted.</summary>
    [JsonPropertyName("kmsKeyVersionNameRef")]
    public V1alpha1DocumentAIProcessorVersionSpecKmsKeyVersionNameRef? KmsKeyVersionNameRef { get; set; }

    /// <summary>ProcessorRef defines the resource reference to DocumentAIProcessor, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("processorRef")]
    public required V1alpha1DocumentAIProcessorVersionSpecProcessorRef ProcessorRef { get; set; }

    /// <summary>The DocumentAIProcessorVersion name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>If specified, lists all the possible values for this entity.  This should not be more than a handful of values.  If the number of values is &gt;10 or could change frequently use the `EntityType.value_ontology` field and specify a list of all possible values in a value ontology file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypesEnumValues
{
    /// <summary>The individual values that this enum values type can include.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypesProperties
{
    /// <summary>User defined name for the property.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies how the entity&apos;s value is obtained.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>The name of the property.  Follows the same guidelines as the EntityType name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Occurrence type limits the number of instances an entity type appears in the document.</summary>
    [JsonPropertyName("occurrenceType")]
    public string? OccurrenceType { get; set; }

    /// <summary>A reference to the value type of the property.  This type is subject to the same conventions as the `Entity.base_types` field.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypes
{
    /// <summary>The entity type that this type is derived from.  For now, one and only one should be set.</summary>
    [JsonPropertyName("baseTypes")]
    public IList<string>? BaseTypes { get; set; }

    /// <summary>User defined name for the type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If specified, lists all the possible values for this entity.  This should not be more than a handful of values.  If the number of values is &gt;10 or could change frequently use the `EntityType.value_ontology` field and specify a list of all possible values in a value ontology file.</summary>
    [JsonPropertyName("enumValues")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypesEnumValues? EnumValues { get; set; }

    /// <summary>
    /// Name of the type. It must be unique within the schema file and
    ///  cannot be a &quot;Common Type&quot;.  The following naming conventions are used:
    /// 
    ///  - Use `snake_casing`.
    ///  - Name matching is case-sensitive.
    ///  - Maximum 64 characters.
    ///  - Must start with a letter.
    ///  - Allowed characters: ASCII letters `[a-z0-9_-]`.  (For backward
    ///    compatibility internal infrastructure and tooling can handle any ascii
    ///    character.)
    ///  - The `/` is sometimes used to denote a property of a type.  For example
    ///    `line_item/amount`.  This convention is deprecated, but will still be
    ///    honored for backward compatibility.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Description the nested structure, or composition of an entity.</summary>
    [JsonPropertyName("properties")]
    public IList<V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypesProperties>? Properties { get; set; }
}

/// <summary>Metadata of the schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaMetadata
{
    /// <summary>If true, on a given page, there can be multiple `document` annotations covering it.</summary>
    [JsonPropertyName("documentAllowMultipleLabels")]
    public bool? DocumentAllowMultipleLabels { get; set; }

    /// <summary>If true, a `document` entity type can be applied to subdocument (splitting). Otherwise, it can only be applied to the entire document (classification).</summary>
    [JsonPropertyName("documentSplitter")]
    public bool? DocumentSplitter { get; set; }

    /// <summary>If set, all the nested entities must be prefixed with the parents.</summary>
    [JsonPropertyName("prefixedNamingOnProperties")]
    public bool? PrefixedNamingOnProperties { get; set; }

    /// <summary>If set, we will skip the naming format validation in the schema. So the string values in `DocumentSchema.EntityType.name` and `DocumentSchema.EntityType.Property.name` will not be checked.</summary>
    [JsonPropertyName("skipNamingValidation")]
    public bool? SkipNamingValidation { get; set; }
}

/// <summary>The schema of the processor version. Describes the output.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchema
{
    /// <summary>Description of the schema.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name to show to users.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Entity types of the schema.</summary>
    [JsonPropertyName("entityTypes")]
    public IList<V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaEntityTypes>? EntityTypes { get; set; }

    /// <summary>Metadata of the schema.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchemaMetadata? Metadata { get; set; }
}

/// <summary>Information for a custom Generative AI model created by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfoCustomGenAiModelInfo
{
    /// <summary>The base processor version ID for the custom model.</summary>
    [JsonPropertyName("baseProcessorVersionID")]
    public string? BaseProcessorVersionID { get; set; }

    /// <summary>The type of custom model created by the user.</summary>
    [JsonPropertyName("customModelType")]
    public string? CustomModelType { get; set; }
}

/// <summary>Information for a pretrained Google-managed foundation model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfoFoundationGenAiModelInfo
{
    /// <summary>Whether finetuning is allowed for this base processor version.</summary>
    [JsonPropertyName("finetuningAllowed")]
    public bool? FinetuningAllowed { get; set; }

    /// <summary>The minimum number of labeled documents in the training dataset required for finetuning.</summary>
    [JsonPropertyName("minTrainLabeledDocuments")]
    public int? MinTrainLabeledDocuments { get; set; }
}

/// <summary>Output only. Information about Generative AI model-based processor versions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfo
{
    /// <summary>Information for a custom Generative AI model created by the user.</summary>
    [JsonPropertyName("customGenAiModelInfo")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfoCustomGenAiModelInfo? CustomGenAiModelInfo { get; set; }

    /// <summary>Information for a pretrained Google-managed foundation model.</summary>
    [JsonPropertyName("foundationGenAiModelInfo")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfoFoundationGenAiModelInfo? FoundationGenAiModelInfo { get; set; }
}

/// <summary>An aggregate of the statistics for the evaluation with fuzzy matching on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluationAggregateMetrics
{
    /// <summary>The calculated f1 score.</summary>
    [JsonPropertyName("f1Score")]
    public double? F1Score { get; set; }

    /// <summary>The amount of false negatives.</summary>
    [JsonPropertyName("falseNegativesCount")]
    public int? FalseNegativesCount { get; set; }

    /// <summary>The amount of false positives.</summary>
    [JsonPropertyName("falsePositivesCount")]
    public int? FalsePositivesCount { get; set; }

    /// <summary>The amount of documents with a ground truth occurrence.</summary>
    [JsonPropertyName("groundTruthDocumentCount")]
    public int? GroundTruthDocumentCount { get; set; }

    /// <summary>The amount of occurrences in ground truth documents.</summary>
    [JsonPropertyName("groundTruthOccurrencesCount")]
    public int? GroundTruthOccurrencesCount { get; set; }

    /// <summary>The calculated precision.</summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>The amount of documents with a predicted occurrence.</summary>
    [JsonPropertyName("predictedDocumentCount")]
    public int? PredictedDocumentCount { get; set; }

    /// <summary>The amount of occurrences in predicted documents.</summary>
    [JsonPropertyName("predictedOccurrencesCount")]
    public int? PredictedOccurrencesCount { get; set; }

    /// <summary>The calculated recall.</summary>
    [JsonPropertyName("recall")]
    public double? Recall { get; set; }

    /// <summary>The amount of documents that had an occurrence of this label.</summary>
    [JsonPropertyName("totalDocumentsCount")]
    public int? TotalDocumentsCount { get; set; }

    /// <summary>The amount of true positives.</summary>
    [JsonPropertyName("truePositivesCount")]
    public int? TruePositivesCount { get; set; }
}

/// <summary>An aggregate of the statistics for the evaluation with fuzzy matching off.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluationAggregateMetricsExact
{
    /// <summary>The calculated f1 score.</summary>
    [JsonPropertyName("f1Score")]
    public double? F1Score { get; set; }

    /// <summary>The amount of false negatives.</summary>
    [JsonPropertyName("falseNegativesCount")]
    public int? FalseNegativesCount { get; set; }

    /// <summary>The amount of false positives.</summary>
    [JsonPropertyName("falsePositivesCount")]
    public int? FalsePositivesCount { get; set; }

    /// <summary>The amount of documents with a ground truth occurrence.</summary>
    [JsonPropertyName("groundTruthDocumentCount")]
    public int? GroundTruthDocumentCount { get; set; }

    /// <summary>The amount of occurrences in ground truth documents.</summary>
    [JsonPropertyName("groundTruthOccurrencesCount")]
    public int? GroundTruthOccurrencesCount { get; set; }

    /// <summary>The calculated precision.</summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>The amount of documents with a predicted occurrence.</summary>
    [JsonPropertyName("predictedDocumentCount")]
    public int? PredictedDocumentCount { get; set; }

    /// <summary>The amount of occurrences in predicted documents.</summary>
    [JsonPropertyName("predictedOccurrencesCount")]
    public int? PredictedOccurrencesCount { get; set; }

    /// <summary>The calculated recall.</summary>
    [JsonPropertyName("recall")]
    public double? Recall { get; set; }

    /// <summary>The amount of documents that had an occurrence of this label.</summary>
    [JsonPropertyName("totalDocumentsCount")]
    public int? TotalDocumentsCount { get; set; }

    /// <summary>The amount of true positives.</summary>
    [JsonPropertyName("truePositivesCount")]
    public int? TruePositivesCount { get; set; }
}

/// <summary>The most recently invoked evaluation for the processor version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluation
{
    /// <summary>An aggregate of the statistics for the evaluation with fuzzy matching on.</summary>
    [JsonPropertyName("aggregateMetrics")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluationAggregateMetrics? AggregateMetrics { get; set; }

    /// <summary>An aggregate of the statistics for the evaluation with fuzzy matching off.</summary>
    [JsonPropertyName("aggregateMetricsExact")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluationAggregateMetricsExact? AggregateMetricsExact { get; set; }

    /// <summary>The resource name of the evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public string? Evaluation { get; set; }

    /// <summary>The resource name of the Long Running Operation for the evaluation.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatusObservedState
{
    /// <summary>The time the processor version was created.</summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>The schema of the processor version. Describes the output.</summary>
    [JsonPropertyName("document_schema")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateDocumentSchema? DocumentSchema { get; set; }

    /// <summary>Output only. Information about Generative AI model-based processor versions.</summary>
    [JsonPropertyName("gen_ai_model_info")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateGenAiModelInfo? GenAiModelInfo { get; set; }

    /// <summary>Output only. Denotes that this `ProcessorVersion` is managed by Google.</summary>
    [JsonPropertyName("google_managed")]
    public bool? GoogleManaged { get; set; }

    /// <summary>The most recently invoked evaluation for the processor version.</summary>
    [JsonPropertyName("latest_evaluation")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedStateLatestEvaluation? LatestEvaluation { get; set; }

    /// <summary>Output only. The model type of this processor version.</summary>
    [JsonPropertyName("model_type")]
    public string? ModelType { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfies_pzi")]
    public bool? SatisfiesPzi { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfies_pzs")]
    public bool? SatisfiesPzs { get; set; }

    /// <summary>Output only. The state of the processor version.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>DocumentAIProcessorVersionStatus defines the config connector machine state of DocumentAIProcessorVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorVersionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DocumentAIProcessorVersionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DocumentAI resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DocumentAIProcessorVersionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DocumentAIProcessorVersion is the Schema for the DocumentAIProcessorVersion API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DocumentAIProcessorVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DocumentAIProcessorVersionSpec>, IStatus<V1alpha1DocumentAIProcessorVersionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DocumentAIProcessorVersion";
    public const string KubeGroup = "documentai.cnrm.cloud.google.com";
    public const string KubePluralName = "documentaiprocessorversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DocumentAIProcessorVersion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DocumentAIProcessorVersionSpec defines the desired state of DocumentAIProcessorVersion</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DocumentAIProcessorVersionSpec Spec { get; set; }

    /// <summary>DocumentAIProcessorVersionStatus defines the config connector machine state of DocumentAIProcessorVersion</summary>
    [JsonPropertyName("status")]
    public V1alpha1DocumentAIProcessorVersionStatus? Status { get; set; }
}