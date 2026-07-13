#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.gcp.upbound.io;
/// <summary>BucketObject is the Schema for the BucketObjects API. Creates a new object inside a specified bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketObjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BucketObject>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketObjectList";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "bucketobjects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketObjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BucketObject objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BucketObject> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecDeletionPolicyEnum>))]
public enum V1beta2BucketObjectSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecForProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketObjectSpecForProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecForProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketObjectSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketObjectSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketObjectSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketObjectSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketObjectSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderBucketSelector
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
    public V1beta2BucketObjectSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderCustomerEncryptionEncryptionKeySecretRef
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

/// <summary>
/// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
    [JsonPropertyName("encryptionKeySecretRef")]
    public V1beta2BucketObjectSpecForProviderCustomerEncryptionEncryptionKeySecretRef? EncryptionKeySecretRef { get; set; }
}

/// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecForProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketObjectSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketObjectSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>
    /// Cache-Control
    /// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to &quot;application/octet-stream&quot; or &quot;text/plain; charset=utf-8&quot;.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>
    /// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customerEncryption")]
    public V1beta2BucketObjectSpecForProviderCustomerEncryption? CustomerEncryption { get; set; }

    /// <summary>When set to ABANDON, the object won&apos;t be deleted from storage bucket.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&apos;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>When set to true, it ensure the object&apos;s Content-Type is empty.</summary>
    [JsonPropertyName("forceEmptyContentType")]
    public bool? ForceEmptyContentType { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you&apos;re interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public V1beta2BucketObjectSpecForProviderRetention? Retention { get; set; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined
    /// if content is not.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5(&quot;file.zip&quot;), where &quot;file.zip&quot; is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>
    /// The StorageClass of the new bucket object.
    /// Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&apos;s default
    /// storage class or to a standard class.
    /// </summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketObjectSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketObjectSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketObjectSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderBucketSelector
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
    public V1beta2BucketObjectSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderCustomerEncryptionEncryptionKeySecretRef
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

/// <summary>
/// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
    [JsonPropertyName("encryptionKeySecretRef")]
    public required V1beta2BucketObjectSpecInitProviderCustomerEncryptionEncryptionKeySecretRef EncryptionKeySecretRef { get; set; }
}

/// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecInitProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
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
public partial class V1beta2BucketObjectSpecInitProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketObjectSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketObjectSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>
    /// Cache-Control
    /// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to &quot;application/octet-stream&quot; or &quot;text/plain; charset=utf-8&quot;.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>
    /// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customerEncryption")]
    public V1beta2BucketObjectSpecInitProviderCustomerEncryption? CustomerEncryption { get; set; }

    /// <summary>When set to ABANDON, the object won&apos;t be deleted from storage bucket.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&apos;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>When set to true, it ensure the object&apos;s Content-Type is empty.</summary>
    [JsonPropertyName("forceEmptyContentType")]
    public bool? ForceEmptyContentType { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you&apos;re interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public V1beta2BucketObjectSpecInitProviderRetention? Retention { get; set; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined
    /// if content is not.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5(&quot;file.zip&quot;), where &quot;file.zip&quot; is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>
    /// The StorageClass of the new bucket object.
    /// Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&apos;s default
    /// storage class or to a standard class.
    /// </summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecManagementPoliciesEnum>))]
public enum V1beta2BucketObjectSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BucketObjectSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketObjectSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BucketObjectSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketObjectSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketObjectSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketObjectSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BucketObjectSpec defines the desired state of BucketObject</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectSpec
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
    public V1beta2BucketObjectSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BucketObjectSpecForProvider ForProvider { get; set; }

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
    public V1beta2BucketObjectSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BucketObjectSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BucketObjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BucketObjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectStatusAtProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }
}

/// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectStatusAtProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectStatusAtProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Cache-Control
    /// directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to &quot;application/octet-stream&quot; or &quot;text/plain; charset=utf-8&quot;.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>(Computed) Base 64 CRC32 hash of the uploaded data.</summary>
    [JsonPropertyName("crc32c")]
    public string? Crc32c { get; set; }

    /// <summary>
    /// Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customerEncryption")]
    public V1beta2BucketObjectStatusAtProviderCustomerEncryption? CustomerEncryption { get; set; }

    /// <summary>When set to ABANDON, the object won&apos;t be deleted from storage bucket.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&apos;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>When set to true, it ensure the object&apos;s Content-Type is empty.</summary>
    [JsonPropertyName("forceEmptyContentType")]
    public bool? ForceEmptyContentType { get; set; }

    /// <summary>(Computed) The content generation of this object. Used for object versioning and soft delete.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Computed) Base 64 MD5 hash of the uploaded data.</summary>
    [JsonPropertyName("md5hash")]
    public string? Md5hash { get; set; }

    /// <summary>(Computed) Hex value of md5hash`</summary>
    [JsonPropertyName("md5hexhash")]
    public string? Md5hexhash { get; set; }

    /// <summary>(Computed) A url reference to download this object.</summary>
    [JsonPropertyName("mediaLink")]
    public string? MediaLink { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you&apos;re interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Computed) The name of the object. Use this field in interpolations with google_storage_object_acl to recreate
    /// google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public V1beta2BucketObjectStatusAtProviderRetention? Retention { get; set; }

    /// <summary>(Computed) A url reference to this object.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined
    /// if content is not.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5(&quot;file.zip&quot;), where &quot;file.zip&quot; is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>
    /// The StorageClass of the new bucket object.
    /// Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&apos;s default
    /// storage class or to a standard class.
    /// </summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectStatusConditions
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

/// <summary>BucketObjectStatus defines the observed state of BucketObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketObjectStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BucketObjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BucketObjectStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketObject is the Schema for the BucketObjects API. Creates a new object inside a specified bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketObject : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BucketObjectSpec>, IStatus<V1beta2BucketObjectStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketObject";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "bucketobjects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketObject";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketObjectSpec defines the desired state of BucketObject</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BucketObjectSpec Spec { get; set; }

    /// <summary>BucketObjectStatus defines the observed state of BucketObject.</summary>
    [JsonPropertyName("status")]
    public V1beta2BucketObjectStatus? Status { get; set; }
}