#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kinesis.services.k8s.aws;
/// <summary>Stream is the Schema for the Streams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StreamList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Stream>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StreamList";
    public const string KubeGroup = "kinesis.services.k8s.aws";
    public const string KubePluralName = "streams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesis.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StreamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Stream objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Stream> Items { get; set; }
}

/// <summary>
/// Indicates the capacity mode of the data stream. Currently, in Kinesis Data
/// Streams, you can choose between an on-demand capacity mode and a provisioned
/// capacity mode for your data streams.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamSpecStreamModeDetails
{
    [JsonPropertyName("streamMode")]
    public string? StreamMode { get; set; }
}

/// <summary>StreamSpec defines the desired state of Stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamSpec
{
    /// <summary>
    /// A name to identify the stream. The stream name is scoped to the Amazon Web
    /// Services account used by the application that creates the stream. It is also
    /// scoped by Amazon Web Services Region. That is, two streams in two different
    /// Amazon Web Services accounts can have the same name. Two streams in the same
    /// Amazon Web Services account but in two different Regions can also have the
    /// same name.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_.-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The number of shards that the stream will use. The throughput of the stream
    /// is a function of the number of shards; more shards are required for greater
    /// provisioned throughput.
    /// </summary>
    [JsonPropertyName("shardCount")]
    public long? ShardCount { get; set; }

    /// <summary>
    /// Indicates the capacity mode of the data stream. Currently, in Kinesis Data
    /// Streams, you can choose between an on-demand capacity mode and a provisioned
    /// capacity mode for your data streams.
    /// </summary>
    [JsonPropertyName("streamModeDetails")]
    public V1alpha1StreamSpecStreamModeDetails? StreamModeDetails { get; set; }

    /// <summary>A set of up to 10 key-value pairs to use to create the tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Represents enhanced metrics types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamStatusEnhancedMonitoring
{
    [JsonPropertyName("shardLevelMetrics")]
    public IList<string>? ShardLevelMetrics { get; set; }
}

/// <summary>StreamStatus defines the observed state of Stream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StreamStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1StreamStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StreamStatusConditions>? Conditions { get; set; }

    /// <summary>The number of enhanced fan-out consumers registered with the stream.</summary>
    [JsonPropertyName("consumerCount")]
    public long? ConsumerCount { get; set; }

    /// <summary>
    /// The encryption type used. This value is one of the following:
    /// 
    ///    * KMS
    /// 
    ///    * NONE
    /// </summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Represents the current enhanced monitoring settings of the stream.</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public IList<V1alpha1StreamStatusEnhancedMonitoring>? EnhancedMonitoring { get; set; }

    /// <summary>
    /// The GUID for the customer-managed Amazon Web Services KMS key to use for
    /// encryption. This value can be a globally unique identifier, a fully specified
    /// ARN to either an alias or a key, or an alias name prefixed by &quot;alias/&quot;.You
    /// can also use a master key owned by Kinesis Data Streams by specifying the
    /// alias aws/kinesis.
    /// 
    ///    * Key ARN example: arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012
    /// 
    ///    * Alias ARN example: arn:aws:kms:us-east-1:123456789012:alias/MyAliasName
    /// 
    ///    * Globally unique key ID example: 12345678-1234-1234-1234-123456789012
    /// 
    ///    * Alias name example: alias/MyAliasName
    /// 
    ///    * Master key owned by Kinesis Data Streams: alias/aws/kinesis
    /// </summary>
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    /// <summary>The number of open shards in the stream.</summary>
    [JsonPropertyName("openShardCount")]
    public long? OpenShardCount { get; set; }

    /// <summary>The current retention period, in hours.</summary>
    [JsonPropertyName("retentionPeriodHours")]
    public long? RetentionPeriodHours { get; set; }

    /// <summary>The approximate time that the stream was created.</summary>
    [JsonPropertyName("streamCreationTimestamp")]
    public DateTime? StreamCreationTimestamp { get; set; }

    /// <summary>
    /// The current status of the stream being described. The stream status is one
    /// of the following states:
    /// 
    ///    * CREATING - The stream is being created. Kinesis Data Streams immediately
    ///    returns and sets StreamStatus to CREATING.
    /// 
    ///    * DELETING - The stream is being deleted. The specified stream is in the
    ///    DELETING state until Kinesis Data Streams completes the deletion.
    /// 
    ///    * ACTIVE - The stream exists and is ready for read and write operations
    ///    or deletion. You should perform read and write operations only on an ACTIVE
    ///    stream.
    /// 
    ///    * UPDATING - Shards in the stream are being merged or split. Read and
    ///    write operations continue to work while the stream is in the UPDATING
    ///    state.
    /// </summary>
    [JsonPropertyName("streamStatus")]
    public string? StreamStatus { get; set; }
}

/// <summary>Stream is the Schema for the Streams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Stream : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StreamSpec?>, IStatus<V1alpha1StreamStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Stream";
    public const string KubeGroup = "kinesis.services.k8s.aws";
    public const string KubePluralName = "streams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesis.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Stream";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StreamSpec defines the desired state of Stream.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1StreamSpec? Spec { get; set; }

    /// <summary>StreamStatus defines the observed state of Stream</summary>
    [JsonPropertyName("status")]
    public V1alpha1StreamStatus? Status { get; set; }
}