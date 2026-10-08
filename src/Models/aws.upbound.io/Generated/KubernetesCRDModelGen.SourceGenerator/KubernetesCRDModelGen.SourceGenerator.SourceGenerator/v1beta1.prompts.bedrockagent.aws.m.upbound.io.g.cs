#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagent.aws.m.upbound.io;
/// <summary>Prompt is the Schema for the Prompts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PromptList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Prompt>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PromptList";
    public const string KubeGroup = "bedrockagent.aws.m.upbound.io";
    public const string KubePluralName = "prompts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PromptList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Prompt objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Prompt> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum>))]
public enum V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelector
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
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantGenAiResourceAgent
{
    /// <summary>ARN of the agent with which to use the prompt.</summary>
    [JsonPropertyName("agentIdentifier")]
    public string? AgentIdentifier { get; set; }
}

/// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantGenAiResource
{
    /// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1PromptSpecForProviderVariantGenAiResourceAgent? Agent { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantInferenceConfigurationText
{
    /// <summary>Maximum number of tokens to return in the response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of strings that define sequences after which the model will stop generating.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Controls the randomness of the response. Choose a lower value for more predictable outputs and a higher value for more surprising outputs.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Percentage of most-likely candidates that the model considers for the next token.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantInferenceConfiguration
{
    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptSpecForProviderVariantInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantMetadata
{
    /// <summary>Key of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessageContent
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See [Message Content] for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatSystemCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatSystem
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfiguration
{
    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationTextCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationTextInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfigurationText
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptSpecForProviderVariantTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariantTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationChat? Chat { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptSpecForProviderVariantTemplateConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProviderVariant
{
    /// <summary>Contains model-specific inference configurations that aren’t in the inferenceConfiguration field. To see model-specific inference parameters, see Inference request parameters and response fields for foundation models.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
    [JsonPropertyName("genAiResource")]
    public V1beta1PromptSpecForProviderVariantGenAiResource? GenAiResource { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1PromptSpecForProviderVariantInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>A list of objects, each containing a key-value pair that defines a metadata tag and value to attach to a prompt variant. See Metadata for more information.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1PromptSpecForProviderVariantMetadata>? Metadata { get; set; }

    /// <summary>Unique identifier of the model or inference profile with which to run inference on the prompt. If this is not supplied, then a gen_ai_resource must be defined.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1PromptSpecForProviderVariantTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>Type of prompt template to use. Valid values: CHAT, TEXT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecForProvider
{
    /// <summary>ARN of the KMS key that you encrypted the prompt with.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnRef")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnRef? CustomerEncryptionKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnSelector")]
    public V1beta1PromptSpecForProviderCustomerEncryptionKeyArnSelector? CustomerEncryptionKeyArnSelector { get; set; }

    /// <summary>Name of the default variant for your prompt.</summary>
    [JsonPropertyName("defaultVariant")]
    public string? DefaultVariant { get; set; }

    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of objects, each containing details about a variant of the prompt. See Variant for more information.</summary>
    [JsonPropertyName("variant")]
    public IList<V1beta1PromptSpecForProviderVariant>? Variant { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum>))]
public enum V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelector
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
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantGenAiResourceAgent
{
    /// <summary>ARN of the agent with which to use the prompt.</summary>
    [JsonPropertyName("agentIdentifier")]
    public string? AgentIdentifier { get; set; }
}

/// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantGenAiResource
{
    /// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1PromptSpecInitProviderVariantGenAiResourceAgent? Agent { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantInferenceConfigurationText
{
    /// <summary>Maximum number of tokens to return in the response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of strings that define sequences after which the model will stop generating.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Controls the randomness of the response. Choose a lower value for more predictable outputs and a higher value for more surprising outputs.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Percentage of most-likely candidates that the model considers for the next token.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantInferenceConfiguration
{
    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptSpecInitProviderVariantInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantMetadata
{
    /// <summary>Key of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessageContent
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See [Message Content] for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatSystemCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatSystem
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfiguration
{
    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationTextCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationTextInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfigurationText
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptSpecInitProviderVariantTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariantTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationChat? Chat { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpecInitProviderVariant
{
    /// <summary>Contains model-specific inference configurations that aren’t in the inferenceConfiguration field. To see model-specific inference parameters, see Inference request parameters and response fields for foundation models.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
    [JsonPropertyName("genAiResource")]
    public V1beta1PromptSpecInitProviderVariantGenAiResource? GenAiResource { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1PromptSpecInitProviderVariantInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>A list of objects, each containing a key-value pair that defines a metadata tag and value to attach to a prompt variant. See Metadata for more information.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1PromptSpecInitProviderVariantMetadata>? Metadata { get; set; }

    /// <summary>Unique identifier of the model or inference profile with which to run inference on the prompt. If this is not supplied, then a gen_ai_resource must be defined.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1PromptSpecInitProviderVariantTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>Type of prompt template to use. Valid values: CHAT, TEXT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
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
public partial class V1beta1PromptSpecInitProvider
{
    /// <summary>ARN of the KMS key that you encrypted the prompt with.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnRef")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnRef? CustomerEncryptionKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnSelector")]
    public V1beta1PromptSpecInitProviderCustomerEncryptionKeyArnSelector? CustomerEncryptionKeyArnSelector { get; set; }

    /// <summary>Name of the default variant for your prompt.</summary>
    [JsonPropertyName("defaultVariant")]
    public string? DefaultVariant { get; set; }

    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of objects, each containing details about a variant of the prompt. See Variant for more information.</summary>
    [JsonPropertyName("variant")]
    public IList<V1beta1PromptSpecInitProviderVariant>? Variant { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PromptSpecManagementPoliciesEnum>))]
public enum V1beta1PromptSpecManagementPoliciesEnum
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
public partial class V1beta1PromptSpecProviderConfigRef
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
public partial class V1beta1PromptSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PromptSpec defines the desired state of Prompt</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PromptSpecForProvider ForProvider { get; set; }

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
    public V1beta1PromptSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PromptSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PromptSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PromptSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantGenAiResourceAgent
{
    /// <summary>ARN of the agent with which to use the prompt.</summary>
    [JsonPropertyName("agentIdentifier")]
    public string? AgentIdentifier { get; set; }
}

/// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantGenAiResource
{
    /// <summary>Specifies an Amazon Bedrock agent with which to use the prompt. See Agent Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1PromptStatusAtProviderVariantGenAiResourceAgent? Agent { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantInferenceConfigurationText
{
    /// <summary>Maximum number of tokens to return in the response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>List of strings that define sequences after which the model will stop generating.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Controls the randomness of the response. Choose a lower value for more predictable outputs and a higher value for more surprising outputs.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Percentage of most-likely candidates that the model considers for the next token.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantInferenceConfiguration
{
    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptStatusAtProviderVariantInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantMetadata
{
    /// <summary>Key of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of a metadata tag for a prompt variant.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessageContent
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See [Message Content] for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatSystemCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatSystem
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This object has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This object has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfiguration
{
    /// <summary>A list of tools to pass to a model. See Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationTextCachePoint
{
    /// <summary>Indicates that the CachePointBlock is of the default type. Valid values: default.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationTextInputVariable
{
    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfigurationText
{
    /// <summary>A cache checkpoint within a template configuration. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1PromptStatusAtProviderVariantTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariantTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationChat? Chat { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Text Inference Configuration for more information.</summary>
    [JsonPropertyName("text")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProviderVariant
{
    /// <summary>Contains model-specific inference configurations that aren’t in the inferenceConfiguration field. To see model-specific inference parameters, see Inference request parameters and response fields for foundation models.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Specifies a generative AI resource with which to use the prompt. If this is not supplied, then a gen_ai_resource must be defined. See Generative AI Resource for more information.</summary>
    [JsonPropertyName("genAiResource")]
    public V1beta1PromptStatusAtProviderVariantGenAiResource? GenAiResource { get; set; }

    /// <summary>Contains inference configurations for the prompt variant. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1PromptStatusAtProviderVariantInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>A list of objects, each containing a key-value pair that defines a metadata tag and value to attach to a prompt variant. See Metadata for more information.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1PromptStatusAtProviderVariantMetadata>? Metadata { get; set; }

    /// <summary>Unique identifier of the model or inference profile with which to run inference on the prompt. If this is not supplied, then a gen_ai_resource must be defined.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Contains configurations for the prompt template. See Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1PromptStatusAtProviderVariantTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>Type of prompt template to use. Valid values: CHAT, TEXT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusAtProvider
{
    /// <summary>ARN of the prompt.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Time at which the prompt was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>ARN of the KMS key that you encrypted the prompt with.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Name of the default variant for your prompt.</summary>
    [JsonPropertyName("defaultVariant")]
    public string? DefaultVariant { get; set; }

    /// <summary>Description of the prompt.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Unique identifier of the prompt.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the prompt.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Time at which the prompt was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary>A list of objects, each containing details about a variant of the prompt. See Variant for more information.</summary>
    [JsonPropertyName("variant")]
    public IList<V1beta1PromptStatusAtProviderVariant>? Variant { get; set; }

    /// <summary>Version of the prompt. When you create a prompt, the version created is the DRAFT version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatusConditions
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

/// <summary>PromptStatus defines the observed state of Prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PromptStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PromptStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PromptStatusConditions>? Conditions { get; set; }

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

/// <summary>Prompt is the Schema for the Prompts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Prompt : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PromptSpec>, IStatus<V1beta1PromptStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Prompt";
    public const string KubeGroup = "bedrockagent.aws.m.upbound.io";
    public const string KubePluralName = "prompts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Prompt";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PromptSpec defines the desired state of Prompt</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PromptSpec Spec { get; set; }

    /// <summary>PromptStatus defines the observed state of Prompt.</summary>
    [JsonPropertyName("status")]
    public V1beta1PromptStatus? Status { get; set; }
}