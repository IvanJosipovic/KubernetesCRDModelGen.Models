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
/// <summary>MemoryStrategy is the Schema for the MemoryStrategys API. Manages an AWS Bedrock AgentCore Memory Strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MemoryStrategyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MemoryStrategy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MemoryStrategyList";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "memorystrategies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemoryStrategyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MemoryStrategy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MemoryStrategy> Items { get; set; }
}

/// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationConsolidation
{
    /// <summary>Additional text to append to the model prompt for consolidation processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for consolidation processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationExtraction
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationReflection
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelector
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
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelector
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
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfiguration
{
    /// <summary>S3 bucket name for event payload delivery.</summary>
    [JsonPropertyName("payloadDeliveryBucketName")]
    public string? PayloadDeliveryBucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
    [JsonPropertyName("payloadDeliveryBucketNameRef")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRef? PayloadDeliveryBucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
    [JsonPropertyName("payloadDeliveryBucketNameSelector")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelector? PayloadDeliveryBucketNameSelector { get; set; }

    /// <summary>ARN of the SNS topic for job notifications.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary>Message-based condition. See message_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger
{
    /// <summary>Number of messages that trigger memory processing. Accepts values from 1 to 50.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }
}

/// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
{
    /// <summary>Idle session timeout (seconds) that triggers memory processing. Accepts values from 10 to 3000.</summary>
    [JsonPropertyName("idleSessionTimeout")]
    public double? IdleSessionTimeout { get; set; }
}

/// <summary>Token-based condition. See token_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger
{
    /// <summary>Number of tokens that trigger memory processing. Accepts values from 100 to 500000.</summary>
    [JsonPropertyName("tokenCount")]
    public double? TokenCount { get; set; }
}

/// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditions
{
    /// <summary>Message-based condition. See message_based_trigger Block below.</summary>
    [JsonPropertyName("messageBasedTrigger")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger? MessageBasedTrigger { get; set; }

    /// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
    [JsonPropertyName("timeBasedTrigger")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger? TimeBasedTrigger { get; set; }

    /// <summary>Token-based condition. See token_based_trigger Block below.</summary>
    [JsonPropertyName("tokenBasedTrigger")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger? TokenBasedTrigger { get; set; }
}

/// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfiguration
{
    /// <summary>Number of historical messages to include in processing context. Valid range: 0 to 50. Defaults to 4.</summary>
    [JsonPropertyName("historicalContextWindowSize")]
    public double? HistoricalContextWindowSize { get; set; }

    /// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
    [JsonPropertyName("invocationConfiguration")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationInvocationConfiguration? InvocationConfiguration { get; set; }

    /// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
    [JsonPropertyName("triggerConditions")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfigurationTriggerConditions? TriggerConditions { get; set; }
}

/// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderConfiguration
{
    /// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("consolidation")]
    public V1beta1MemoryStrategySpecForProviderConfigurationConsolidation? Consolidation { get; set; }

    /// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("extraction")]
    public V1beta1MemoryStrategySpecForProviderConfigurationExtraction? Extraction { get; set; }

    /// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("reflection")]
    public V1beta1MemoryStrategySpecForProviderConfigurationReflection? Reflection { get; set; }

    /// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
    [JsonPropertyName("selfManagedConfiguration")]
    public V1beta1MemoryStrategySpecForProviderConfigurationSelfManagedConfiguration? SelfManagedConfiguration { get; set; }

    /// <summary>Type of custom override. Valid values: SEMANTIC_OVERRIDE, SUMMARY_OVERRIDE, USER_PREFERENCE_OVERRIDE, EPISODIC_OVERRIDE, SELF_MANAGED. Changing this forces a new resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate memoryExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate memoryExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelector
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
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Memory in bedrockagentcore to populate memoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Memory in bedrockagentcore to populate memoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryIdSelector
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
    public V1beta1MemoryStrategySpecForProviderMemoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation
{
    /// <summary>Maximum allowed value.</summary>
    [JsonPropertyName("maxValue")]
    public double? MaxValue { get; set; }

    /// <summary>Minimum allowed value.</summary>
    [JsonPropertyName("minValue")]
    public double? MinValue { get; set; }
}

/// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>Maximum number of items in the string list.</summary>
    [JsonPropertyName("maxItems")]
    public double? MaxItems { get; set; }
}

/// <summary>Validation for STRING fields. See string_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }
}

/// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation
{
    /// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
    [JsonPropertyName("numberValidation")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation? NumberValidation { get; set; }

    /// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
    [JsonPropertyName("stringListValidation")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation? StringListValidation { get; set; }

    /// <summary>Validation for STRING fields. See string_validation Block below.</summary>
    [JsonPropertyName("stringValidation")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation? StringValidation { get; set; }
}

/// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig
{
    /// <summary>Description of what this metadata field represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Instructions for extraction. Supports built-in operators like LATEST_VALUE or custom natural-language instructions.</summary>
    [JsonPropertyName("llmExtractionInstruction")]
    public string? LlmExtractionInstruction { get; set; }

    /// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
    [JsonPropertyName("validation")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation? Validation { get; set; }
}

/// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfig
{
    /// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
    [JsonPropertyName("llmExtractionConfig")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig? LlmExtractionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchema
{
    /// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
    [JsonPropertyName("extractionConfig")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchemaExtractionConfig? ExtractionConfig { get; set; }

    /// <summary>Whether the metadata value is extracted by the LLM or passed through deterministically from the event. Valid values: LLM_INFERRED, STRICTLY_CONSISTENT.</summary>
    [JsonPropertyName("extractionType")]
    public string? ExtractionType { get; set; }

    /// <summary>Metadata field name. Must match an indexed key to be queryable via metadata filters.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Metadata value type. Valid values: STRING, STRINGLIST, NUMBER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderMemoryRecordSchema
{
    /// <summary>List of metadata field definitions for records generated by this strategy. See metadata_schema Block below.</summary>
    [JsonPropertyName("metadataSchema")]
    public IList<V1beta1MemoryStrategySpecForProviderMemoryRecordSchemaMetadataSchema>? MetadataSchema { get; set; }
}

/// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProviderReflectionConfiguration
{
    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecForProvider
{
    /// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1MemoryStrategySpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the memory strategy. Once set, a description cannot be removed via update because the service API ignores a null description and retains the previously stored value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the IAM role that the memory service assumes to perform operations.</summary>
    [JsonPropertyName("memoryExecutionRoleArn")]
    public string? MemoryExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate memoryExecutionRoleArn.</summary>
    [JsonPropertyName("memoryExecutionRoleArnRef")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnRef? MemoryExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate memoryExecutionRoleArn.</summary>
    [JsonPropertyName("memoryExecutionRoleArnSelector")]
    public V1beta1MemoryStrategySpecForProviderMemoryExecutionRoleArnSelector? MemoryExecutionRoleArnSelector { get; set; }

    /// <summary>ID of the memory to associate with this strategy. Changing this forces a new resource.</summary>
    [JsonPropertyName("memoryId")]
    public string? MemoryId { get; set; }

    /// <summary>Reference to a Memory in bedrockagentcore to populate memoryId.</summary>
    [JsonPropertyName("memoryIdRef")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdRef? MemoryIdRef { get; set; }

    /// <summary>Selector for a Memory in bedrockagentcore to populate memoryId.</summary>
    [JsonPropertyName("memoryIdSelector")]
    public V1beta1MemoryStrategySpecForProviderMemoryIdSelector? MemoryIdSelector { get; set; }

    /// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
    [JsonPropertyName("memoryRecordSchema")]
    public V1beta1MemoryStrategySpecForProviderMemoryRecordSchema? MemoryRecordSchema { get; set; }

    /// <summary>Name of the memory strategy. Changing this forces a new resource, because the service API does not support renaming a strategy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set containing exactly one namespace template where this strategy applies (for example /strategies/{memoryStrategyId}/actors/{actorId}/sessions/{sessionId}). Namespace templates help organize and scope memory content. Exactly one of namespace_templates or namespaces must be configured for all strategies except CUSTOM strategies using SELF_MANAGED configuration.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }

    /// <summary>Set of namespace identifiers where this strategy applies. Exactly one of namespaces or namespace_templates must be configured. The API treats this as a legacy parameter; prefer namespace_templates. Since the API mirrors the two fields, switching an existing configuration from namespaces to namespace_templates with the same value is an in-place no-op.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
    [JsonPropertyName("reflectionConfiguration")]
    public V1beta1MemoryStrategySpecForProviderReflectionConfiguration? ReflectionConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Type of memory strategy. Valid values: SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC, CUSTOM. Changing this forces a new resource. Note that only one strategy of each built-in type (SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC) can exist per memory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationConsolidation
{
    /// <summary>Additional text to append to the model prompt for consolidation processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for consolidation processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationExtraction
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationReflection
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelector
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
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelector
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
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfiguration
{
    /// <summary>S3 bucket name for event payload delivery.</summary>
    [JsonPropertyName("payloadDeliveryBucketName")]
    public string? PayloadDeliveryBucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
    [JsonPropertyName("payloadDeliveryBucketNameRef")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameRef? PayloadDeliveryBucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate payloadDeliveryBucketName.</summary>
    [JsonPropertyName("payloadDeliveryBucketNameSelector")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationPayloadDeliveryBucketNameSelector? PayloadDeliveryBucketNameSelector { get; set; }

    /// <summary>ARN of the SNS topic for job notifications.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfigurationTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary>Message-based condition. See message_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger
{
    /// <summary>Number of messages that trigger memory processing. Accepts values from 1 to 50.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }
}

/// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
{
    /// <summary>Idle session timeout (seconds) that triggers memory processing. Accepts values from 10 to 3000.</summary>
    [JsonPropertyName("idleSessionTimeout")]
    public double? IdleSessionTimeout { get; set; }
}

/// <summary>Token-based condition. See token_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger
{
    /// <summary>Number of tokens that trigger memory processing. Accepts values from 100 to 500000.</summary>
    [JsonPropertyName("tokenCount")]
    public double? TokenCount { get; set; }
}

/// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditions
{
    /// <summary>Message-based condition. See message_based_trigger Block below.</summary>
    [JsonPropertyName("messageBasedTrigger")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger? MessageBasedTrigger { get; set; }

    /// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
    [JsonPropertyName("timeBasedTrigger")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger? TimeBasedTrigger { get; set; }

    /// <summary>Token-based condition. See token_based_trigger Block below.</summary>
    [JsonPropertyName("tokenBasedTrigger")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger? TokenBasedTrigger { get; set; }
}

/// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfiguration
{
    /// <summary>Number of historical messages to include in processing context. Valid range: 0 to 50. Defaults to 4.</summary>
    [JsonPropertyName("historicalContextWindowSize")]
    public double? HistoricalContextWindowSize { get; set; }

    /// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
    [JsonPropertyName("invocationConfiguration")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationInvocationConfiguration? InvocationConfiguration { get; set; }

    /// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
    [JsonPropertyName("triggerConditions")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfigurationTriggerConditions? TriggerConditions { get; set; }
}

/// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderConfiguration
{
    /// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("consolidation")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationConsolidation? Consolidation { get; set; }

    /// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("extraction")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationExtraction? Extraction { get; set; }

    /// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("reflection")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationReflection? Reflection { get; set; }

    /// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
    [JsonPropertyName("selfManagedConfiguration")]
    public V1beta1MemoryStrategySpecInitProviderConfigurationSelfManagedConfiguration? SelfManagedConfiguration { get; set; }

    /// <summary>Type of custom override. Valid values: SEMANTIC_OVERRIDE, SUMMARY_OVERRIDE, USER_PREFERENCE_OVERRIDE, EPISODIC_OVERRIDE, SELF_MANAGED. Changing this forces a new resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate memoryExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate memoryExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelector
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
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Memory in bedrockagentcore to populate memoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolveEnum>))]
public enum V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Memory in bedrockagentcore to populate memoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryIdSelector
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
    public V1beta1MemoryStrategySpecInitProviderMemoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation
{
    /// <summary>Maximum allowed value.</summary>
    [JsonPropertyName("maxValue")]
    public double? MaxValue { get; set; }

    /// <summary>Minimum allowed value.</summary>
    [JsonPropertyName("minValue")]
    public double? MinValue { get; set; }
}

/// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>Maximum number of items in the string list.</summary>
    [JsonPropertyName("maxItems")]
    public double? MaxItems { get; set; }
}

/// <summary>Validation for STRING fields. See string_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }
}

/// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation
{
    /// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
    [JsonPropertyName("numberValidation")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation? NumberValidation { get; set; }

    /// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
    [JsonPropertyName("stringListValidation")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation? StringListValidation { get; set; }

    /// <summary>Validation for STRING fields. See string_validation Block below.</summary>
    [JsonPropertyName("stringValidation")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation? StringValidation { get; set; }
}

/// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig
{
    /// <summary>Description of what this metadata field represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Instructions for extraction. Supports built-in operators like LATEST_VALUE or custom natural-language instructions.</summary>
    [JsonPropertyName("llmExtractionInstruction")]
    public string? LlmExtractionInstruction { get; set; }

    /// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
    [JsonPropertyName("validation")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation? Validation { get; set; }
}

/// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfig
{
    /// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
    [JsonPropertyName("llmExtractionConfig")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig? LlmExtractionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchema
{
    /// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
    [JsonPropertyName("extractionConfig")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchemaExtractionConfig? ExtractionConfig { get; set; }

    /// <summary>Whether the metadata value is extracted by the LLM or passed through deterministically from the event. Valid values: LLM_INFERRED, STRICTLY_CONSISTENT.</summary>
    [JsonPropertyName("extractionType")]
    public string? ExtractionType { get; set; }

    /// <summary>Metadata field name. Must match an indexed key to be queryable via metadata filters.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Metadata value type. Valid values: STRING, STRINGLIST, NUMBER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderMemoryRecordSchema
{
    /// <summary>List of metadata field definitions for records generated by this strategy. See metadata_schema Block below.</summary>
    [JsonPropertyName("metadataSchema")]
    public IList<V1beta1MemoryStrategySpecInitProviderMemoryRecordSchemaMetadataSchema>? MetadataSchema { get; set; }
}

/// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpecInitProviderReflectionConfiguration
{
    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
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
public partial class V1beta1MemoryStrategySpecInitProvider
{
    /// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1MemoryStrategySpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the memory strategy. Once set, a description cannot be removed via update because the service API ignores a null description and retains the previously stored value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the IAM role that the memory service assumes to perform operations.</summary>
    [JsonPropertyName("memoryExecutionRoleArn")]
    public string? MemoryExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate memoryExecutionRoleArn.</summary>
    [JsonPropertyName("memoryExecutionRoleArnRef")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnRef? MemoryExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate memoryExecutionRoleArn.</summary>
    [JsonPropertyName("memoryExecutionRoleArnSelector")]
    public V1beta1MemoryStrategySpecInitProviderMemoryExecutionRoleArnSelector? MemoryExecutionRoleArnSelector { get; set; }

    /// <summary>ID of the memory to associate with this strategy. Changing this forces a new resource.</summary>
    [JsonPropertyName("memoryId")]
    public string? MemoryId { get; set; }

    /// <summary>Reference to a Memory in bedrockagentcore to populate memoryId.</summary>
    [JsonPropertyName("memoryIdRef")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdRef? MemoryIdRef { get; set; }

    /// <summary>Selector for a Memory in bedrockagentcore to populate memoryId.</summary>
    [JsonPropertyName("memoryIdSelector")]
    public V1beta1MemoryStrategySpecInitProviderMemoryIdSelector? MemoryIdSelector { get; set; }

    /// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
    [JsonPropertyName("memoryRecordSchema")]
    public V1beta1MemoryStrategySpecInitProviderMemoryRecordSchema? MemoryRecordSchema { get; set; }

    /// <summary>Name of the memory strategy. Changing this forces a new resource, because the service API does not support renaming a strategy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set containing exactly one namespace template where this strategy applies (for example /strategies/{memoryStrategyId}/actors/{actorId}/sessions/{sessionId}). Namespace templates help organize and scope memory content. Exactly one of namespace_templates or namespaces must be configured for all strategies except CUSTOM strategies using SELF_MANAGED configuration.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }

    /// <summary>Set of namespace identifiers where this strategy applies. Exactly one of namespaces or namespace_templates must be configured. The API treats this as a legacy parameter; prefer namespace_templates. Since the API mirrors the two fields, switching an existing configuration from namespaces to namespace_templates with the same value is an in-place no-op.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
    [JsonPropertyName("reflectionConfiguration")]
    public V1beta1MemoryStrategySpecInitProviderReflectionConfiguration? ReflectionConfiguration { get; set; }

    /// <summary>Type of memory strategy. Valid values: SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC, CUSTOM. Changing this forces a new resource. Note that only one strategy of each built-in type (SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC) can exist per memory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MemoryStrategySpecManagementPoliciesEnum>))]
public enum V1beta1MemoryStrategySpecManagementPoliciesEnum
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
public partial class V1beta1MemoryStrategySpecProviderConfigRef
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
public partial class V1beta1MemoryStrategySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MemoryStrategySpec defines the desired state of MemoryStrategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1MemoryStrategySpecForProvider ForProvider { get; set; }

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
    public V1beta1MemoryStrategySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MemoryStrategySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MemoryStrategySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MemoryStrategySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationConsolidation
{
    /// <summary>Additional text to append to the model prompt for consolidation processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for consolidation processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationExtraction
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }
}

/// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationReflection
{
    /// <summary>Additional text to append to the model prompt for reflection processing.</summary>
    [JsonPropertyName("appendToPrompt")]
    public string? AppendToPrompt { get; set; }

    /// <summary>ID of the foundation model to use for reflection processing.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
}

/// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationInvocationConfiguration
{
    /// <summary>S3 bucket name for event payload delivery.</summary>
    [JsonPropertyName("payloadDeliveryBucketName")]
    public string? PayloadDeliveryBucketName { get; set; }

    /// <summary>ARN of the SNS topic for job notifications.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary>Message-based condition. See message_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger
{
    /// <summary>Number of messages that trigger memory processing. Accepts values from 1 to 50.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }
}

/// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger
{
    /// <summary>Idle session timeout (seconds) that triggers memory processing. Accepts values from 10 to 3000.</summary>
    [JsonPropertyName("idleSessionTimeout")]
    public double? IdleSessionTimeout { get; set; }
}

/// <summary>Token-based condition. See token_based_trigger Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger
{
    /// <summary>Number of tokens that trigger memory processing. Accepts values from 100 to 500000.</summary>
    [JsonPropertyName("tokenCount")]
    public double? TokenCount { get; set; }
}

/// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditions
{
    /// <summary>Message-based condition. See message_based_trigger Block below.</summary>
    [JsonPropertyName("messageBasedTrigger")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsMessageBasedTrigger? MessageBasedTrigger { get; set; }

    /// <summary>Idle-time condition. See time_based_trigger Block below.</summary>
    [JsonPropertyName("timeBasedTrigger")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsTimeBasedTrigger? TimeBasedTrigger { get; set; }

    /// <summary>Token-based condition. See token_based_trigger Block below.</summary>
    [JsonPropertyName("tokenBasedTrigger")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsTokenBasedTrigger? TokenBasedTrigger { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualMessageBasedTrigger
{
    /// <summary>Number of messages that trigger memory processing.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualTimeBasedTrigger
{
    /// <summary>Idle session timeout (seconds) that triggers memory processing.</summary>
    [JsonPropertyName("idleSessionTimeout")]
    public double? IdleSessionTimeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualTokenBasedTrigger
{
    /// <summary>Number of tokens that trigger memory processing.</summary>
    [JsonPropertyName("tokenCount")]
    public double? TokenCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActual
{
    /// <summary>Message-based condition.</summary>
    [JsonPropertyName("messageBasedTrigger")]
    public IList<V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualMessageBasedTrigger>? MessageBasedTrigger { get; set; }

    /// <summary>Idle-time condition.</summary>
    [JsonPropertyName("timeBasedTrigger")]
    public IList<V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualTimeBasedTrigger>? TimeBasedTrigger { get; set; }

    /// <summary>Token-based condition.</summary>
    [JsonPropertyName("tokenBasedTrigger")]
    public IList<V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActualTokenBasedTrigger>? TokenBasedTrigger { get; set; }
}

/// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfiguration
{
    /// <summary>Number of historical messages to include in processing context. Valid range: 0 to 50. Defaults to 4.</summary>
    [JsonPropertyName("historicalContextWindowSize")]
    public double? HistoricalContextWindowSize { get; set; }

    /// <summary>Configuration used to invoke the self-managed memory processing pipeline. See invocation_configuration Block below.</summary>
    [JsonPropertyName("invocationConfiguration")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationInvocationConfiguration? InvocationConfiguration { get; set; }

    /// <summary>Conditions that trigger memory processing. See trigger_conditions Block below. When omitted, the service supplies the documented defaults for all three trigger types.</summary>
    [JsonPropertyName("triggerConditions")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditions? TriggerConditions { get; set; }

    /// <summary>Actual deployed trigger conditions.</summary>
    [JsonPropertyName("triggerConditionsActual")]
    public IList<V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfigurationTriggerConditionsActual>? TriggerConditionsActual { get; set; }
}

/// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderConfiguration
{
    /// <summary>Consolidation configuration for the memory strategy. See consolidation Block below. Cannot be used with type set to SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("consolidation")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationConsolidation? Consolidation { get; set; }

    /// <summary>Extraction configuration for the memory strategy. See extraction Block below. Cannot be used with type set to SUMMARY_OVERRIDE or SELF_MANAGED. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("extraction")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationExtraction? Extraction { get; set; }

    /// <summary>Reflection configuration for the memory strategy. See reflection Block below. Can only be used, and is required, with type set to EPISODIC_OVERRIDE. Once added, this block cannot be removed without recreating the resource.</summary>
    [JsonPropertyName("reflection")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationReflection? Reflection { get; set; }

    /// <summary>Self-managed processing configuration. Required when type is SELF_MANAGED and only valid for that type. See self_managed_configuration Block below.</summary>
    [JsonPropertyName("selfManagedConfiguration")]
    public V1beta1MemoryStrategyStatusAtProviderConfigurationSelfManagedConfiguration? SelfManagedConfiguration { get; set; }

    /// <summary>Type of custom override. Valid values: SEMANTIC_OVERRIDE, SUMMARY_OVERRIDE, USER_PREFERENCE_OVERRIDE, EPISODIC_OVERRIDE, SELF_MANAGED. Changing this forces a new resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation
{
    /// <summary>Maximum allowed value.</summary>
    [JsonPropertyName("maxValue")]
    public double? MaxValue { get; set; }

    /// <summary>Minimum allowed value.</summary>
    [JsonPropertyName("minValue")]
    public double? MinValue { get; set; }
}

/// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>Maximum number of items in the string list.</summary>
    [JsonPropertyName("maxItems")]
    public double? MaxItems { get; set; }
}

/// <summary>Validation for STRING fields. See string_validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation
{
    /// <summary>Allowed values for items in this STRINGLIST field.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }
}

/// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation
{
    /// <summary>Validation for NUMBER fields. See number_validation Block below.</summary>
    [JsonPropertyName("numberValidation")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationNumberValidation? NumberValidation { get; set; }

    /// <summary>Validation for STRINGLIST fields. See string_list_validation Block below.</summary>
    [JsonPropertyName("stringListValidation")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringListValidation? StringListValidation { get; set; }

    /// <summary>Validation for STRING fields. See string_validation Block below.</summary>
    [JsonPropertyName("stringValidation")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidationStringValidation? StringValidation { get; set; }
}

/// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig
{
    /// <summary>Description of what this metadata field represents.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Instructions for extraction. Supports built-in operators like LATEST_VALUE or custom natural-language instructions.</summary>
    [JsonPropertyName("llmExtractionInstruction")]
    public string? LlmExtractionInstruction { get; set; }

    /// <summary>Validation rules to constrain extracted values. See validation Block below.</summary>
    [JsonPropertyName("validation")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfigValidation? Validation { get; set; }
}

/// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfig
{
    /// <summary>Model-based extraction configuration. See llm_extraction_config Block below.</summary>
    [JsonPropertyName("llmExtractionConfig")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfigLlmExtractionConfig? LlmExtractionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchema
{
    /// <summary>Configuration for extracting this metadata value from conversational content. Applicable only when extraction_type is LLM_INFERRED. See extraction_config Block below.</summary>
    [JsonPropertyName("extractionConfig")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchemaExtractionConfig? ExtractionConfig { get; set; }

    /// <summary>Whether the metadata value is extracted by the LLM or passed through deterministically from the event. Valid values: LLM_INFERRED, STRICTLY_CONSISTENT.</summary>
    [JsonPropertyName("extractionType")]
    public string? ExtractionType { get; set; }

    /// <summary>Metadata field name. Must match an indexed key to be queryable via metadata filters.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Metadata value type. Valid values: STRING, STRINGLIST, NUMBER.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchema
{
    /// <summary>List of metadata field definitions for records generated by this strategy. See metadata_schema Block below.</summary>
    [JsonPropertyName("metadataSchema")]
    public IList<V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchemaMetadataSchema>? MetadataSchema { get; set; }
}

/// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProviderReflectionConfiguration
{
    /// <summary>Namespace templates over which to create reflections. Can be less nested than episode namespaces.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusAtProvider
{
    /// <summary>Custom configuration block. Required when type is CUSTOM, must be omitted for other types. See configuration Block below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1MemoryStrategyStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the memory strategy. Once set, a description cannot be removed via update because the service API ignores a null description and retains the previously stored value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the IAM role that the memory service assumes to perform operations.</summary>
    [JsonPropertyName("memoryExecutionRoleArn")]
    public string? MemoryExecutionRoleArn { get; set; }

    /// <summary>ID of the memory to associate with this strategy. Changing this forces a new resource.</summary>
    [JsonPropertyName("memoryId")]
    public string? MemoryId { get; set; }

    /// <summary>Schema for metadata fields on records generated by this strategy. Valid for all strategy types. See memory_record_schema Block below.</summary>
    [JsonPropertyName("memoryRecordSchema")]
    public V1beta1MemoryStrategyStatusAtProviderMemoryRecordSchema? MemoryRecordSchema { get; set; }

    /// <summary>Unique identifier of the Memory Strategy. This corresponds to the service strategyId identifier (AWS API / CloudFormation terminology).</summary>
    [JsonPropertyName("memoryStrategyId")]
    public string? MemoryStrategyId { get; set; }

    /// <summary>Name of the memory strategy. Changing this forces a new resource, because the service API does not support renaming a strategy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set containing exactly one namespace template where this strategy applies (for example /strategies/{memoryStrategyId}/actors/{actorId}/sessions/{sessionId}). Namespace templates help organize and scope memory content. Exactly one of namespace_templates or namespaces must be configured for all strategies except CUSTOM strategies using SELF_MANAGED configuration.</summary>
    [JsonPropertyName("namespaceTemplates")]
    public IList<string>? NamespaceTemplates { get; set; }

    /// <summary>Set of namespace identifiers where this strategy applies. Exactly one of namespaces or namespace_templates must be configured. The API treats this as a legacy parameter; prefer namespace_templates. Since the API mirrors the two fields, switching an existing configuration from namespaces to namespace_templates with the same value is an in-place no-op.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Configuration for the reflections created with the episodic memory strategy. Valid when type is EPISODIC, must be omitted for other types. See reflection_configuration Block below.</summary>
    [JsonPropertyName("reflectionConfiguration")]
    public V1beta1MemoryStrategyStatusAtProviderReflectionConfiguration? ReflectionConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Type of memory strategy. Valid values: SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC, CUSTOM. Changing this forces a new resource. Note that only one strategy of each built-in type (SEMANTIC, SUMMARIZATION, USER_PREFERENCE, EPISODIC) can exist per memory.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatusConditions
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

/// <summary>MemoryStrategyStatus defines the observed state of MemoryStrategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MemoryStrategyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MemoryStrategyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MemoryStrategyStatusConditions>? Conditions { get; set; }

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

/// <summary>MemoryStrategy is the Schema for the MemoryStrategys API. Manages an AWS Bedrock AgentCore Memory Strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MemoryStrategy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MemoryStrategySpec>, IStatus<V1beta1MemoryStrategyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MemoryStrategy";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "memorystrategies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemoryStrategy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MemoryStrategySpec defines the desired state of MemoryStrategy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MemoryStrategySpec Spec { get; set; }

    /// <summary>MemoryStrategyStatus defines the observed state of MemoryStrategy.</summary>
    [JsonPropertyName("status")]
    public V1beta1MemoryStrategyStatus? Status { get; set; }
}