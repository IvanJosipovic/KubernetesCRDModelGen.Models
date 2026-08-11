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
/// <summary>Guardrail is the Schema for the Guardrails API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GuardrailList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Guardrail>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GuardrailList";
    public const string KubeGroup = "bedrock.aws.m.upbound.io";
    public const string KubePluralName = "guardrails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrock.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GuardrailList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Guardrail objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Guardrail> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderContentPolicyConfigFiltersConfig
{
    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on input.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>List of selected input modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("inputModalities")]
    public IList<string>? InputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("inputStrength")]
    public string? InputStrength { get; set; }

    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on output.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>List of selected output modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("outputModalities")]
    public IList<string>? OutputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("outputStrength")]
    public string? OutputStrength { get; set; }

    /// <summary>Type of filter in content policy. Valid Values: SEXUAL, VIOLENCE, HATE, INSULTS, MISCONDUCT, PROMPT_ATTACK.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderContentPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

/// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderContentPolicyConfig
{
    /// <summary>
    /// Set of content filter configs in content policy.
    /// See Filters Config for more information.
    /// </summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailSpecForProviderContentPolicyConfigFiltersConfig>? FiltersConfig { get; set; }

    /// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailSpecForProviderContentPolicyConfigTierConfig? TierConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderContextualGroundingPolicyConfigFiltersConfig
{
    /// <summary>The threshold for this filter.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderContextualGroundingPolicyConfig
{
    /// <summary>One or more blocks defining contextual grounding filter configs. See Contextual Grounding Filters Config for more information.</summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailSpecForProviderContextualGroundingPolicyConfigFiltersConfig>? FiltersConfig { get; set; }
}

/// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderCrossRegionConfig
{
    /// <summary>Guardrail profile ARN.</summary>
    [JsonPropertyName("guardrailProfileIdentifier")]
    public string? GuardrailProfileIdentifier { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderKmsKeyArnSelector
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
    public V1beta1GuardrailSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfigPiiEntitiesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfigRegexesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The regex pattern.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfig
{
    /// <summary>List of entities. See PII Entities Config for more information.</summary>
    [JsonPropertyName("piiEntitiesConfig")]
    public IList<V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfigPiiEntitiesConfig>? PiiEntitiesConfig { get; set; }

    /// <summary>List of regex. See Regexes Config for more information.</summary>
    [JsonPropertyName("regexesConfig")]
    public IList<V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfigRegexesConfig>? RegexesConfig { get; set; }
}

/// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderTopicPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderTopicPolicyConfigTopicsConfig
{
    /// <summary>Definition of topic in topic policy.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>List of text examples.</summary>
    [JsonPropertyName("examples")]
    public IList<string>? Examples { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderTopicPolicyConfig
{
    /// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailSpecForProviderTopicPolicyConfigTierConfig? TierConfig { get; set; }

    /// <summary>List of topic configs in topic policy. See Topics Config for more information.</summary>
    [JsonPropertyName("topicsConfig")]
    public IList<V1beta1GuardrailSpecForProviderTopicPolicyConfigTopicsConfig>? TopicsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderWordPolicyConfigManagedWordListsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderWordPolicyConfigWordsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The custom word text.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProviderWordPolicyConfig
{
    /// <summary>A config for the list of managed words. See Managed Word Lists Config for more information.</summary>
    [JsonPropertyName("managedWordListsConfig")]
    public IList<V1beta1GuardrailSpecForProviderWordPolicyConfigManagedWordListsConfig>? ManagedWordListsConfig { get; set; }

    /// <summary>List of custom word configs. See Words Config for more information.</summary>
    [JsonPropertyName("wordsConfig")]
    public IList<V1beta1GuardrailSpecForProviderWordPolicyConfigWordsConfig>? WordsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecForProvider
{
    /// <summary>Message to return when the guardrail blocks a prompt.</summary>
    [JsonPropertyName("blockedInputMessaging")]
    public string? BlockedInputMessaging { get; set; }

    /// <summary>Message to return when the guardrail blocks a model response.</summary>
    [JsonPropertyName("blockedOutputsMessaging")]
    public string? BlockedOutputsMessaging { get; set; }

    /// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
    [JsonPropertyName("contentPolicyConfig")]
    public V1beta1GuardrailSpecForProviderContentPolicyConfig? ContentPolicyConfig { get; set; }

    /// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
    [JsonPropertyName("contextualGroundingPolicyConfig")]
    public V1beta1GuardrailSpecForProviderContextualGroundingPolicyConfig? ContextualGroundingPolicyConfig { get; set; }

    /// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
    [JsonPropertyName("crossRegionConfig")]
    public V1beta1GuardrailSpecForProviderCrossRegionConfig? CrossRegionConfig { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The KMS key with which the guardrail was encrypted at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1GuardrailSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
    [JsonPropertyName("sensitiveInformationPolicyConfig")]
    public V1beta1GuardrailSpecForProviderSensitiveInformationPolicyConfig? SensitiveInformationPolicyConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
    [JsonPropertyName("topicPolicyConfig")]
    public V1beta1GuardrailSpecForProviderTopicPolicyConfig? TopicPolicyConfig { get; set; }

    /// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
    [JsonPropertyName("wordPolicyConfig")]
    public V1beta1GuardrailSpecForProviderWordPolicyConfig? WordPolicyConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderContentPolicyConfigFiltersConfig
{
    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on input.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>List of selected input modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("inputModalities")]
    public IList<string>? InputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("inputStrength")]
    public string? InputStrength { get; set; }

    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on output.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>List of selected output modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("outputModalities")]
    public IList<string>? OutputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("outputStrength")]
    public string? OutputStrength { get; set; }

    /// <summary>Type of filter in content policy. Valid Values: SEXUAL, VIOLENCE, HATE, INSULTS, MISCONDUCT, PROMPT_ATTACK.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderContentPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

/// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderContentPolicyConfig
{
    /// <summary>
    /// Set of content filter configs in content policy.
    /// See Filters Config for more information.
    /// </summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailSpecInitProviderContentPolicyConfigFiltersConfig>? FiltersConfig { get; set; }

    /// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailSpecInitProviderContentPolicyConfigTierConfig? TierConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderContextualGroundingPolicyConfigFiltersConfig
{
    /// <summary>The threshold for this filter.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderContextualGroundingPolicyConfig
{
    /// <summary>One or more blocks defining contextual grounding filter configs. See Contextual Grounding Filters Config for more information.</summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailSpecInitProviderContextualGroundingPolicyConfigFiltersConfig>? FiltersConfig { get; set; }
}

/// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderCrossRegionConfig
{
    /// <summary>Guardrail profile ARN.</summary>
    [JsonPropertyName("guardrailProfileIdentifier")]
    public string? GuardrailProfileIdentifier { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderKmsKeyArnSelector
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
    public V1beta1GuardrailSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfigPiiEntitiesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfigRegexesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The regex pattern.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfig
{
    /// <summary>List of entities. See PII Entities Config for more information.</summary>
    [JsonPropertyName("piiEntitiesConfig")]
    public IList<V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfigPiiEntitiesConfig>? PiiEntitiesConfig { get; set; }

    /// <summary>List of regex. See Regexes Config for more information.</summary>
    [JsonPropertyName("regexesConfig")]
    public IList<V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfigRegexesConfig>? RegexesConfig { get; set; }
}

/// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderTopicPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderTopicPolicyConfigTopicsConfig
{
    /// <summary>Definition of topic in topic policy.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>List of text examples.</summary>
    [JsonPropertyName("examples")]
    public IList<string>? Examples { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderTopicPolicyConfig
{
    /// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailSpecInitProviderTopicPolicyConfigTierConfig? TierConfig { get; set; }

    /// <summary>List of topic configs in topic policy. See Topics Config for more information.</summary>
    [JsonPropertyName("topicsConfig")]
    public IList<V1beta1GuardrailSpecInitProviderTopicPolicyConfigTopicsConfig>? TopicsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderWordPolicyConfigManagedWordListsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderWordPolicyConfigWordsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The custom word text.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpecInitProviderWordPolicyConfig
{
    /// <summary>A config for the list of managed words. See Managed Word Lists Config for more information.</summary>
    [JsonPropertyName("managedWordListsConfig")]
    public IList<V1beta1GuardrailSpecInitProviderWordPolicyConfigManagedWordListsConfig>? ManagedWordListsConfig { get; set; }

    /// <summary>List of custom word configs. See Words Config for more information.</summary>
    [JsonPropertyName("wordsConfig")]
    public IList<V1beta1GuardrailSpecInitProviderWordPolicyConfigWordsConfig>? WordsConfig { get; set; }
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
public partial class V1beta1GuardrailSpecInitProvider
{
    /// <summary>Message to return when the guardrail blocks a prompt.</summary>
    [JsonPropertyName("blockedInputMessaging")]
    public string? BlockedInputMessaging { get; set; }

    /// <summary>Message to return when the guardrail blocks a model response.</summary>
    [JsonPropertyName("blockedOutputsMessaging")]
    public string? BlockedOutputsMessaging { get; set; }

    /// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
    [JsonPropertyName("contentPolicyConfig")]
    public V1beta1GuardrailSpecInitProviderContentPolicyConfig? ContentPolicyConfig { get; set; }

    /// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
    [JsonPropertyName("contextualGroundingPolicyConfig")]
    public V1beta1GuardrailSpecInitProviderContextualGroundingPolicyConfig? ContextualGroundingPolicyConfig { get; set; }

    /// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
    [JsonPropertyName("crossRegionConfig")]
    public V1beta1GuardrailSpecInitProviderCrossRegionConfig? CrossRegionConfig { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The KMS key with which the guardrail was encrypted at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1GuardrailSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
    [JsonPropertyName("sensitiveInformationPolicyConfig")]
    public V1beta1GuardrailSpecInitProviderSensitiveInformationPolicyConfig? SensitiveInformationPolicyConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
    [JsonPropertyName("topicPolicyConfig")]
    public V1beta1GuardrailSpecInitProviderTopicPolicyConfig? TopicPolicyConfig { get; set; }

    /// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
    [JsonPropertyName("wordPolicyConfig")]
    public V1beta1GuardrailSpecInitProviderWordPolicyConfig? WordPolicyConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GuardrailSpecManagementPoliciesEnum>))]
public enum V1beta1GuardrailSpecManagementPoliciesEnum
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
public partial class V1beta1GuardrailSpecProviderConfigRef
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
public partial class V1beta1GuardrailSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GuardrailSpec defines the desired state of Guardrail</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1GuardrailSpecForProvider ForProvider { get; set; }

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
    public V1beta1GuardrailSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GuardrailSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GuardrailSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GuardrailSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderContentPolicyConfigFiltersConfig
{
    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on input.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>List of selected input modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("inputModalities")]
    public IList<string>? InputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("inputStrength")]
    public string? InputStrength { get; set; }

    /// <summary>Action to take when harmful content is detected. Valid values: BLOCK, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Toggles guardrail evaluation on output.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>List of selected output modalities. Valid values: IMAGE, TEXT.</summary>
    [JsonPropertyName("outputModalities")]
    public IList<string>? OutputModalities { get; set; }

    /// <summary>Strength for filters. Valid values: NONE, LOW, MEDIUM, HIGH.</summary>
    [JsonPropertyName("outputStrength")]
    public string? OutputStrength { get; set; }

    /// <summary>Type of filter in content policy. Valid Values: SEXUAL, VIOLENCE, HATE, INSULTS, MISCONDUCT, PROMPT_ATTACK.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderContentPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

/// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderContentPolicyConfig
{
    /// <summary>
    /// Set of content filter configs in content policy.
    /// See Filters Config for more information.
    /// </summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailStatusAtProviderContentPolicyConfigFiltersConfig>? FiltersConfig { get; set; }

    /// <summary>Configuration block for the content policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailStatusAtProviderContentPolicyConfigTierConfig? TierConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderContextualGroundingPolicyConfigFiltersConfig
{
    /// <summary>The threshold for this filter.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderContextualGroundingPolicyConfig
{
    /// <summary>One or more blocks defining contextual grounding filter configs. See Contextual Grounding Filters Config for more information.</summary>
    [JsonPropertyName("filtersConfig")]
    public IList<V1beta1GuardrailStatusAtProviderContextualGroundingPolicyConfigFiltersConfig>? FiltersConfig { get; set; }
}

/// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderCrossRegionConfig
{
    /// <summary>Guardrail profile ARN.</summary>
    [JsonPropertyName("guardrailProfileIdentifier")]
    public string? GuardrailProfileIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfigPiiEntitiesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfigRegexesConfig
{
    /// <summary>Options for sensitive information action. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The regex pattern.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfig
{
    /// <summary>List of entities. See PII Entities Config for more information.</summary>
    [JsonPropertyName("piiEntitiesConfig")]
    public IList<V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfigPiiEntitiesConfig>? PiiEntitiesConfig { get; set; }

    /// <summary>List of regex. See Regexes Config for more information.</summary>
    [JsonPropertyName("regexesConfig")]
    public IList<V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfigRegexesConfig>? RegexesConfig { get; set; }
}

/// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderTopicPolicyConfigTierConfig
{
    /// <summary>The name of the content policy tier. Valid values include STANDARD or CLASSIC.</summary>
    [JsonPropertyName("tierName")]
    public string? TierName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderTopicPolicyConfigTopicsConfig
{
    /// <summary>Definition of topic in topic policy.</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>List of text examples.</summary>
    [JsonPropertyName("examples")]
    public IList<string>? Examples { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderTopicPolicyConfig
{
    /// <summary>Configuration block for the topic policy tier. See Tier Config for more information.</summary>
    [JsonPropertyName("tierConfig")]
    public V1beta1GuardrailStatusAtProviderTopicPolicyConfigTierConfig? TierConfig { get; set; }

    /// <summary>List of topic configs in topic policy. See Topics Config for more information.</summary>
    [JsonPropertyName("topicsConfig")]
    public IList<V1beta1GuardrailStatusAtProviderTopicPolicyConfigTopicsConfig>? TopicsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderWordPolicyConfigManagedWordListsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>Type of topic in a policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderWordPolicyConfigWordsConfig
{
    /// <summary>Action to take when harmful content is detected in the input. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("inputAction")]
    public string? InputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the input. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("inputEnabled")]
    public bool? InputEnabled { get; set; }

    /// <summary>Action to take when harmful content is detected in the output. Valid values: BLOCK, ANONYMIZE, NONE.</summary>
    [JsonPropertyName("outputAction")]
    public string? OutputAction { get; set; }

    /// <summary>Whether to enable guardrail evaluation on the output. When disabled, you aren&apos;t charged for the evaluation.</summary>
    [JsonPropertyName("outputEnabled")]
    public bool? OutputEnabled { get; set; }

    /// <summary>The custom word text.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProviderWordPolicyConfig
{
    /// <summary>A config for the list of managed words. See Managed Word Lists Config for more information.</summary>
    [JsonPropertyName("managedWordListsConfig")]
    public IList<V1beta1GuardrailStatusAtProviderWordPolicyConfigManagedWordListsConfig>? ManagedWordListsConfig { get; set; }

    /// <summary>List of custom word configs. See Words Config for more information.</summary>
    [JsonPropertyName("wordsConfig")]
    public IList<V1beta1GuardrailStatusAtProviderWordPolicyConfigWordsConfig>? WordsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusAtProvider
{
    /// <summary>Message to return when the guardrail blocks a prompt.</summary>
    [JsonPropertyName("blockedInputMessaging")]
    public string? BlockedInputMessaging { get; set; }

    /// <summary>Message to return when the guardrail blocks a model response.</summary>
    [JsonPropertyName("blockedOutputsMessaging")]
    public string? BlockedOutputsMessaging { get; set; }

    /// <summary>Content policy config for a guardrail. See Content Policy Config for more information.</summary>
    [JsonPropertyName("contentPolicyConfig")]
    public V1beta1GuardrailStatusAtProviderContentPolicyConfig? ContentPolicyConfig { get; set; }

    /// <summary>Contextual grounding policy config for a guardrail. See Contextual Grounding Policy Config for more information.</summary>
    [JsonPropertyName("contextualGroundingPolicyConfig")]
    public V1beta1GuardrailStatusAtProviderContextualGroundingPolicyConfig? ContextualGroundingPolicyConfig { get; set; }

    /// <summary>Unix epoch timestamp in seconds for when the Guardrail was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>region routing for bedrock guardrails. See [Cross Region Config](#cross-region-config for more information. Note see available regions here.</summary>
    [JsonPropertyName("crossRegionConfig")]
    public V1beta1GuardrailStatusAtProviderCrossRegionConfig? CrossRegionConfig { get; set; }

    /// <summary>Description of the guardrail or its version.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the Guardrail.</summary>
    [JsonPropertyName("guardrailArn")]
    public string? GuardrailArn { get; set; }

    /// <summary>ID of the Guardrail.</summary>
    [JsonPropertyName("guardrailId")]
    public string? GuardrailId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The KMS key with which the guardrail was encrypted at rest.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Name of the guardrail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Sensitive information policy config for a guardrail. See Sensitive Information Policy Config for more information.</summary>
    [JsonPropertyName("sensitiveInformationPolicyConfig")]
    public V1beta1GuardrailStatusAtProviderSensitiveInformationPolicyConfig? SensitiveInformationPolicyConfig { get; set; }

    /// <summary>Status of the Bedrock Guardrail. One of READY, FAILED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Topic policy config for a guardrail. See Topic Policy Config for more information.</summary>
    [JsonPropertyName("topicPolicyConfig")]
    public V1beta1GuardrailStatusAtProviderTopicPolicyConfig? TopicPolicyConfig { get; set; }

    /// <summary>Date and time that the Guardrail list was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary>Version of the Guardrail.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Word policy config for a guardrail. See Word Policy Config for more information.</summary>
    [JsonPropertyName("wordPolicyConfig")]
    public V1beta1GuardrailStatusAtProviderWordPolicyConfig? WordPolicyConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatusConditions
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

/// <summary>GuardrailStatus defines the observed state of Guardrail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GuardrailStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GuardrailStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GuardrailStatusConditions>? Conditions { get; set; }

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

/// <summary>Guardrail is the Schema for the Guardrails API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Guardrail : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GuardrailSpec>, IStatus<V1beta1GuardrailStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Guardrail";
    public const string KubeGroup = "bedrock.aws.m.upbound.io";
    public const string KubePluralName = "guardrails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrock.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Guardrail";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GuardrailSpec defines the desired state of Guardrail</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GuardrailSpec Spec { get; set; }

    /// <summary>GuardrailStatus defines the observed state of Guardrail.</summary>
    [JsonPropertyName("status")]
    public V1beta1GuardrailStatus? Status { get; set; }
}