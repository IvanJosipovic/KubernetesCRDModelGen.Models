#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unitycatalog.databricks.upbound.io;
/// <summary>StorageCredential is the Schema for the StorageCredentials API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageCredentialList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageCredential>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageCredentialList";
    public const string KubeGroup = "unitycatalog.databricks.upbound.io";
    public const string KubePluralName = "storagecredentials";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unitycatalog.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageCredentialList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1StorageCredential objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1StorageCredential> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageCredentialSpecDeletionPolicyEnum>))]
public enum V1beta1StorageCredentialSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderAwsIamRole
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role for S3 data access, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

/// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderAzureServicePrincipalClientSecretSecretRef
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
public partial class V1beta1StorageCredentialSpecForProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1StorageCredentialSpecForProviderAzureServicePrincipalClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>R2 API token secret access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef
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
public partial class V1beta1StorageCredentialSpecForProviderCloudflareApiToken
{
    /// <summary>R2 API token access key ID</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>R2 account ID</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>R2 API token secret access key</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1beta1StorageCredentialSpecForProviderCloudflareApiTokenSecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef
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
public partial class V1beta1StorageCredentialSpecForProviderGcpServiceAccountKey
{
    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1StorageCredentialSpecForProviderGcpServiceAccountKeyPrivateKeySecretRef? PrivateKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecForProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1StorageCredentialSpecForProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1StorageCredentialSpecForProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1StorageCredentialSpecForProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1StorageCredentialSpecForProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1StorageCredentialSpecForProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete storage credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update storage credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1StorageCredentialSpecForProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

    /// <summary>Whether the storage credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>Unique identifier of the parent Metastore. If set for workspace-level, it must match the ID of the metastore assigned to the worspace. When changing the metastore assigned to a workspace, this field becomes required.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Username/groupname/sp application_id of the storage credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the storage credential is only usable for read operations.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the storage credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderAwsIamRole
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role for S3 data access, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

/// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderAzureServicePrincipalClientSecretSecretRef
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
public partial class V1beta1StorageCredentialSpecInitProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta1StorageCredentialSpecInitProviderAzureServicePrincipalClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

/// <summary>R2 API token secret access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef
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
public partial class V1beta1StorageCredentialSpecInitProviderCloudflareApiToken
{
    /// <summary>R2 API token access key ID</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>R2 account ID</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>R2 API token secret access key</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public required V1beta1StorageCredentialSpecInitProviderCloudflareApiTokenSecretAccessKeySecretRef SecretAccessKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef
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
public partial class V1beta1StorageCredentialSpecInitProviderGcpServiceAccountKey
{
    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1beta1StorageCredentialSpecInitProviderGcpServiceAccountKeyPrivateKeySecretRef PrivateKeySecretRef { get; set; }
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
public partial class V1beta1StorageCredentialSpecInitProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1StorageCredentialSpecInitProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1StorageCredentialSpecInitProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1StorageCredentialSpecInitProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1StorageCredentialSpecInitProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1StorageCredentialSpecInitProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete storage credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update storage credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1StorageCredentialSpecInitProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

    /// <summary>Whether the storage credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>Unique identifier of the parent Metastore. If set for workspace-level, it must match the ID of the metastore assigned to the worspace. When changing the metastore assigned to a workspace, this field becomes required.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Username/groupname/sp application_id of the storage credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the storage credential is only usable for read operations.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the storage credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageCredentialSpecManagementPoliciesEnum>))]
public enum V1beta1StorageCredentialSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageCredentialSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1StorageCredentialSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageCredentialSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1StorageCredentialSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StorageCredentialSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StorageCredentialSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageCredentialSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>StorageCredentialSpec defines the desired state of StorageCredential</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialSpec
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
    public V1beta1StorageCredentialSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1StorageCredentialSpecForProvider ForProvider { get; set; }

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
    public V1beta1StorageCredentialSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1StorageCredentialSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StorageCredentialSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StorageCredentialSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderAwsIamRole
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role for S3 data access, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderCloudflareApiToken
{
    /// <summary>R2 API token access key ID</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>R2 account ID</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderDatabricksGcpServiceAccount
{
    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProviderGcpServiceAccountKey
{
    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusAtProvider
{
    [JsonPropertyName("awsIamRole")]
    public V1beta1StorageCredentialStatusAtProviderAwsIamRole? AwsIamRole { get; set; }

    [JsonPropertyName("azureManagedIdentity")]
    public V1beta1StorageCredentialStatusAtProviderAzureManagedIdentity? AzureManagedIdentity { get; set; }

    [JsonPropertyName("azureServicePrincipal")]
    public V1beta1StorageCredentialStatusAtProviderAzureServicePrincipal? AzureServicePrincipal { get; set; }

    [JsonPropertyName("cloudflareApiToken")]
    public V1beta1StorageCredentialStatusAtProviderCloudflareApiToken? CloudflareApiToken { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("databricksGcpServiceAccount")]
    public V1beta1StorageCredentialStatusAtProviderDatabricksGcpServiceAccount? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete storage credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update storage credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    [JsonPropertyName("gcpServiceAccountKey")]
    public V1beta1StorageCredentialStatusAtProviderGcpServiceAccountKey? GcpServiceAccountKey { get; set; }

    /// <summary>ID of this storage credential - same as the name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the storage credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>Unique identifier of the parent Metastore. If set for workspace-level, it must match the ID of the metastore assigned to the worspace. When changing the metastore assigned to a workspace, this field becomes required.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Username/groupname/sp application_id of the storage credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates whether the storage credential is only usable for read operations.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the storage credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Unique ID of storage credential.</summary>
    [JsonPropertyName("storageCredentialId")]
    public string? StorageCredentialId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatusConditions
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

/// <summary>StorageCredentialStatus defines the observed state of StorageCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageCredentialStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1StorageCredentialStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageCredentialStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StorageCredential is the Schema for the StorageCredentials API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageCredential : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageCredentialSpec>, IStatus<V1beta1StorageCredentialStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageCredential";
    public const string KubeGroup = "unitycatalog.databricks.upbound.io";
    public const string KubePluralName = "storagecredentials";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unitycatalog.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageCredential";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageCredentialSpec defines the desired state of StorageCredential</summary>
    [JsonPropertyName("spec")]
    public required V1beta1StorageCredentialSpec Spec { get; set; }

    /// <summary>StorageCredentialStatus defines the observed state of StorageCredential.</summary>
    [JsonPropertyName("status")]
    public V1beta1StorageCredentialStatus? Status { get; set; }
}