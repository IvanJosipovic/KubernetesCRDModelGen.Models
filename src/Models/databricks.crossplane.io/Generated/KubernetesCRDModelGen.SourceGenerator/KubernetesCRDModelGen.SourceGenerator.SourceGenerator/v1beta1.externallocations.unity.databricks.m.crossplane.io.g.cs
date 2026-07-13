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
/// <summary>ExternalLocation is the Schema for the ExternalLocations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExternalLocationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ExternalLocation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExternalLocationList";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "externallocations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExternalLocationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ExternalLocation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ExternalLocation> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolutionEnum>))]
public enum V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolveEnum>))]
public enum V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StorageCredential in unity to populate credentialName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderCredentialNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolveEnum>))]
public enum V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StorageCredential in unity to populate credentialName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderCredentialNameSelector
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
    public V1beta1ExternalLocationSpecForProviderCredentialNameSelectorPolicy? Policy { get; set; }
}

/// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = &quot;SSE-KMS&quot;. Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public V1beta1ExternalLocationSpecForProviderEncryptionDetailsSseEncryptionDetails? SseEncryptionDetails { get; set; }
}

/// <summary>Configuration for managed Azure Queue Storage queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueManagedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueManagedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for managed Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueManagedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary>Configuration for provided Azure Storage Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for provided Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueManagedAqs? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueManagedPubsub? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueManagedSqs? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedAqs? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedPubsub? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueueProvidedSqs? ProvidedSqs { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecForProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>Reference to a StorageCredential in unity to populate credentialName.</summary>
    [JsonPropertyName("credentialNameRef")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameRef? CredentialNameRef { get; set; }

    /// <summary>Selector for a StorageCredential in unity to populate credentialName.</summary>
    [JsonPropertyName("credentialNameSelector")]
    public V1beta1ExternalLocationSpecForProviderCredentialNameSelector? CredentialNameSelector { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    [JsonPropertyName("encryptionDetails")]
    public V1beta1ExternalLocationSpecForProviderEncryptionDetails? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    [JsonPropertyName("fileEventQueue")]
    public V1beta1ExternalLocationSpecForProviderFileEventQueue? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ExternalLocationSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).   If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolutionEnum>))]
public enum V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolveEnum>))]
public enum V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StorageCredential in unity to populate credentialName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderCredentialNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolveEnum>))]
public enum V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StorageCredential in unity to populate credentialName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderCredentialNameSelector
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
    public V1beta1ExternalLocationSpecInitProviderCredentialNameSelectorPolicy? Policy { get; set; }
}

/// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = &quot;SSE-KMS&quot;. Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public V1beta1ExternalLocationSpecInitProviderEncryptionDetailsSseEncryptionDetails? SseEncryptionDetails { get; set; }
}

/// <summary>Configuration for managed Azure Queue Storage queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for managed Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary>Configuration for provided Azure Storage Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedAqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedPubsub
{
    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for provided Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedSqs
{
    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedAqs? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedPubsub? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueManagedSqs? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedAqs? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedPubsub? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueueProvidedSqs? ProvidedSqs { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
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
public partial class V1beta1ExternalLocationSpecInitProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>Reference to a StorageCredential in unity to populate credentialName.</summary>
    [JsonPropertyName("credentialNameRef")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameRef? CredentialNameRef { get; set; }

    /// <summary>Selector for a StorageCredential in unity to populate credentialName.</summary>
    [JsonPropertyName("credentialNameSelector")]
    public V1beta1ExternalLocationSpecInitProviderCredentialNameSelector? CredentialNameSelector { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    [JsonPropertyName("encryptionDetails")]
    public V1beta1ExternalLocationSpecInitProviderEncryptionDetails? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    [JsonPropertyName("fileEventQueue")]
    public V1beta1ExternalLocationSpecInitProviderFileEventQueue? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ExternalLocationSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).   If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExternalLocationSpecManagementPoliciesEnum>))]
public enum V1beta1ExternalLocationSpecManagementPoliciesEnum
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
public partial class V1beta1ExternalLocationSpecProviderConfigRef
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
public partial class V1beta1ExternalLocationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ExternalLocationSpec defines the desired state of ExternalLocation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ExternalLocationSpecForProvider ForProvider { get; set; }

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
    public V1beta1ExternalLocationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ExternalLocationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExternalLocationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExternalLocationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderEncryptionDetailsSseEncryptionDetails
{
    /// <summary>Encryption algorithm value. Sets the value of the x-amz-server-side-encryption header in S3 request.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional ARN of the SSE-KMS key used with the S3 location, when algorithm = &quot;SSE-KMS&quot;. Sets the value of the x-amz-server-side-encryption-aws-kms-key-id header.</summary>
    [JsonPropertyName("awsKmsKeyArn")]
    public string? AwsKmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderEncryptionDetails
{
    /// <summary>a block describing server-Side Encryption properties for clients communicating with AWS S3. Consists of the following attributes:</summary>
    [JsonPropertyName("sseEncryptionDetails")]
    public V1beta1ExternalLocationStatusAtProviderEncryptionDetailsSseEncryptionDetails? SseEncryptionDetails { get; set; }
}

/// <summary>Configuration for managed Azure Queue Storage queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedAqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedPubsub
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for managed Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedSqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

/// <summary>Configuration for provided Azure Storage Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedAqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The name of the Azure resource group.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure subscription ID.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedPubsub
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The name of the subscription.</summary>
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
}

/// <summary>Configuration for provided Amazon SQS queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedSqs
{
    /// <summary>(Computed) The ID of the managed resource.</summary>
    [JsonPropertyName("managedResourceId")]
    public string? ManagedResourceId { get; set; }

    /// <summary>The URL of the queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderFileEventQueue
{
    /// <summary>Configuration for managed Azure Queue Storage queue.</summary>
    [JsonPropertyName("managedAqs")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedAqs? ManagedAqs { get; set; }

    /// <summary>Configuration for managed Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("managedPubsub")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedPubsub? ManagedPubsub { get; set; }

    /// <summary>Configuration for managed Amazon SQS queue.</summary>
    [JsonPropertyName("managedSqs")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueManagedSqs? ManagedSqs { get; set; }

    /// <summary>Configuration for provided Azure Storage Queue.</summary>
    [JsonPropertyName("providedAqs")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedAqs? ProvidedAqs { get; set; }

    /// <summary>Configuration for provided Google Cloud Pub/Sub queue.</summary>
    [JsonPropertyName("providedPubsub")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedPubsub? ProvidedPubsub { get; set; }

    /// <summary>Configuration for provided Amazon SQS queue.</summary>
    [JsonPropertyName("providedSqs")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueueProvidedSqs? ProvidedSqs { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusAtProvider
{
    [JsonPropertyName("browseOnly")]
    public bool? BrowseOnly { get; set; }

    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time at which this external location was created, in epoch milliseconds.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>Username of external location creator.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Unique ID of the location&apos;s storage credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>Name of the databricks_storage_credential to use with this external location.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("effectiveEnableFileEvents")]
    public bool? EffectiveEnableFileEvents { get; set; }

    /// <summary>indicates if managed file events are enabled for this external location.  Requires file_event_queue block.</summary>
    [JsonPropertyName("enableFileEvents")]
    public bool? EnableFileEvents { get; set; }

    [JsonPropertyName("encryptionDetails")]
    public V1beta1ExternalLocationStatusAtProviderEncryptionDetails? EncryptionDetails { get; set; }

    /// <summary>Indicates whether fallback mode is enabled for this external location. When fallback mode is enabled (disabled by default), the access to the location falls back to cluster credentials if UC credentials are not sufficient.</summary>
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; set; }

    [JsonPropertyName("fileEventQueue")]
    public V1beta1ExternalLocationStatusAtProviderFileEventQueue? FileEventQueue { get; set; }

    /// <summary>Destroy external location regardless of its dependents.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update external location regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the external location is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the external location to ISOLATION_MODE_ISOLATED will automatically allow access from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this external location - same as name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of External Location, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the external location owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1ExternalLocationStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Indicates whether the external location is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the external location</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary>Time at which external location this was last modified, in epoch milliseconds.</summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary>Username of user who last modified the external location.</summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary>Path URL in cloud storage, of the form: s3://[bucket-host]/[bucket-dir] (AWS), abfss://[user]@[host]/[path] (Azure), gs://[bucket-host]/[bucket-dir] (GCP).   If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatusConditions
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

/// <summary>ExternalLocationStatus defines the observed state of ExternalLocation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExternalLocationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ExternalLocationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExternalLocationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExternalLocation is the Schema for the ExternalLocations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExternalLocation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExternalLocationSpec>, IStatus<V1beta1ExternalLocationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExternalLocation";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "externallocations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExternalLocation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExternalLocationSpec defines the desired state of ExternalLocation</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ExternalLocationSpec Spec { get; set; }

    /// <summary>ExternalLocationStatus defines the observed state of ExternalLocation.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExternalLocationStatus? Status { get; set; }
}