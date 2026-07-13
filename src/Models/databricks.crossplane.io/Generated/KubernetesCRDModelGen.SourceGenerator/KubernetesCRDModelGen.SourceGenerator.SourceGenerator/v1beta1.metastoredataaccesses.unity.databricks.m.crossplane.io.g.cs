#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.m.crossplane.io;
/// <summary>MetastoreDataAccess is the Schema for the MetastoreDataAccesss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreDataAccessList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MetastoreDataAccess>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreDataAccessList";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "metastoredataaccesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreDataAccessList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MetastoreDataAccess objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MetastoreDataAccess> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderAwsIamRole
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
public partial class V1beta1MetastoreDataAccessSpecForProviderAzureManagedIdentity
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

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderAzureServicePrincipalClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderAzureServicePrincipal
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1MetastoreDataAccessSpecForProviderAzureServicePrincipalClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderCloudflareApiToken
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1beta1MetastoreDataAccessSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1MetastoreDataAccessSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef? PrivateKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum>))]
public enum V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum>))]
public enum V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum>))]
public enum V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelector
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
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecForProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1MetastoreDataAccessSpecForProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1MetastoreDataAccessSpecForProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1MetastoreDataAccessSpecForProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1MetastoreDataAccessSpecForProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1MetastoreDataAccessSpecForProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1MetastoreDataAccessSpecForProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

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
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdRef? MetastoreIdRef { get; set; }

    /// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdSelector")]
    public V1beta1MetastoreDataAccessSpecForProviderMetastoreIdSelector? MetastoreIdSelector { get; set; }

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
public partial class V1beta1MetastoreDataAccessSpecInitProviderAwsIamRole
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
public partial class V1beta1MetastoreDataAccessSpecInitProviderAzureManagedIdentity
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

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderAzureServicePrincipalClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderAzureServicePrincipal
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta1MetastoreDataAccessSpecInitProviderAzureServicePrincipalClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderCloudflareApiToken
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public required V1beta1MetastoreDataAccessSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1beta1MetastoreDataAccessSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef PrivateKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum>))]
public enum V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum>))]
public enum V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum>))]
public enum V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelector
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
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1MetastoreDataAccessSpecInitProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1MetastoreDataAccessSpecInitProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1MetastoreDataAccessSpecInitProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1MetastoreDataAccessSpecInitProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1MetastoreDataAccessSpecInitProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1MetastoreDataAccessSpecInitProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1MetastoreDataAccessSpecInitProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

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
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdRef? MetastoreIdRef { get; set; }

    /// <summary>Selector for a Metastore in unity to populate metastoreId.</summary>
    [JsonPropertyName("metastoreIdSelector")]
    public V1beta1MetastoreDataAccessSpecInitProviderMetastoreIdSelector? MetastoreIdSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetastoreDataAccessSpecManagementPoliciesEnum>))]
public enum V1beta1MetastoreDataAccessSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MetastoreDataAccessSpec defines the desired state of MetastoreDataAccess</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1MetastoreDataAccessSpecForProvider ForProvider { get; set; }

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
    public V1beta1MetastoreDataAccessSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MetastoreDataAccessSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MetastoreDataAccessSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MetastoreDataAccessSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessStatusAtProviderAwsIamRole
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
public partial class V1beta1MetastoreDataAccessStatusAtProviderAzureManagedIdentity
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
public partial class V1beta1MetastoreDataAccessStatusAtProviderAzureServicePrincipal
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
public partial class V1beta1MetastoreDataAccessStatusAtProviderCloudflareApiToken
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
public partial class V1beta1MetastoreDataAccessStatusAtProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessStatusAtProviderGcpServiceAccountKey
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this data access configuration in form of &lt;metastore_id&gt;|&lt;name&gt;.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreDataAccessStatusAtProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1MetastoreDataAccessStatusAtProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1MetastoreDataAccessStatusAtProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1MetastoreDataAccessStatusAtProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1MetastoreDataAccessStatusAtProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1MetastoreDataAccessStatusAtProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1MetastoreDataAccessStatusAtProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

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
public partial class V1beta1MetastoreDataAccessStatusConditions
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
public partial class V1beta1MetastoreDataAccessStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MetastoreDataAccessStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetastoreDataAccessStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MetastoreDataAccess is the Schema for the MetastoreDataAccesss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreDataAccess : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetastoreDataAccessSpec>, IStatus<V1beta1MetastoreDataAccessStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreDataAccess";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "metastoredataaccesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreDataAccess";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreDataAccessSpec defines the desired state of MetastoreDataAccess</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MetastoreDataAccessSpec Spec { get; set; }

    /// <summary>MetastoreDataAccessStatus defines the observed state of MetastoreDataAccess.</summary>
    [JsonPropertyName("status")]
    public V1beta1MetastoreDataAccessStatus? Status { get; set; }
}