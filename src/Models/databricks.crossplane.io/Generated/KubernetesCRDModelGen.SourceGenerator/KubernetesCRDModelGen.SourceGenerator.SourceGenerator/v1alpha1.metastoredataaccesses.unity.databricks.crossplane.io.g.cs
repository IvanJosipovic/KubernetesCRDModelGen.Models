#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>
/// MetastoreDataAccess is the Schema for the MetastoreDataAccesss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreDataAccessList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetastoreDataAccess>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreDataAccessList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "metastoredataaccesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreDataAccessList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MetastoreDataAccess objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MetastoreDataAccess> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderAwsIamRole
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderAzureManagedIdentity
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderAzureServicePrincipalClientSecretSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderAzureServicePrincipal
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1alpha1MetastoreDataAccessSpecForProviderAzureServicePrincipalClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderCloudflareApiToken
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1alpha1MetastoreDataAccessSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1MetastoreDataAccessSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef? PrivateKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelector
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
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecForProvider
{
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderAwsIamRole>? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderCloudflareApiToken>? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public IList<V1alpha1MetastoreDataAccessSpecForProviderGcpServiceAccountKey>? GcpServiceAccountKey { get; set; }

    /// <summary>whether to set this credential as the default for the metastore. In practice, this should always be true.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdRef")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdRef? MetastoreIdRef { get; set; }

    /// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdSelector")]
    public V1alpha1MetastoreDataAccessSpecForProviderMetastoreIdSelector? MetastoreIdSelector { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderAwsIamRole
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderAzureManagedIdentity
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderAzureServicePrincipalClientSecretSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderAzureServicePrincipal
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1alpha1MetastoreDataAccessSpecInitProviderAzureServicePrincipalClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderCloudflareApiToken
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public required V1alpha1MetastoreDataAccessSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1alpha1MetastoreDataAccessSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef PrivateKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelector
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
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicy? Policy { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecInitProvider
{
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderAwsIamRole>? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderCloudflareApiToken>? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public IList<V1alpha1MetastoreDataAccessSpecInitProviderGcpServiceAccountKey>? GcpServiceAccountKey { get; set; }

    /// <summary>whether to set this credential as the default for the metastore. In practice, this should always be true.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdRef")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdRef? MetastoreIdRef { get; set; }

    /// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdSelector")]
    public V1alpha1MetastoreDataAccessSpecInitProviderMetastoreIdSelector? MetastoreIdSelector { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MetastoreDataAccessSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MetastoreDataAccessSpec defines the desired state of MetastoreDataAccess</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessSpec
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
    public V1alpha1MetastoreDataAccessSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1MetastoreDataAccessSpecForProvider ForProvider { get; set; }

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
    public V1alpha1MetastoreDataAccessSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1MetastoreDataAccessSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MetastoreDataAccessSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MetastoreDataAccessSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderAwsIamRole
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderAzureManagedIdentity
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderAzureServicePrincipal
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderCloudflareApiToken
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusAtProvider
{
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderAwsIamRole>? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderCloudflareApiToken>? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public IList<V1alpha1MetastoreDataAccessStatusAtProviderGcpServiceAccountKey>? GcpServiceAccountKey { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>whether to set this credential as the default for the metastore. In practice, this should always be true.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatusConditions
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

/// <summary>MetastoreDataAccessStatus defines the observed state of MetastoreDataAccess.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MetastoreDataAccessStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1MetastoreDataAccessStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetastoreDataAccessStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// MetastoreDataAccess is the Schema for the MetastoreDataAccesss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreDataAccess : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetastoreDataAccessSpec>, IStatus<V1alpha1MetastoreDataAccessStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreDataAccess";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "metastoredataaccesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreDataAccess";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreDataAccessSpec defines the desired state of MetastoreDataAccess</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MetastoreDataAccessSpec Spec { get; set; }

    /// <summary>MetastoreDataAccessStatus defines the observed state of MetastoreDataAccess.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetastoreDataAccessStatus? Status { get; set; }
}