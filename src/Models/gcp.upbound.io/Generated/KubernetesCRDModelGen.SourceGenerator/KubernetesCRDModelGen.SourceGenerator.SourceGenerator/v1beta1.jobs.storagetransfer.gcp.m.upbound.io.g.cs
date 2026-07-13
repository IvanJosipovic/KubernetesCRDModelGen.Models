#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagetransfer.gcp.m.upbound.io;
/// <summary>Job is the Schema for the Jobs API. Creates a new Transfer Job in Google Cloud Storage Transfer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Job>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "storagetransfer.gcp.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storagetransfer.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Job> Items { get; set; }
}

/// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderEventStream
{
    /// <summary>Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated.A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamExpirationTime")]
    public string? EventStreamExpirationTime { get; set; }

    /// <summary>Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamStartTime")]
    public string? EventStreamStartTime { get; set; }

    /// <summary>Specifies a unique name of the resource such as AWS SQS ARN in the form &apos;arn:aws:sqs:region:account_id:queue_name&apos;, or Pub/Sub subscription resource name in the form &apos;projects/{project}/subscriptions/{sub}&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Logging configuration. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderLoggingConfig
{
    [JsonPropertyName("enableOnPremGcsTransferLogs")]
    public bool? EnableOnPremGcsTransferLogs { get; set; }

    /// <summary>
    /// A list of loggable action states. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action state may be one of SUCCEEDED, and FAILED.
    /// </summary>
    [JsonPropertyName("logActionStates")]
    public IList<string>? LogActionStates { get; set; }

    /// <summary>
    /// A list of actions to be logged. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action may be one of FIND, DELETE, and COPY.
    /// </summary>
    [JsonPropertyName("logActions")]
    public IList<string>? LogActions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationConfigPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelector
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
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationConfig
{
    /// <summary>Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &quot;TRANSFER_OPERATION_SUCCESS&quot;, &quot;TRANSFER_OPERATION_FAILED&quot;, &quot;TRANSFER_OPERATION_ABORTED&quot;.</summary>
    [JsonPropertyName("eventTypes")]
    public IList<string>? EventTypes { get; set; }

    /// <summary>The desired format of the notification message payloads. One of &quot;NONE&quot; or &quot;JSON&quot;.</summary>
    [JsonPropertyName("payloadFormat")]
    public string? PayloadFormat { get; set; }

    /// <summary>The Topic.name of the Pub/Sub topic to which to publish notifications. Must be of the format: projects/{project}/topics/{topic}. Not matching this format results in an INVALID_ARGUMENT error.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicRef? PubsubTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicSelector")]
    public V1beta1JobSpecForProviderNotificationConfigPubsubTopicSelector? PubsubTopicSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelector
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
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSinkBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelector
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
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSourceBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobSpecForProviderReplicationSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderReplicationSpec
{
    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobSpecForProviderReplicationSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobSpecForProviderReplicationSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobSpecForProviderReplicationSpecTransferOptions? TransferOptions { get; set; }
}

/// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderScheduleScheduleEndDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderScheduleScheduleStartDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderScheduleStartTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSchedule
{
    /// <summary>Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("repeatInterval")]
    public string? RepeatInterval { get; set; }

    /// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
    [JsonPropertyName("scheduleEndDate")]
    public V1beta1JobSpecForProviderScheduleScheduleEndDate? ScheduleEndDate { get; set; }

    /// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
    [JsonPropertyName("scheduleStartDate")]
    public V1beta1JobSpecForProviderScheduleScheduleStartDate? ScheduleStartDate { get; set; }

    /// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
    [JsonPropertyName("startTimeOfDay")]
    public V1beta1JobSpecForProviderScheduleStartTimeOfDay? StartTimeOfDay { get; set; }
}

/// <summary>AWS Key ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS Secret Access Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS credentials block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKey
{
    /// <summary>AWS Key ID.</summary>
    [JsonPropertyName("accessKeyIdSecretRef")]
    public V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef? AccessKeyIdSecretRef { get; set; }

    /// <summary>AWS Secret Access Key.</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

/// <summary>An AWS S3 data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAwsS3DataSource
{
    /// <summary>AWS credentials block.</summary>
    [JsonPropertyName("awsAccessKey")]
    public V1beta1JobSpecForProviderTransferSpecAwsS3DataSourceAwsAccessKey? AwsAccessKey { get; set; }

    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Egress bytes over a Google-managed private network. This network is shared between other users of Storage Transfer Service.</summary>
    [JsonPropertyName("managedPrivateNetwork")]
    public bool? ManagedPrivateNetwork { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the role to support temporary credentials via &apos;AssumeRoleWithWebIdentity&apos;. For more information about ARNs, see IAM ARNs. When a role ARN is provided, Transfer Service fetches temporary credentials for the session using a &apos;AssumeRoleWithWebIdentity&apos; call for the provided role using the [GoogleServiceAccount][] for this project.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Credentials used to authenticate API requests to Azure block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials
{
    /// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef? SasTokenSecretRef { get; set; }
}

/// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSource
{
    /// <summary>Credentials used to authenticate API requests to Azure block.</summary>
    [JsonPropertyName("azureCredentials")]
    public V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The container to transfer from the Azure Storage account.`</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The name of the Azure Storage account.</summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelector
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
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSinkBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelector
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
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSourceBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An HDFS data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecHdfsDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A HTTP URL data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecHttpDataSource
{
    /// <summary>The URL that points to the file that stores the object list entries. This file must allow public access. Currently, only URLs with HTTP and HTTPS schemes are supported.</summary>
    [JsonPropertyName("listUrl")]
    public string? ListUrl { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

/// <summary>A POSIX data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecPosixDataSink
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary>A POSIX filesystem data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecPosixDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobSpecForProviderTransferSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTransferSpec
{
    /// <summary>An AWS S3 data source. Structure documented below.</summary>
    [JsonPropertyName("awsS3DataSource")]
    public V1beta1JobSpecForProviderTransferSpecAwsS3DataSource? AwsS3DataSource { get; set; }

    /// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
    [JsonPropertyName("azureBlobStorageDataSource")]
    public V1beta1JobSpecForProviderTransferSpecAzureBlobStorageDataSource? AzureBlobStorageDataSource { get; set; }

    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobSpecForProviderTransferSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>An HDFS data source. Structure documented below.</summary>
    [JsonPropertyName("hdfsDataSource")]
    public V1beta1JobSpecForProviderTransferSpecHdfsDataSource? HdfsDataSource { get; set; }

    /// <summary>A HTTP URL data source. Structure documented below.</summary>
    [JsonPropertyName("httpDataSource")]
    public V1beta1JobSpecForProviderTransferSpecHttpDataSource? HttpDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobSpecForProviderTransferSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>A POSIX data sink. Structure documented below.</summary>
    [JsonPropertyName("posixDataSink")]
    public V1beta1JobSpecForProviderTransferSpecPosixDataSink? PosixDataSink { get; set; }

    /// <summary>A POSIX filesystem data source. Structure documented below.</summary>
    [JsonPropertyName("posixDataSource")]
    public V1beta1JobSpecForProviderTransferSpecPosixDataSource? PosixDataSource { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data sink. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sinkAgentPoolName")]
    public string? SinkAgentPoolName { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sourceAgentPoolName")]
    public string? SourceAgentPoolName { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobSpecForProviderTransferSpecTransferOptions? TransferOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProvider
{
    /// <summary>Unique description to identify the Transfer Job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
    [JsonPropertyName("eventStream")]
    public V1beta1JobSpecForProviderEventStream? EventStream { get; set; }

    /// <summary>Logging configuration. Structure documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1JobSpecForProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the Transfer Job. This name must start with &quot;transferJobs/&quot; prefix and end with a letter or a number, and should be no more than 128 characters ( transferJobs/^(?!OPI)[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For transfers involving PosixFilesystem, this name must start with transferJobs/OPI specifically ( transferJobs/OPI^[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For all other transfer types, this name must not start with transferJobs/OPI. Default the provider will assign a random unique name with transferJobs/{{name}} format, where name is a numeric value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1JobSpecForProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary>
    /// The project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
    [JsonPropertyName("replicationSpec")]
    public V1beta1JobSpecForProviderReplicationSpec? ReplicationSpec { get; set; }

    /// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
    [JsonPropertyName("transferSpec")]
    public V1beta1JobSpecForProviderTransferSpec? TransferSpec { get; set; }
}

/// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderEventStream
{
    /// <summary>Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated.A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamExpirationTime")]
    public string? EventStreamExpirationTime { get; set; }

    /// <summary>Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamStartTime")]
    public string? EventStreamStartTime { get; set; }

    /// <summary>Specifies a unique name of the resource such as AWS SQS ARN in the form &apos;arn:aws:sqs:region:account_id:queue_name&apos;, or Pub/Sub subscription resource name in the form &apos;projects/{project}/subscriptions/{sub}&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Logging configuration. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderLoggingConfig
{
    [JsonPropertyName("enableOnPremGcsTransferLogs")]
    public bool? EnableOnPremGcsTransferLogs { get; set; }

    /// <summary>
    /// A list of loggable action states. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action state may be one of SUCCEEDED, and FAILED.
    /// </summary>
    [JsonPropertyName("logActionStates")]
    public IList<string>? LogActionStates { get; set; }

    /// <summary>
    /// A list of actions to be logged. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action may be one of FIND, DELETE, and COPY.
    /// </summary>
    [JsonPropertyName("logActions")]
    public IList<string>? LogActions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelector
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
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationConfig
{
    /// <summary>Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &quot;TRANSFER_OPERATION_SUCCESS&quot;, &quot;TRANSFER_OPERATION_FAILED&quot;, &quot;TRANSFER_OPERATION_ABORTED&quot;.</summary>
    [JsonPropertyName("eventTypes")]
    public IList<string>? EventTypes { get; set; }

    /// <summary>The desired format of the notification message payloads. One of &quot;NONE&quot; or &quot;JSON&quot;.</summary>
    [JsonPropertyName("payloadFormat")]
    public string? PayloadFormat { get; set; }

    /// <summary>The Topic.name of the Pub/Sub topic to which to publish notifications. Must be of the format: projects/{project}/topics/{topic}. Not matching this format results in an INVALID_ARGUMENT error.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicRef? PubsubTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicSelector")]
    public V1beta1JobSpecInitProviderNotificationConfigPubsubTopicSelector? PubsubTopicSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelector
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
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSinkBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelector
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
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSourceBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobSpecInitProviderReplicationSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderReplicationSpec
{
    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobSpecInitProviderReplicationSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobSpecInitProviderReplicationSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobSpecInitProviderReplicationSpecTransferOptions? TransferOptions { get; set; }
}

/// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderScheduleScheduleEndDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderScheduleScheduleStartDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderScheduleStartTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSchedule
{
    /// <summary>Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("repeatInterval")]
    public string? RepeatInterval { get; set; }

    /// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
    [JsonPropertyName("scheduleEndDate")]
    public V1beta1JobSpecInitProviderScheduleScheduleEndDate? ScheduleEndDate { get; set; }

    /// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
    [JsonPropertyName("scheduleStartDate")]
    public V1beta1JobSpecInitProviderScheduleScheduleStartDate? ScheduleStartDate { get; set; }

    /// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
    [JsonPropertyName("startTimeOfDay")]
    public V1beta1JobSpecInitProviderScheduleStartTimeOfDay? StartTimeOfDay { get; set; }
}

/// <summary>AWS Key ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS Secret Access Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS credentials block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKey
{
    /// <summary>AWS Key ID.</summary>
    [JsonPropertyName("accessKeyIdSecretRef")]
    public required V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef AccessKeyIdSecretRef { get; set; }

    /// <summary>AWS Secret Access Key.</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public required V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef SecretAccessKeySecretRef { get; set; }
}

/// <summary>An AWS S3 data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAwsS3DataSource
{
    /// <summary>AWS credentials block.</summary>
    [JsonPropertyName("awsAccessKey")]
    public V1beta1JobSpecInitProviderTransferSpecAwsS3DataSourceAwsAccessKey? AwsAccessKey { get; set; }

    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Egress bytes over a Google-managed private network. This network is shared between other users of Storage Transfer Service.</summary>
    [JsonPropertyName("managedPrivateNetwork")]
    public bool? ManagedPrivateNetwork { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the role to support temporary credentials via &apos;AssumeRoleWithWebIdentity&apos;. For more information about ARNs, see IAM ARNs. When a role ARN is provided, Transfer Service fetches temporary credentials for the session using a &apos;AssumeRoleWithWebIdentity&apos; call for the provided role using the [GoogleServiceAccount][] for this project.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Credentials used to authenticate API requests to Azure block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials
{
    /// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public required V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef SasTokenSecretRef { get; set; }
}

/// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSource
{
    /// <summary>Credentials used to authenticate API requests to Azure block.</summary>
    [JsonPropertyName("azureCredentials")]
    public V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The container to transfer from the Azure Storage account.`</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The name of the Azure Storage account.</summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelector
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
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSinkBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelector
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
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSourceBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An HDFS data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecHdfsDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A HTTP URL data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecHttpDataSource
{
    /// <summary>The URL that points to the file that stores the object list entries. This file must allow public access. Currently, only URLs with HTTP and HTTPS schemes are supported.</summary>
    [JsonPropertyName("listUrl")]
    public string? ListUrl { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

/// <summary>A POSIX data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecPosixDataSink
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary>A POSIX filesystem data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecPosixDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobSpecInitProviderTransferSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTransferSpec
{
    /// <summary>An AWS S3 data source. Structure documented below.</summary>
    [JsonPropertyName("awsS3DataSource")]
    public V1beta1JobSpecInitProviderTransferSpecAwsS3DataSource? AwsS3DataSource { get; set; }

    /// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
    [JsonPropertyName("azureBlobStorageDataSource")]
    public V1beta1JobSpecInitProviderTransferSpecAzureBlobStorageDataSource? AzureBlobStorageDataSource { get; set; }

    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobSpecInitProviderTransferSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>An HDFS data source. Structure documented below.</summary>
    [JsonPropertyName("hdfsDataSource")]
    public V1beta1JobSpecInitProviderTransferSpecHdfsDataSource? HdfsDataSource { get; set; }

    /// <summary>A HTTP URL data source. Structure documented below.</summary>
    [JsonPropertyName("httpDataSource")]
    public V1beta1JobSpecInitProviderTransferSpecHttpDataSource? HttpDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobSpecInitProviderTransferSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>A POSIX data sink. Structure documented below.</summary>
    [JsonPropertyName("posixDataSink")]
    public V1beta1JobSpecInitProviderTransferSpecPosixDataSink? PosixDataSink { get; set; }

    /// <summary>A POSIX filesystem data source. Structure documented below.</summary>
    [JsonPropertyName("posixDataSource")]
    public V1beta1JobSpecInitProviderTransferSpecPosixDataSource? PosixDataSource { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data sink. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sinkAgentPoolName")]
    public string? SinkAgentPoolName { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sourceAgentPoolName")]
    public string? SourceAgentPoolName { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobSpecInitProviderTransferSpecTransferOptions? TransferOptions { get; set; }
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
public partial class V1beta1JobSpecInitProvider
{
    /// <summary>Unique description to identify the Transfer Job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
    [JsonPropertyName("eventStream")]
    public V1beta1JobSpecInitProviderEventStream? EventStream { get; set; }

    /// <summary>Logging configuration. Structure documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1JobSpecInitProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the Transfer Job. This name must start with &quot;transferJobs/&quot; prefix and end with a letter or a number, and should be no more than 128 characters ( transferJobs/^(?!OPI)[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For transfers involving PosixFilesystem, this name must start with transferJobs/OPI specifically ( transferJobs/OPI^[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For all other transfer types, this name must not start with transferJobs/OPI. Default the provider will assign a random unique name with transferJobs/{{name}} format, where name is a numeric value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1JobSpecInitProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary>
    /// The project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
    [JsonPropertyName("replicationSpec")]
    public V1beta1JobSpecInitProviderReplicationSpec? ReplicationSpec { get; set; }

    /// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
    [JsonPropertyName("transferSpec")]
    public V1beta1JobSpecInitProviderTransferSpec? TransferSpec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecManagementPoliciesEnum>))]
public enum V1beta1JobSpecManagementPoliciesEnum
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
public partial class V1beta1JobSpecProviderConfigRef
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
public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1JobSpecForProvider ForProvider { get; set; }

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
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderEventStream
{
    /// <summary>Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated.A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamExpirationTime")]
    public string? EventStreamExpirationTime { get; set; }

    /// <summary>Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("eventStreamStartTime")]
    public string? EventStreamStartTime { get; set; }

    /// <summary>Specifies a unique name of the resource such as AWS SQS ARN in the form &apos;arn:aws:sqs:region:account_id:queue_name&apos;, or Pub/Sub subscription resource name in the form &apos;projects/{project}/subscriptions/{sub}&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Logging configuration. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderLoggingConfig
{
    [JsonPropertyName("enableOnPremGcsTransferLogs")]
    public bool? EnableOnPremGcsTransferLogs { get; set; }

    /// <summary>
    /// A list of loggable action states. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action state may be one of SUCCEEDED, and FAILED.
    /// </summary>
    [JsonPropertyName("logActionStates")]
    public IList<string>? LogActionStates { get; set; }

    /// <summary>
    /// A list of actions to be logged. If empty, no logs are generated. Not supported for transfers with PosixFilesystem data sources; use enableOnpremGcsTransferLogs instead.
    /// Each action may be one of FIND, DELETE, and COPY.
    /// </summary>
    [JsonPropertyName("logActions")]
    public IList<string>? LogActions { get; set; }
}

/// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNotificationConfig
{
    /// <summary>Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &quot;TRANSFER_OPERATION_SUCCESS&quot;, &quot;TRANSFER_OPERATION_FAILED&quot;, &quot;TRANSFER_OPERATION_ABORTED&quot;.</summary>
    [JsonPropertyName("eventTypes")]
    public IList<string>? EventTypes { get; set; }

    /// <summary>The desired format of the notification message payloads. One of &quot;NONE&quot; or &quot;JSON&quot;.</summary>
    [JsonPropertyName("payloadFormat")]
    public string? PayloadFormat { get; set; }

    /// <summary>The Topic.name of the Pub/Sub topic to which to publish notifications. Must be of the format: projects/{project}/topics/{topic}. Not matching this format results in an INVALID_ARGUMENT error.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobStatusAtProviderReplicationSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderReplicationSpec
{
    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobStatusAtProviderReplicationSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobStatusAtProviderReplicationSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobStatusAtProviderReplicationSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobStatusAtProviderReplicationSpecTransferOptions? TransferOptions { get; set; }
}

/// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderScheduleScheduleEndDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderScheduleScheduleStartDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderScheduleStartTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSchedule
{
    /// <summary>Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("repeatInterval")]
    public string? RepeatInterval { get; set; }

    /// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once. Structure documented below.</summary>
    [JsonPropertyName("scheduleEndDate")]
    public V1beta1JobStatusAtProviderScheduleScheduleEndDate? ScheduleEndDate { get; set; }

    /// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day. Structure documented below.</summary>
    [JsonPropertyName("scheduleStartDate")]
    public V1beta1JobStatusAtProviderScheduleScheduleStartDate? ScheduleStartDate { get; set; }

    /// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer&apos;s start time in a day is specified in your local timezone. Structure documented below.</summary>
    [JsonPropertyName("startTimeOfDay")]
    public V1beta1JobStatusAtProviderScheduleStartTimeOfDay? StartTimeOfDay { get; set; }
}

/// <summary>AWS Key ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS Secret Access Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AWS credentials block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKey
{
    /// <summary>AWS Key ID.</summary>
    [JsonPropertyName("accessKeyIdSecretRef")]
    public V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdSecretRef? AccessKeyIdSecretRef { get; set; }

    /// <summary>AWS Secret Access Key.</summary>
    [JsonPropertyName("secretAccessKeySecretRef")]
    public V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeySecretRef? SecretAccessKeySecretRef { get; set; }
}

/// <summary>An AWS S3 data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAwsS3DataSource
{
    /// <summary>AWS credentials block.</summary>
    [JsonPropertyName("awsAccessKey")]
    public V1beta1JobStatusAtProviderTransferSpecAwsS3DataSourceAwsAccessKey? AwsAccessKey { get; set; }

    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Egress bytes over a Google-managed private network. This network is shared between other users of Storage Transfer Service.</summary>
    [JsonPropertyName("managedPrivateNetwork")]
    public bool? ManagedPrivateNetwork { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the role to support temporary credentials via &apos;AssumeRoleWithWebIdentity&apos;. For more information about ARNs, see IAM ARNs. When a role ARN is provided, Transfer Service fetches temporary credentials for the session using a &apos;AssumeRoleWithWebIdentity&apos; call for the provided role using the [GoogleServiceAccount][] for this project.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Credentials used to authenticate API requests to Azure block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials
{
    /// <summary>Azure shared access signature. See Grant limited access to Azure Storage resources using shared access signatures (SAS).</summary>
    [JsonPropertyName("sasTokenSecretRef")]
    public V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenSecretRef? SasTokenSecretRef { get; set; }
}

/// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSource
{
    /// <summary>Credentials used to authenticate API requests to Azure block.</summary>
    [JsonPropertyName("azureCredentials")]
    public V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSourceAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The container to transfer from the Azure Storage account.`</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The name of the Azure Storage account.</summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }
}

/// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecGcsDataSink
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecGcsDataSource
{
    /// <summary>Google Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An HDFS data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecHdfsDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A HTTP URL data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecHttpDataSource
{
    /// <summary>The URL that points to the file that stores the object list entries. This file must allow public access. Currently, only URLs with HTTP and HTTPS schemes are supported.</summary>
    [JsonPropertyName("listUrl")]
    public string? ListUrl { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes. See Requirements.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_prefixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions. See Requirements.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; before this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a &quot;last modification time&quot; on or after this timestamp and objects that don&apos;t have a &quot;last modification time&quot; are transferred. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

/// <summary>A POSIX data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecPosixDataSink
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

/// <summary>A POSIX filesystem data source. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecPosixDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecTransferOptionsMetadataOptions
{
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    [JsonPropertyName("symlink")]
    public string? Symlink { get; set; }

    [JsonPropertyName("temporaryHold")]
    public string? TemporaryHold { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and
    /// delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1JobStatusAtProviderTransferSpecTransferOptionsMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink. Possible values: ALWAYS, DIFFERENT, NEVER.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTransferSpec
{
    /// <summary>An AWS S3 data source. Structure documented below.</summary>
    [JsonPropertyName("awsS3DataSource")]
    public V1beta1JobStatusAtProviderTransferSpecAwsS3DataSource? AwsS3DataSource { get; set; }

    /// <summary>An Azure Blob Storage data source. Structure documented below.</summary>
    [JsonPropertyName("azureBlobStorageDataSource")]
    public V1beta1JobStatusAtProviderTransferSpecAzureBlobStorageDataSource? AzureBlobStorageDataSource { get; set; }

    /// <summary>A Google Cloud Storage data sink. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1JobStatusAtProviderTransferSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source. Structure documented below.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1JobStatusAtProviderTransferSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>An HDFS data source. Structure documented below.</summary>
    [JsonPropertyName("hdfsDataSource")]
    public V1beta1JobStatusAtProviderTransferSpecHdfsDataSource? HdfsDataSource { get; set; }

    /// <summary>A HTTP URL data source. Structure documented below.</summary>
    [JsonPropertyName("httpDataSource")]
    public V1beta1JobStatusAtProviderTransferSpecHttpDataSource? HttpDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects&apos; last_modification_time do not exclude objects in a data sink. Structure documented below.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1JobStatusAtProviderTransferSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>A POSIX data sink. Structure documented below.</summary>
    [JsonPropertyName("posixDataSink")]
    public V1beta1JobStatusAtProviderTransferSpecPosixDataSink? PosixDataSink { get; set; }

    /// <summary>A POSIX filesystem data source. Structure documented below.</summary>
    [JsonPropertyName("posixDataSource")]
    public V1beta1JobStatusAtProviderTransferSpecPosixDataSource? PosixDataSource { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data sink. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sinkAgentPoolName")]
    public string? SinkAgentPoolName { get; set; }

    /// <summary>Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sourceAgentPoolName")]
    public string? SourceAgentPoolName { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects&apos; last_modification_time are ignored and do not exclude objects in a data source or a data sink. Structure documented below.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1JobStatusAtProviderTransferSpecTransferOptions? TransferOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProvider
{
    /// <summary>When the Transfer Job was created.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>When the Transfer Job was deleted.</summary>
    [JsonPropertyName("deletionTime")]
    public string? DeletionTime { get; set; }

    /// <summary>Unique description to identify the Transfer Job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the Event-driven transfer options. Event-driven transfers listen to an event stream to transfer updated files. Structure documented below Either event_stream or schedule must be set.</summary>
    [JsonPropertyName("eventStream")]
    public V1beta1JobStatusAtProviderEventStream? EventStream { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>When the Transfer Job was last modified.</summary>
    [JsonPropertyName("lastModificationTime")]
    public string? LastModificationTime { get; set; }

    /// <summary>Logging configuration. Structure documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1JobStatusAtProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the Transfer Job. This name must start with &quot;transferJobs/&quot; prefix and end with a letter or a number, and should be no more than 128 characters ( transferJobs/^(?!OPI)[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For transfers involving PosixFilesystem, this name must start with transferJobs/OPI specifically ( transferJobs/OPI^[A-Za-z0-9-._~]*[A-Za-z0-9]$ ). For all other transfer types, this name must not start with transferJobs/OPI. Default the provider will assign a random unique name with transferJobs/{{name}} format, where name is a numeric value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Notification configuration. This is not supported for transfers involving PosixFilesystem. Structure documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1JobStatusAtProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary>
    /// The project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Replication specification. Structure documented below. User should not configure schedule, event_stream with this argument. One of transfer_spec, or replication_spec must be specified.</summary>
    [JsonPropertyName("replicationSpec")]
    public V1beta1JobStatusAtProviderReplicationSpec? ReplicationSpec { get; set; }

    /// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run. Structure documented below. Either schedule or event_stream must be set.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Transfer specification. Structure documented below. One of transfer_spec, or replication_spec can be specified.</summary>
    [JsonPropertyName("transferSpec")]
    public V1beta1JobStatusAtProviderTransferSpec? TransferSpec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusConditions
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

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. Creates a new Transfer Job in Google Cloud Storage Transfer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "storagetransfer.gcp.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storagetransfer.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}