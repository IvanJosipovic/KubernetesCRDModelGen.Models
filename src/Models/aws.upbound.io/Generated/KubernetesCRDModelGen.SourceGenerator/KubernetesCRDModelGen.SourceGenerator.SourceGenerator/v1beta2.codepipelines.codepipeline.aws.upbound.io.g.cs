#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codepipeline.aws.upbound.io;
/// <summary>Codepipeline is the Schema for the Codepipelines API. Provides a CodePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CodepipelineList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Codepipeline>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CodepipelineList";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "codepipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codepipeline.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CodepipelineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Codepipeline objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Codepipeline> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecDeletionPolicyEnum>))]
public enum V1beta2CodepipelineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStoreLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelector
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
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreEncryptionKey? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta2CodepipelineSpecForProviderArtifactStoreLocationSelector? LocationSelector { get; set; }

    /// <summary>The region where the artifact store is located. Required for a cross-region CodePipeline, do not provide for a single-region CodePipeline.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CodepipelineSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderRoleArnSelector
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
    public V1beta2CodepipelineSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecForProviderStageBeforeEntryConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecForProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecForProviderStageBeforeEntryCondition? Condition { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecForProviderStageOnFailureConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecForProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecForProviderStageOnFailureCondition? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public V1beta2CodepipelineSpecForProviderStageOnFailureRetryConfiguration? RetryConfiguration { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecForProviderStageOnSuccessConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecForProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecForProviderStageOnSuccessCondition? Condition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2CodepipelineSpecForProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public V1beta2CodepipelineSpecForProviderStageBeforeEntry? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta2CodepipelineSpecForProviderStageOnFailure? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta2CodepipelineSpecForProviderStageOnSuccess? OnSuccess { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequestBranches? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequestFilePaths? FilePaths { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushBranches? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushFilePaths? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPushTags? Tags { get; set; }
}

/// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta2CodepipelineSpecForProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public V1beta2CodepipelineSpecForProviderTriggerGitConfiguration? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecForProvider
{
    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta2CodepipelineSpecForProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2CodepipelineSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2CodepipelineSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta2CodepipelineSpecForProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta2CodepipelineSpecForProviderTrigger>? Trigger { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta2CodepipelineSpecForProviderVariable>? Variable { get; set; }
}

/// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelector
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
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreEncryptionKey? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta2CodepipelineSpecInitProviderArtifactStoreLocationSelector? LocationSelector { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CodepipelineSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderRoleArnSelector
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
    public V1beta2CodepipelineSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecInitProviderStageBeforeEntryConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecInitProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecInitProviderStageBeforeEntryCondition? Condition { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecInitProviderStageOnFailureConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecInitProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecInitProviderStageOnFailureCondition? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public V1beta2CodepipelineSpecInitProviderStageOnFailureRetryConfiguration? RetryConfiguration { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineSpecInitProviderStageOnSuccessConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineSpecInitProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineSpecInitProviderStageOnSuccessCondition? Condition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2CodepipelineSpecInitProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public V1beta2CodepipelineSpecInitProviderStageBeforeEntry? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta2CodepipelineSpecInitProviderStageOnFailure? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta2CodepipelineSpecInitProviderStageOnSuccess? OnSuccess { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestBranches? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestFilePaths? FilePaths { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushBranches? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushFilePaths? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPushTags? Tags { get; set; }
}

/// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta2CodepipelineSpecInitProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public V1beta2CodepipelineSpecInitProviderTriggerGitConfiguration? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecInitProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta2CodepipelineSpecInitProvider
{
    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta2CodepipelineSpecInitProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2CodepipelineSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2CodepipelineSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta2CodepipelineSpecInitProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta2CodepipelineSpecInitProviderTrigger>? Trigger { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta2CodepipelineSpecInitProviderVariable>? Variable { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecManagementPoliciesEnum>))]
public enum V1beta2CodepipelineSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CodepipelineSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CodepipelineSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CodepipelineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CodepipelineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CodepipelineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CodepipelineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CodepipelineSpec defines the desired state of Codepipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineSpec
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
    public V1beta2CodepipelineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CodepipelineSpecForProvider ForProvider { get; set; }

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
    public V1beta2CodepipelineSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CodepipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CodepipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CodepipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don&apos;t specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1beta2CodepipelineStatusAtProviderArtifactStoreEncryptionKey? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The region where the artifact store is located. Required for a cross-region CodePipeline, do not provide for a single-region CodePipeline.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineStatusAtProviderStageBeforeEntryConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineStatusAtProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineStatusAtProviderStageBeforeEntryCondition? Condition { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineStatusAtProviderStageOnFailureConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineStatusAtProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineStatusAtProviderStageOnFailureCondition? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public V1beta2CodepipelineStatusAtProviderStageOnFailureRetryConfiguration? RetryConfiguration { get; set; }
}

/// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration&apos;s configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public V1beta2CodepipelineStatusAtProviderStageOnSuccessConditionRuleRuleTypeId? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2CodepipelineStatusAtProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2CodepipelineStatusAtProviderStageOnSuccessCondition? Condition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2CodepipelineStatusAtProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public V1beta2CodepipelineStatusAtProviderStageBeforeEntry? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta2CodepipelineStatusAtProviderStageOnFailure? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta2CodepipelineStatusAtProviderStageOnSuccess? OnSuccess { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestBranches? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestFilePaths? FilePaths { get; set; }
}

/// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushBranches? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushFilePaths? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPushTags? Tags { get; set; }
}

/// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public V1beta2CodepipelineStatusAtProviderTriggerGitConfiguration? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestBranches>? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestFilePaths>? FilePaths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushBranches>? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushFilePaths>? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPushTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAllGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderTriggerAll
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAllGitConfiguration>? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusAtProvider
{
    /// <summary>Codepipeline ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta2CodepipelineStatusAtProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Codepipeline ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta2CodepipelineStatusAtProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta2CodepipelineStatusAtProviderTrigger>? Trigger { get; set; }

    /// <summary>A list of all triggers present on the pipeline, including default triggers added by AWS for V2 pipelines which omit an explicit trigger definition.</summary>
    [JsonPropertyName("triggerAll")]
    public IList<V1beta2CodepipelineStatusAtProviderTriggerAll>? TriggerAll { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta2CodepipelineStatusAtProviderVariable>? Variable { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatusConditions
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

/// <summary>CodepipelineStatus defines the observed state of Codepipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CodepipelineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CodepipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CodepipelineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Codepipeline is the Schema for the Codepipelines API. Provides a CodePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Codepipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CodepipelineSpec>, IStatus<V1beta2CodepipelineStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Codepipeline";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "codepipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codepipeline.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Codepipeline";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CodepipelineSpec defines the desired state of Codepipeline</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CodepipelineSpec Spec { get; set; }

    /// <summary>CodepipelineStatus defines the observed state of Codepipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta2CodepipelineStatus? Status { get; set; }
}