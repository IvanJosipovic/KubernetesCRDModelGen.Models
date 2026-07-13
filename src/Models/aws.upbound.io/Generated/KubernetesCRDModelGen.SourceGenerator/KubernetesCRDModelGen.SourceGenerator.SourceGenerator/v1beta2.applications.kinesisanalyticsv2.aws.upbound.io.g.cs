#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kinesisanalyticsv2.aws.upbound.io;
/// <summary>Application is the Schema for the Applications API. Manages a Kinesis Analytics v2 Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Application>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "kinesisanalyticsv2.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalyticsv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Application objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Application> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecDeletionPolicyEnum>))]
public enum V1beta2ApplicationSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy? Policy { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>Reference to a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeyRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef? FileKeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeySelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector? FileKeySelector { get; set; }

    /// <summary>The version of the object containing the application code.</summary>
    [JsonPropertyName("objectVersion")]
    public string? ObjectVersion { get; set; }
}

/// <summary>The location and type of the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationEncryptionConfiguration
{
    /// <summary>The ARN of the KMS key to use for encryption. Required when key_type is set to CUSTOMER_MANAGED_KEY. The KMS key must be in the same region as the application.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of encryption key to use. Valid values: CUSTOMER_MANAGED_KEY, AWS_OWNED_KEY.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
{
    /// <summary>The key of the application execution property key-value map.</summary>
    [JsonPropertyName("propertyGroupId")]
    public string? PropertyGroupId { get; set; }

    /// <summary>Application execution property key-value map.</summary>
    [JsonPropertyName("propertyMap")]
    public IDictionary<string, string>? PropertyMap { get; set; }
}

/// <summary>Describes execution properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
{
    /// <summary>Describes the interval in milliseconds between checkpoint operations.</summary>
    [JsonPropertyName("checkpointInterval")]
    public double? CheckpointInterval { get; set; }

    /// <summary>Describes whether checkpointing is enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("checkpointingEnabled")]
    public bool? CheckpointingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the minimum time in milliseconds after a checkpoint operation completes that a new checkpoint operation can start.</summary>
    [JsonPropertyName("minPauseBetweenCheckpoints")]
    public double? MinPauseBetweenCheckpoints { get; set; }
}

/// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
{
    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the verbosity of the CloudWatch Logs for an application. Valid values: DEBUG, ERROR, INFO, WARN.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Describes the granularity of the CloudWatch Logs for an application. Valid values: APPLICATION, OPERATOR, PARALLELISM, TASK.</summary>
    [JsonPropertyName("metricsLevel")]
    public string? MetricsLevel { get; set; }
}

/// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
{
    /// <summary>Describes whether the Kinesis Data Analytics service can increase the parallelism of the application in response to increased throughput.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the initial number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Describes the number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform per Kinesis Processing Unit (KPU) used by the application.</summary>
    [JsonPropertyName("parallelismPerKpu")]
    public double? ParallelismPerKpu { get; set; }
}

/// <summary>The configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
{
    /// <summary>Specifies how the application should be restored. Valid values: RESTORE_FROM_CUSTOM_SNAPSHOT, RESTORE_FROM_LATEST_SNAPSHOT, SKIP_RESTORE_FROM_SNAPSHOT.</summary>
    [JsonPropertyName("applicationRestoreType")]
    public string? ApplicationRestoreType { get; set; }

    /// <summary>The identifier of an existing snapshot of application state to use to restart an application. The application uses this value if RESTORE_FROM_CUSTOM_SNAPSHOT is specified for application_restore_type.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }
}

/// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// The input processing configuration for the input.
/// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
{
    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }
}

/// <summary>The reference data source used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector
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
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfiguration
{
    /// <summary>The Security Group IDs used by the VPC configuration.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Subnet IDs used by the VPC configuration.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>The application&apos;s configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch log stream to receive application messages.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderServiceExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderServiceExecutionRoleSelector
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
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta2ApplicationSpecForProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>A summary description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force stop an unresponsive Flink-based application.</summary>
    [JsonPropertyName("forceStop")]
    public bool? ForceStop { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The runtime environment for the application. Valid values: SQL-1_0, FLINK-1_6, FLINK-1_8, FLINK-1_11, FLINK-1_13, FLINK-1_15, FLINK-1_18, FLINK-1_19, FLINK-1_20.</summary>
    [JsonPropertyName("runtimeEnvironment")]
    public string? RuntimeEnvironment { get; set; }

    /// <summary>The ARN of the IAM role used by the application to access Kinesis data streams, Kinesis Data Firehose delivery streams, Amazon S3 objects, and other external resources.</summary>
    [JsonPropertyName("serviceExecutionRole")]
    public string? ServiceExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleRef")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleRef? ServiceExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleSelector")]
    public V1beta2ApplicationSpecForProviderServiceExecutionRoleSelector? ServiceExecutionRoleSelector { get; set; }

    /// <summary>Whether to start or stop the application.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy? Policy { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>Reference to a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeyRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef? FileKeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeySelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector? FileKeySelector { get; set; }

    /// <summary>The version of the object containing the application code.</summary>
    [JsonPropertyName("objectVersion")]
    public string? ObjectVersion { get; set; }
}

/// <summary>The location and type of the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationEncryptionConfiguration
{
    /// <summary>The ARN of the KMS key to use for encryption. Required when key_type is set to CUSTOMER_MANAGED_KEY. The KMS key must be in the same region as the application.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of encryption key to use. Valid values: CUSTOMER_MANAGED_KEY, AWS_OWNED_KEY.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
{
    /// <summary>The key of the application execution property key-value map.</summary>
    [JsonPropertyName("propertyGroupId")]
    public string? PropertyGroupId { get; set; }

    /// <summary>Application execution property key-value map.</summary>
    [JsonPropertyName("propertyMap")]
    public IDictionary<string, string>? PropertyMap { get; set; }
}

/// <summary>Describes execution properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
{
    /// <summary>Describes the interval in milliseconds between checkpoint operations.</summary>
    [JsonPropertyName("checkpointInterval")]
    public double? CheckpointInterval { get; set; }

    /// <summary>Describes whether checkpointing is enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("checkpointingEnabled")]
    public bool? CheckpointingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the minimum time in milliseconds after a checkpoint operation completes that a new checkpoint operation can start.</summary>
    [JsonPropertyName("minPauseBetweenCheckpoints")]
    public double? MinPauseBetweenCheckpoints { get; set; }
}

/// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
{
    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the verbosity of the CloudWatch Logs for an application. Valid values: DEBUG, ERROR, INFO, WARN.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Describes the granularity of the CloudWatch Logs for an application. Valid values: APPLICATION, OPERATOR, PARALLELISM, TASK.</summary>
    [JsonPropertyName("metricsLevel")]
    public string? MetricsLevel { get; set; }
}

/// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
{
    /// <summary>Describes whether the Kinesis Data Analytics service can increase the parallelism of the application in response to increased throughput.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the initial number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Describes the number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform per Kinesis Processing Unit (KPU) used by the application.</summary>
    [JsonPropertyName("parallelismPerKpu")]
    public double? ParallelismPerKpu { get; set; }
}

/// <summary>The configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
{
    /// <summary>Specifies how the application should be restored. Valid values: RESTORE_FROM_CUSTOM_SNAPSHOT, RESTORE_FROM_LATEST_SNAPSHOT, SKIP_RESTORE_FROM_SNAPSHOT.</summary>
    [JsonPropertyName("applicationRestoreType")]
    public string? ApplicationRestoreType { get; set; }

    /// <summary>The identifier of an existing snapshot of application state to use to restart an application. The application uses this value if RESTORE_FROM_CUSTOM_SNAPSHOT is specified for application_restore_type.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }
}

/// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// The input processing configuration for the input.
/// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
{
    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }
}

/// <summary>The reference data source used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector
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
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfiguration
{
    /// <summary>The Security Group IDs used by the VPC configuration.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Subnet IDs used by the VPC configuration.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>The application&apos;s configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch log stream to receive application messages.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderServiceExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelector
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
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2ApplicationSpecInitProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta2ApplicationSpecInitProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>A summary description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force stop an unresponsive Flink-based application.</summary>
    [JsonPropertyName("forceStop")]
    public bool? ForceStop { get; set; }

    /// <summary>The runtime environment for the application. Valid values: SQL-1_0, FLINK-1_6, FLINK-1_8, FLINK-1_11, FLINK-1_13, FLINK-1_15, FLINK-1_18, FLINK-1_19, FLINK-1_20.</summary>
    [JsonPropertyName("runtimeEnvironment")]
    public string? RuntimeEnvironment { get; set; }

    /// <summary>The ARN of the IAM role used by the application to access Kinesis data streams, Kinesis Data Firehose delivery streams, Amazon S3 objects, and other external resources.</summary>
    [JsonPropertyName("serviceExecutionRole")]
    public string? ServiceExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleRef")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleRef? ServiceExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleSelector")]
    public V1beta2ApplicationSpecInitProviderServiceExecutionRoleSelector? ServiceExecutionRoleSelector { get; set; }

    /// <summary>Whether to start or stop the application.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecManagementPoliciesEnum>))]
public enum V1beta2ApplicationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpec
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
    public V1beta2ApplicationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ApplicationSpecForProvider ForProvider { get; set; }

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
    public V1beta2ApplicationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The version of the object containing the application code.</summary>
    [JsonPropertyName("objectVersion")]
    public string? ObjectVersion { get; set; }
}

/// <summary>The location and type of the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationEncryptionConfiguration
{
    /// <summary>The ARN of the KMS key to use for encryption. Required when key_type is set to CUSTOMER_MANAGED_KEY. The KMS key must be in the same region as the application.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of encryption key to use. Valid values: CUSTOMER_MANAGED_KEY, AWS_OWNED_KEY.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
{
    /// <summary>The key of the application execution property key-value map.</summary>
    [JsonPropertyName("propertyGroupId")]
    public string? PropertyGroupId { get; set; }

    /// <summary>Application execution property key-value map.</summary>
    [JsonPropertyName("propertyMap")]
    public IDictionary<string, string>? PropertyMap { get; set; }
}

/// <summary>Describes execution properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta2ApplicationStatusAtProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
{
    /// <summary>Describes the interval in milliseconds between checkpoint operations.</summary>
    [JsonPropertyName("checkpointInterval")]
    public double? CheckpointInterval { get; set; }

    /// <summary>Describes whether checkpointing is enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("checkpointingEnabled")]
    public bool? CheckpointingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the minimum time in milliseconds after a checkpoint operation completes that a new checkpoint operation can start.</summary>
    [JsonPropertyName("minPauseBetweenCheckpoints")]
    public double? MinPauseBetweenCheckpoints { get; set; }
}

/// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
{
    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the verbosity of the CloudWatch Logs for an application. Valid values: DEBUG, ERROR, INFO, WARN.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Describes the granularity of the CloudWatch Logs for an application. Valid values: APPLICATION, OPERATOR, PARALLELISM, TASK.</summary>
    [JsonPropertyName("metricsLevel")]
    public string? MetricsLevel { get; set; }
}

/// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
{
    /// <summary>Describes whether the Kinesis Data Analytics service can increase the parallelism of the application in response to increased throughput.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Describes whether the application uses Kinesis Data Analytics&apos; default checkpointing behavior. Valid values: CUSTOM, DEFAULT. Set this attribute to CUSTOM in order for any specified checkpointing_enabled, checkpoint_interval, or min_pause_between_checkpoints attribute values to be effective. If this attribute is set to DEFAULT, the application will always use the following values:</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Describes the initial number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Describes the number of parallel tasks that a Flink-based Kinesis Data Analytics application can perform per Kinesis Processing Unit (KPU) used by the application.</summary>
    [JsonPropertyName("parallelismPerKpu")]
    public double? ParallelismPerKpu { get; set; }
}

/// <summary>The configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
{
    /// <summary>Specifies how the application should be restored. Valid values: RESTORE_FROM_CUSTOM_SNAPSHOT, RESTORE_FROM_LATEST_SNAPSHOT, SKIP_RESTORE_FROM_SNAPSHOT.</summary>
    [JsonPropertyName("applicationRestoreType")]
    public string? ApplicationRestoreType { get; set; }

    /// <summary>The identifier of an existing snapshot of application state to use to restart an application. The application uses this value if RESTORE_FROM_CUSTOM_SNAPSHOT is specified for application_restore_type.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }
}

/// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>
/// The input processing configuration for the input.
/// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    [JsonPropertyName("inAppStreamNames")]
    public IList<string>? InAppStreamNames { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
{
    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("outputId")]
    public string? OutputId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
{
    /// <summary>A reference to the data element in the streaming input or the reference data source.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of column created in the in-application input stream or reference table.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
{
    /// <summary>The column delimiter. For example, in a CSV format, a comma (,) is the typical column delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The row delimiter. For example, in a CSV format, \n is the typical row delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }
}

/// <summary>The reference data source used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>The application identifier.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfigurationVpcConfiguration
{
    /// <summary>The Security Group IDs used by the VPC configuration.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The Subnet IDs used by the VPC configuration.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("vpcConfigurationId")]
    public string? VpcConfigurationId { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>The application&apos;s configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderCloudwatchLoggingOptions
{
    /// <summary>The application identifier.</summary>
    [JsonPropertyName("cloudwatchLoggingOptionId")]
    public string? CloudwatchLoggingOptionId { get; set; }

    /// <summary>The ARN of the CloudWatch log stream to receive application messages.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta2ApplicationStatusAtProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>The ARN of the application.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationStatusAtProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The current timestamp when the application was created.</summary>
    [JsonPropertyName("createTimestamp")]
    public string? CreateTimestamp { get; set; }

    /// <summary>A summary description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force stop an unresponsive Flink-based application.</summary>
    [JsonPropertyName("forceStop")]
    public bool? ForceStop { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The current timestamp when the application was last updated.</summary>
    [JsonPropertyName("lastUpdateTimestamp")]
    public string? LastUpdateTimestamp { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The runtime environment for the application. Valid values: SQL-1_0, FLINK-1_6, FLINK-1_8, FLINK-1_11, FLINK-1_13, FLINK-1_15, FLINK-1_18, FLINK-1_19, FLINK-1_20.</summary>
    [JsonPropertyName("runtimeEnvironment")]
    public string? RuntimeEnvironment { get; set; }

    /// <summary>The ARN of the IAM role used by the application to access Kinesis data streams, Kinesis Data Firehose delivery streams, Amazon S3 objects, and other external resources.</summary>
    [JsonPropertyName("serviceExecutionRole")]
    public string? ServiceExecutionRole { get; set; }

    /// <summary>Whether to start or stop the application.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>The status of the application.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The current application version. Kinesis Data Analytics updates the version_id each time the application is updated.</summary>
    [JsonPropertyName("versionId")]
    public double? VersionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Manages a Kinesis Analytics v2 Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ApplicationSpec>, IStatus<V1beta2ApplicationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Application";
    public const string KubeGroup = "kinesisanalyticsv2.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalyticsv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Application";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta2ApplicationStatus? Status { get; set; }
}