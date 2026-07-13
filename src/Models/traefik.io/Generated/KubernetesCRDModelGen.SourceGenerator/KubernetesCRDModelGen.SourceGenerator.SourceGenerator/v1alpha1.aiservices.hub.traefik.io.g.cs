#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>AIService is a Kubernetes-like Service to interact with a text-based LLM provider. It defines the parameters and credentials required to interact with various LLM providers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AIServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AIService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AIServiceList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "aiservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AIServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AIService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AIService> Items { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAnthropicParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAnthropicToken
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Anthropic configures Anthropic backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAnthropic
{
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecAnthropicParams? Params { get; set; }

    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("token")]
    public V1alpha1AIServiceSpecAnthropicToken? Token { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAzureOpenaiApiKeySecret
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAzureOpenaiParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>AzureOpenAI configures AzureOpenAI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAzureOpenai
{
    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("apiKeySecret")]
    public V1alpha1AIServiceSpecAzureOpenaiApiKeySecret? ApiKeySecret { get; set; }

    [JsonPropertyName("baseUrl")]
    public required string BaseUrl { get; set; }

    [JsonPropertyName("deploymentName")]
    public required string DeploymentName { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecAzureOpenaiParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecBedrockParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Bedrock configures Bedrock backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecBedrock
{
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecBedrockParams? Params { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("systemMessage")]
    public bool? SystemMessage { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecCohereParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecCohereToken
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Cohere configures Cohere backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecCohere
{
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecCohereParams? Params { get; set; }

    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("token")]
    public V1alpha1AIServiceSpecCohereToken? Token { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecDeepSeekParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecDeepSeekToken
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>DeepSeek configures DeepSeek.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecDeepSeek
{
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecDeepSeekParams? Params { get; set; }

    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("token")]
    public V1alpha1AIServiceSpecDeepSeekToken? Token { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecGeminiApiKey
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecGeminiParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Gemini configures Gemini backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecGemini
{
    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("apiKey")]
    public V1alpha1AIServiceSpecGeminiApiKey? ApiKey { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecGeminiParams? Params { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecMistralApiKey
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecMistralParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Mistral configures Mistral AI backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecMistral
{
    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("apiKey")]
    public V1alpha1AIServiceSpecMistralApiKey? ApiKey { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecMistralParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOllamaParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Ollama configures Ollama backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOllama
{
    [JsonPropertyName("baseUrl")]
    public required string BaseUrl { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecOllamaParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOpenaiParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOpenaiToken
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>OpenAI configures OpenAI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOpenai
{
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecOpenaiParams? Params { get; set; }

    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("token")]
    public V1alpha1AIServiceSpecOpenaiToken? Token { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecQWenParams
{
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>SecretReference references a kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecQWenToken
{
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>QWen configures QWen.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecQWen
{
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecQWenParams? Params { get; set; }

    /// <summary>SecretReference references a kubernetes secret.</summary>
    [JsonPropertyName("token")]
    public V1alpha1AIServiceSpecQWenToken? Token { get; set; }
}

/// <summary>The desired behavior of this AIService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpec
{
    /// <summary>Anthropic configures Anthropic backend.</summary>
    [JsonPropertyName("anthropic")]
    public V1alpha1AIServiceSpecAnthropic? Anthropic { get; set; }

    /// <summary>AzureOpenAI configures AzureOpenAI.</summary>
    [JsonPropertyName("azureOpenai")]
    public V1alpha1AIServiceSpecAzureOpenai? AzureOpenai { get; set; }

    /// <summary>Bedrock configures Bedrock backend.</summary>
    [JsonPropertyName("bedrock")]
    public V1alpha1AIServiceSpecBedrock? Bedrock { get; set; }

    /// <summary>Cohere configures Cohere backend.</summary>
    [JsonPropertyName("cohere")]
    public V1alpha1AIServiceSpecCohere? Cohere { get; set; }

    /// <summary>DeepSeek configures DeepSeek.</summary>
    [JsonPropertyName("deepSeek")]
    public V1alpha1AIServiceSpecDeepSeek? DeepSeek { get; set; }

    /// <summary>Gemini configures Gemini backend.</summary>
    [JsonPropertyName("gemini")]
    public V1alpha1AIServiceSpecGemini? Gemini { get; set; }

    /// <summary>Mistral configures Mistral AI backend.</summary>
    [JsonPropertyName("mistral")]
    public V1alpha1AIServiceSpecMistral? Mistral { get; set; }

    /// <summary>Ollama configures Ollama backend.</summary>
    [JsonPropertyName("ollama")]
    public V1alpha1AIServiceSpecOllama? Ollama { get; set; }

    /// <summary>OpenAI configures OpenAI.</summary>
    [JsonPropertyName("openai")]
    public V1alpha1AIServiceSpecOpenai? Openai { get; set; }

    /// <summary>QWen configures QWen.</summary>
    [JsonPropertyName("qWen")]
    public V1alpha1AIServiceSpecQWen? QWen { get; set; }
}

/// <summary>AIService is a Kubernetes-like Service to interact with a text-based LLM provider. It defines the parameters and credentials required to interact with various LLM providers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AIService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AIServiceSpec?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AIService";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "aiservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AIService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this AIService.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AIServiceSpec? Spec { get; set; }
}