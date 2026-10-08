#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrock.aws.m.upbound.io;
/// <summary>EvaluationJob is the Schema for the EvaluationJobs API. Manages an Amazon Bedrock evaluation job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EvaluationJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EvaluationJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EvaluationJobList";
    public const string KubeGroup = "bedrock.aws.m.upbound.io";
    public const string KubePluralName = "evaluationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrock.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EvaluationJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1EvaluationJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1EvaluationJob> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue
{
    /// <summary>Floating point number representing the rating value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>String representing the rating value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale
{
    /// <summary>Definition for one rating in the custom metric rating scale.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue? Value { get; set; }
}

/// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition
{
    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more items defining the rating scale for the custom metric. See rating_scale Block below.</summary>
    [JsonPropertyName("ratingScale")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale>? RatingScale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric
{
    /// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
    [JsonPropertyName("customMetricDefinition")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition? CustomMetricDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfig
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric>? CustomMetric { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomated
{
    /// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
    [JsonPropertyName("customMetricConfig")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedCustomMetricConfig? CustomMetricConfig { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.automated.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomatedEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanCustomMetric
{
    /// <summary>Description of the metric.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>How the metric is rated. Valid values: ThumbsUpDown, IndividualLikertScale, ComparisonLikertScale, ComparisonChoice, ComparisonRank.</summary>
    [JsonPropertyName("ratingMethod")]
    public string? RatingMethod { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanHumanWorkflowConfig
{
    /// <summary>ARN of the Amazon SageMaker AI flow definition.</summary>
    [JsonPropertyName("flowDefinitionArn")]
    public string? FlowDefinitionArn { get; set; }

    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }
}

/// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfigHuman
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanCustomMetric>? CustomMetric { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.human.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
    [JsonPropertyName("humanWorkflowConfig")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigHumanHumanWorkflowConfig? HumanWorkflowConfig { get; set; }
}

/// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderEvaluationConfig
{
    /// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
    [JsonPropertyName("automated")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigAutomated? Automated { get; set; }

    /// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
    [JsonPropertyName("human")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfigHuman? Human { get; set; }
}

/// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigModelBedrockModelPerformanceConfig
{
    /// <summary>Whether to use the latency-optimized or standard version of the model. Valid values: standard, optimized.</summary>
    [JsonPropertyName("latency")]
    public string? Latency { get; set; }
}

/// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigModelBedrockModel
{
    /// <summary>JSON-formatted string of inference parameters for the model.</summary>
    [JsonPropertyName("inferenceParams")]
    public string? InferenceParams { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }

    /// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigModelBedrockModelPerformanceConfig? PerformanceConfig { get; set; }
}

/// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigModelPrecomputedInferenceSource
{
    /// <summary>Label that identifies the precomputed inference source.</summary>
    [JsonPropertyName("inferenceSourceIdentifier")]
    public string? InferenceSourceIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigModel
{
    /// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
    [JsonPropertyName("bedrockModel")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigModelBedrockModel? BedrockModel { get; set; }

    /// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
    [JsonPropertyName("precomputedInferenceSource")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigModelPrecomputedInferenceSource? PrecomputedInferenceSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>ARN of the foundation model, or inference profile, used to generate responses.</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
    [JsonPropertyName("retrievalConfiguration")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration? RetrievalConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
    [JsonPropertyName("knowledgeBaseRetrievalConfiguration")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration? KnowledgeBaseRetrievalConfiguration { get; set; }
}

/// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig? RetrieveAndGenerateConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
    [JsonPropertyName("retrieveConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig? RetrieveConfig { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateSourceConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig? RetrieveAndGenerateSourceConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
    [JsonPropertyName("retrieveSourceConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig? RetrieveSourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfig
{
    /// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
    [JsonPropertyName("knowledgeBaseConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigKnowledgeBaseConfig? KnowledgeBaseConfig { get; set; }

    /// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
    [JsonPropertyName("precomputedRagSourceConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfigPrecomputedRagSourceConfig? PrecomputedRagSourceConfig { get; set; }
}

/// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderInferenceConfig
{
    /// <summary>One or more inference models. Automated jobs support a single model; jobs that use human workers support up to two models. See model Block below.</summary>
    [JsonPropertyName("model")]
    public IList<V1beta1EvaluationJobSpecForProviderInferenceConfigModel>? Model { get; set; }

    /// <summary>Inference configuration for a knowledge base evaluation job. See rag_config Block below.</summary>
    [JsonPropertyName("ragConfig")]
    public IList<V1beta1EvaluationJobSpecForProviderInferenceConfigRagConfig>? RagConfig { get; set; }
}

/// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderOutputDataConfig
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProviderRoleArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecForProvider
{
    /// <summary>Whether the evaluation job evaluates a model or a knowledge base. Valid values: ModelEvaluation, RagEvaluation.</summary>
    [JsonPropertyName("applicationType")]
    public string? ApplicationType { get; set; }

    /// <summary>ARN of the customer managed KMS key to use to encrypt the evaluation job.</summary>
    [JsonPropertyName("customerEncryptionKeyId")]
    public string? CustomerEncryptionKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyId.</summary>
    [JsonPropertyName("customerEncryptionKeyIdRef")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdRef? CustomerEncryptionKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyId.</summary>
    [JsonPropertyName("customerEncryptionKeyIdSelector")]
    public V1beta1EvaluationJobSpecForProviderCustomerEncryptionKeyIdSelector? CustomerEncryptionKeyIdSelector { get; set; }

    /// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
    [JsonPropertyName("evaluationConfig")]
    public V1beta1EvaluationJobSpecForProviderEvaluationConfig? EvaluationConfig { get; set; }

    /// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluationJobSpecForProviderInferenceConfig? InferenceConfig { get; set; }

    /// <summary>Description of the evaluation job.</summary>
    [JsonPropertyName("jobDescription")]
    public string? JobDescription { get; set; }

    /// <summary>Name for the evaluation job. Must be unique within your AWS account and Region, and consist of lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
    [JsonPropertyName("outputDataConfig")]
    public V1beta1EvaluationJobSpecForProviderOutputDataConfig? OutputDataConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>ARN of an IAM service role that Amazon Bedrock can assume to perform tasks on your behalf. See Required permissions for model evaluations.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1EvaluationJobSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1EvaluationJobSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to leave the evaluation job in its current state when destroying the resource, instead of stopping it.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue
{
    /// <summary>Floating point number representing the rating value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>String representing the rating value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale
{
    /// <summary>Definition for one rating in the custom metric rating scale.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue? Value { get; set; }
}

/// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition
{
    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more items defining the rating scale for the custom metric. See rating_scale Block below.</summary>
    [JsonPropertyName("ratingScale")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale>? RatingScale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric
{
    /// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
    [JsonPropertyName("customMetricDefinition")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition? CustomMetricDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfig
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric>? CustomMetric { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomated
{
    /// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
    [JsonPropertyName("customMetricConfig")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedCustomMetricConfig? CustomMetricConfig { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.automated.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomatedEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanCustomMetric
{
    /// <summary>Description of the metric.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>How the metric is rated. Valid values: ThumbsUpDown, IndividualLikertScale, ComparisonLikertScale, ComparisonChoice, ComparisonRank.</summary>
    [JsonPropertyName("ratingMethod")]
    public string? RatingMethod { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanHumanWorkflowConfig
{
    /// <summary>ARN of the Amazon SageMaker AI flow definition.</summary>
    [JsonPropertyName("flowDefinitionArn")]
    public string? FlowDefinitionArn { get; set; }

    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }
}

/// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfigHuman
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanCustomMetric>? CustomMetric { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.human.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
    [JsonPropertyName("humanWorkflowConfig")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigHumanHumanWorkflowConfig? HumanWorkflowConfig { get; set; }
}

/// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderEvaluationConfig
{
    /// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
    [JsonPropertyName("automated")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigAutomated? Automated { get; set; }

    /// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
    [JsonPropertyName("human")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfigHuman? Human { get; set; }
}

/// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigModelBedrockModelPerformanceConfig
{
    /// <summary>Whether to use the latency-optimized or standard version of the model. Valid values: standard, optimized.</summary>
    [JsonPropertyName("latency")]
    public string? Latency { get; set; }
}

/// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigModelBedrockModel
{
    /// <summary>JSON-formatted string of inference parameters for the model.</summary>
    [JsonPropertyName("inferenceParams")]
    public string? InferenceParams { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }

    /// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigModelBedrockModelPerformanceConfig? PerformanceConfig { get; set; }
}

/// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigModelPrecomputedInferenceSource
{
    /// <summary>Label that identifies the precomputed inference source.</summary>
    [JsonPropertyName("inferenceSourceIdentifier")]
    public string? InferenceSourceIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigModel
{
    /// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
    [JsonPropertyName("bedrockModel")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigModelBedrockModel? BedrockModel { get; set; }

    /// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
    [JsonPropertyName("precomputedInferenceSource")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigModelPrecomputedInferenceSource? PrecomputedInferenceSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>ARN of the foundation model, or inference profile, used to generate responses.</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
    [JsonPropertyName("retrievalConfiguration")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration? RetrievalConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
    [JsonPropertyName("knowledgeBaseRetrievalConfiguration")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration? KnowledgeBaseRetrievalConfiguration { get; set; }
}

/// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig? RetrieveAndGenerateConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
    [JsonPropertyName("retrieveConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig? RetrieveConfig { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateSourceConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig? RetrieveAndGenerateSourceConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
    [JsonPropertyName("retrieveSourceConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig? RetrieveSourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfig
{
    /// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
    [JsonPropertyName("knowledgeBaseConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigKnowledgeBaseConfig? KnowledgeBaseConfig { get; set; }

    /// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
    [JsonPropertyName("precomputedRagSourceConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfigPrecomputedRagSourceConfig? PrecomputedRagSourceConfig { get; set; }
}

/// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderInferenceConfig
{
    /// <summary>One or more inference models. Automated jobs support a single model; jobs that use human workers support up to two models. See model Block below.</summary>
    [JsonPropertyName("model")]
    public IList<V1beta1EvaluationJobSpecInitProviderInferenceConfigModel>? Model { get; set; }

    /// <summary>Inference configuration for a knowledge base evaluation job. See rag_config Block below.</summary>
    [JsonPropertyName("ragConfig")]
    public IList<V1beta1EvaluationJobSpecInitProviderInferenceConfigRagConfig>? RagConfig { get; set; }
}

/// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderOutputDataConfig
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProviderRoleArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecInitProvider
{
    /// <summary>Whether the evaluation job evaluates a model or a knowledge base. Valid values: ModelEvaluation, RagEvaluation.</summary>
    [JsonPropertyName("applicationType")]
    public string? ApplicationType { get; set; }

    /// <summary>ARN of the customer managed KMS key to use to encrypt the evaluation job.</summary>
    [JsonPropertyName("customerEncryptionKeyId")]
    public string? CustomerEncryptionKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyId.</summary>
    [JsonPropertyName("customerEncryptionKeyIdRef")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdRef? CustomerEncryptionKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyId.</summary>
    [JsonPropertyName("customerEncryptionKeyIdSelector")]
    public V1beta1EvaluationJobSpecInitProviderCustomerEncryptionKeyIdSelector? CustomerEncryptionKeyIdSelector { get; set; }

    /// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
    [JsonPropertyName("evaluationConfig")]
    public V1beta1EvaluationJobSpecInitProviderEvaluationConfig? EvaluationConfig { get; set; }

    /// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluationJobSpecInitProviderInferenceConfig? InferenceConfig { get; set; }

    /// <summary>Description of the evaluation job.</summary>
    [JsonPropertyName("jobDescription")]
    public string? JobDescription { get; set; }

    /// <summary>Name for the evaluation job. Must be unique within your AWS account and Region, and consist of lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
    [JsonPropertyName("outputDataConfig")]
    public V1beta1EvaluationJobSpecInitProviderOutputDataConfig? OutputDataConfig { get; set; }

    /// <summary>ARN of an IAM service role that Amazon Bedrock can assume to perform tasks on your behalf. See Required permissions for model evaluations.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1EvaluationJobSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to leave the evaluation job in its current state when destroying the resource, instead of stopping it.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluationJobSpecManagementPoliciesEnum>))]
public enum V1beta1EvaluationJobSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EvaluationJobSpec defines the desired state of EvaluationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EvaluationJobSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EvaluationJobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EvaluationJobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EvaluationJobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EvaluationJobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue
{
    /// <summary>Floating point number representing the rating value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>String representing the rating value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale
{
    /// <summary>Definition for one rating in the custom metric rating scale.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Value for one rating in the custom metric rating scale. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScaleValue? Value { get; set; }
}

/// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition
{
    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more items defining the rating scale for the custom metric. See rating_scale Block below.</summary>
    [JsonPropertyName("ratingScale")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinitionRatingScale>? RatingScale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric
{
    /// <summary>Definition of the custom metric. See custom_metric_definition Block below.</summary>
    [JsonPropertyName("customMetricDefinition")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition? CustomMetricDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfig
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigCustomMetric>? CustomMetric { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfigEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel
{
    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }
}

/// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedEvaluatorModelConfig
{
    /// <summary>Evaluator model. See bedrock_evaluator_model Block below.</summary>
    [JsonPropertyName("bedrockEvaluatorModel")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedEvaluatorModelConfigBedrockEvaluatorModel>? BedrockEvaluatorModel { get; set; }
}

/// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomated
{
    /// <summary>Configuration for custom metrics to compute for the evaluation job. See custom_metric_config Block below.</summary>
    [JsonPropertyName("customMetricConfig")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedCustomMetricConfig? CustomMetricConfig { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.automated.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the evaluator (judge) model. Required for automated jobs that use an LLM-as-judge metric, or that evaluate a knowledge base. See evaluator_model_config Block below.</summary>
    [JsonPropertyName("evaluatorModelConfig")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomatedEvaluatorModelConfig? EvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanCustomMetric
{
    /// <summary>Description of the metric.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>How the metric is rated. Valid values: ThumbsUpDown, IndividualLikertScale, ComparisonLikertScale, ComparisonChoice, ComparisonRank.</summary>
    [JsonPropertyName("ratingMethod")]
    public string? RatingMethod { get; set; }
}

/// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Prompt dataset to use. See dataset Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfigDataset
{
    /// <summary>Location of a custom prompt dataset. See dataset_location Block below.</summary>
    [JsonPropertyName("datasetLocation")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfigDatasetDatasetLocation? DatasetLocation { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfig
{
    /// <summary>Prompt dataset to use. See dataset Block below.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfigDataset? Dataset { get; set; }

    /// <summary>Names of the metrics to use for the evaluation job.</summary>
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    /// <summary>Type of task to evaluate. Common values are Summarization, Classification, QuestionAndAnswer, Generation, and Custom. Use General for automated evaluation jobs that use a judge model (evaluator_model_config).</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanHumanWorkflowConfig
{
    /// <summary>ARN of the Amazon SageMaker AI flow definition.</summary>
    [JsonPropertyName("flowDefinitionArn")]
    public string? FlowDefinitionArn { get; set; }

    /// <summary>Instructions for the flow definition.</summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }
}

/// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfigHuman
{
    /// <summary>One or more custom metrics for your human workers to use. See evaluation_config.human.custom_metric Block below.</summary>
    [JsonPropertyName("customMetric")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanCustomMetric>? CustomMetric { get; set; }

    /// <summary>One or more configurations for the prompt datasets and metrics to use. See evaluation_config.human.dataset_metric_config Block below.</summary>
    [JsonPropertyName("datasetMetricConfig")]
    public IList<V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanDatasetMetricConfig>? DatasetMetricConfig { get; set; }

    /// <summary>Configuration for the human workflow. See human_workflow_config Block below.</summary>
    [JsonPropertyName("humanWorkflowConfig")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigHumanHumanWorkflowConfig? HumanWorkflowConfig { get; set; }
}

/// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderEvaluationConfig
{
    /// <summary>Configuration for an automated evaluation job that computes metrics. See automated Block below.</summary>
    [JsonPropertyName("automated")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigAutomated? Automated { get; set; }

    /// <summary>Configuration for an evaluation job that uses human workers. See human Block below.</summary>
    [JsonPropertyName("human")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfigHuman? Human { get; set; }
}

/// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigModelBedrockModelPerformanceConfig
{
    /// <summary>Whether to use the latency-optimized or standard version of the model. Valid values: standard, optimized.</summary>
    [JsonPropertyName("latency")]
    public string? Latency { get; set; }
}

/// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigModelBedrockModel
{
    /// <summary>JSON-formatted string of inference parameters for the model.</summary>
    [JsonPropertyName("inferenceParams")]
    public string? InferenceParams { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model, or inference profile, used for inference.</summary>
    [JsonPropertyName("modelIdentifier")]
    public string? ModelIdentifier { get; set; }

    /// <summary>Model&apos;s performance settings. See performance_config Block below.</summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigModelBedrockModelPerformanceConfig? PerformanceConfig { get; set; }
}

/// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigModelPrecomputedInferenceSource
{
    /// <summary>Label that identifies the precomputed inference source.</summary>
    [JsonPropertyName("inferenceSourceIdentifier")]
    public string? InferenceSourceIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigModel
{
    /// <summary>Amazon Bedrock model. See bedrock_model Block below.</summary>
    [JsonPropertyName("bedrockModel")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigModelBedrockModel? BedrockModel { get; set; }

    /// <summary>Model where you provide your own precomputed inference response data. See precomputed_inference_source Block below.</summary>
    [JsonPropertyName("precomputedInferenceSource")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigModelPrecomputedInferenceSource? PrecomputedInferenceSource { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>ARN of the foundation model, or inference profile, used to generate responses.</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Knowledge base retrieval configuration. See retrieval_configuration Block below.</summary>
    [JsonPropertyName("retrievalConfiguration")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration? RetrievalConfiguration { get; set; }
}

/// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration
{
    /// <summary>Number of text chunks to retrieve.</summary>
    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration
{
    /// <summary>Vector search configuration. See vector_search_configuration Block above.</summary>
    [JsonPropertyName("vectorSearchConfiguration")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfigurationVectorSearchConfiguration? VectorSearchConfiguration { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig
{
    /// <summary>Identifier of the knowledge base.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Knowledge base retrieval configuration. See knowledge_base_retrieval_configuration Block below.</summary>
    [JsonPropertyName("knowledgeBaseRetrievalConfiguration")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration? KnowledgeBaseRetrievalConfiguration { get; set; }
}

/// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig? RetrieveAndGenerateConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_config Block below.</summary>
    [JsonPropertyName("retrieveConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig? RetrieveConfig { get; set; }
}

/// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig
{
    /// <summary>Label that identifies the precomputed RAG source.</summary>
    [JsonPropertyName("ragSourceIdentifier")]
    public string? RagSourceIdentifier { get; set; }
}

/// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfig
{
    /// <summary>Configuration for retrieval with response generation. See retrieve_and_generate_source_config Block below.</summary>
    [JsonPropertyName("retrieveAndGenerateSourceConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig? RetrieveAndGenerateSourceConfig { get; set; }

    /// <summary>Configuration for retrieval only. See retrieve_source_config Block below.</summary>
    [JsonPropertyName("retrieveSourceConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig? RetrieveSourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfig
{
    /// <summary>Amazon Bedrock knowledge base. See knowledge_base_config Block below.</summary>
    [JsonPropertyName("knowledgeBaseConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigKnowledgeBaseConfig? KnowledgeBaseConfig { get; set; }

    /// <summary>RAG source where you provide your own precomputed inference response data. See precomputed_rag_source_config Block below.</summary>
    [JsonPropertyName("precomputedRagSourceConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfigPrecomputedRagSourceConfig? PrecomputedRagSourceConfig { get; set; }
}

/// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderInferenceConfig
{
    /// <summary>One or more inference models. Automated jobs support a single model; jobs that use human workers support up to two models. See model Block below.</summary>
    [JsonPropertyName("model")]
    public IList<V1beta1EvaluationJobStatusAtProviderInferenceConfigModel>? Model { get; set; }

    /// <summary>Inference configuration for a knowledge base evaluation job. See rag_config Block below.</summary>
    [JsonPropertyName("ragConfig")]
    public IList<V1beta1EvaluationJobStatusAtProviderInferenceConfigRagConfig>? RagConfig { get; set; }
}

/// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProviderOutputDataConfig
{
    /// <summary>S3 URI where the results of the evaluation job are stored.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusAtProvider
{
    /// <summary>Whether the evaluation job evaluates a model or a knowledge base. Valid values: ModelEvaluation, RagEvaluation.</summary>
    [JsonPropertyName("applicationType")]
    public string? ApplicationType { get; set; }

    /// <summary>Date and time the evaluation job was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>ARN of the customer managed KMS key to use to encrypt the evaluation job.</summary>
    [JsonPropertyName("customerEncryptionKeyId")]
    public string? CustomerEncryptionKeyId { get; set; }

    /// <summary>Configuration for either an automated or human-based evaluation job. See evaluation_config Block below.</summary>
    [JsonPropertyName("evaluationConfig")]
    public V1beta1EvaluationJobStatusAtProviderEvaluationConfig? EvaluationConfig { get; set; }

    /// <summary>List of reasons the evaluation job failed to create, if applicable.</summary>
    [JsonPropertyName("failureMessages")]
    public IList<string>? FailureMessages { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for the inference model, or models, used for the evaluation job. See inference_config Block below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluationJobStatusAtProviderInferenceConfig? InferenceConfig { get; set; }

    /// <summary>ARN of the evaluation job.</summary>
    [JsonPropertyName("jobArn")]
    public string? JobArn { get; set; }

    /// <summary>Description of the evaluation job.</summary>
    [JsonPropertyName("jobDescription")]
    public string? JobDescription { get; set; }

    /// <summary>Name for the evaluation job. Must be unique within your AWS account and Region, and consist of lowercase letters, numbers, and hyphens.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Whether the evaluation job is automated or human-based.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>Date and time the evaluation job was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>Configuration for the Amazon S3 location where the results of the evaluation job are stored. See output_data_config Block below.</summary>
    [JsonPropertyName("outputDataConfig")]
    public V1beta1EvaluationJobStatusAtProviderOutputDataConfig? OutputDataConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of an IAM service role that Amazon Bedrock can assume to perform tasks on your behalf. See Required permissions for model evaluations.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Whether to leave the evaluation job in its current state when destroying the resource, instead of stopping it.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Current status of the evaluation job.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatusConditions
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

/// <summary>EvaluationJobStatus defines the observed state of EvaluationJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluationJobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EvaluationJobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EvaluationJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EvaluationJob is the Schema for the EvaluationJobs API. Manages an Amazon Bedrock evaluation job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EvaluationJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EvaluationJobSpec>, IStatus<V1beta1EvaluationJobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EvaluationJob";
    public const string KubeGroup = "bedrock.aws.m.upbound.io";
    public const string KubePluralName = "evaluationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrock.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EvaluationJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EvaluationJobSpec defines the desired state of EvaluationJob</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EvaluationJobSpec Spec { get; set; }

    /// <summary>EvaluationJobStatus defines the observed state of EvaluationJob.</summary>
    [JsonPropertyName("status")]
    public V1beta1EvaluationJobStatus? Status { get; set; }
}