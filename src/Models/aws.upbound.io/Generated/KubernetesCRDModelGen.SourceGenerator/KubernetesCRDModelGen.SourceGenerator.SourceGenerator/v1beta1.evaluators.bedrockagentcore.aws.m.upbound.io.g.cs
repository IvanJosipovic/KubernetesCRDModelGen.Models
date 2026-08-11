#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.m.upbound.io;
/// <summary>Evaluator is the Schema for the Evaluators API. Manages an AWS Bedrock AgentCore Evaluator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EvaluatorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Evaluator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EvaluatorList";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "evaluators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EvaluatorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Evaluator objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Evaluator> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelector
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
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Lambda function configuration. See lambda_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfig
{
    /// <summary>ARN of the Lambda function that runs the evaluation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>Time in seconds to wait for the Lambda function before timing out. Defaults to 60. Range 1–300.</summary>
    [JsonPropertyName("lambdaTimeoutInSeconds")]
    public double? LambdaTimeoutInSeconds { get; set; }
}

/// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBased
{
    /// <summary>Lambda function configuration. See lambda_config below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBasedLambdaConfig? LambdaConfig { get; set; }
}

/// <summary>Instructions that tell the model how to score the agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeInstructionsSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig
{
    /// <summary>Maximum number of tokens to generate in the model response. Must be at least 1.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of sequences that cause the model to stop generating tokens.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Temperature value that controls randomness. Range 0–1.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p sampling parameter. Range 0–1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig
{
    /// <summary>JSON-encoded model-specific request fields, for settings not covered by inference_config.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig? InferenceConfig { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model to use for evaluation.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Which Bedrock model to use. See model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfig
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
    [JsonPropertyName("bedrockEvaluatorModelConfig")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig? BedrockEvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Numerical value for this rating option. Must be at least 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Scale used to score the agent. See rating_scale below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScale
{
    /// <summary>One or more categorical rating scale definitions. See categorical below.</summary>
    [JsonPropertyName("categorical")]
    public IList<V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical>? Categorical { get; set; }

    /// <summary>One or more numerical rating scale definitions. See numerical below.</summary>
    [JsonPropertyName("numerical")]
    public IList<V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical>? Numerical { get; set; }
}

/// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudge
{
    /// <summary>Instructions that tell the model how to score the agent.</summary>
    [JsonPropertyName("instructionsSecretRef")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeInstructionsSecretRef? InstructionsSecretRef { get; set; }

    /// <summary>Which Bedrock model to use. See model_config below.</summary>
    [JsonPropertyName("modelConfig")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeModelConfig? ModelConfig { get; set; }

    /// <summary>Scale used to score the agent. See rating_scale below.</summary>
    [JsonPropertyName("ratingScale")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudgeRatingScale? RatingScale { get; set; }
}

/// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderEvaluatorConfig
{
    /// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
    [JsonPropertyName("codeBased")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigCodeBased? CodeBased { get; set; }

    /// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
    [JsonPropertyName("llmAsAJudge")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfigLlmAsAJudge? LlmAsAJudge { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProviderKmsKeyArnSelector
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
    public V1beta1EvaluatorSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecForProvider
{
    /// <summary>Description of the evaluator. Length 1–200.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
    [JsonPropertyName("evaluatorConfig")]
    public V1beta1EvaluatorSpecForProviderEvaluatorConfig? EvaluatorConfig { get; set; }

    /// <summary>Name of the evaluator. Must match the pattern ^[a-zA-Z][a-zA-Z0-9_]{0,47}$.</summary>
    [JsonPropertyName("evaluatorName")]
    public string? EvaluatorName { get; set; }

    /// <summary>ARN of a customer-managed KMS key used to encrypt the evaluator&apos;s sensitive data. Only symmetric encryption keys are supported.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EvaluatorSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Evaluation level that determines the scope of evaluation. Valid values: TOOL_CALL, TRACE, SESSION.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelector
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
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Lambda function configuration. See lambda_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfig
{
    /// <summary>ARN of the Lambda function that runs the evaluation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfigLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>Time in seconds to wait for the Lambda function before timing out. Defaults to 60. Range 1–300.</summary>
    [JsonPropertyName("lambdaTimeoutInSeconds")]
    public double? LambdaTimeoutInSeconds { get; set; }
}

/// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBased
{
    /// <summary>Lambda function configuration. See lambda_config below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBasedLambdaConfig? LambdaConfig { get; set; }
}

/// <summary>Instructions that tell the model how to score the agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeInstructionsSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig
{
    /// <summary>Maximum number of tokens to generate in the model response. Must be at least 1.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of sequences that cause the model to stop generating tokens.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Temperature value that controls randomness. Range 0–1.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p sampling parameter. Range 0–1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig
{
    /// <summary>JSON-encoded model-specific request fields, for settings not covered by inference_config.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig? InferenceConfig { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model to use for evaluation.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Which Bedrock model to use. See model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfig
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
    [JsonPropertyName("bedrockEvaluatorModelConfig")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig? BedrockEvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Numerical value for this rating option. Must be at least 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Scale used to score the agent. See rating_scale below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScale
{
    /// <summary>One or more categorical rating scale definitions. See categorical below.</summary>
    [JsonPropertyName("categorical")]
    public IList<V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical>? Categorical { get; set; }

    /// <summary>One or more numerical rating scale definitions. See numerical below.</summary>
    [JsonPropertyName("numerical")]
    public IList<V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical>? Numerical { get; set; }
}

/// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudge
{
    /// <summary>Instructions that tell the model how to score the agent.</summary>
    [JsonPropertyName("instructionsSecretRef")]
    public required V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeInstructionsSecretRef InstructionsSecretRef { get; set; }

    /// <summary>Which Bedrock model to use. See model_config below.</summary>
    [JsonPropertyName("modelConfig")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeModelConfig? ModelConfig { get; set; }

    /// <summary>Scale used to score the agent. See rating_scale below.</summary>
    [JsonPropertyName("ratingScale")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudgeRatingScale? RatingScale { get; set; }
}

/// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderEvaluatorConfig
{
    /// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
    [JsonPropertyName("codeBased")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigCodeBased? CodeBased { get; set; }

    /// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
    [JsonPropertyName("llmAsAJudge")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfigLlmAsAJudge? LlmAsAJudge { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpecInitProviderKmsKeyArnSelector
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
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1EvaluatorSpecInitProvider
{
    /// <summary>Description of the evaluator. Length 1–200.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
    [JsonPropertyName("evaluatorConfig")]
    public V1beta1EvaluatorSpecInitProviderEvaluatorConfig? EvaluatorConfig { get; set; }

    /// <summary>Name of the evaluator. Must match the pattern ^[a-zA-Z][a-zA-Z0-9_]{0,47}$.</summary>
    [JsonPropertyName("evaluatorName")]
    public string? EvaluatorName { get; set; }

    /// <summary>ARN of a customer-managed KMS key used to encrypt the evaluator&apos;s sensitive data. Only symmetric encryption keys are supported.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EvaluatorSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Evaluation level that determines the scope of evaluation. Valid values: TOOL_CALL, TRACE, SESSION.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EvaluatorSpecManagementPoliciesEnum>))]
public enum V1beta1EvaluatorSpecManagementPoliciesEnum
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
public partial class V1beta1EvaluatorSpecProviderConfigRef
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
public partial class V1beta1EvaluatorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EvaluatorSpec defines the desired state of Evaluator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EvaluatorSpecForProvider ForProvider { get; set; }

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
    public V1beta1EvaluatorSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EvaluatorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EvaluatorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EvaluatorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Lambda function configuration. See lambda_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigCodeBasedLambdaConfig
{
    /// <summary>ARN of the Lambda function that runs the evaluation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Time in seconds to wait for the Lambda function before timing out. Defaults to 60. Range 1–300.</summary>
    [JsonPropertyName("lambdaTimeoutInSeconds")]
    public double? LambdaTimeoutInSeconds { get; set; }
}

/// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigCodeBased
{
    /// <summary>Lambda function configuration. See lambda_config below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigCodeBasedLambdaConfig? LambdaConfig { get; set; }
}

/// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig
{
    /// <summary>Maximum number of tokens to generate in the model response. Must be at least 1.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of sequences that cause the model to stop generating tokens.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Temperature value that controls randomness. Range 0–1.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p sampling parameter. Range 0–1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig
{
    /// <summary>JSON-encoded model-specific request fields, for settings not covered by inference_config.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Settings that control how the model generates its response. See inference_config below.</summary>
    [JsonPropertyName("inferenceConfig")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfigInferenceConfig? InferenceConfig { get; set; }

    /// <summary>Identifier of the Amazon Bedrock model to use for evaluation.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Which Bedrock model to use. See model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfig
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_evaluator_model_config below.</summary>
    [JsonPropertyName("bedrockEvaluatorModelConfig")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfigBedrockEvaluatorModelConfig? BedrockEvaluatorModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical
{
    /// <summary>Description that explains what this numerical rating represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Label for this numerical rating option. Length 1–100.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Numerical value for this rating option. Must be at least 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Scale used to score the agent. See rating_scale below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScale
{
    /// <summary>One or more categorical rating scale definitions. See categorical below.</summary>
    [JsonPropertyName("categorical")]
    public IList<V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScaleCategorical>? Categorical { get; set; }

    /// <summary>One or more numerical rating scale definitions. See numerical below.</summary>
    [JsonPropertyName("numerical")]
    public IList<V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScaleNumerical>? Numerical { get; set; }
}

/// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudge
{
    /// <summary>Which Bedrock model to use. See model_config below.</summary>
    [JsonPropertyName("modelConfig")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeModelConfig? ModelConfig { get; set; }

    /// <summary>Scale used to score the agent. See rating_scale below.</summary>
    [JsonPropertyName("ratingScale")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudgeRatingScale? RatingScale { get; set; }
}

/// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProviderEvaluatorConfig
{
    /// <summary>Configuration that runs a Lambda function you provide to score the agent. See code_based below.</summary>
    [JsonPropertyName("codeBased")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigCodeBased? CodeBased { get; set; }

    /// <summary>Configuration that uses a Bedrock model to score the agent. See llm_as_a_judge below.</summary>
    [JsonPropertyName("llmAsAJudge")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfigLlmAsAJudge? LlmAsAJudge { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusAtProvider
{
    /// <summary>Timestamp when the evaluator was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Description of the evaluator. Length 1–200.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the evaluator.</summary>
    [JsonPropertyName("evaluatorArn")]
    public string? EvaluatorArn { get; set; }

    /// <summary>Configuration that defines how the evaluator assesses agent performance. See evaluator_config below.</summary>
    [JsonPropertyName("evaluatorConfig")]
    public V1beta1EvaluatorStatusAtProviderEvaluatorConfig? EvaluatorConfig { get; set; }

    /// <summary>Unique identifier of the evaluator.</summary>
    [JsonPropertyName("evaluatorId")]
    public string? EvaluatorId { get; set; }

    /// <summary>Name of the evaluator. Must match the pattern ^[a-zA-Z][a-zA-Z0-9_]{0,47}$.</summary>
    [JsonPropertyName("evaluatorName")]
    public string? EvaluatorName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of a customer-managed KMS key used to encrypt the evaluator&apos;s sensitive data. Only symmetric encryption keys are supported.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Evaluation level that determines the scope of evaluation. Valid values: TOOL_CALL, TRACE, SESSION.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Whether the evaluator is locked because it is in use by an active online evaluation.</summary>
    [JsonPropertyName("lockedForModification")]
    public bool? LockedForModification { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Current status of the evaluator.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatusConditions
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

/// <summary>EvaluatorStatus defines the observed state of Evaluator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EvaluatorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EvaluatorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EvaluatorStatusConditions>? Conditions { get; set; }

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

/// <summary>Evaluator is the Schema for the Evaluators API. Manages an AWS Bedrock AgentCore Evaluator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Evaluator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EvaluatorSpec>, IStatus<V1beta1EvaluatorStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Evaluator";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "evaluators";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Evaluator";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EvaluatorSpec defines the desired state of Evaluator</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EvaluatorSpec Spec { get; set; }

    /// <summary>EvaluatorStatus defines the observed state of Evaluator.</summary>
    [JsonPropertyName("status")]
    public V1beta1EvaluatorStatus? Status { get; set; }
}