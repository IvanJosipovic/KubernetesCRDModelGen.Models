#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>DataCatalogEncryptionSettings is the Schema for the DataCatalogEncryptionSettingss API. Provides a Glue Data Catalog Encryption Settings resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataCatalogEncryptionSettingsList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DataCatalogEncryptionSettings>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataCatalogEncryptionSettingsList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "datacatalogencryptionsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCatalogEncryptionSettingsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DataCatalogEncryptionSettings objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DataCatalogEncryptionSettings> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecDeletionPolicyEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector
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
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef? AwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdSelector")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector? AwsKmsKeyIdSelector { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector
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
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef? SseAwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdSelector")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector? SseAwsKmsKeyIdSelector { get; set; }
}

/// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRest? EncryptionAtRest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecForProvider
{
    /// <summary>The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public V1beta2DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettings? DataCatalogEncryptionSettings { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector
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
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef? AwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdSelector")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector? AwsKmsKeyIdSelector { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector
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
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef? SseAwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdSelector")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector? SseAwsKmsKeyIdSelector { get; set; }
}

/// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRest? EncryptionAtRest { get; set; }
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
public partial class V1beta2DataCatalogEncryptionSettingsSpecInitProvider
{
    /// <summary>The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public V1beta2DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettings? DataCatalogEncryptionSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecManagementPoliciesEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DataCatalogEncryptionSettingsSpec defines the desired state of DataCatalogEncryptionSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsSpec
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
    public V1beta2DataCatalogEncryptionSettingsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DataCatalogEncryptionSettingsSpecForProvider ForProvider { get; set; }

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
    public V1beta2DataCatalogEncryptionSettingsSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DataCatalogEncryptionSettingsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DataCatalogEncryptionSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }
}

/// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsEncryptionAtRest? EncryptionAtRest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatusAtProvider
{
    /// <summary>The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public V1beta2DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettings? DataCatalogEncryptionSettings { get; set; }

    /// <summary>The ID of the Data Catalog to set the security configuration for.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatusConditions
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

/// <summary>DataCatalogEncryptionSettingsStatus defines the observed state of DataCatalogEncryptionSettings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataCatalogEncryptionSettingsStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DataCatalogEncryptionSettingsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DataCatalogEncryptionSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataCatalogEncryptionSettings is the Schema for the DataCatalogEncryptionSettingss API. Provides a Glue Data Catalog Encryption Settings resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataCatalogEncryptionSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DataCatalogEncryptionSettingsSpec>, IStatus<V1beta2DataCatalogEncryptionSettingsStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataCatalogEncryptionSettings";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "datacatalogencryptionsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCatalogEncryptionSettings";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataCatalogEncryptionSettingsSpec defines the desired state of DataCatalogEncryptionSettings</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DataCatalogEncryptionSettingsSpec Spec { get; set; }

    /// <summary>DataCatalogEncryptionSettingsStatus defines the observed state of DataCatalogEncryptionSettings.</summary>
    [JsonPropertyName("status")]
    public V1beta2DataCatalogEncryptionSettingsStatus? Status { get; set; }
}