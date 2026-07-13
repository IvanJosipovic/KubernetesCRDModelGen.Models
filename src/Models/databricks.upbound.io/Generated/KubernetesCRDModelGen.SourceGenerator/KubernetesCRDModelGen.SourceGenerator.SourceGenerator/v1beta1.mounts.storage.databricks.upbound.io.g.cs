#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.databricks.upbound.io;
/// <summary>Mount is the Schema for the Mounts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MountList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Mount>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MountList";
    public const string KubeGroup = "storage.databricks.upbound.io";
    public const string KubePluralName = "mounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Mount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Mount> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MountSpecDeletionPolicyEnum>))]
public enum V1beta1MountSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProviderAbfs
{
    /// <summary>(String) This is the client_id (Application Object ID) for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(String) ADLS gen2 container name. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(Bool) either or not initialize FS for the first use</summary>
    [JsonPropertyName("initializeFileSystem")]
    public bool? InitializeFileSystem { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it).</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProviderAdl
{
    /// <summary>(String) This is the client_id for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) This is the spark configuration prefix for adls gen 1 mount. The options are fs.adl, dfs.adls. Use fs.adl for runtime 6.0 and above for the clusters. Otherwise use dfs.adls. The default value is: fs.adl.</summary>
    [JsonPropertyName("sparkConfPrefix")]
    public string? SparkConfPrefix { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is for ADLS gen 1. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageResourceName")]
    public string? StorageResourceName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it)</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProviderGs
{
    /// <summary>(String) GCS bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) email of registered Google Service Account for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have a Google service account attached to it.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

/// <summary>to mount AWS S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProviderS3
{
    /// <summary>(String) S3 bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) ARN of registered instance profile for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have an instance profile attached to it. If both cluster_id &amp; instance_profile are specified, then cluster_id takes precedence.</summary>
    [JsonPropertyName("instanceProfile")]
    public string? InstanceProfile { get; set; }
}

/// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProviderWasb
{
    /// <summary>(String) This is the auth type for blob storage. This can either be SAS tokens (SAS) or account access keys (ACCESS_KEY).</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>(String) The container in which the data is. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is the secret key in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretKey")]
    public string? TokenSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretScope")]
    public string? TokenSecretScope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecForProvider
{
    /// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
    [JsonPropertyName("abfs")]
    public V1beta1MountSpecForProviderAbfs? Abfs { get; set; }

    /// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
    [JsonPropertyName("adl")]
    public V1beta1MountSpecForProviderAdl? Adl { get; set; }

    /// <summary>Cluster to use for mounting. If no cluster is specified, a new cluster will be created and will mount the bucket for all of the clusters in this workspace. If the cluster is not running - it&apos;s going to be started, so be aware to set auto-termination rules on it.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>encryption type. Currently used only for AWS S3 mounts</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>configuration parameters that are necessary for mounting of specific storage</summary>
    [JsonPropertyName("extraConfigs")]
    public IDictionary<string, string>? ExtraConfigs { get; set; }

    /// <summary>to mount Google Cloud Storage</summary>
    [JsonPropertyName("gs")]
    public V1beta1MountSpecForProviderGs? Gs { get; set; }

    /// <summary>Name, under which mount will be accessible in dbfs:/mnt/&lt;MOUNT_NAME&gt;. If not specified, provider will try to infer it from depending on the resource type:</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>resource ID for a given storage account. Could be used to fill defaults, such as storage account &amp; container names on Azure.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>to mount AWS S3</summary>
    [JsonPropertyName("s3")]
    public V1beta1MountSpecForProviderS3? S3 { get; set; }

    /// <summary>the URI for accessing specific storage (s3a://...., abfss://...., gs://...., etc.)</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
    [JsonPropertyName("wasb")]
    public V1beta1MountSpecForProviderWasb? Wasb { get; set; }
}

/// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecInitProviderAbfs
{
    /// <summary>(String) This is the client_id (Application Object ID) for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(String) ADLS gen2 container name. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(Bool) either or not initialize FS for the first use</summary>
    [JsonPropertyName("initializeFileSystem")]
    public bool? InitializeFileSystem { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it).</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecInitProviderAdl
{
    /// <summary>(String) This is the client_id for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) This is the spark configuration prefix for adls gen 1 mount. The options are fs.adl, dfs.adls. Use fs.adl for runtime 6.0 and above for the clusters. Otherwise use dfs.adls. The default value is: fs.adl.</summary>
    [JsonPropertyName("sparkConfPrefix")]
    public string? SparkConfPrefix { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is for ADLS gen 1. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageResourceName")]
    public string? StorageResourceName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it)</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecInitProviderGs
{
    /// <summary>(String) GCS bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) email of registered Google Service Account for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have a Google service account attached to it.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

/// <summary>to mount AWS S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecInitProviderS3
{
    /// <summary>(String) S3 bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) ARN of registered instance profile for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have an instance profile attached to it. If both cluster_id &amp; instance_profile are specified, then cluster_id takes precedence.</summary>
    [JsonPropertyName("instanceProfile")]
    public string? InstanceProfile { get; set; }
}

/// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecInitProviderWasb
{
    /// <summary>(String) This is the auth type for blob storage. This can either be SAS tokens (SAS) or account access keys (ACCESS_KEY).</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>(String) The container in which the data is. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is the secret key in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretKey")]
    public string? TokenSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretScope")]
    public string? TokenSecretScope { get; set; }
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
public partial class V1beta1MountSpecInitProvider
{
    /// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
    [JsonPropertyName("abfs")]
    public V1beta1MountSpecInitProviderAbfs? Abfs { get; set; }

    /// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
    [JsonPropertyName("adl")]
    public V1beta1MountSpecInitProviderAdl? Adl { get; set; }

    /// <summary>Cluster to use for mounting. If no cluster is specified, a new cluster will be created and will mount the bucket for all of the clusters in this workspace. If the cluster is not running - it&apos;s going to be started, so be aware to set auto-termination rules on it.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>encryption type. Currently used only for AWS S3 mounts</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>configuration parameters that are necessary for mounting of specific storage</summary>
    [JsonPropertyName("extraConfigs")]
    public IDictionary<string, string>? ExtraConfigs { get; set; }

    /// <summary>to mount Google Cloud Storage</summary>
    [JsonPropertyName("gs")]
    public V1beta1MountSpecInitProviderGs? Gs { get; set; }

    /// <summary>Name, under which mount will be accessible in dbfs:/mnt/&lt;MOUNT_NAME&gt;. If not specified, provider will try to infer it from depending on the resource type:</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>resource ID for a given storage account. Could be used to fill defaults, such as storage account &amp; container names on Azure.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>to mount AWS S3</summary>
    [JsonPropertyName("s3")]
    public V1beta1MountSpecInitProviderS3? S3 { get; set; }

    /// <summary>the URI for accessing specific storage (s3a://...., abfss://...., gs://...., etc.)</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
    [JsonPropertyName("wasb")]
    public V1beta1MountSpecInitProviderWasb? Wasb { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MountSpecManagementPoliciesEnum>))]
public enum V1beta1MountSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MountSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1MountSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MountSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1MountSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MountSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MountSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MountSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MountSpec defines the desired state of Mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountSpec
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
    public V1beta1MountSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1MountSpecForProvider ForProvider { get; set; }

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
    public V1beta1MountSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1MountSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProviderAbfs
{
    /// <summary>(String) This is the client_id (Application Object ID) for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(String) ADLS gen2 container name. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(Bool) either or not initialize FS for the first use</summary>
    [JsonPropertyName("initializeFileSystem")]
    public bool? InitializeFileSystem { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it).</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProviderAdl
{
    /// <summary>(String) This is the client_id for the enterprise application for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>(String) This is the secret key in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretKey")]
    public string? ClientSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your service principal/enterprise app client secret will be stored.</summary>
    [JsonPropertyName("clientSecretScope")]
    public string? ClientSecretScope { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) This is the spark configuration prefix for adls gen 1 mount. The options are fs.adl, dfs.adls. Use fs.adl for runtime 6.0 and above for the clusters. Otherwise use dfs.adls. The default value is: fs.adl.</summary>
    [JsonPropertyName("sparkConfPrefix")]
    public string? SparkConfPrefix { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is for ADLS gen 1. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageResourceName")]
    public string? StorageResourceName { get; set; }

    /// <summary>(String) This is your azure directory tenant id. It is required for creating the mount. (Could be omitted if Azure authentication is used, and we can extract tenant_id from it)</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>to mount Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProviderGs
{
    /// <summary>(String) GCS bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) email of registered Google Service Account for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have a Google service account attached to it.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

/// <summary>to mount AWS S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProviderS3
{
    /// <summary>(String) S3 bucket name to be mounted.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(String) ARN of registered instance profile for data access.  If it&apos;s not specified, then the cluster_id should be provided, and the cluster should have an instance profile attached to it. If both cluster_id &amp; instance_profile are specified, then cluster_id takes precedence.</summary>
    [JsonPropertyName("instanceProfile")]
    public string? InstanceProfile { get; set; }
}

/// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProviderWasb
{
    /// <summary>(String) This is the auth type for blob storage. This can either be SAS tokens (SAS) or account access keys (ACCESS_KEY).</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>(String) The container in which the data is. This is what you are trying to mount. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>(Computed) (String) This is optional if you don&apos;t want to add an additional directory that you wish to mount. This must start with a &quot;/&quot;.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>(String) The name of the storage resource in which the data is. (Could be omitted if resource_id is provided)</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>(String) This is the secret key in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretKey")]
    public string? TokenSecretKey { get; set; }

    /// <summary>(String) This is the secret scope in which your auth type token is stored.</summary>
    [JsonPropertyName("tokenSecretScope")]
    public string? TokenSecretScope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusAtProvider
{
    /// <summary>to mount ADLS Gen2 using Azure Blob Filesystem (ABFS) driver</summary>
    [JsonPropertyName("abfs")]
    public V1beta1MountStatusAtProviderAbfs? Abfs { get; set; }

    /// <summary>to mount ADLS Gen1 using Azure Data Lake (ADL) driver</summary>
    [JsonPropertyName("adl")]
    public V1beta1MountStatusAtProviderAdl? Adl { get; set; }

    /// <summary>Cluster to use for mounting. If no cluster is specified, a new cluster will be created and will mount the bucket for all of the clusters in this workspace. If the cluster is not running - it&apos;s going to be started, so be aware to set auto-termination rules on it.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>encryption type. Currently used only for AWS S3 mounts</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>configuration parameters that are necessary for mounting of specific storage</summary>
    [JsonPropertyName("extraConfigs")]
    public IDictionary<string, string>? ExtraConfigs { get; set; }

    /// <summary>to mount Google Cloud Storage</summary>
    [JsonPropertyName("gs")]
    public V1beta1MountStatusAtProviderGs? Gs { get; set; }

    /// <summary>mount name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name, under which mount will be accessible in dbfs:/mnt/&lt;MOUNT_NAME&gt;. If not specified, provider will try to infer it from depending on the resource type:</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>resource ID for a given storage account. Could be used to fill defaults, such as storage account &amp; container names on Azure.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>to mount AWS S3</summary>
    [JsonPropertyName("s3")]
    public V1beta1MountStatusAtProviderS3? S3 { get; set; }

    /// <summary>(String) HDFS-compatible url</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>the URI for accessing specific storage (s3a://...., abfss://...., gs://...., etc.)</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>to mount Azure Blob Storage using Windows Azure Storage Blob (WASB) driver</summary>
    [JsonPropertyName("wasb")]
    public V1beta1MountStatusAtProviderWasb? Wasb { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatusConditions
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

/// <summary>MountStatus defines the observed state of Mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MountStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MountStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Mount is the Schema for the Mounts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Mount : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MountSpec>, IStatus<V1beta1MountStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Mount";
    public const string KubeGroup = "storage.databricks.upbound.io";
    public const string KubePluralName = "mounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Mount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MountSpec defines the desired state of Mount</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MountSpec Spec { get; set; }

    /// <summary>MountStatus defines the observed state of Mount.</summary>
    [JsonPropertyName("status")]
    public V1beta1MountStatus? Status { get; set; }
}