#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serving.databricks.crossplane.io;
/// <summary>ModelServing is the Schema for the ModelServings API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ModelServingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ModelServing>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ModelServingList";
    public const string KubeGroup = "serving.databricks.crossplane.io";
    public const string KubePluralName = "modelservings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "serving.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelServingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ModelServing objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ModelServing> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelServingSpecDeletionPolicyEnum>))]
public enum V1beta1ModelServingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for input guardrail filters:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingSpecForProviderAiGatewayGuardrailsInputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingSpecForProviderAiGatewayGuardrailsOutputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public V1beta1ModelServingSpecForProviderAiGatewayGuardrailsInput? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public V1beta1ModelServingSpecForProviderAiGatewayGuardrailsOutput? Output { get; set; }
}

/// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }

    /// <summary>Specifies how many tokens are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("tokens")]
    public double? Tokens { get; set; }
}

/// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public V1beta1ModelServingSpecForProviderAiGatewayFallbackConfig? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public V1beta1ModelServingSpecForProviderAiGatewayGuardrails? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public V1beta1ModelServingSpecForProviderAiGatewayInferenceTableConfig? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingSpecForProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public V1beta1ModelServingSpecForProviderAiGatewayUsageTrackingConfig? UsageTrackingConfig { get; set; }
}

/// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfigAi21LabsApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AI21Labs Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
    [JsonPropertyName("ai21LabsApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfigAi21LabsApiKeyPlaintextSecretRef? Ai21LabsApiKeyPlaintextSecretRef { get; set; }

    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }
}

/// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsAccessKeyIdPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsSecretAccessKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Amazon Bedrock Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsAccessKeyIdPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsAccessKeyIdPlaintextSecretRef? AwsAccessKeyIdPlaintextSecretRef { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsSecretAccessKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsSecretAccessKeyPlaintextSecretRef? AwsSecretAccessKeyPlaintextSecretRef { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary>The Anthropic API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfigAnthropicApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Anthropic Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }

    /// <summary>The Anthropic API key provided as a plaintext string.</summary>
    [JsonPropertyName("anthropicApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfigAnthropicApiKeyPlaintextSecretRef? AnthropicApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The Cohere API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfigCohereApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Cohere Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfig
{
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }

    /// <summary>The Cohere API key provided as a plaintext string.</summary>
    [JsonPropertyName("cohereApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfigCohereApiKeyPlaintextSecretRef? CohereApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The API Key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuthValuePlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>The API Key provided as a plaintext string.</summary>
    [JsonPropertyName("valuePlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuthValuePlaintextSecretRef? ValuePlaintextSecretRef { get; set; }
}

/// <summary>The token provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuthTokenPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>The token provided as a plaintext string.</summary>
    [JsonPropertyName("tokenPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuthTokenPlaintextSecretRef? TokenPlaintextSecretRef { get; set; }
}

/// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfigDatabricksApiTokenPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Databricks Model Serving Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
    [JsonPropertyName("databricksApiTokenPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfigDatabricksApiTokenPlaintextSecretRef? DatabricksApiTokenPlaintextSecretRef { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfigPrivateKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Google Cloud Vertex AI Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
    [JsonPropertyName("privateKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfigPrivateKeyPlaintextSecretRef? PrivateKeyPlaintextSecretRef { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfigMicrosoftEntraClientSecretPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfigOpenaiApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OpenAI Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
    [JsonPropertyName("microsoftEntraClientSecretPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfigMicrosoftEntraClientSecretPlaintextSecretRef? MicrosoftEntraClientSecretPlaintextSecretRef { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: &quot;https://api.openai.com/v1&quot;). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
    [JsonPropertyName("openaiApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfigOpenaiApiKeyPlaintextSecretRef? OpenaiApiKeyPlaintextSecretRef { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary>The PaLM API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfigPalmApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PaLM Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }

    /// <summary>The PaLM API key provided as a plaintext string.</summary>
    [JsonPropertyName("palmApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfigPalmApiKeyPlaintextSecretRef? PalmApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfig? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfig? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfig? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfig? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
    [JsonPropertyName("customProviderConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfig? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfig? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfig? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedEntities
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public V1beta1ModelServingSpecForProviderConfigServedEntitiesExternalModel? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigServedModels
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1beta1ModelServingSpecForProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public V1beta1ModelServingSpecForProviderConfigAutoCaptureConfig? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1beta1ModelServingSpecForProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1beta1ModelServingSpecForProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public V1beta1ModelServingSpecForProviderConfigTrafficConfig? TrafficConfig { get; set; }
}

/// <summary>A block with Email notification setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderEmailNotifications
{
    /// <summary>a list of email addresses to be notified when an endpoint fails to update its configuration or state.</summary>
    [JsonPropertyName("onUpdateFailure")]
    public IList<string>? OnUpdateFailure { get; set; }

    /// <summary>a list of email addresses to be notified when an endpoint successfully updates its configuration or state.</summary>
    [JsonPropertyName("onUpdateSuccess")]
    public IList<string>? OnUpdateSuccess { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecForProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public V1beta1ModelServingSpecForProviderAiGateway? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public V1beta1ModelServingSpecForProviderConfig? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A block with Email notification setting.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1ModelServingSpecForProviderEmailNotifications? EmailNotifications { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ModelServingSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingSpecForProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1ModelServingSpecForProviderTags>? Tags { get; set; }
}

/// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for input guardrail filters:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsInputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsOutputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsInput? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public V1beta1ModelServingSpecInitProviderAiGatewayGuardrailsOutput? Output { get; set; }
}

/// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }

    /// <summary>Specifies how many tokens are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("tokens")]
    public double? Tokens { get; set; }
}

/// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public V1beta1ModelServingSpecInitProviderAiGatewayFallbackConfig? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public V1beta1ModelServingSpecInitProviderAiGatewayGuardrails? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public V1beta1ModelServingSpecInitProviderAiGatewayInferenceTableConfig? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingSpecInitProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public V1beta1ModelServingSpecInitProviderAiGatewayUsageTrackingConfig? UsageTrackingConfig { get; set; }
}

/// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfigAi21LabsApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AI21Labs Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
    [JsonPropertyName("ai21LabsApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfigAi21LabsApiKeyPlaintextSecretRef? Ai21LabsApiKeyPlaintextSecretRef { get; set; }

    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }
}

/// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsAccessKeyIdPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsSecretAccessKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Amazon Bedrock Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsAccessKeyIdPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsAccessKeyIdPlaintextSecretRef? AwsAccessKeyIdPlaintextSecretRef { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsSecretAccessKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfigAwsSecretAccessKeyPlaintextSecretRef? AwsSecretAccessKeyPlaintextSecretRef { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary>The Anthropic API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfigAnthropicApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Anthropic Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }

    /// <summary>The Anthropic API key provided as a plaintext string.</summary>
    [JsonPropertyName("anthropicApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfigAnthropicApiKeyPlaintextSecretRef? AnthropicApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The Cohere API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfigCohereApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Cohere Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfig
{
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }

    /// <summary>The Cohere API key provided as a plaintext string.</summary>
    [JsonPropertyName("cohereApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfigCohereApiKeyPlaintextSecretRef? CohereApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The API Key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuthValuePlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>The API Key provided as a plaintext string.</summary>
    [JsonPropertyName("valuePlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuthValuePlaintextSecretRef? ValuePlaintextSecretRef { get; set; }
}

/// <summary>The token provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuthTokenPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>The token provided as a plaintext string.</summary>
    [JsonPropertyName("tokenPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuthTokenPlaintextSecretRef? TokenPlaintextSecretRef { get; set; }
}

/// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfigDatabricksApiTokenPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Databricks Model Serving Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
    [JsonPropertyName("databricksApiTokenPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfigDatabricksApiTokenPlaintextSecretRef? DatabricksApiTokenPlaintextSecretRef { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfigPrivateKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Google Cloud Vertex AI Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
    [JsonPropertyName("privateKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfigPrivateKeyPlaintextSecretRef? PrivateKeyPlaintextSecretRef { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfigMicrosoftEntraClientSecretPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfigOpenaiApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OpenAI Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
    [JsonPropertyName("microsoftEntraClientSecretPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfigMicrosoftEntraClientSecretPlaintextSecretRef? MicrosoftEntraClientSecretPlaintextSecretRef { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: &quot;https://api.openai.com/v1&quot;). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
    [JsonPropertyName("openaiApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfigOpenaiApiKeyPlaintextSecretRef? OpenaiApiKeyPlaintextSecretRef { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary>The PaLM API key provided as a plaintext string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfigPalmApiKeyPlaintextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PaLM Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }

    /// <summary>The PaLM API key provided as a plaintext string.</summary>
    [JsonPropertyName("palmApiKeyPlaintextSecretRef")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfigPalmApiKeyPlaintextSecretRef? PalmApiKeyPlaintextSecretRef { get; set; }
}

/// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfig? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfig? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfig? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfig? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
    [JsonPropertyName("customProviderConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfig? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfig? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfig? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedEntities
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public V1beta1ModelServingSpecInitProviderConfigServedEntitiesExternalModel? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigServedModels
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1beta1ModelServingSpecInitProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public V1beta1ModelServingSpecInitProviderConfigAutoCaptureConfig? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1beta1ModelServingSpecInitProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1beta1ModelServingSpecInitProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public V1beta1ModelServingSpecInitProviderConfigTrafficConfig? TrafficConfig { get; set; }
}

/// <summary>A block with Email notification setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderEmailNotifications
{
    /// <summary>a list of email addresses to be notified when an endpoint fails to update its configuration or state.</summary>
    [JsonPropertyName("onUpdateFailure")]
    public IList<string>? OnUpdateFailure { get; set; }

    /// <summary>a list of email addresses to be notified when an endpoint successfully updates its configuration or state.</summary>
    [JsonPropertyName("onUpdateSuccess")]
    public IList<string>? OnUpdateSuccess { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecInitProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public V1beta1ModelServingSpecInitProviderAiGateway? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public V1beta1ModelServingSpecInitProviderConfig? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A block with Email notification setting.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1ModelServingSpecInitProviderEmailNotifications? EmailNotifications { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ModelServingSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingSpecInitProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1ModelServingSpecInitProviderTags>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelServingSpecManagementPoliciesEnum>))]
public enum V1beta1ModelServingSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelServingSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ModelServingSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelServingSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ModelServingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ModelServingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ModelServingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelServingSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ModelServingSpec defines the desired state of ModelServing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1ModelServingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ModelServingSpecForProvider ForProvider { get; set; }

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
    public V1beta1ModelServingSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ModelServingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ModelServingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ModelServingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for input guardrail filters:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsInputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for guardrail PII filter:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsOutputPii? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsInput? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public V1beta1ModelServingStatusAtProviderAiGatewayGuardrailsOutput? Output { get; set; }
}

/// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }

    /// <summary>Specifies how many tokens are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("tokens")]
    public double? Tokens { get; set; }
}

/// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public V1beta1ModelServingStatusAtProviderAiGatewayFallbackConfig? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public V1beta1ModelServingStatusAtProviderAiGatewayGuardrails? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public V1beta1ModelServingStatusAtProviderAiGatewayInferenceTableConfig? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingStatusAtProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public V1beta1ModelServingStatusAtProviderAiGatewayUsageTrackingConfig? UsageTrackingConfig { get; set; }
}

/// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary>AI21Labs Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }
}

/// <summary>Amazon Bedrock Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary>Anthropic Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }
}

/// <summary>Cohere Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCohereConfig
{
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }
}

/// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary>Databricks Model Serving Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary>Google Cloud Vertex AI Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>OpenAI Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: &quot;https://api.openai.com/v1&quot;). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary>PaLM Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }
}

/// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAi21labsConfig? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAmazonBedrockConfig? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAnthropicConfig? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCohereConfig? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is &apos;custom&apos;.</summary>
    [JsonPropertyName("customProviderConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfig? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelOpenaiConfig? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModelPalmConfig? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedEntities
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public V1beta1ModelServingStatusAtProviderConfigServedEntitiesExternalModel? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigServedModels
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("burstScalingEnabled")]
    public bool? BurstScalingEnabled { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1beta1ModelServingStatusAtProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public V1beta1ModelServingStatusAtProviderConfigAutoCaptureConfig? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1beta1ModelServingStatusAtProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1beta1ModelServingStatusAtProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public V1beta1ModelServingStatusAtProviderConfigTrafficConfig? TrafficConfig { get; set; }
}

/// <summary>A block with Email notification setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderEmailNotifications
{
    /// <summary>a list of email addresses to be notified when an endpoint fails to update its configuration or state.</summary>
    [JsonPropertyName("onUpdateFailure")]
    public IList<string>? OnUpdateFailure { get; set; }

    /// <summary>a list of email addresses to be notified when an endpoint successfully updates its configuration or state.</summary>
    [JsonPropertyName("onUpdateSuccess")]
    public IList<string>? OnUpdateSuccess { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusAtProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public V1beta1ModelServingStatusAtProviderAiGateway? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public V1beta1ModelServingStatusAtProviderConfig? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A block with Email notification setting.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1ModelServingStatusAtProviderEmailNotifications? EmailNotifications { get; set; }

    /// <summary>Invocation url of the endpoint.</summary>
    [JsonPropertyName("endpointUrl")]
    public string? EndpointUrl { get; set; }

    /// <summary>Equal to the name argument and used to identify the serving endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ModelServingStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1ModelServingStatusAtProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Unique identifier of the serving endpoint primarily used to set permissions and refer to this instance for other operations.</summary>
    [JsonPropertyName("servingEndpointId")]
    public string? ServingEndpointId { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1ModelServingStatusAtProviderTags>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatusConditions
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

/// <summary>ModelServingStatus defines the observed state of ModelServing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelServingStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ModelServingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ModelServingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ModelServing is the Schema for the ModelServings API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ModelServing : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ModelServingSpec>, IStatus<V1beta1ModelServingStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ModelServing";
    public const string KubeGroup = "serving.databricks.crossplane.io";
    public const string KubePluralName = "modelservings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "serving.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelServing";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelServingSpec defines the desired state of ModelServing</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ModelServingSpec Spec { get; set; }

    /// <summary>ModelServingStatus defines the observed state of ModelServing.</summary>
    [JsonPropertyName("status")]
    public V1beta1ModelServingStatus? Status { get; set; }
}