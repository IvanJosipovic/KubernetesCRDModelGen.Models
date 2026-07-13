#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.raft.vault.m.upbound.io;
/// <summary>SnapshotAgentConfig is the Schema for the SnapshotAgentConfigs API. Creates a Raft Snapshot Agent Configuration for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SnapshotAgentConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SnapshotAgentConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SnapshotAgentConfigList";
    public const string KubeGroup = "raft.vault.m.upbound.io";
    public const string KubePluralName = "snapshotagentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "raft.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotAgentConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SnapshotAgentConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SnapshotAgentConfig> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotAgentConfigSpecForProvider
{
    /// <summary>
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations.
    /// Note: Not supported with storage_type = &quot;local&quot;.
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations. Requires Vault Enterprise 1.21.0+. Not supported with storage_type = &quot;local&quot;.
    /// </summary>
    [JsonPropertyName("autoloadEnabled")]
    public bool? AutoloadEnabled { get; set; }

    /// <summary>
    /// AWS access key ID.
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>
    /// S3 bucket to write snapshots to.
    /// S3 bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("awsS3Bucket")]
    public string? AwsS3Bucket { get; set; }

    /// <summary>
    /// Disable TLS for the S3 endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// aws_s3_endpoint.
    /// Disable TLS for the S3 endpoint. This should only be used for testing purposes.
    /// </summary>
    [JsonPropertyName("awsS3DisableTls")]
    public bool? AwsS3DisableTls { get; set; }

    /// <summary>
    /// Use KMS to encrypt bucket contents.
    /// Use KMS to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3EnableKms")]
    public bool? AwsS3EnableKms { get; set; }

    /// <summary>
    /// AWS endpoint. This is typically only set when
    /// using a non-AWS S3 implementation like Minio.
    /// AWS endpoint. This is typically only set when using a non-AWS S3 implementation like Minio.
    /// </summary>
    [JsonPropertyName("awsS3Endpoint")]
    public string? AwsS3Endpoint { get; set; }

    /// <summary>
    /// Use the endpoint/bucket URL style
    /// instead of bucket.endpoint. May be needed when setting aws_s3_endpoint.
    /// Use the endpoint/bucket URL style instead of bucket.endpoint.
    /// </summary>
    [JsonPropertyName("awsS3ForcePathStyle")]
    public bool? AwsS3ForcePathStyle { get; set; }

    /// <summary>
    /// Use named KMS key, when aws_s3_enable_kms = true
    /// Use named KMS key, when aws_s3_enable_kms=true
    /// </summary>
    [JsonPropertyName("awsS3KmsKey")]
    public string? AwsS3KmsKey { get; set; }

    /// <summary>
    /// AWS region bucket is in.
    /// AWS region bucket is in.
    /// </summary>
    [JsonPropertyName("awsS3Region")]
    public string? AwsS3Region { get; set; }

    /// <summary>
    /// Use AES256 to encrypt bucket contents.
    /// Use AES256 to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3ServerSideEncryption")]
    public bool? AwsS3ServerSideEncryption { get; set; }

    /// <summary>
    /// AWS secret access key.
    /// AWS secret access key.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS session token.
    /// AWS session token.
    /// </summary>
    [JsonPropertyName("awsSessionToken")]
    public string? AwsSessionToken { get; set; }

    /// <summary>
    /// Azure account key. Required when azure_auth_mode = &quot;shared&quot;.
    /// Azure account key. Required when azure_auth_mode is &apos;shared&apos;.
    /// </summary>
    [JsonPropertyName("azureAccountKey")]
    public string? AzureAccountKey { get; set; }

    /// <summary>
    /// Azure account name.
    /// Azure account name.
    /// </summary>
    [JsonPropertyName("azureAccountName")]
    public string? AzureAccountName { get; set; }

    /// <summary>
    /// Azure authentication mode. Required by Vault API when using storage_type = &quot;azure-blob&quot;. Possible values are:
    /// Azure authentication mode. Required for azure-blob storage. Possible values are &apos;shared&apos;, &apos;managed&apos;, or &apos;environment&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureAuthMode")]
    public string? AzureAuthMode { get; set; }

    /// <summary>
    /// Azure blob environment.
    /// Azure blob environment.
    /// </summary>
    [JsonPropertyName("azureBlobEnvironment")]
    public string? AzureBlobEnvironment { get; set; }

    /// <summary>
    /// Azure client ID for authentication. Required when azure_auth_mode = &quot;managed&quot;.
    /// Requires Vault Enterprise 1.18.0+.
    /// Azure client ID for authentication. Required when azure_auth_mode is &apos;managed&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureClientId")]
    public string? AzureClientId { get; set; }

    /// <summary>
    /// Azure container name to write
    /// snapshots to.
    /// Azure container name to write snapshots to.
    /// </summary>
    [JsonPropertyName("azureContainerName")]
    public string? AzureContainerName { get; set; }

    /// <summary>
    /// Azure blob storage endpoint. This is typically
    /// only set when using a non-Azure implementation like Azurite.
    /// Azure blob storage endpoint. This is typically only set when using a non-Azure implementation like Azurite.
    /// </summary>
    [JsonPropertyName("azureEndpoint")]
    public string? AzureEndpoint { get; set; }

    /// <summary>
    /// Within the directory or bucket
    /// prefix given by path_prefix, the file or object name of snapshot files
    /// will start with this string.
    /// The file or object name of snapshot files will start with this string.
    /// </summary>
    [JsonPropertyName("filePrefix")]
    public string? FilePrefix { get; set; }

    /// <summary>
    /// Disable TLS for the GCS endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// google_endpoint.
    /// Disable TLS for the GCS endpoint.
    /// </summary>
    [JsonPropertyName("googleDisableTls")]
    public bool? GoogleDisableTls { get; set; }

    /// <summary>
    /// GCS endpoint. This is typically only set when
    /// using a non-Google GCS implementation like fake-gcs-server.
    /// GCS endpoint. This is typically only set when using a non-Google GCS implementation like fake-gcs-server.
    /// </summary>
    [JsonPropertyName("googleEndpoint")]
    public string? GoogleEndpoint { get; set; }

    /// <summary>
    /// GCS bucket to write snapshots to.
    /// GCS bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("googleGcsBucket")]
    public string? GoogleGcsBucket { get; set; }

    /// <summary>
    /// Google service account key in JSON format.
    /// The raw value looks like this:
    /// Google service account key in JSON format.
    /// </summary>
    [JsonPropertyName("googleServiceAccountKey")]
    public string? GoogleServiceAccountKey { get; set; }

    /// <summary>
    /// Time (in seconds) between snapshots.
    /// Number of seconds between snapshots.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// For storage_type = local, the maximum
    /// space, in bytes, to use for snapshots. Snapshot attempts will fail if there is not enough
    /// space left in this allowance.
    /// The maximum space, in bytes, to use for snapshots.
    /// </summary>
    [JsonPropertyName("localMaxSpace")]
    public double? LocalMaxSpace { get; set; }

    /// <summary>
    /// &lt;required&gt; – Name of the configuration to modify.
    /// Name of the snapshot agent configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// For storage_type = &quot;local&quot;, the directory to
    /// write the snapshots in. For cloud storage types, the bucket prefix to use.
    /// Types azure-s3 and google-gcs require a trailing / (slash).
    /// Types local and aws-s3 the trailing / is optional.
    /// The directory or bucket prefix to to use.
    /// </summary>
    [JsonPropertyName("pathPrefix")]
    public string? PathPrefix { get; set; }

    /// <summary>
    /// How many snapshots are to be kept; when writing a
    /// snapshot, if there are more snapshots already stored than this number, the
    /// oldest ones will be deleted.
    /// How many snapshots are to be kept.
    /// </summary>
    [JsonPropertyName("retain")]
    public double? Retain { get; set; }

    /// <summary>
    /// One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;,
    /// or &quot;google-gcs&quot;. The remaining parameters described below are all specific to
    /// the selected storage_type and prefixed accordingly.
    /// What storage service to send snapshots to. One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;, or &quot;google-gcs&quot;.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
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
public partial class V1alpha1SnapshotAgentConfigSpecInitProvider
{
    /// <summary>
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations.
    /// Note: Not supported with storage_type = &quot;local&quot;.
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations. Requires Vault Enterprise 1.21.0+. Not supported with storage_type = &quot;local&quot;.
    /// </summary>
    [JsonPropertyName("autoloadEnabled")]
    public bool? AutoloadEnabled { get; set; }

    /// <summary>
    /// AWS access key ID.
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>
    /// S3 bucket to write snapshots to.
    /// S3 bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("awsS3Bucket")]
    public string? AwsS3Bucket { get; set; }

    /// <summary>
    /// Disable TLS for the S3 endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// aws_s3_endpoint.
    /// Disable TLS for the S3 endpoint. This should only be used for testing purposes.
    /// </summary>
    [JsonPropertyName("awsS3DisableTls")]
    public bool? AwsS3DisableTls { get; set; }

    /// <summary>
    /// Use KMS to encrypt bucket contents.
    /// Use KMS to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3EnableKms")]
    public bool? AwsS3EnableKms { get; set; }

    /// <summary>
    /// AWS endpoint. This is typically only set when
    /// using a non-AWS S3 implementation like Minio.
    /// AWS endpoint. This is typically only set when using a non-AWS S3 implementation like Minio.
    /// </summary>
    [JsonPropertyName("awsS3Endpoint")]
    public string? AwsS3Endpoint { get; set; }

    /// <summary>
    /// Use the endpoint/bucket URL style
    /// instead of bucket.endpoint. May be needed when setting aws_s3_endpoint.
    /// Use the endpoint/bucket URL style instead of bucket.endpoint.
    /// </summary>
    [JsonPropertyName("awsS3ForcePathStyle")]
    public bool? AwsS3ForcePathStyle { get; set; }

    /// <summary>
    /// Use named KMS key, when aws_s3_enable_kms = true
    /// Use named KMS key, when aws_s3_enable_kms=true
    /// </summary>
    [JsonPropertyName("awsS3KmsKey")]
    public string? AwsS3KmsKey { get; set; }

    /// <summary>
    /// AWS region bucket is in.
    /// AWS region bucket is in.
    /// </summary>
    [JsonPropertyName("awsS3Region")]
    public string? AwsS3Region { get; set; }

    /// <summary>
    /// Use AES256 to encrypt bucket contents.
    /// Use AES256 to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3ServerSideEncryption")]
    public bool? AwsS3ServerSideEncryption { get; set; }

    /// <summary>
    /// AWS secret access key.
    /// AWS secret access key.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS session token.
    /// AWS session token.
    /// </summary>
    [JsonPropertyName("awsSessionToken")]
    public string? AwsSessionToken { get; set; }

    /// <summary>
    /// Azure account key. Required when azure_auth_mode = &quot;shared&quot;.
    /// Azure account key. Required when azure_auth_mode is &apos;shared&apos;.
    /// </summary>
    [JsonPropertyName("azureAccountKey")]
    public string? AzureAccountKey { get; set; }

    /// <summary>
    /// Azure account name.
    /// Azure account name.
    /// </summary>
    [JsonPropertyName("azureAccountName")]
    public string? AzureAccountName { get; set; }

    /// <summary>
    /// Azure authentication mode. Required by Vault API when using storage_type = &quot;azure-blob&quot;. Possible values are:
    /// Azure authentication mode. Required for azure-blob storage. Possible values are &apos;shared&apos;, &apos;managed&apos;, or &apos;environment&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureAuthMode")]
    public string? AzureAuthMode { get; set; }

    /// <summary>
    /// Azure blob environment.
    /// Azure blob environment.
    /// </summary>
    [JsonPropertyName("azureBlobEnvironment")]
    public string? AzureBlobEnvironment { get; set; }

    /// <summary>
    /// Azure client ID for authentication. Required when azure_auth_mode = &quot;managed&quot;.
    /// Requires Vault Enterprise 1.18.0+.
    /// Azure client ID for authentication. Required when azure_auth_mode is &apos;managed&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureClientId")]
    public string? AzureClientId { get; set; }

    /// <summary>
    /// Azure container name to write
    /// snapshots to.
    /// Azure container name to write snapshots to.
    /// </summary>
    [JsonPropertyName("azureContainerName")]
    public string? AzureContainerName { get; set; }

    /// <summary>
    /// Azure blob storage endpoint. This is typically
    /// only set when using a non-Azure implementation like Azurite.
    /// Azure blob storage endpoint. This is typically only set when using a non-Azure implementation like Azurite.
    /// </summary>
    [JsonPropertyName("azureEndpoint")]
    public string? AzureEndpoint { get; set; }

    /// <summary>
    /// Within the directory or bucket
    /// prefix given by path_prefix, the file or object name of snapshot files
    /// will start with this string.
    /// The file or object name of snapshot files will start with this string.
    /// </summary>
    [JsonPropertyName("filePrefix")]
    public string? FilePrefix { get; set; }

    /// <summary>
    /// Disable TLS for the GCS endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// google_endpoint.
    /// Disable TLS for the GCS endpoint.
    /// </summary>
    [JsonPropertyName("googleDisableTls")]
    public bool? GoogleDisableTls { get; set; }

    /// <summary>
    /// GCS endpoint. This is typically only set when
    /// using a non-Google GCS implementation like fake-gcs-server.
    /// GCS endpoint. This is typically only set when using a non-Google GCS implementation like fake-gcs-server.
    /// </summary>
    [JsonPropertyName("googleEndpoint")]
    public string? GoogleEndpoint { get; set; }

    /// <summary>
    /// GCS bucket to write snapshots to.
    /// GCS bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("googleGcsBucket")]
    public string? GoogleGcsBucket { get; set; }

    /// <summary>
    /// Google service account key in JSON format.
    /// The raw value looks like this:
    /// Google service account key in JSON format.
    /// </summary>
    [JsonPropertyName("googleServiceAccountKey")]
    public string? GoogleServiceAccountKey { get; set; }

    /// <summary>
    /// Time (in seconds) between snapshots.
    /// Number of seconds between snapshots.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// For storage_type = local, the maximum
    /// space, in bytes, to use for snapshots. Snapshot attempts will fail if there is not enough
    /// space left in this allowance.
    /// The maximum space, in bytes, to use for snapshots.
    /// </summary>
    [JsonPropertyName("localMaxSpace")]
    public double? LocalMaxSpace { get; set; }

    /// <summary>
    /// &lt;required&gt; – Name of the configuration to modify.
    /// Name of the snapshot agent configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// For storage_type = &quot;local&quot;, the directory to
    /// write the snapshots in. For cloud storage types, the bucket prefix to use.
    /// Types azure-s3 and google-gcs require a trailing / (slash).
    /// Types local and aws-s3 the trailing / is optional.
    /// The directory or bucket prefix to to use.
    /// </summary>
    [JsonPropertyName("pathPrefix")]
    public string? PathPrefix { get; set; }

    /// <summary>
    /// How many snapshots are to be kept; when writing a
    /// snapshot, if there are more snapshots already stored than this number, the
    /// oldest ones will be deleted.
    /// How many snapshots are to be kept.
    /// </summary>
    [JsonPropertyName("retain")]
    public double? Retain { get; set; }

    /// <summary>
    /// One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;,
    /// or &quot;google-gcs&quot;. The remaining parameters described below are all specific to
    /// the selected storage_type and prefixed accordingly.
    /// What storage service to send snapshots to. One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;, or &quot;google-gcs&quot;.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SnapshotAgentConfigSpecManagementPoliciesEnum>))]
public enum V1alpha1SnapshotAgentConfigSpecManagementPoliciesEnum
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
public partial class V1alpha1SnapshotAgentConfigSpecProviderConfigRef
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
public partial class V1alpha1SnapshotAgentConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SnapshotAgentConfigSpec defines the desired state of SnapshotAgentConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotAgentConfigSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SnapshotAgentConfigSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SnapshotAgentConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SnapshotAgentConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SnapshotAgentConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SnapshotAgentConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotAgentConfigStatusAtProvider
{
    /// <summary>
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations.
    /// Note: Not supported with storage_type = &quot;local&quot;.
    /// Have Vault automatically load the latest snapshot after it is written. This will replace the previously loaded snapshot. Note that this does not mean the snapshot is automatically applied to the cluster, it is just loaded and available for recovery operations. Requires Vault Enterprise 1.21.0+. Not supported with storage_type = &quot;local&quot;.
    /// </summary>
    [JsonPropertyName("autoloadEnabled")]
    public bool? AutoloadEnabled { get; set; }

    /// <summary>
    /// AWS access key ID.
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>
    /// S3 bucket to write snapshots to.
    /// S3 bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("awsS3Bucket")]
    public string? AwsS3Bucket { get; set; }

    /// <summary>
    /// Disable TLS for the S3 endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// aws_s3_endpoint.
    /// Disable TLS for the S3 endpoint. This should only be used for testing purposes.
    /// </summary>
    [JsonPropertyName("awsS3DisableTls")]
    public bool? AwsS3DisableTls { get; set; }

    /// <summary>
    /// Use KMS to encrypt bucket contents.
    /// Use KMS to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3EnableKms")]
    public bool? AwsS3EnableKms { get; set; }

    /// <summary>
    /// AWS endpoint. This is typically only set when
    /// using a non-AWS S3 implementation like Minio.
    /// AWS endpoint. This is typically only set when using a non-AWS S3 implementation like Minio.
    /// </summary>
    [JsonPropertyName("awsS3Endpoint")]
    public string? AwsS3Endpoint { get; set; }

    /// <summary>
    /// Use the endpoint/bucket URL style
    /// instead of bucket.endpoint. May be needed when setting aws_s3_endpoint.
    /// Use the endpoint/bucket URL style instead of bucket.endpoint.
    /// </summary>
    [JsonPropertyName("awsS3ForcePathStyle")]
    public bool? AwsS3ForcePathStyle { get; set; }

    /// <summary>
    /// Use named KMS key, when aws_s3_enable_kms = true
    /// Use named KMS key, when aws_s3_enable_kms=true
    /// </summary>
    [JsonPropertyName("awsS3KmsKey")]
    public string? AwsS3KmsKey { get; set; }

    /// <summary>
    /// AWS region bucket is in.
    /// AWS region bucket is in.
    /// </summary>
    [JsonPropertyName("awsS3Region")]
    public string? AwsS3Region { get; set; }

    /// <summary>
    /// Use AES256 to encrypt bucket contents.
    /// Use AES256 to encrypt bucket contents.
    /// </summary>
    [JsonPropertyName("awsS3ServerSideEncryption")]
    public bool? AwsS3ServerSideEncryption { get; set; }

    /// <summary>
    /// AWS secret access key.
    /// AWS secret access key.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS session token.
    /// AWS session token.
    /// </summary>
    [JsonPropertyName("awsSessionToken")]
    public string? AwsSessionToken { get; set; }

    /// <summary>
    /// Azure account key. Required when azure_auth_mode = &quot;shared&quot;.
    /// Azure account key. Required when azure_auth_mode is &apos;shared&apos;.
    /// </summary>
    [JsonPropertyName("azureAccountKey")]
    public string? AzureAccountKey { get; set; }

    /// <summary>
    /// Azure account name.
    /// Azure account name.
    /// </summary>
    [JsonPropertyName("azureAccountName")]
    public string? AzureAccountName { get; set; }

    /// <summary>
    /// Azure authentication mode. Required by Vault API when using storage_type = &quot;azure-blob&quot;. Possible values are:
    /// Azure authentication mode. Required for azure-blob storage. Possible values are &apos;shared&apos;, &apos;managed&apos;, or &apos;environment&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureAuthMode")]
    public string? AzureAuthMode { get; set; }

    /// <summary>
    /// Azure blob environment.
    /// Azure blob environment.
    /// </summary>
    [JsonPropertyName("azureBlobEnvironment")]
    public string? AzureBlobEnvironment { get; set; }

    /// <summary>
    /// Azure client ID for authentication. Required when azure_auth_mode = &quot;managed&quot;.
    /// Requires Vault Enterprise 1.18.0+.
    /// Azure client ID for authentication. Required when azure_auth_mode is &apos;managed&apos;. Requires Vault Enterprise 1.18.0+.
    /// </summary>
    [JsonPropertyName("azureClientId")]
    public string? AzureClientId { get; set; }

    /// <summary>
    /// Azure container name to write
    /// snapshots to.
    /// Azure container name to write snapshots to.
    /// </summary>
    [JsonPropertyName("azureContainerName")]
    public string? AzureContainerName { get; set; }

    /// <summary>
    /// Azure blob storage endpoint. This is typically
    /// only set when using a non-Azure implementation like Azurite.
    /// Azure blob storage endpoint. This is typically only set when using a non-Azure implementation like Azurite.
    /// </summary>
    [JsonPropertyName("azureEndpoint")]
    public string? AzureEndpoint { get; set; }

    /// <summary>
    /// Within the directory or bucket
    /// prefix given by path_prefix, the file or object name of snapshot files
    /// will start with this string.
    /// The file or object name of snapshot files will start with this string.
    /// </summary>
    [JsonPropertyName("filePrefix")]
    public string? FilePrefix { get; set; }

    /// <summary>
    /// Disable TLS for the GCS endpoint. This
    /// should only be used for testing purposes, typically in conjunction with
    /// google_endpoint.
    /// Disable TLS for the GCS endpoint.
    /// </summary>
    [JsonPropertyName("googleDisableTls")]
    public bool? GoogleDisableTls { get; set; }

    /// <summary>
    /// GCS endpoint. This is typically only set when
    /// using a non-Google GCS implementation like fake-gcs-server.
    /// GCS endpoint. This is typically only set when using a non-Google GCS implementation like fake-gcs-server.
    /// </summary>
    [JsonPropertyName("googleEndpoint")]
    public string? GoogleEndpoint { get; set; }

    /// <summary>
    /// GCS bucket to write snapshots to.
    /// GCS bucket to write snapshots to.
    /// </summary>
    [JsonPropertyName("googleGcsBucket")]
    public string? GoogleGcsBucket { get; set; }

    /// <summary>
    /// Google service account key in JSON format.
    /// The raw value looks like this:
    /// Google service account key in JSON format.
    /// </summary>
    [JsonPropertyName("googleServiceAccountKey")]
    public string? GoogleServiceAccountKey { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Time (in seconds) between snapshots.
    /// Number of seconds between snapshots.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// For storage_type = local, the maximum
    /// space, in bytes, to use for snapshots. Snapshot attempts will fail if there is not enough
    /// space left in this allowance.
    /// The maximum space, in bytes, to use for snapshots.
    /// </summary>
    [JsonPropertyName("localMaxSpace")]
    public double? LocalMaxSpace { get; set; }

    /// <summary>
    /// &lt;required&gt; – Name of the configuration to modify.
    /// Name of the snapshot agent configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// For storage_type = &quot;local&quot;, the directory to
    /// write the snapshots in. For cloud storage types, the bucket prefix to use.
    /// Types azure-s3 and google-gcs require a trailing / (slash).
    /// Types local and aws-s3 the trailing / is optional.
    /// The directory or bucket prefix to to use.
    /// </summary>
    [JsonPropertyName("pathPrefix")]
    public string? PathPrefix { get; set; }

    /// <summary>
    /// How many snapshots are to be kept; when writing a
    /// snapshot, if there are more snapshots already stored than this number, the
    /// oldest ones will be deleted.
    /// How many snapshots are to be kept.
    /// </summary>
    [JsonPropertyName("retain")]
    public double? Retain { get; set; }

    /// <summary>
    /// One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;,
    /// or &quot;google-gcs&quot;. The remaining parameters described below are all specific to
    /// the selected storage_type and prefixed accordingly.
    /// What storage service to send snapshots to. One of &quot;local&quot;, &quot;azure-blob&quot;, &quot;aws-s3&quot;, or &quot;google-gcs&quot;.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotAgentConfigStatusConditions
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

/// <summary>SnapshotAgentConfigStatus defines the observed state of SnapshotAgentConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotAgentConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SnapshotAgentConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SnapshotAgentConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SnapshotAgentConfig is the Schema for the SnapshotAgentConfigs API. Creates a Raft Snapshot Agent Configuration for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SnapshotAgentConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SnapshotAgentConfigSpec>, IStatus<V1alpha1SnapshotAgentConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SnapshotAgentConfig";
    public const string KubeGroup = "raft.vault.m.upbound.io";
    public const string KubePluralName = "snapshotagentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "raft.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotAgentConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SnapshotAgentConfigSpec defines the desired state of SnapshotAgentConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SnapshotAgentConfigSpec Spec { get; set; }

    /// <summary>SnapshotAgentConfigStatus defines the observed state of SnapshotAgentConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SnapshotAgentConfigStatus? Status { get; set; }
}