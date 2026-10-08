#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagent.aws.upbound.io;
/// <summary>Flow is the Schema for the Flows API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FlowList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Flow>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FlowList";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Flow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Flow> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecDeletionPolicyEnum>))]
public enum V1beta1FlowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionConnectionConfigurationConditional
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionConnectionConfigurationData
{
    /// <summary>The name of the output in the source node that the connection begins from.</summary>
    [JsonPropertyName("sourceOutput")]
    public string? SourceOutput { get; set; }

    /// <summary>The name of the input in the target node that the connection ends at.</summary>
    [JsonPropertyName("targetInput")]
    public string? TargetInput { get; set; }
}

/// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionConnectionConfiguration
{
    /// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
    [JsonPropertyName("conditional")]
    public V1beta1FlowSpecForProviderDefinitionConnectionConfigurationConditional? Conditional { get; set; }

    /// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
    [JsonPropertyName("data")]
    public V1beta1FlowSpecForProviderDefinitionConnectionConfigurationData? Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionConnection
{
    /// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowSpecForProviderDefinitionConnectionConfiguration? Configuration { get; set; }

    /// <summary>A name for the connection that you can reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The node that the connection starts at.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The node that the connection ends at.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Whether the source node that the connection begins from is a condition node Conditional or not Data.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationAgent
{
    /// <summary>ARN of the alias of the agent to invoke.</summary>
    [JsonPropertyName("agentAliasArn")]
    public string? AgentAliasArn { get; set; }
}

/// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationCollector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationConditionCondition
{
    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationCondition
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationConditionCondition>? Condition { get; set; }
}

/// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationInlineCode
{
    /// <summary>The code that&apos;s executed in your inline code node.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>The programming language used by your inline code node.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationInput
{
}

/// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationIterator
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText? Text { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBase
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the knowledge base to query.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunction
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationLex
{
    /// <summary>ARN of the Amazon Lex bot alias to invoke.</summary>
    [JsonPropertyName("botAliasArn")]
    public string? BotAliasArn { get; set; }

    /// <summary>The Region to invoke the Amazon Lex bot in</summary>
    [JsonPropertyName("localeId")]
    public string? LocaleId { get; set; }
}

/// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationOutput
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See Message Content for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>The description of the tool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration
{
    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat? Chat { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText? Text { get; set; }
}

/// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInline
{
    /// <summary>Additional fields to be included in the model request for the Prompt node.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>The type of prompt template. Valid values: TEXT, CHAT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Prompt in bedrockagent to populate promptArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Prompt in bedrockagent to populate promptArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResource
{
    /// <summary>ARN of the prompt from Prompt management.</summary>
    [JsonPropertyName("promptArn")]
    public string? PromptArn { get; set; }

    /// <summary>Reference to a Prompt in bedrockagent to populate promptArn.</summary>
    [JsonPropertyName("promptArnRef")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRef? PromptArnRef { get; set; }

    /// <summary>Selector for a Prompt in bedrockagent to populate promptArn.</summary>
    [JsonPropertyName("promptArnSelector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelector? PromptArnSelector { get; set; }
}

/// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfiguration
{
    /// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
    [JsonPropertyName("inline")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationInline? Inline { get; set; }

    /// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
    [JsonPropertyName("resource")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfigurationResource? Resource { get; set; }
}

/// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationPrompt
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPromptSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelector? BucketNameSelector { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrieval
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrievalServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelector? BucketNameSelector { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorage
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorageServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeConfiguration
{
    /// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationAgent? Agent { get; set; }

    /// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
    [JsonPropertyName("collector")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationCollector? Collector { get; set; }

    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationCondition? Condition { get; set; }

    /// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
    [JsonPropertyName("inlineCode")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationInlineCode? InlineCode { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationInput? Input { get; set; }

    /// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
    [JsonPropertyName("iterator")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationIterator? Iterator { get; set; }

    /// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
    [JsonPropertyName("knowledgeBase")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationKnowledgeBase? KnowledgeBase { get; set; }

    /// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
    [JsonPropertyName("lambdaFunction")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLambdaFunction? LambdaFunction { get; set; }

    /// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
    [JsonPropertyName("lex")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationLex? Lex { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationOutput? Output { get; set; }

    /// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
    [JsonPropertyName("prompt")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationPrompt? Prompt { get; set; }

    /// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
    [JsonPropertyName("retrieval")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationRetrieval? Retrieval { get; set; }

    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
    [JsonPropertyName("storage")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfigurationStorage? Storage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeInput
{
    /// <summary>How input data flows between iterations in a DoWhile loop.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNodeOutput
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinitionNode
{
    /// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowSpecForProviderDefinitionNodeConfiguration? Configuration { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeInput>? Input { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1FlowSpecForProviderDefinitionNodeOutput>? Output { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDefinition
{
    /// <summary>A list of connection definitions in the flow. See Connection for more information.</summary>
    [JsonPropertyName("connection")]
    public IList<V1beta1FlowSpecForProviderDefinitionConnection>? Connection { get; set; }

    /// <summary>A list of node definitions in the flow. See Node for more information.</summary>
    [JsonPropertyName("node")]
    public IList<V1beta1FlowSpecForProviderDefinitionNode>? Node { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderExecutionRoleArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProvider
{
    /// <summary>ARN of the KMS key to encrypt the flow.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnRef")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnRef? CustomerEncryptionKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnSelector")]
    public V1beta1FlowSpecForProviderCustomerEncryptionKeyArnSelector? CustomerEncryptionKeyArnSelector { get; set; }

    /// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
    [JsonPropertyName("definition")]
    public V1beta1FlowSpecForProviderDefinition? Definition { get; set; }

    /// <summary>A description for the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the service role with permissions to create and manage a flow. For more information, see Create a service role for flows in Amazon Bedrock in the Amazon Bedrock User Guide.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1FlowSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1FlowSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A name for the flow.</summary>
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
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionConnectionConfigurationConditional
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionConnectionConfigurationData
{
    /// <summary>The name of the output in the source node that the connection begins from.</summary>
    [JsonPropertyName("sourceOutput")]
    public string? SourceOutput { get; set; }

    /// <summary>The name of the input in the target node that the connection ends at.</summary>
    [JsonPropertyName("targetInput")]
    public string? TargetInput { get; set; }
}

/// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionConnectionConfiguration
{
    /// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
    [JsonPropertyName("conditional")]
    public V1beta1FlowSpecInitProviderDefinitionConnectionConfigurationConditional? Conditional { get; set; }

    /// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
    [JsonPropertyName("data")]
    public V1beta1FlowSpecInitProviderDefinitionConnectionConfigurationData? Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionConnection
{
    /// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowSpecInitProviderDefinitionConnectionConfiguration? Configuration { get; set; }

    /// <summary>A name for the connection that you can reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The node that the connection starts at.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The node that the connection ends at.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Whether the source node that the connection begins from is a condition node Conditional or not Data.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationAgent
{
    /// <summary>ARN of the alias of the agent to invoke.</summary>
    [JsonPropertyName("agentAliasArn")]
    public string? AgentAliasArn { get; set; }
}

/// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationCollector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationConditionCondition
{
    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationCondition
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationConditionCondition>? Condition { get; set; }
}

/// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationInlineCode
{
    /// <summary>The code that&apos;s executed in your inline code node.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>The programming language used by your inline code node.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationInput
{
}

/// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationIterator
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText? Text { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBase
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the knowledge base to query.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBaseKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunction
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunctionLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLex
{
    /// <summary>ARN of the Amazon Lex bot alias to invoke.</summary>
    [JsonPropertyName("botAliasArn")]
    public string? BotAliasArn { get; set; }

    /// <summary>The Region to invoke the Amazon Lex bot in</summary>
    [JsonPropertyName("localeId")]
    public string? LocaleId { get; set; }
}

/// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationOutput
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See Message Content for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>The description of the tool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration
{
    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat? Chat { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText? Text { get; set; }
}

/// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInline
{
    /// <summary>Additional fields to be included in the model request for the Prompt node.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>The type of prompt template. Valid values: TEXT, CHAT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Prompt in bedrockagent to populate promptArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Prompt in bedrockagent to populate promptArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResource
{
    /// <summary>ARN of the prompt from Prompt management.</summary>
    [JsonPropertyName("promptArn")]
    public string? PromptArn { get; set; }

    /// <summary>Reference to a Prompt in bedrockagent to populate promptArn.</summary>
    [JsonPropertyName("promptArnRef")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnRef? PromptArnRef { get; set; }

    /// <summary>Selector for a Prompt in bedrockagent to populate promptArn.</summary>
    [JsonPropertyName("promptArnSelector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResourcePromptArnSelector? PromptArnSelector { get; set; }
}

/// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfiguration
{
    /// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
    [JsonPropertyName("inline")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationInline? Inline { get; set; }

    /// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
    [JsonPropertyName("resource")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfigurationResource? Resource { get; set; }
}

/// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPrompt
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPromptSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3BucketNameSelector? BucketNameSelector { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrieval
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrievalServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3BucketNameSelector? BucketNameSelector { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorage
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorageServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeConfiguration
{
    /// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationAgent? Agent { get; set; }

    /// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
    [JsonPropertyName("collector")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationCollector? Collector { get; set; }

    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationCondition? Condition { get; set; }

    /// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
    [JsonPropertyName("inlineCode")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationInlineCode? InlineCode { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationInput? Input { get; set; }

    /// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
    [JsonPropertyName("iterator")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationIterator? Iterator { get; set; }

    /// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
    [JsonPropertyName("knowledgeBase")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationKnowledgeBase? KnowledgeBase { get; set; }

    /// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
    [JsonPropertyName("lambdaFunction")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLambdaFunction? LambdaFunction { get; set; }

    /// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
    [JsonPropertyName("lex")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationLex? Lex { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationOutput? Output { get; set; }

    /// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
    [JsonPropertyName("prompt")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationPrompt? Prompt { get; set; }

    /// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
    [JsonPropertyName("retrieval")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationRetrieval? Retrieval { get; set; }

    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
    [JsonPropertyName("storage")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfigurationStorage? Storage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeInput
{
    /// <summary>How input data flows between iterations in a DoWhile loop.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNodeOutput
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinitionNode
{
    /// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowSpecInitProviderDefinitionNodeConfiguration? Configuration { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeInput>? Input { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNodeOutput>? Output { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDefinition
{
    /// <summary>A list of connection definitions in the flow. See Connection for more information.</summary>
    [JsonPropertyName("connection")]
    public IList<V1beta1FlowSpecInitProviderDefinitionConnection>? Connection { get; set; }

    /// <summary>A list of node definitions in the flow. See Node for more information.</summary>
    [JsonPropertyName("node")]
    public IList<V1beta1FlowSpecInitProviderDefinitionNode>? Node { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderExecutionRoleArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1FlowSpecInitProvider
{
    /// <summary>ARN of the KMS key to encrypt the flow.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnRef")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnRef? CustomerEncryptionKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate customerEncryptionKeyArn.</summary>
    [JsonPropertyName("customerEncryptionKeyArnSelector")]
    public V1beta1FlowSpecInitProviderCustomerEncryptionKeyArnSelector? CustomerEncryptionKeyArnSelector { get; set; }

    /// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
    [JsonPropertyName("definition")]
    public V1beta1FlowSpecInitProviderDefinition? Definition { get; set; }

    /// <summary>A description for the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the service role with permissions to create and manage a flow. For more information, see Create a service role for flows in Amazon Bedrock in the Amazon Bedrock User Guide.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1FlowSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A name for the flow.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecManagementPoliciesEnum>))]
public enum V1beta1FlowSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FlowSpec defines the desired state of Flow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpec
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
    public V1beta1FlowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1FlowSpecForProvider ForProvider { get; set; }

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
    public V1beta1FlowSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1FlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionConnectionConfigurationConditional
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionConnectionConfigurationData
{
    /// <summary>The name of the output in the source node that the connection begins from.</summary>
    [JsonPropertyName("sourceOutput")]
    public string? SourceOutput { get; set; }

    /// <summary>The name of the input in the target node that the connection ends at.</summary>
    [JsonPropertyName("targetInput")]
    public string? TargetInput { get; set; }
}

/// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionConnectionConfiguration
{
    /// <summary>The configuration of a connection originating from a Condition node. See Conditional Connection Configuration for more information.</summary>
    [JsonPropertyName("conditional")]
    public V1beta1FlowStatusAtProviderDefinitionConnectionConfigurationConditional? Conditional { get; set; }

    /// <summary>The configuration of a connection originating from a node that isn’t a Condition node. See Data Connection Configuration for more information.</summary>
    [JsonPropertyName("data")]
    public V1beta1FlowStatusAtProviderDefinitionConnectionConfigurationData? Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionConnection
{
    /// <summary>Configuration of the connection. See Connection Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowStatusAtProviderDefinitionConnectionConfiguration? Configuration { get; set; }

    /// <summary>A name for the connection that you can reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The node that the connection starts at.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The node that the connection ends at.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Whether the source node that the connection begins from is a condition node Conditional or not Data.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationAgent
{
    /// <summary>ARN of the alias of the agent to invoke.</summary>
    [JsonPropertyName("agentAliasArn")]
    public string? AgentAliasArn { get; set; }
}

/// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationCollector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationConditionCondition
{
    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationCondition
{
    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationConditionCondition>? Condition { get; set; }
}

/// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationInlineCode
{
    /// <summary>The code that&apos;s executed in your inline code node.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>The programming language used by your inline code node.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationInput
{
}

/// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationIterator
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfigurationText? Text { get; set; }
}

/// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBase
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBaseInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the knowledge base to query.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    [JsonPropertyName("numberOfResults")]
    public double? NumberOfResults { get; set; }
}

/// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationLambdaFunction
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationLex
{
    /// <summary>ARN of the Amazon Lex bot alias to invoke.</summary>
    [JsonPropertyName("botAliasArn")]
    public string? BotAliasArn { get; set; }

    /// <summary>The Region to invoke the Amazon Lex bot in</summary>
    [JsonPropertyName("localeId")]
    public string? LocaleId { get; set; }
}

/// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationOutput
{
}

/// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptGuardrailConfiguration
{
    /// <summary>The unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>The version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText
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

/// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration
{
    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfigurationText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContentCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage
{
    /// <summary>Contains the content for the message you pass to, or receive from a model. See Message Content for more information.</summary>
    [JsonPropertyName("content")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessageContent>? Content { get; set; }

    /// <summary>The role that the message belongs to.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystemCachePoint? CachePoint { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
{
    /// <summary>A JSON object defining the input schema for the tool.</summary>
    [JsonPropertyName("json")]
    public string? Json { get; set; }
}

/// <summary>The specification for the tool. See Tool Specification for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec
{
    /// <summary>The description of the tool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The input schema of the tool. See Tool Input Schema for more information.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema? InputSchema { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolCachePoint? CachePoint { get; set; }

    /// <summary>The specification for the tool. See Tool Specification for more information.</summary>
    [JsonPropertyName("toolSpec")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolToolSpec? ToolSpec { get; set; }
}

/// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny
{
}

/// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto
{
}

/// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice
{
    /// <summary>Defines tools, at least one of which must be requested by the model. No text is generated but the results of tool use are sent back to the model to help generate a response. This block has no fields.</summary>
    [JsonPropertyName("any")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAny? Any { get; set; }

    /// <summary>Defines tools. The model automatically decides whether to call a tool or to generate text instead. This block has no fields.</summary>
    [JsonPropertyName("auto")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceAuto? Auto { get; set; }

    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoiceTool? Tool { get; set; }
}

/// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration
{
    /// <summary>Defines a specific tool that the model must request. No text is generated but the results of tool use are sent back to the model to help generate a response. See Named Tool for more information.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationTool>? Tool { get; set; }

    /// <summary>Defines which tools the model should request when invoked. See Tool Choice for more information.</summary>
    [JsonPropertyName("toolChoice")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfigurationToolChoice? ToolChoice { get; set; }
}

/// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat
{
    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatInputVariable>? InputVariable { get; set; }

    /// <summary>A list of messages in the chat for the prompt. See Message for more information.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatMessage>? Message { get; set; }

    /// <summary>A list of system prompts to provide context to the model or to describe how it should behave. See System for more information.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatSystem>? System { get; set; }

    /// <summary>Configuration information for the tools that the model can use when generating a response. See Tool Configuration for more information.</summary>
    [JsonPropertyName("toolConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChatToolConfiguration? ToolConfiguration { get; set; }
}

/// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint
{
    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The message for the prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText
{
    /// <summary>Creates a cache checkpoint within a tool designation. See Cache Point for more information.</summary>
    [JsonPropertyName("cachePoint")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextCachePoint? CachePoint { get; set; }

    /// <summary>A list of variables in the prompt template. See Input Variable for more information.</summary>
    [JsonPropertyName("inputVariable")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationTextInputVariable>? InputVariable { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration
{
    /// <summary>Contains configurations to use the prompt in a conversational format. See Chat Template Configuration for more information.</summary>
    [JsonPropertyName("chat")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationChat? Chat { get; set; }

    /// <summary>The message for the prompt.</summary>
    [JsonPropertyName("text")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfigurationText? Text { get; set; }
}

/// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInline
{
    /// <summary>Additional fields to be included in the model request for the Prompt node.</summary>
    [JsonPropertyName("additionalModelRequestFields")]
    public string? AdditionalModelRequestFields { get; set; }

    /// <summary>Configures model inference for knowledge base query and response generation. See Inference Configuration for more information.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineInferenceConfiguration? InferenceConfiguration { get; set; }

    /// <summary>The unique identifier of the model or inference profile to use to generate a response from the query results. Omit this field if you want to return the retrieved results as an array.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Contains a prompt and variables in the prompt that can be replaced with values at runtime. See Prompt Template Configuration for more information.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInlineTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>The type of prompt template. Valid values: TEXT, CHAT.</summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

/// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationResource
{
    /// <summary>ARN of the prompt from Prompt management.</summary>
    [JsonPropertyName("promptArn")]
    public string? PromptArn { get; set; }
}

/// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfiguration
{
    /// <summary>Contains configurations for a prompt that is defined inline. See Prompt Inline Configuration for more information.</summary>
    [JsonPropertyName("inline")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationInline? Inline { get; set; }

    /// <summary>Contains configurations for a prompt from Prompt management. See Prompt Resource Configuration for more information.</summary>
    [JsonPropertyName("resource")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfigurationResource? Resource { get; set; }
}

/// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPrompt
{
    /// <summary>Configures a guardrail for prompt generation. See Guardrail Configuration for more information.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptGuardrailConfiguration? GuardrailConfiguration { get; set; }

    /// <summary>Configures the prompt source, either inline or from Prompt management. See Source Configuration for more information.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPromptSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrievalServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrievalServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrieval
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrievalServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorageServiceConfigurationS3
{
    /// <summary>The name of the Amazon S3 bucket in which to store the input into the node.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorageServiceConfiguration
{
    /// <summary>Contains configurations for the service to use for storing the input into the node. See Storage S3 Service Configuration for more information.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorageServiceConfigurationS3? S3 { get; set; }
}

/// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorage
{
    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Service Configuration for more information.</summary>
    [JsonPropertyName("serviceConfiguration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorageServiceConfiguration? ServiceConfiguration { get; set; }
}

/// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeConfiguration
{
    /// <summary>Contains configurations for an agent node in your flow. Invokes an alias of an agent and returns the response. See Agent Node Configuration for more information.</summary>
    [JsonPropertyName("agent")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationAgent? Agent { get; set; }

    /// <summary>Contains configurations for a collector node in your flow. Collects an iteration of inputs and consolidates them into an array of outputs. This object has no fields.</summary>
    [JsonPropertyName("collector")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationCollector? Collector { get; set; }

    /// <summary>Contains configurations for a Condition node in your flow. Defines conditions that lead to different branches of the flow. See Condition Node Configuration for more information.</summary>
    [JsonPropertyName("condition")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationCondition? Condition { get; set; }

    /// <summary>Contains configurations for an inline code node in your flow. See Inline Code Node Configuration for more information.</summary>
    [JsonPropertyName("inlineCode")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationInlineCode? InlineCode { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationInput? Input { get; set; }

    /// <summary>Contains configurations for an iterator node in your flow. Takes an input that is an array and iteratively sends each item of the array as an output to the following node. The size of the array is also returned in the output. The output flow node at the end of the flow iteration will return a response for each member of the array. To return only one response, you can include a collector node downstream from the iterator node. This block has no fields.</summary>
    [JsonPropertyName("iterator")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationIterator? Iterator { get; set; }

    /// <summary>Contains configurations for a knowledge base node in your flow. Queries a knowledge base and returns the retrieved results or generated response. See Knowledge Base Node Configuration for more information.</summary>
    [JsonPropertyName("knowledgeBase")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationKnowledgeBase? KnowledgeBase { get; set; }

    /// <summary>Contains configurations for a Lambda function node in your flow. Invokes a Lambda function. See Lambda Function Node Configuration for more information.</summary>
    [JsonPropertyName("lambdaFunction")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationLambdaFunction? LambdaFunction { get; set; }

    /// <summary>Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to identify the intent of the input and return the intent as the output. See Lex Node Configuration for more information.</summary>
    [JsonPropertyName("lex")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationLex? Lex { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationOutput? Output { get; set; }

    /// <summary>Contains configurations for a prompt node in your flow. Runs a prompt and generates the model response as the output. You can use a prompt from Prompt management or you can configure one in this node. See Prompt Node Configuration for more information.</summary>
    [JsonPropertyName("prompt")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationPrompt? Prompt { get; set; }

    /// <summary>Contains configurations for a Retrieval node in your flow. Retrieves data from an Amazon S3 location and returns it as the output. See Retrieval Node Configuration for more information.</summary>
    [JsonPropertyName("retrieval")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationRetrieval? Retrieval { get; set; }

    /// <summary>Contains configurations for a Storage node in your flow. Stores an input in an Amazon S3 location. See Storage Node Configuration for more information.</summary>
    [JsonPropertyName("storage")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfigurationStorage? Storage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeInput
{
    /// <summary>How input data flows between iterations in a DoWhile loop.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>An expression that formats the input for the node. For an explanation of how to create expressions, see Expressions in Prompt flows in Amazon Bedrock.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNodeOutput
{
    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinitionNode
{
    /// <summary>Contains configurations for the node. See Node Configuration for more information.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1FlowStatusAtProviderDefinitionNodeConfiguration? Configuration { get; set; }

    /// <summary>A list of objects containing information about an input into the node. See Node Input for more information.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeInput>? Input { get; set; }

    /// <summary>The name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of objects containing information about an output from the node. See Node Output for more information.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNodeOutput>? Output { get; set; }

    /// <summary>The data type of the output. If the output doesn’t match this type at runtime, a validation error will be thrown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDefinition
{
    /// <summary>A list of connection definitions in the flow. See Connection for more information.</summary>
    [JsonPropertyName("connection")]
    public IList<V1beta1FlowStatusAtProviderDefinitionConnection>? Connection { get; set; }

    /// <summary>A list of node definitions in the flow. See Node for more information.</summary>
    [JsonPropertyName("node")]
    public IList<V1beta1FlowStatusAtProviderDefinitionNode>? Node { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProvider
{
    /// <summary>ARN of the flow.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The time at which the flow was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>ARN of the KMS key to encrypt the flow.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>A definition of the nodes and connections between nodes in the flow. See Definition for more information.</summary>
    [JsonPropertyName("definition")]
    public V1beta1FlowStatusAtProviderDefinition? Definition { get; set; }

    /// <summary>A description for the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the service role with permissions to create and manage a flow. For more information, see Create a service role for flows in Amazon Bedrock in the Amazon Bedrock User Guide.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>The unique identifier of the flow.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A name for the flow.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The status of the flow.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The time at which the flow was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary>The version of the flow.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusConditions
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

/// <summary>FlowStatus defines the observed state of Flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FlowStatusConditions>? Conditions { get; set; }

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

/// <summary>Flow is the Schema for the Flows API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Flow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FlowSpec>, IStatus<V1beta1FlowStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Flow";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Flow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlowSpec defines the desired state of Flow</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FlowSpec Spec { get; set; }

    /// <summary>FlowStatus defines the observed state of Flow.</summary>
    [JsonPropertyName("status")]
    public V1beta1FlowStatus? Status { get; set; }
}