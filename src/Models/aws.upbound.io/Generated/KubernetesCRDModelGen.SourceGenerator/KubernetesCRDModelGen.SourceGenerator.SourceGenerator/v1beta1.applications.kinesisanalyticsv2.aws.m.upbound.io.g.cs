#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kinesisanalyticsv2.aws.m.upbound.io;
/// <summary>Application is the Schema for the Applications API. Manages a Kinesis Analytics v2 Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "kinesisanalyticsv2.aws.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalyticsv2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Application objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Application> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy? Policy { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>Reference to a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeyRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef? FileKeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeySelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector? FileKeySelector { get; set; }

    /// <summary>The version of the object containing the application code.</summary>
    [JsonPropertyName("objectVersion")]
    public string? ObjectVersion { get; set; }
}

/// <summary>The location and type of the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationEncryptionConfiguration
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }
}

/// <summary>The reference data source used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector
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
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfiguration
{
    /// <summary>The Security Group IDs used by the VPC configuration.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Subnet IDs used by the VPC configuration.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>The application&apos;s configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch log stream to receive application messages.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderServiceExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderServiceExecutionRoleSelector
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
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta1ApplicationSpecForProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

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
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleRef? ServiceExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleSelector")]
    public V1beta1ApplicationSpecForProviderServiceExecutionRoleSelector? ServiceExecutionRoleSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Object in s3 to populate fileKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelectorPolicy? Policy { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>Reference to a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeyRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeyRef? FileKeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate fileKey.</summary>
    [JsonPropertyName("fileKeySelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocationFileKeySelector? FileKeySelector { get; set; }

    /// <summary>The version of the object containing the application code.</summary>
    [JsonPropertyName("objectVersion")]
    public string? ObjectVersion { get; set; }
}

/// <summary>The location and type of the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationEncryptionConfiguration
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutputResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
{
    /// <summary>The ARN for the S3 bucket containing the application code.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSourceBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>The file key for the object containing the application code.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }
}

/// <summary>The reference data source used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector
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
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfiguration
{
    /// <summary>The Security Group IDs used by the VPC configuration.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Subnet IDs used by the VPC configuration.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfigurationSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>The application&apos;s configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch log stream to receive application messages.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderServiceExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelector
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
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta1ApplicationSpecInitProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

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
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleRef? ServiceExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRole.</summary>
    [JsonPropertyName("serviceExecutionRoleSelector")]
    public V1beta1ApplicationSpecInitProviderServiceExecutionRoleSelector? ServiceExecutionRoleSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecManagementPoliciesEnum>))]
public enum V1beta1ApplicationSpecManagementPoliciesEnum
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
public partial class V1beta1ApplicationSpecProviderConfigRef
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
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ApplicationSpecForProvider ForProvider { get; set; }

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
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContent
{
    /// <summary>Information about the Amazon S3 bucket containing the application code.</summary>
    [JsonPropertyName("s3ContentLocation")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContentS3ContentLocation? S3ContentLocation { get; set; }

    /// <summary>The text-format code for the application.</summary>
    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }
}

/// <summary>The code location and type parameters for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfiguration
{
    /// <summary>The location and type of the application code.</summary>
    [JsonPropertyName("codeContent")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContent { get; set; }

    /// <summary>Specifies whether the code content is in text or zip format. Valid values: PLAINTEXT, ZIPFILE.</summary>
    [JsonPropertyName("codeContentType")]
    public string? CodeContentType { get; set; }
}

/// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationEncryptionConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationSnapshotConfiguration
{
    /// <summary>Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("snapshotsEnabled")]
    public bool? SnapshotsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationEnvironmentProperties
{
    /// <summary>Describes the execution property groups.</summary>
    [JsonPropertyName("propertyGroup")]
    public IList<V1beta1ApplicationStatusAtProviderApplicationConfigurationEnvironmentPropertiesPropertyGroup>? PropertyGroup { get; set; }
}

/// <summary>Describes an application&apos;s checkpointing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfiguration
{
    /// <summary>Describes an application&apos;s checkpointing configuration.</summary>
    [JsonPropertyName("checkpointConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationCheckpointConfiguration? CheckpointConfiguration { get; set; }

    /// <summary>Describes configuration parameters for CloudWatch logging for an application.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Describes parameters for how an application executes multiple tasks simultaneously.</summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration? ParallelismConfiguration { get; set; }
}

/// <summary>The restore behavior of a restarting application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration
{
    /// <summary>When restoring from a snapshot, specifies whether the runtime is allowed to skip a state that cannot be mapped to the new program. Default is false.</summary>
    [JsonPropertyName("allowNonRestoredState")]
    public bool? AllowNonRestoredState { get; set; }
}

/// <summary>Describes the starting properties for a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfiguration
{
    /// <summary>The restore behavior of a restarting application.</summary>
    [JsonPropertyName("applicationRestoreConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration { get; set; }

    /// <summary>The starting parameters for a Flink-based Kinesis Data Analytics application.</summary>
    [JsonPropertyName("flinkRunConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration { get; set; }
}

/// <summary>Describes the number of in-application streams to create.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism
{
    /// <summary>The number of in-application streams to create.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration
{
    /// <summary>Describes the Lambda function that is used to preprocess the records in the stream before being processed by your application code.</summary>
    [JsonPropertyName("inputLambdaProcessor")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfigurationInputLambdaProcessor? InputLambdaProcessor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("inputStartingPosition")]
    public string? InputStartingPosition { get; set; }
}

/// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>The input stream used by the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInput
{
    [JsonPropertyName("inAppStreamNames")]
    public IList<string>? InAppStreamNames { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Describes the number of in-application streams to create.</summary>
    [JsonPropertyName("inputParallelism")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputParallelism? InputParallelism { get; set; }

    /// <summary>
    /// The input processing configuration for the input.
    /// An input processor transforms records as they are received from the stream, before the application&apos;s SQL code executes.
    /// </summary>
    [JsonPropertyName("inputProcessingConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputProcessingConfiguration? InputProcessingConfiguration { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns in the in-application stream that is being created.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputSchema? InputSchema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source.</summary>
    [JsonPropertyName("inputStartingPositionConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputInputStartingPositionConfiguration>? InputStartingPositionConfiguration { get; set; }

    /// <summary>If the streaming source is a Kinesis Data Firehose delivery stream, identifies the delivery stream&apos;s ARN.</summary>
    [JsonPropertyName("kinesisFirehoseInput")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisFirehoseInput? KinesisFirehoseInput { get; set; }

    /// <summary>If the streaming source is a Kinesis data stream, identifies the stream&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("kinesisStreamsInput")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInputKinesisStreamsInput? KinesisStreamsInput { get; set; }

    /// <summary>The name prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }
}

/// <summary>Describes the data format when records are written to the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema
{
    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>Identifies a Kinesis data stream as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>Identifies a Lambda function as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput
{
    /// <summary>The ARN of the Lambda function that operates on records in the stream.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutput
{
    /// <summary>Describes the data format when records are written to the destination.</summary>
    [JsonPropertyName("destinationSchema")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputDestinationSchema? DestinationSchema { get; set; }

    /// <summary>Identifies a Kinesis Data Firehose delivery stream as the destination.</summary>
    [JsonPropertyName("kinesisFirehoseOutput")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisFirehoseOutput? KinesisFirehoseOutput { get; set; }

    /// <summary>Identifies a Kinesis data stream as the destination.</summary>
    [JsonPropertyName("kinesisStreamsOutput")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputKinesisStreamsOutput? KinesisStreamsOutput { get; set; }

    /// <summary>Identifies a Lambda function as the destination.</summary>
    [JsonPropertyName("lambdaOutput")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutputLambdaOutput? LambdaOutput { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The application identifier.</summary>
    [JsonPropertyName("outputId")]
    public string? OutputId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters
{
    /// <summary>The path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters
{
    /// <summary>Provides additional mapping information when the record format uses delimiters (for example, CSV).</summary>
    [JsonPropertyName("csvMappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersCsvMappingParameters? CsvMappingParameters { get; set; }

    /// <summary>Provides additional mapping information when JSON is the record format on the streaming source.</summary>
    [JsonPropertyName("jsonMappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParametersJsonMappingParameters? JsonMappingParameters { get; set; }
}

/// <summary>Specifies the format of the records on the streaming source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat
{
    /// <summary>Provides additional mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some delimiter) on the streaming source.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The type of record format. Valid values: CSV, JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema
{
    /// <summary>Describes the mapping of each data element in the streaming source to the corresponding column in the in-application stream.</summary>
    [JsonPropertyName("recordColumn")]
    public IList<V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumn>? RecordColumn { get; set; }

    /// <summary>Specifies the encoding of the records in the streaming source. For example, UTF-8.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>Specifies the format of the records on the streaming source.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource
{
    /// <summary>The application identifier.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Describes the format of the data in the streaming source, and how each data element maps to corresponding columns created in the in-application stream.</summary>
    [JsonPropertyName("referenceSchema")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchema? ReferenceSchema { get; set; }

    /// <summary>Identifies the S3 bucket and object that contains the reference data.</summary>
    [JsonPropertyName("s3ReferenceDataSource")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceS3ReferenceDataSource? S3ReferenceDataSource { get; set; }

    /// <summary>The name of the in-application table to create.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The configuration of a SQL-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfiguration
{
    /// <summary>The input stream used by the application.</summary>
    [JsonPropertyName("input")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationInput? Input { get; set; }

    /// <summary>The destination streams used by the application.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationOutput>? Output { get; set; }

    /// <summary>The reference data source used by the application.</summary>
    [JsonPropertyName("referenceDataSource")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfigurationReferenceDataSource? ReferenceDataSource { get; set; }
}

/// <summary>The VPC configuration of a Flink-based application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderApplicationConfigurationVpcConfiguration
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
public partial class V1beta1ApplicationStatusAtProviderApplicationConfiguration
{
    /// <summary>The code location and type parameters for the application.</summary>
    [JsonPropertyName("applicationCodeConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationCodeConfiguration? ApplicationCodeConfiguration { get; set; }

    /// <summary>The encryption configuration for the application. This can be used to encrypt data at rest in the application.</summary>
    [JsonPropertyName("applicationEncryptionConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationEncryptionConfiguration? ApplicationEncryptionConfiguration { get; set; }

    /// <summary>Describes whether snapshots are enabled for a Flink-based application.</summary>
    [JsonPropertyName("applicationSnapshotConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration { get; set; }

    /// <summary>Describes execution properties for a Flink-based application.</summary>
    [JsonPropertyName("environmentProperties")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationEnvironmentProperties? EnvironmentProperties { get; set; }

    /// <summary>The configuration of a Flink-based application.</summary>
    [JsonPropertyName("flinkApplicationConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration { get; set; }

    /// <summary>Describes the starting properties for a Flink-based application.</summary>
    [JsonPropertyName("runConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationRunConfiguration? RunConfiguration { get; set; }

    /// <summary>The configuration of a SQL-based application.</summary>
    [JsonPropertyName("sqlApplicationConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration { get; set; }

    /// <summary>The VPC configuration of a Flink-based application.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfigurationVpcConfiguration? VpcConfiguration { get; set; }
}

/// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderCloudwatchLoggingOptions
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
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>The application&apos;s configuration</summary>
    [JsonPropertyName("applicationConfiguration")]
    public V1beta1ApplicationStatusAtProviderApplicationConfiguration? ApplicationConfiguration { get; set; }

    /// <summary>The application&apos;s mode. Valid values are STREAMING, INTERACTIVE.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>The ARN of the application.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A CloudWatch log stream to monitor application configuration errors.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationStatusAtProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

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
public partial class V1beta1ApplicationStatusConditions
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
public partial class V1beta1ApplicationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "kinesisanalyticsv2.aws.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalyticsv2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Application";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}