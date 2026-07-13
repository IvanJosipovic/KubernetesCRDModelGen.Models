#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecr.aws.upbound.io;
/// <summary>RepositoryCreationTemplate is the Schema for the RepositoryCreationTemplates API. Provides an Elastic Container Registry Repository Creation Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RepositoryCreationTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RepositoryCreationTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RepositoryCreationTemplateList";
    public const string KubeGroup = "ecr.aws.upbound.io";
    public const string KubePluralName = "repositorycreationtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryCreationTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RepositoryCreationTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RepositoryCreationTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecDeletionPolicyEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelector
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
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for any created repositories. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfigurationKmsKeySelector? KmsKeySelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProviderImageTagMutabilityExclusionFilter
{
    /// <summary>The filter pattern to use for excluding image tags from the mutability setting. Must contain only letters, numbers, and special characters (._-). Each filter can be up to 128 characters long and can contain a maximum of 2 wildcards ().</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The type of filter to use. Must be WILDCARD.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecForProvider
{
    /// <summary>Which features this template applies to. Must contain one or more of CREATE_ON_PUSH, PULL_THROUGH_CACHE, or REPLICATION.</summary>
    [JsonPropertyName("appliedFor")]
    public IList<string>? AppliedFor { get; set; }

    /// <summary>A custom IAM role to use for repository creation. Required if using repository tags or KMS encryption.</summary>
    [JsonPropertyName("customRoleArn")]
    public string? CustomRoleArn { get; set; }

    /// <summary>The description for this template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encryption configuration for any created repositories. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositoryCreationTemplateSpecForProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>The tag mutability setting for any created repositories. Must be one of: MUTABLE, IMMUTABLE, IMMUTABLE_WITH_EXCLUSION, or MUTABLE_WITH_EXCLUSION. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Configuration block that defines filters to specify which image tags can override the default tag mutability setting. Only applicable when image_tag_mutability is set to IMMUTABLE_WITH_EXCLUSION or MUTABLE_WITH_EXCLUSION. See below for schema.</summary>
    [JsonPropertyName("imageTagMutabilityExclusionFilter")]
    public IList<V1beta1RepositoryCreationTemplateSpecForProviderImageTagMutabilityExclusionFilter>? ImageTagMutabilityExclusionFilter { get; set; }

    /// <summary>The lifecycle policy document to apply to any created repositories. See more details about Policy Parameters in the official AWS docs. Consider using the aws_ecr_lifecycle_policy_document data_source to generate/manage the JSON document used for the lifecycle_policy argument.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public string? LifecyclePolicy { get; set; }

    /// <summary>The repository name prefix to match against. Use ROOT to match any prefix that doesn&apos;t explicitly match another template.</summary>
    [JsonPropertyName("prefix")]
    public required string Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The registry policy document to apply to any created repositories. This is a JSON formatted string.</summary>
    [JsonPropertyName("repositoryPolicy")]
    public string? RepositoryPolicy { get; set; }

    /// <summary>A map of tags to assign to any created repositories.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelector
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
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for any created repositories. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfigurationKmsKeySelector? KmsKeySelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecInitProviderImageTagMutabilityExclusionFilter
{
    /// <summary>The filter pattern to use for excluding image tags from the mutability setting. Must contain only letters, numbers, and special characters (._-). Each filter can be up to 128 characters long and can contain a maximum of 2 wildcards ().</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The type of filter to use. Must be WILDCARD.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
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
public partial class V1beta1RepositoryCreationTemplateSpecInitProvider
{
    /// <summary>Which features this template applies to. Must contain one or more of CREATE_ON_PUSH, PULL_THROUGH_CACHE, or REPLICATION.</summary>
    [JsonPropertyName("appliedFor")]
    public IList<string>? AppliedFor { get; set; }

    /// <summary>A custom IAM role to use for repository creation. Required if using repository tags or KMS encryption.</summary>
    [JsonPropertyName("customRoleArn")]
    public string? CustomRoleArn { get; set; }

    /// <summary>The description for this template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encryption configuration for any created repositories. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositoryCreationTemplateSpecInitProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>The tag mutability setting for any created repositories. Must be one of: MUTABLE, IMMUTABLE, IMMUTABLE_WITH_EXCLUSION, or MUTABLE_WITH_EXCLUSION. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Configuration block that defines filters to specify which image tags can override the default tag mutability setting. Only applicable when image_tag_mutability is set to IMMUTABLE_WITH_EXCLUSION or MUTABLE_WITH_EXCLUSION. See below for schema.</summary>
    [JsonPropertyName("imageTagMutabilityExclusionFilter")]
    public IList<V1beta1RepositoryCreationTemplateSpecInitProviderImageTagMutabilityExclusionFilter>? ImageTagMutabilityExclusionFilter { get; set; }

    /// <summary>The lifecycle policy document to apply to any created repositories. See more details about Policy Parameters in the official AWS docs. Consider using the aws_ecr_lifecycle_policy_document data_source to generate/manage the JSON document used for the lifecycle_policy argument.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public string? LifecyclePolicy { get; set; }

    /// <summary>The registry policy document to apply to any created repositories. This is a JSON formatted string.</summary>
    [JsonPropertyName("repositoryPolicy")]
    public string? RepositoryPolicy { get; set; }

    /// <summary>A map of tags to assign to any created repositories.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecManagementPoliciesEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RepositoryCreationTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RepositoryCreationTemplateSpec defines the desired state of RepositoryCreationTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateSpec
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
    public V1beta1RepositoryCreationTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1RepositoryCreationTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta1RepositoryCreationTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1RepositoryCreationTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RepositoryCreationTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RepositoryCreationTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateStatusAtProviderEncryptionConfiguration
{
    /// <summary>The encryption type to use for any created repositories. Valid values are AES256 or KMS. Defaults to AES256.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The ARN of the KMS key to use when encryption_type is KMS. If not specified, uses the default AWS managed key for ECR.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateStatusAtProviderImageTagMutabilityExclusionFilter
{
    /// <summary>The filter pattern to use for excluding image tags from the mutability setting. Must contain only letters, numbers, and special characters (._-). Each filter can be up to 128 characters long and can contain a maximum of 2 wildcards ().</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The type of filter to use. Must be WILDCARD.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateStatusAtProvider
{
    /// <summary>Which features this template applies to. Must contain one or more of CREATE_ON_PUSH, PULL_THROUGH_CACHE, or REPLICATION.</summary>
    [JsonPropertyName("appliedFor")]
    public IList<string>? AppliedFor { get; set; }

    /// <summary>A custom IAM role to use for repository creation. Required if using repository tags or KMS encryption.</summary>
    [JsonPropertyName("customRoleArn")]
    public string? CustomRoleArn { get; set; }

    /// <summary>The description for this template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Encryption configuration for any created repositories. See below for schema.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1RepositoryCreationTemplateStatusAtProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The tag mutability setting for any created repositories. Must be one of: MUTABLE, IMMUTABLE, IMMUTABLE_WITH_EXCLUSION, or MUTABLE_WITH_EXCLUSION. Defaults to MUTABLE.</summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>Configuration block that defines filters to specify which image tags can override the default tag mutability setting. Only applicable when image_tag_mutability is set to IMMUTABLE_WITH_EXCLUSION or MUTABLE_WITH_EXCLUSION. See below for schema.</summary>
    [JsonPropertyName("imageTagMutabilityExclusionFilter")]
    public IList<V1beta1RepositoryCreationTemplateStatusAtProviderImageTagMutabilityExclusionFilter>? ImageTagMutabilityExclusionFilter { get; set; }

    /// <summary>The lifecycle policy document to apply to any created repositories. See more details about Policy Parameters in the official AWS docs. Consider using the aws_ecr_lifecycle_policy_document data_source to generate/manage the JSON document used for the lifecycle_policy argument.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public string? LifecyclePolicy { get; set; }

    /// <summary>The repository name prefix to match against. Use ROOT to match any prefix that doesn&apos;t explicitly match another template.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The registry ID the repository creation template applies to.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }

    /// <summary>The registry policy document to apply to any created repositories. This is a JSON formatted string.</summary>
    [JsonPropertyName("repositoryPolicy")]
    public string? RepositoryPolicy { get; set; }

    /// <summary>A map of tags to assign to any created repositories.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateStatusConditions
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

/// <summary>RepositoryCreationTemplateStatus defines the observed state of RepositoryCreationTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepositoryCreationTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RepositoryCreationTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RepositoryCreationTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RepositoryCreationTemplate is the Schema for the RepositoryCreationTemplates API. Provides an Elastic Container Registry Repository Creation Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RepositoryCreationTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RepositoryCreationTemplateSpec>, IStatus<V1beta1RepositoryCreationTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RepositoryCreationTemplate";
    public const string KubeGroup = "ecr.aws.upbound.io";
    public const string KubePluralName = "repositorycreationtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryCreationTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RepositoryCreationTemplateSpec defines the desired state of RepositoryCreationTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RepositoryCreationTemplateSpec Spec { get; set; }

    /// <summary>RepositoryCreationTemplateStatus defines the observed state of RepositoryCreationTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1RepositoryCreationTemplateStatus? Status { get; set; }
}