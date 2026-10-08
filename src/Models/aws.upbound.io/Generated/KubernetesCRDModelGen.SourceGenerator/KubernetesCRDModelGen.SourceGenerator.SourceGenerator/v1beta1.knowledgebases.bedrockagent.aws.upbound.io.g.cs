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
/// <summary>KnowledgeBase is the Schema for the KnowledgeBases API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KnowledgeBaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KnowledgeBase>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KnowledgeBaseList";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "knowledgebases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KnowledgeBaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1KnowledgeBase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1KnowledgeBase> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecDeletionPolicyEnum>))]
public enum V1beta1KnowledgeBaseSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in kendra to populate kendraIndexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in kendra to populate kendraIndexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration
{
    /// <summary>ARN of the Amazon Kendra index.</summary>
    [JsonPropertyName("kendraIndexArn")]
    public string? KendraIndexArn { get; set; }

    /// <summary>Reference to a Index in kendra to populate kendraIndexArn.</summary>
    [JsonPropertyName("kendraIndexArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRef? KendraIndexArnRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate kendraIndexArn.</summary>
    [JsonPropertyName("kendraIndexArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelector? KendraIndexArnSelector { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used to encrypt the managed knowledge base.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>Type of embedding model. Valid values: MANAGED, CUSTOM. When MANAGED, no model selection or configuration is required. When CUSTOM, embedding_model_arn and embedding_model_configuration are required. Defaults to MANAGED.</summary>
    [JsonPropertyName("embeddingModelType")]
    public string? EmbeddingModelType { get; set; }

    /// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration
{
    /// <summary>Database username for authentication to an Amazon Redshift provisioned data warehouse.</summary>
    [JsonPropertyName("databaseUser")]
    public string? DatabaseUser { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in redshift to populate clusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in redshift to populate clusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelector
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
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ID of the Amazon Redshift cluster.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in redshift to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in redshift to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration
{
    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ARN of the Amazon Redshift workgroup.</summary>
    [JsonPropertyName("workgroupArn")]
    public string? WorkgroupArn { get; set; }
}

/// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration
{
    /// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
    [JsonPropertyName("provisionedConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration? ProvisionedConfiguration { get; set; }

    /// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
    [JsonPropertyName("serverlessConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration? ServerlessConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery
{
    /// <summary>Example natural language query.</summary>
    [JsonPropertyName("naturalLanguage")]
    public string? NaturalLanguage { get; set; }

    /// <summary>SQL equivalent of natural_language.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn
{
    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable
{
    /// <summary>Information about a column in the table. See column block for details.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn>? Column { get; set; }

    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext
{
    /// <summary>Information about example queries to help the query engine generate appropriate SQL queries. See curated_query block for details.</summary>
    [JsonPropertyName("curatedQuery")]
    public IList<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery>? CuratedQuery { get; set; }

    /// <summary>Information about a table in the database. See table block for details.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable>? Table { get; set; }
}

/// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration
{
    /// <summary>Time after which query generation will time out.</summary>
    [JsonPropertyName("executionTimeoutSeconds")]
    public double? ExecutionTimeoutSeconds { get; set; }

    /// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
    [JsonPropertyName("generationContext")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext? GenerationContext { get; set; }
}

/// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration
{
    /// <summary>List of names of the tables to use.</summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration
{
    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration
{
    /// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
    [JsonPropertyName("awsDataCatalogConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration? AwsDataCatalogConfiguration { get; set; }

    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration
{
    /// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
    [JsonPropertyName("queryEngineConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration? QueryEngineConfiguration { get; set; }

    /// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
    [JsonPropertyName("queryGenerationConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration? QueryGenerationConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration
{
    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location
{
    /// <summary>URI of the location.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation
{
    /// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location? S3Location { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration
{
    /// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
    [JsonPropertyName("storageLocation")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation? StorageLocation { get; set; }
}

/// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
    [JsonPropertyName("supplementalDataStorageConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration? SupplementalDataStorageConfiguration { get; set; }
}

/// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfiguration
{
    /// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("kendraKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration? KendraKnowledgeBaseConfiguration { get; set; }

    /// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration? ManagedKnowledgeBaseConfiguration { get; set; }

    /// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("sqlKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration? SqlKnowledgeBaseConfiguration { get; set; }

    /// <summary>Type of data that the data source is converted into for the knowledge base. Valid Values: VECTOR, KENDRA, SQL, MANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("vectorKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration? VectorKnowledgeBaseConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderRoleArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationMongoDbAtlasConfiguration
{
    /// <summary>–  The name of the collection in the MongoDB Atlas database.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  The name of the service that hosts the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpointServiceName")]
    public string? EndpointServiceName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("textIndexName")]
    public string? TextIndexName { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationNeptuneAnalyticsConfiguration
{
    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the Neptune Analytics vector store.</summary>
    [JsonPropertyName("graphArn")]
    public string? GraphArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfiguration
{
    /// <summary>ARN of the OpenSearch domain.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>Endpoint URL of the OpenSearch domain.</summary>
    [JsonPropertyName("domainEndpoint")]
    public string? DomainEndpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Collection in opensearchserverless to populate collectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Collection in opensearchserverless to populate collectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfiguration
{
    /// <summary>ARN of the OpenSearch Service vector store.</summary>
    [JsonPropertyName("collectionArn")]
    public string? CollectionArn { get; set; }

    /// <summary>Reference to a Collection in opensearchserverless to populate collectionArn.</summary>
    [JsonPropertyName("collectionArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRef? CollectionArnRef { get; set; }

    /// <summary>Selector for a Collection in opensearchserverless to populate collectionArn.</summary>
    [JsonPropertyName("collectionArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelector? CollectionArnSelector { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationPineconeConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationPineconeConfiguration
{
    /// <summary>Endpoint URL for your index management page.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationPineconeConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>Namespace to be used to write new data to your database.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationFieldMapping
{
    /// <summary>Name for the universal metadata field where Amazon Bedrock will store any custom metadata from your data source.</summary>
    [JsonPropertyName("customMetadataField")]
    public string? CustomMetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>Name of the field in which Amazon Bedrock stores the ID for each entry.</summary>
    [JsonPropertyName("primaryKeyField")]
    public string? PrimaryKeyField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in rds to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in rds to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the vector store.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Cluster in rds to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfigurationResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>Name of the table in the database.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRedisEnterpriseCloudConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in s3vectors to populate indexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in s3vectors to populate indexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelector
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
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfiguration
{
    /// <summary>ARN of the S3 Vectors index. Conflicts with index_name and vector_bucket_arn.</summary>
    [JsonPropertyName("indexArn")]
    public string? IndexArn { get; set; }

    /// <summary>Reference to a Index in s3vectors to populate indexArn.</summary>
    [JsonPropertyName("indexArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnRef? IndexArnRef { get; set; }

    /// <summary>Selector for a Index in s3vectors to populate indexArn.</summary>
    [JsonPropertyName("indexArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationIndexArnSelector? IndexArnSelector { get; set; }

    /// <summary>Name of the S3 Vectors index. Must be specified with vector_bucket_arn. Conflicts with index_arn.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>ARN of the S3 Vectors vector bucket. Must be specified with index_name. Conflicts with index_arn.</summary>
    [JsonPropertyName("vectorBucketArn")]
    public string? VectorBucketArn { get; set; }

    /// <summary>Reference to a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
    [JsonPropertyName("vectorBucketArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRef? VectorBucketArnRef { get; set; }

    /// <summary>Selector for a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
    [JsonPropertyName("vectorBucketArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelector? VectorBucketArnSelector { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProviderStorageConfiguration
{
    /// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
    [JsonPropertyName("mongoDbAtlasConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationMongoDbAtlasConfiguration? MongoDbAtlasConfiguration { get; set; }

    /// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
    [JsonPropertyName("neptuneAnalyticsConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationNeptuneAnalyticsConfiguration? NeptuneAnalyticsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
    [JsonPropertyName("opensearchManagedClusterConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchManagedClusterConfiguration? OpensearchManagedClusterConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
    [JsonPropertyName("opensearchServerlessConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationOpensearchServerlessConfiguration? OpensearchServerlessConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
    [JsonPropertyName("pineconeConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationPineconeConfiguration? PineconeConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
    [JsonPropertyName("rdsConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRdsConfiguration? RdsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
    [JsonPropertyName("redisEnterpriseCloudConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationRedisEnterpriseCloudConfiguration? RedisEnterpriseCloudConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
    [JsonPropertyName("s3VectorsConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfigurationS3VectorsConfiguration? S3VectorsConfiguration { get; set; }

    /// <summary>Data storage service to use. Valid values: REDSHIFT, AWS_DATA_CATALOG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecForProvider
{
    /// <summary>Description of the knowledge base.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("knowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderKnowledgeBaseConfiguration? KnowledgeBaseConfiguration { get; set; }

    /// <summary>Name of the knowledge base.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the knowledge base.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1KnowledgeBaseSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseSpecForProviderStorageConfiguration? StorageConfiguration { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in kendra to populate kendraIndexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in kendra to populate kendraIndexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration
{
    /// <summary>ARN of the Amazon Kendra index.</summary>
    [JsonPropertyName("kendraIndexArn")]
    public string? KendraIndexArn { get; set; }

    /// <summary>Reference to a Index in kendra to populate kendraIndexArn.</summary>
    [JsonPropertyName("kendraIndexArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnRef? KendraIndexArnRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate kendraIndexArn.</summary>
    [JsonPropertyName("kendraIndexArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfigurationKendraIndexArnSelector? KendraIndexArnSelector { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used to encrypt the managed knowledge base.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>Type of embedding model. Valid values: MANAGED, CUSTOM. When MANAGED, no model selection or configuration is required. When CUSTOM, embedding_model_arn and embedding_model_configuration are required. Defaults to MANAGED.</summary>
    [JsonPropertyName("embeddingModelType")]
    public string? EmbeddingModelType { get; set; }

    /// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration
{
    /// <summary>Database username for authentication to an Amazon Redshift provisioned data warehouse.</summary>
    [JsonPropertyName("databaseUser")]
    public string? DatabaseUser { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in redshift to populate clusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in redshift to populate clusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ID of the Amazon Redshift cluster.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in redshift to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierRef")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierRef? ClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in redshift to populate clusterIdentifier.</summary>
    [JsonPropertyName("clusterIdentifierSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationClusterIdentifierSelector? ClusterIdentifierSelector { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration
{
    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ARN of the Amazon Redshift workgroup.</summary>
    [JsonPropertyName("workgroupArn")]
    public string? WorkgroupArn { get; set; }
}

/// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration
{
    /// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
    [JsonPropertyName("provisionedConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration? ProvisionedConfiguration { get; set; }

    /// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
    [JsonPropertyName("serverlessConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration? ServerlessConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery
{
    /// <summary>Example natural language query.</summary>
    [JsonPropertyName("naturalLanguage")]
    public string? NaturalLanguage { get; set; }

    /// <summary>SQL equivalent of natural_language.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn
{
    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable
{
    /// <summary>Information about a column in the table. See column block for details.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn>? Column { get; set; }

    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext
{
    /// <summary>Information about example queries to help the query engine generate appropriate SQL queries. See curated_query block for details.</summary>
    [JsonPropertyName("curatedQuery")]
    public IList<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery>? CuratedQuery { get; set; }

    /// <summary>Information about a table in the database. See table block for details.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable>? Table { get; set; }
}

/// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration
{
    /// <summary>Time after which query generation will time out.</summary>
    [JsonPropertyName("executionTimeoutSeconds")]
    public double? ExecutionTimeoutSeconds { get; set; }

    /// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
    [JsonPropertyName("generationContext")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext? GenerationContext { get; set; }
}

/// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration
{
    /// <summary>List of names of the tables to use.</summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration
{
    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration
{
    /// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
    [JsonPropertyName("awsDataCatalogConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration? AwsDataCatalogConfiguration { get; set; }

    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration
{
    /// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
    [JsonPropertyName("queryEngineConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration? QueryEngineConfiguration { get; set; }

    /// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
    [JsonPropertyName("queryGenerationConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration? QueryGenerationConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration
{
    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location
{
    /// <summary>URI of the location.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation
{
    /// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location? S3Location { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration
{
    /// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
    [JsonPropertyName("storageLocation")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation? StorageLocation { get; set; }
}

/// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
    [JsonPropertyName("supplementalDataStorageConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration? SupplementalDataStorageConfiguration { get; set; }
}

/// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfiguration
{
    /// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("kendraKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration? KendraKnowledgeBaseConfiguration { get; set; }

    /// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration? ManagedKnowledgeBaseConfiguration { get; set; }

    /// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("sqlKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration? SqlKnowledgeBaseConfiguration { get; set; }

    /// <summary>Type of data that the data source is converted into for the knowledge base. Valid Values: VECTOR, KENDRA, SQL, MANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("vectorKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration? VectorKnowledgeBaseConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderRoleArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationMongoDbAtlasConfiguration
{
    /// <summary>–  The name of the collection in the MongoDB Atlas database.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  The name of the service that hosts the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpointServiceName")]
    public string? EndpointServiceName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("textIndexName")]
    public string? TextIndexName { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationNeptuneAnalyticsConfiguration
{
    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the Neptune Analytics vector store.</summary>
    [JsonPropertyName("graphArn")]
    public string? GraphArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfiguration
{
    /// <summary>ARN of the OpenSearch domain.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>Endpoint URL of the OpenSearch domain.</summary>
    [JsonPropertyName("domainEndpoint")]
    public string? DomainEndpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Collection in opensearchserverless to populate collectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Collection in opensearchserverless to populate collectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfiguration
{
    /// <summary>ARN of the OpenSearch Service vector store.</summary>
    [JsonPropertyName("collectionArn")]
    public string? CollectionArn { get; set; }

    /// <summary>Reference to a Collection in opensearchserverless to populate collectionArn.</summary>
    [JsonPropertyName("collectionArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnRef? CollectionArnRef { get; set; }

    /// <summary>Selector for a Collection in opensearchserverless to populate collectionArn.</summary>
    [JsonPropertyName("collectionArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationCollectionArnSelector? CollectionArnSelector { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationPineconeConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationPineconeConfiguration
{
    /// <summary>Endpoint URL for your index management page.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationPineconeConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>Namespace to be used to write new data to your database.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationFieldMapping
{
    /// <summary>Name for the universal metadata field where Amazon Bedrock will store any custom metadata from your data source.</summary>
    [JsonPropertyName("customMetadataField")]
    public string? CustomMetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>Name of the field in which Amazon Bedrock stores the ID for each entry.</summary>
    [JsonPropertyName("primaryKeyField")]
    public string? PrimaryKeyField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in rds to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in rds to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the vector store.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Cluster in rds to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfigurationResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>Name of the table in the database.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRedisEnterpriseCloudConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in s3vectors to populate indexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in s3vectors to populate indexArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelector
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
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfiguration
{
    /// <summary>ARN of the S3 Vectors index. Conflicts with index_name and vector_bucket_arn.</summary>
    [JsonPropertyName("indexArn")]
    public string? IndexArn { get; set; }

    /// <summary>Reference to a Index in s3vectors to populate indexArn.</summary>
    [JsonPropertyName("indexArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnRef? IndexArnRef { get; set; }

    /// <summary>Selector for a Index in s3vectors to populate indexArn.</summary>
    [JsonPropertyName("indexArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationIndexArnSelector? IndexArnSelector { get; set; }

    /// <summary>Name of the S3 Vectors index. Must be specified with vector_bucket_arn. Conflicts with index_arn.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>ARN of the S3 Vectors vector bucket. Must be specified with index_name. Conflicts with index_arn.</summary>
    [JsonPropertyName("vectorBucketArn")]
    public string? VectorBucketArn { get; set; }

    /// <summary>Reference to a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
    [JsonPropertyName("vectorBucketArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnRef? VectorBucketArnRef { get; set; }

    /// <summary>Selector for a VectorBucket in s3vectors to populate vectorBucketArn.</summary>
    [JsonPropertyName("vectorBucketArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfigurationVectorBucketArnSelector? VectorBucketArnSelector { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecInitProviderStorageConfiguration
{
    /// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
    [JsonPropertyName("mongoDbAtlasConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationMongoDbAtlasConfiguration? MongoDbAtlasConfiguration { get; set; }

    /// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
    [JsonPropertyName("neptuneAnalyticsConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationNeptuneAnalyticsConfiguration? NeptuneAnalyticsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
    [JsonPropertyName("opensearchManagedClusterConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchManagedClusterConfiguration? OpensearchManagedClusterConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
    [JsonPropertyName("opensearchServerlessConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationOpensearchServerlessConfiguration? OpensearchServerlessConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
    [JsonPropertyName("pineconeConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationPineconeConfiguration? PineconeConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
    [JsonPropertyName("rdsConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRdsConfiguration? RdsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
    [JsonPropertyName("redisEnterpriseCloudConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationRedisEnterpriseCloudConfiguration? RedisEnterpriseCloudConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
    [JsonPropertyName("s3VectorsConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfigurationS3VectorsConfiguration? S3VectorsConfiguration { get; set; }

    /// <summary>Data storage service to use. Valid values: REDSHIFT, AWS_DATA_CATALOG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1beta1KnowledgeBaseSpecInitProvider
{
    /// <summary>Description of the knowledge base.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("knowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderKnowledgeBaseConfiguration? KnowledgeBaseConfiguration { get; set; }

    /// <summary>Name of the knowledge base.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the knowledge base.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1KnowledgeBaseSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseSpecInitProviderStorageConfiguration? StorageConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecManagementPoliciesEnum>))]
public enum V1beta1KnowledgeBaseSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KnowledgeBaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KnowledgeBaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>KnowledgeBaseSpec defines the desired state of KnowledgeBase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseSpec
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
    public V1beta1KnowledgeBaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1KnowledgeBaseSpecForProvider ForProvider { get; set; }

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
    public V1beta1KnowledgeBaseSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1KnowledgeBaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KnowledgeBaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KnowledgeBaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration
{
    /// <summary>ARN of the Amazon Kendra index.</summary>
    [JsonPropertyName("kendraIndexArn")]
    public string? KendraIndexArn { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used to encrypt the managed knowledge base.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>Type of embedding model. Valid values: MANAGED, CUSTOM. When MANAGED, no model selection or configuration is required. When CUSTOM, embedding_model_arn and embedding_model_configuration are required. Defaults to MANAGED.</summary>
    [JsonPropertyName("embeddingModelType")]
    public string? EmbeddingModelType { get; set; }

    /// <summary>Server-side encryption configuration for the managed knowledge base. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration
{
    /// <summary>Database username for authentication to an Amazon Redshift provisioned data warehouse.</summary>
    [JsonPropertyName("databaseUser")]
    public string? DatabaseUser { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ID of the Amazon Redshift cluster.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration
{
    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ARN of a Secrets Manager secret for authentication.</summary>
    [JsonPropertyName("usernamePasswordSecretArn")]
    public string? UsernamePasswordSecretArn { get; set; }
}

/// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration
{
    /// <summary>Configurations for authentication to Amazon Redshift. See auth_configuration block for details.</summary>
    [JsonPropertyName("authConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfigurationAuthConfiguration? AuthConfiguration { get; set; }

    /// <summary>ARN of the Amazon Redshift workgroup.</summary>
    [JsonPropertyName("workgroupArn")]
    public string? WorkgroupArn { get; set; }
}

/// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration
{
    /// <summary>Configurations for a provisioned Amazon Redshift query engine. See provisioned_configuration block for details.</summary>
    [JsonPropertyName("provisionedConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration? ProvisionedConfiguration { get; set; }

    /// <summary>Configurations for a serverless Amazon Redshift query engine. See serverless_configuration block for details.</summary>
    [JsonPropertyName("serverlessConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationServerlessConfiguration? ServerlessConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery
{
    /// <summary>Example natural language query.</summary>
    [JsonPropertyName("naturalLanguage")]
    public string? NaturalLanguage { get; set; }

    /// <summary>SQL equivalent of natural_language.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn
{
    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable
{
    /// <summary>Information about a column in the table. See column block for details.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTableColumn>? Column { get; set; }

    /// <summary>Description of the table that helps the query engine understand the contents of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to include or exclude the table during query generation. Valid values INCLUDE, EXCLUDE.</summary>
    [JsonPropertyName("inclusion")]
    public string? Inclusion { get; set; }

    /// <summary>Name of the table for which the other fields in this object apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext
{
    /// <summary>Information about example queries to help the query engine generate appropriate SQL queries. See curated_query block for details.</summary>
    [JsonPropertyName("curatedQuery")]
    public IList<V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextCuratedQuery>? CuratedQuery { get; set; }

    /// <summary>Information about a table in the database. See table block for details.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContextTable>? Table { get; set; }
}

/// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration
{
    /// <summary>Time after which query generation will time out.</summary>
    [JsonPropertyName("executionTimeoutSeconds")]
    public double? ExecutionTimeoutSeconds { get; set; }

    /// <summary>Configurations for context to use during query generation. See generation_context block for details.</summary>
    [JsonPropertyName("generationContext")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfigurationGenerationContext? GenerationContext { get; set; }
}

/// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration
{
    /// <summary>List of names of the tables to use.</summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration
{
    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration
{
    /// <summary>Configurations for storage in AWS Glue Data Catalog. See aws_data_catalog_configuration block for details.</summary>
    [JsonPropertyName("awsDataCatalogConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationAwsDataCatalogConfiguration? AwsDataCatalogConfiguration { get; set; }

    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration
{
    /// <summary>Configurations for an Amazon Redshift query engine. See query_engine_configuration block for details.</summary>
    [JsonPropertyName("queryEngineConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration? QueryEngineConfiguration { get; set; }

    /// <summary>Configurations for generating queries. See query_generation_configuration block for details.</summary>
    [JsonPropertyName("queryGenerationConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration? QueryGenerationConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration
{
    /// <summary>Configurations for storage in Amazon Redshift. See redshift_configuration block for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudioSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration
{
    /// <summary>Duration in seconds for each audio or video segment.</summary>
    [JsonPropertyName("fixedLengthDuration")]
    public double? FixedLengthDuration { get; set; }
}

/// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo
{
    /// <summary>Configuration for segmenting video content during processing. See segmentation_configuration block for details.</summary>
    [JsonPropertyName("segmentationConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideoSegmentationConfiguration? SegmentationConfiguration { get; set; }
}

/// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
{
    /// <summary>Configuration for processing audio content in multimodal knowledge bases. See audio block for details.</summary>
    [JsonPropertyName("audio")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio? Audio { get; set; }

    /// <summary>Dimension details for the vector configuration used on the Bedrock embeddings model.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>Data type for the vectors when using a model to convert text into vector embeddings. The model must support the specified data type for vector embeddings.  Valid values are FLOAT32 and BINARY.</summary>
    [JsonPropertyName("embeddingDataType")]
    public string? EmbeddingDataType { get; set; }

    /// <summary>Configuration for processing video content in multimodal knowledge bases. See video block for details.</summary>
    [JsonPropertyName("video")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo? Video { get; set; }
}

/// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration
{
    /// <summary>The vector configuration details on the Bedrock embeddings model.  See bedrock_embedding_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockEmbeddingModelConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration? BedrockEmbeddingModelConfiguration { get; set; }
}

/// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location
{
    /// <summary>URI of the location.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation
{
    /// <summary>Contains information about the Amazon S3 location for the extracted images.  See s3_location block for details.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocationS3Location? S3Location { get; set; }

    /// <summary>Storage service used for this location. S3 is the only valid value.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration
{
    /// <summary>A storage location specification for images extracted from multimodal documents in your data source.  See storage_location block for details.</summary>
    [JsonPropertyName("storageLocation")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfigurationStorageLocation? StorageLocation { get; set; }
}

/// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration
{
    /// <summary>ARN of the model used to create vector embeddings for the knowledge base.</summary>
    [JsonPropertyName("embeddingModelArn")]
    public string? EmbeddingModelArn { get; set; }

    /// <summary>The embeddings model configuration details for the vector model used in Knowledge Base.  See embedding_model_configuration block for details.</summary>
    [JsonPropertyName("embeddingModelConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationEmbeddingModelConfiguration? EmbeddingModelConfiguration { get; set; }

    /// <summary>supplemental_data_storage_configuration.  See supplemental_data_storage_configuration block for details.</summary>
    [JsonPropertyName("supplementalDataStorageConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfigurationSupplementalDataStorageConfiguration? SupplementalDataStorageConfiguration { get; set; }
}

/// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfiguration
{
    /// <summary>Settings for an Amazon Kendra knowledge base. See kendra_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("kendraKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration? KendraKnowledgeBaseConfiguration { get; set; }

    /// <summary>Settings for a managed knowledge base where Amazon Bedrock manages the vector store. See managed_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration? ManagedKnowledgeBaseConfiguration { get; set; }

    /// <summary>Configurations for a knowledge base connected to an SQL database. See sql_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("sqlKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration? SqlKnowledgeBaseConfiguration { get; set; }

    /// <summary>Type of data that the data source is converted into for the knowledge base. Valid Values: VECTOR, KENDRA, SQL, MANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the model that&apos;s used to convert the data source into vector embeddings. See vector_knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("vectorKnowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration? VectorKnowledgeBaseConfiguration { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationMongoDbAtlasConfiguration
{
    /// <summary>–  The name of the collection in the MongoDB Atlas database.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  The name of the service that hosts the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpointServiceName")]
    public string? EndpointServiceName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationMongoDbAtlasConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("textIndexName")]
    public string? TextIndexName { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationNeptuneAnalyticsConfiguration
{
    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the Neptune Analytics vector store.</summary>
    [JsonPropertyName("graphArn")]
    public string? GraphArn { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchManagedClusterConfiguration
{
    /// <summary>ARN of the OpenSearch domain.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Endpoint URL of the OpenSearch domain.</summary>
    [JsonPropertyName("domainEndpoint")]
    public string? DomainEndpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchServerlessConfiguration
{
    /// <summary>ARN of the OpenSearch Service vector store.</summary>
    [JsonPropertyName("collectionArn")]
    public string? CollectionArn { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchServerlessConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationPineconeConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationPineconeConfiguration
{
    /// <summary>Endpoint URL for your index management page.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationPineconeConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>Namespace to be used to write new data to your database.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRdsConfigurationFieldMapping
{
    /// <summary>Name for the universal metadata field where Amazon Bedrock will store any custom metadata from your data source.</summary>
    [JsonPropertyName("customMetadataField")]
    public string? CustomMetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>Name of the field in which Amazon Bedrock stores the ID for each entry.</summary>
    [JsonPropertyName("primaryKeyField")]
    public string? PrimaryKeyField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRdsConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The name of the database in the MongoDB Atlas database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRdsConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>ARN of the vector store.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Name of the table in the database.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping
{
    /// <summary>–  The name of the field in which Amazon Bedrock stores metadata about the vector store.</summary>
    [JsonPropertyName("metadataField")]
    public string? MetadataField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the raw text from your data. The text is split according to the chunking strategy you choose.</summary>
    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    /// <summary>–  The name of the field in which Amazon Bedrock stores the vector embeddings for your data sources.</summary>
    [JsonPropertyName("vectorField")]
    public string? VectorField { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRedisEnterpriseCloudConfiguration
{
    /// <summary>–  The ARN of the secret that you created in AWS Secrets Manager that is linked to your MongoDB Atlas database.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>–  The endpoint URL of the MongoDB Atlas database.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>–  Contains the names of the fields to which to map information about the vector store.</summary>
    [JsonPropertyName("fieldMapping")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRedisEnterpriseCloudConfigurationFieldMapping? FieldMapping { get; set; }

    /// <summary>–  The name of the vector index.</summary>
    [JsonPropertyName("vectorIndexName")]
    public string? VectorIndexName { get; set; }
}

/// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationS3VectorsConfiguration
{
    /// <summary>ARN of the S3 Vectors index. Conflicts with index_name and vector_bucket_arn.</summary>
    [JsonPropertyName("indexArn")]
    public string? IndexArn { get; set; }

    /// <summary>Name of the S3 Vectors index. Must be specified with vector_bucket_arn. Conflicts with index_arn.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>ARN of the S3 Vectors vector bucket. Must be specified with index_name. Conflicts with index_arn.</summary>
    [JsonPropertyName("vectorBucketArn")]
    public string? VectorBucketArn { get; set; }
}

/// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProviderStorageConfiguration
{
    /// <summary>–  The storage configuration of the knowledge base in MongoDB Atlas. See mongo_db_atlas_configuration block for details.</summary>
    [JsonPropertyName("mongoDbAtlasConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationMongoDbAtlasConfiguration? MongoDbAtlasConfiguration { get; set; }

    /// <summary>–  The storage configuration of the knowledge base in Amazon Neptune Analytics. See neptune_analytics_configuration block for details.</summary>
    [JsonPropertyName("neptuneAnalyticsConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationNeptuneAnalyticsConfiguration? NeptuneAnalyticsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Managed Cluster. See opensearch_managed_cluster_configuration block for details.</summary>
    [JsonPropertyName("opensearchManagedClusterConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchManagedClusterConfiguration? OpensearchManagedClusterConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon OpenSearch Service Serverless. See opensearch_serverless_configuration block for details.</summary>
    [JsonPropertyName("opensearchServerlessConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationOpensearchServerlessConfiguration? OpensearchServerlessConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Pinecone. See pinecone_configuration block for details.</summary>
    [JsonPropertyName("pineconeConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationPineconeConfiguration? PineconeConfiguration { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base in Amazon RDS. For more information, see Create a vector index in Amazon RDS. See rds_configuration block for details.</summary>
    [JsonPropertyName("rdsConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRdsConfiguration? RdsConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Redis Enterprise Cloud. See redis_enterprise_cloud_configuration block for details.</summary>
    [JsonPropertyName("redisEnterpriseCloudConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationRedisEnterpriseCloudConfiguration? RedisEnterpriseCloudConfiguration { get; set; }

    /// <summary>The storage configuration of the knowledge base in Amazon S3 Vectors. See s3_vectors_configuration block for details.</summary>
    [JsonPropertyName("s3VectorsConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfigurationS3VectorsConfiguration? S3VectorsConfiguration { get; set; }

    /// <summary>Data storage service to use. Valid values: REDSHIFT, AWS_DATA_CATALOG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusAtProvider
{
    /// <summary>ARN of the knowledge base.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Time at which the knowledge base was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Description of the knowledge base.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("failureReasons")]
    public IList<string>? FailureReasons { get; set; }

    /// <summary>Unique identifier of the knowledge base.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Details about the embeddings configuration of the knowledge base. See knowledge_base_configuration block for details.</summary>
    [JsonPropertyName("knowledgeBaseConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderKnowledgeBaseConfiguration? KnowledgeBaseConfiguration { get; set; }

    /// <summary>Name of the knowledge base.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the knowledge base.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Details about the storage configuration of the knowledge base. See storage_configuration block for details.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1KnowledgeBaseStatusAtProviderStorageConfiguration? StorageConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Time at which the knowledge base was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatusConditions
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

/// <summary>KnowledgeBaseStatus defines the observed state of KnowledgeBase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KnowledgeBaseStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1KnowledgeBaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KnowledgeBaseStatusConditions>? Conditions { get; set; }

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

/// <summary>KnowledgeBase is the Schema for the KnowledgeBases API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KnowledgeBase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KnowledgeBaseSpec>, IStatus<V1beta1KnowledgeBaseStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KnowledgeBase";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "knowledgebases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KnowledgeBase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KnowledgeBaseSpec defines the desired state of KnowledgeBase</summary>
    [JsonPropertyName("spec")]
    public required V1beta1KnowledgeBaseSpec Spec { get; set; }

    /// <summary>KnowledgeBaseStatus defines the observed state of KnowledgeBase.</summary>
    [JsonPropertyName("status")]
    public V1beta1KnowledgeBaseStatus? Status { get; set; }
}