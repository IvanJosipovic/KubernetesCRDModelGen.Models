#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.gcp.upbound.io;
/// <summary>Subscription is the Schema for the Subscriptions API. A named resource representing the stream of messages from a single, specific topic, to be delivered to the subscribing application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Subscription>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Subscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Subscription> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecDeletionPolicyEnum>))]
public enum V1beta2SubscriptionSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelector
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
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If delivery to BigQuery is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderBigqueryConfig
{
    /// <summary>
    /// When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that
    /// are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync
    /// and any messages with extra fields are not written and remain in the subscription&apos;s backlog.
    /// </summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>
    /// The service account to use to write to BigQuery. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>
    /// When true, use the BigQuery table&apos;s schema as the columns to write to in BigQuery. Messages
    /// must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table.
    /// The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If set, message data will be written to Cloud Storage in Avro format.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfigAvroConfig
{
    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelector
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
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderCloudStorageConfig
{
    /// <summary>
    /// If set, message data will be written to Cloud Storage in Avro format.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("avroConfig")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigAvroConfig? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &quot;gs://&quot;.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in &quot;/&quot;.</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>
    /// The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB.
    /// The maxBytes limit may be exceeded in cases where messages are larger than the limit.
    /// </summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>
    /// The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes.
    /// May not exceed the subscription&apos;s acknowledgement deadline.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>
    /// The service account to use to write to Cloud Storage. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelector
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
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for dead lettering messages in
/// this subscription. If dead_letter_policy is not set, dead lettering
/// is disabled.
/// The Cloud Pub/Sub service account associated with this subscription&apos;s
/// parent project (i.e.,
/// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
/// permission to Acknowledge() messages on this subscription.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderDeadLetterPolicy
{
    /// <summary>
    /// The name of the topic to which dead letter messages should be published.
    /// Format is projects/{project}/topics/{topic}.
    /// The Cloud Pub/Sub service account associated with the enclosing subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Publish() to this topic.
    /// The operation will fail if the topic does not exist.
    /// Users should ensure that there is a subscription attached to this topic
    /// since messages published to a topic with no subscriptions are lost.
    /// </summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicSelector")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelector? DeadLetterTopicSelector { get; set; }

    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must be
    /// between 5 and 100.
    /// The number of delivery attempts is defined as 1 + (the sum of number of
    /// NACKs and number of times the acknowledgement deadline has been exceeded for the message).
    /// A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that
    /// client libraries may automatically extend ack_deadlines.
    /// This field will be honored on a best effort basis.
    /// If this parameter is 0, a default value of 5 is used.
    /// </summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for this subscription&apos;s expiration.
/// A subscription is considered active as long as any connected subscriber
/// is successfully consuming messages from the subscription or is issuing
/// operations on the subscription. If expirationPolicy is not set, a default
/// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
/// resource never expires.  The minimum allowed value for expirationPolicy.ttl
/// is 1 day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderExpirationPolicy
{
    /// <summary>
    /// Specifies the &quot;time-to-live&quot; duration for an associated resource. The
    /// resource expires if it is not active for a period of ttl.
    /// If ttl is set to &quot; &quot;, the associated resource never expires.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example - &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderMessageTransformsJavascriptUdf
{
    /// <summary>
    /// JavaScript code that contains a function function_name with the
    /// following signature:
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderMessageTransforms
{
    /// <summary>
    /// Controls whether or not to use this transform. If not set or false,
    /// the transform will be applied to messages. Default: true.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
    /// each one must have a unique function_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("javascriptUdf")]
    public V1beta2SubscriptionSpecForProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// When set, the payload to the push endpoint is not wrapped.Sets the
/// data field as the HTTP body for delivery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderPushConfigNoWrapper
{
    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If specified, Pub/Sub will generate and attach an OIDC JWT token as
/// an Authorization header in the HTTP request for every pushed message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderPushConfigOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. The audience claim
    /// identifies the recipients that the JWT is intended for. The audience
    /// value is a single case-sensitive string. Having multiple values (array)
    /// for the audience field is not supported. More info about the OIDC JWT
    /// token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3
    /// Note: if not specified, the Push endpoint URL will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating the OIDC token.
    /// The caller (for subscriptions.create, subscriptions.patch, and
    /// subscriptions.modifyPushConfig RPCs) must have the
    /// iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// If push delivery is used with this subscription, this field is used to
/// configure it. An empty pushConfig signifies that the subscriber will
/// pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderPushConfig
{
    /// <summary>
    /// Endpoint configuration attributes.
    /// Every endpoint has a set of API supported attributes that can
    /// be used to control different aspects of the message delivery.
    /// The currently supported attribute is x-goog-version, which you
    /// can use to change the format of the pushed message. This
    /// attribute indicates the version of the data expected by
    /// the endpoint. This controls the shape of the pushed message
    /// (i.e., its fields and metadata). The endpoint version is
    /// based on the version of the Pub/Sub API.
    /// If not present during the subscriptions.create call,
    /// it will default to the version of the API used to make
    /// such call. If not present during a subscriptions.modifyPushConfig
    /// call, its value will not be changed. subscriptions.get
    /// calls will always return a valid version, even if the
    /// subscription was created without this attribute.
    /// The possible values for this attribute are:
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// When set, the payload to the push endpoint is not wrapped.Sets the
    /// data field as the HTTP body for delivery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("noWrapper")]
    public V1beta2SubscriptionSpecForProviderPushConfigNoWrapper? NoWrapper { get; set; }

    /// <summary>
    /// If specified, Pub/Sub will generate and attach an OIDC JWT token as
    /// an Authorization header in the HTTP request for every pushed message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2SubscriptionSpecForProviderPushConfigOidcToken? OidcToken { get; set; }

    /// <summary>
    /// A URL locating the endpoint to which messages should be pushed.
    /// For example, a Webhook endpoint might use
    /// &quot;https://example.com/push&quot;.
    /// </summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary>
/// A policy that specifies how Pub/Sub retries message delivery for this subscription.
/// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
/// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderRetryPolicy
{
    /// <summary>
    /// The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>
    /// The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderTopicRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderTopicRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecForProviderTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecForProviderTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProviderTopicSelector
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
    public V1beta2SubscriptionSpecForProviderTopicSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecForProvider
{
    /// <summary>
    /// This value is the maximum time after a subscriber receives a message
    /// before the subscriber should acknowledge the message. After message
    /// delivery but before the ack deadline expires and before the message is
    /// acknowledged, it is an outstanding message and will not be delivered
    /// again during that time (on a best-effort basis).
    /// For pull subscriptions, this value is used as the initial value for
    /// the ack deadline. To override this value for a given message, call
    /// subscriptions.modifyAckDeadline with the corresponding ackId if using
    /// pull. The minimum custom deadline you can specify is 10 seconds. The
    /// maximum custom deadline you can specify is 600 seconds (10 minutes).
    /// If this parameter is 0, a default value of 10 seconds is used.
    /// For push delivery, this value is also used to set the request timeout
    /// for the call to the push endpoint.
    /// If the subscriber never acknowledges the message, the Pub/Sub system
    /// will eventually redeliver the message.
    /// </summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>
    /// If delivery to BigQuery is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryConfig")]
    public V1beta2SubscriptionSpecForProviderBigqueryConfig? BigqueryConfig { get; set; }

    /// <summary>
    /// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageConfig")]
    public V1beta2SubscriptionSpecForProviderCloudStorageConfig? CloudStorageConfig { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for dead lettering messages in
    /// this subscription. If dead_letter_policy is not set, dead lettering
    /// is disabled.
    /// The Cloud Pub/Sub service account associated with this subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Acknowledge() messages on this subscription.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deadLetterPolicy")]
    public V1beta2SubscriptionSpecForProviderDeadLetterPolicy? DeadLetterPolicy { get; set; }

    /// <summary>
    /// If true, Pub/Sub provides the following guarantees for the delivery
    /// of a message with a given value of messageId on this Subscriptions&apos;:
    /// </summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>
    /// If true, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for this subscription&apos;s expiration.
    /// A subscription is considered active as long as any connected subscriber
    /// is successfully consuming messages from the subscription or is issuing
    /// operations on the subscription. If expirationPolicy is not set, a default
    /// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
    /// resource never expires.  The minimum allowed value for expirationPolicy.ttl
    /// is 1 day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expirationPolicy")]
    public V1beta2SubscriptionSpecForProviderExpirationPolicy? ExpirationPolicy { get; set; }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&apos;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&apos;t modify the filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// How long to retain unacknowledged messages in the subscription&apos;s
    /// backlog, from the moment a message is published. If
    /// retain_acked_messages is true, then this also configures the retention
    /// of acknowledged messages, and thus configures how far back in time a
    /// subscriptions.seek can be done. Defaults to 7 days. Cannot be more
    /// than 31 days (&quot;2678400s&quot;) or less than 10 minutes (&quot;600s&quot;).
    /// A duration in seconds with up to nine fractional digits, terminated
    /// by &apos;s&apos;. Example: &quot;600.5s&quot;.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2SubscriptionSpecForProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// If push delivery is used with this subscription, this field is used to
    /// configure it. An empty pushConfig signifies that the subscriber will
    /// pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pushConfig")]
    public V1beta2SubscriptionSpecForProviderPushConfig? PushConfig { get; set; }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If true, then
    /// messages are not expunged from the subscription&apos;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery for this subscription.
    /// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
    /// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2SubscriptionSpecForProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2SubscriptionSpecForProviderTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2SubscriptionSpecForProviderTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelector
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
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If delivery to BigQuery is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderBigqueryConfig
{
    /// <summary>
    /// When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that
    /// are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync
    /// and any messages with extra fields are not written and remain in the subscription&apos;s backlog.
    /// </summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>
    /// The service account to use to write to BigQuery. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>
    /// When true, use the BigQuery table&apos;s schema as the columns to write to in BigQuery. Messages
    /// must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table.
    /// The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If set, message data will be written to Cloud Storage in Avro format.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfigAvroConfig
{
    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelector
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
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderCloudStorageConfig
{
    /// <summary>
    /// If set, message data will be written to Cloud Storage in Avro format.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("avroConfig")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigAvroConfig? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &quot;gs://&quot;.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in &quot;/&quot;.</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>
    /// The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB.
    /// The maxBytes limit may be exceeded in cases where messages are larger than the limit.
    /// </summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>
    /// The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes.
    /// May not exceed the subscription&apos;s acknowledgement deadline.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>
    /// The service account to use to write to Cloud Storage. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelector
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
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for dead lettering messages in
/// this subscription. If dead_letter_policy is not set, dead lettering
/// is disabled.
/// The Cloud Pub/Sub service account associated with this subscription&apos;s
/// parent project (i.e.,
/// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
/// permission to Acknowledge() messages on this subscription.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderDeadLetterPolicy
{
    /// <summary>
    /// The name of the topic to which dead letter messages should be published.
    /// Format is projects/{project}/topics/{topic}.
    /// The Cloud Pub/Sub service account associated with the enclosing subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Publish() to this topic.
    /// The operation will fail if the topic does not exist.
    /// Users should ensure that there is a subscription attached to this topic
    /// since messages published to a topic with no subscriptions are lost.
    /// </summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicSelector")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelector? DeadLetterTopicSelector { get; set; }

    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must be
    /// between 5 and 100.
    /// The number of delivery attempts is defined as 1 + (the sum of number of
    /// NACKs and number of times the acknowledgement deadline has been exceeded for the message).
    /// A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that
    /// client libraries may automatically extend ack_deadlines.
    /// This field will be honored on a best effort basis.
    /// If this parameter is 0, a default value of 5 is used.
    /// </summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for this subscription&apos;s expiration.
/// A subscription is considered active as long as any connected subscriber
/// is successfully consuming messages from the subscription or is issuing
/// operations on the subscription. If expirationPolicy is not set, a default
/// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
/// resource never expires.  The minimum allowed value for expirationPolicy.ttl
/// is 1 day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderExpirationPolicy
{
    /// <summary>
    /// Specifies the &quot;time-to-live&quot; duration for an associated resource. The
    /// resource expires if it is not active for a period of ttl.
    /// If ttl is set to &quot; &quot;, the associated resource never expires.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example - &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderMessageTransformsJavascriptUdf
{
    /// <summary>
    /// JavaScript code that contains a function function_name with the
    /// following signature:
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderMessageTransforms
{
    /// <summary>
    /// Controls whether or not to use this transform. If not set or false,
    /// the transform will be applied to messages. Default: true.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
    /// each one must have a unique function_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("javascriptUdf")]
    public V1beta2SubscriptionSpecInitProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// When set, the payload to the push endpoint is not wrapped.Sets the
/// data field as the HTTP body for delivery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderPushConfigNoWrapper
{
    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If specified, Pub/Sub will generate and attach an OIDC JWT token as
/// an Authorization header in the HTTP request for every pushed message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderPushConfigOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. The audience claim
    /// identifies the recipients that the JWT is intended for. The audience
    /// value is a single case-sensitive string. Having multiple values (array)
    /// for the audience field is not supported. More info about the OIDC JWT
    /// token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3
    /// Note: if not specified, the Push endpoint URL will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating the OIDC token.
    /// The caller (for subscriptions.create, subscriptions.patch, and
    /// subscriptions.modifyPushConfig RPCs) must have the
    /// iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// If push delivery is used with this subscription, this field is used to
/// configure it. An empty pushConfig signifies that the subscriber will
/// pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderPushConfig
{
    /// <summary>
    /// Endpoint configuration attributes.
    /// Every endpoint has a set of API supported attributes that can
    /// be used to control different aspects of the message delivery.
    /// The currently supported attribute is x-goog-version, which you
    /// can use to change the format of the pushed message. This
    /// attribute indicates the version of the data expected by
    /// the endpoint. This controls the shape of the pushed message
    /// (i.e., its fields and metadata). The endpoint version is
    /// based on the version of the Pub/Sub API.
    /// If not present during the subscriptions.create call,
    /// it will default to the version of the API used to make
    /// such call. If not present during a subscriptions.modifyPushConfig
    /// call, its value will not be changed. subscriptions.get
    /// calls will always return a valid version, even if the
    /// subscription was created without this attribute.
    /// The possible values for this attribute are:
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// When set, the payload to the push endpoint is not wrapped.Sets the
    /// data field as the HTTP body for delivery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("noWrapper")]
    public V1beta2SubscriptionSpecInitProviderPushConfigNoWrapper? NoWrapper { get; set; }

    /// <summary>
    /// If specified, Pub/Sub will generate and attach an OIDC JWT token as
    /// an Authorization header in the HTTP request for every pushed message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2SubscriptionSpecInitProviderPushConfigOidcToken? OidcToken { get; set; }

    /// <summary>
    /// A URL locating the endpoint to which messages should be pushed.
    /// For example, a Webhook endpoint might use
    /// &quot;https://example.com/push&quot;.
    /// </summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary>
/// A policy that specifies how Pub/Sub retries message delivery for this subscription.
/// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
/// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderRetryPolicy
{
    /// <summary>
    /// The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>
    /// The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecInitProviderTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecInitProviderTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecInitProviderTopicSelector
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
    public V1beta2SubscriptionSpecInitProviderTopicSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2SubscriptionSpecInitProvider
{
    /// <summary>
    /// This value is the maximum time after a subscriber receives a message
    /// before the subscriber should acknowledge the message. After message
    /// delivery but before the ack deadline expires and before the message is
    /// acknowledged, it is an outstanding message and will not be delivered
    /// again during that time (on a best-effort basis).
    /// For pull subscriptions, this value is used as the initial value for
    /// the ack deadline. To override this value for a given message, call
    /// subscriptions.modifyAckDeadline with the corresponding ackId if using
    /// pull. The minimum custom deadline you can specify is 10 seconds. The
    /// maximum custom deadline you can specify is 600 seconds (10 minutes).
    /// If this parameter is 0, a default value of 10 seconds is used.
    /// For push delivery, this value is also used to set the request timeout
    /// for the call to the push endpoint.
    /// If the subscriber never acknowledges the message, the Pub/Sub system
    /// will eventually redeliver the message.
    /// </summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>
    /// If delivery to BigQuery is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryConfig")]
    public V1beta2SubscriptionSpecInitProviderBigqueryConfig? BigqueryConfig { get; set; }

    /// <summary>
    /// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageConfig")]
    public V1beta2SubscriptionSpecInitProviderCloudStorageConfig? CloudStorageConfig { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for dead lettering messages in
    /// this subscription. If dead_letter_policy is not set, dead lettering
    /// is disabled.
    /// The Cloud Pub/Sub service account associated with this subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Acknowledge() messages on this subscription.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deadLetterPolicy")]
    public V1beta2SubscriptionSpecInitProviderDeadLetterPolicy? DeadLetterPolicy { get; set; }

    /// <summary>
    /// If true, Pub/Sub provides the following guarantees for the delivery
    /// of a message with a given value of messageId on this Subscriptions&apos;:
    /// </summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>
    /// If true, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for this subscription&apos;s expiration.
    /// A subscription is considered active as long as any connected subscriber
    /// is successfully consuming messages from the subscription or is issuing
    /// operations on the subscription. If expirationPolicy is not set, a default
    /// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
    /// resource never expires.  The minimum allowed value for expirationPolicy.ttl
    /// is 1 day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expirationPolicy")]
    public V1beta2SubscriptionSpecInitProviderExpirationPolicy? ExpirationPolicy { get; set; }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&apos;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&apos;t modify the filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// How long to retain unacknowledged messages in the subscription&apos;s
    /// backlog, from the moment a message is published. If
    /// retain_acked_messages is true, then this also configures the retention
    /// of acknowledged messages, and thus configures how far back in time a
    /// subscriptions.seek can be done. Defaults to 7 days. Cannot be more
    /// than 31 days (&quot;2678400s&quot;) or less than 10 minutes (&quot;600s&quot;).
    /// A duration in seconds with up to nine fractional digits, terminated
    /// by &apos;s&apos;. Example: &quot;600.5s&quot;.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2SubscriptionSpecInitProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// If push delivery is used with this subscription, this field is used to
    /// configure it. An empty pushConfig signifies that the subscriber will
    /// pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pushConfig")]
    public V1beta2SubscriptionSpecInitProviderPushConfig? PushConfig { get; set; }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If true, then
    /// messages are not expunged from the subscription&apos;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery for this subscription.
    /// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
    /// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2SubscriptionSpecInitProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2SubscriptionSpecInitProviderTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2SubscriptionSpecInitProviderTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecManagementPoliciesEnum>))]
public enum V1beta2SubscriptionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionSpec
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
    public V1beta2SubscriptionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SubscriptionSpecForProvider ForProvider { get; set; }

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
    public V1beta2SubscriptionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SubscriptionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// If delivery to BigQuery is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderBigqueryConfig
{
    /// <summary>
    /// When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that
    /// are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync
    /// and any messages with extra fields are not written and remain in the subscription&apos;s backlog.
    /// </summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>
    /// The service account to use to write to BigQuery. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>
    /// When true, use the BigQuery table&apos;s schema as the columns to write to in BigQuery. Messages
    /// must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table.
    /// The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If set, message data will be written to Cloud Storage in Avro format.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderCloudStorageConfigAvroConfig
{
    /// <summary>
    /// When true, use the topic&apos;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
/// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
/// If all three are empty, then the subscriber will pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderCloudStorageConfig
{
    /// <summary>
    /// If set, message data will be written to Cloud Storage in Avro format.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("avroConfig")]
    public V1beta2SubscriptionStatusAtProviderCloudStorageConfigAvroConfig? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &quot;gs://&quot;.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in &quot;/&quot;.</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>
    /// The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB.
    /// The maxBytes limit may be exceeded in cases where messages are larger than the limit.
    /// </summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>
    /// The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes.
    /// May not exceed the subscription&apos;s acknowledgement deadline.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>
    /// The service account to use to write to Cloud Storage. If not specified, the Pub/Sub
    /// service agent,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// (Output)
    /// An output-only field that indicates whether or not the subscription can receive messages.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for dead lettering messages in
/// this subscription. If dead_letter_policy is not set, dead lettering
/// is disabled.
/// The Cloud Pub/Sub service account associated with this subscription&apos;s
/// parent project (i.e.,
/// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
/// permission to Acknowledge() messages on this subscription.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderDeadLetterPolicy
{
    /// <summary>
    /// The name of the topic to which dead letter messages should be published.
    /// Format is projects/{project}/topics/{topic}.
    /// The Cloud Pub/Sub service account associated with the enclosing subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Publish() to this topic.
    /// The operation will fail if the topic does not exist.
    /// Users should ensure that there is a subscription attached to this topic
    /// since messages published to a topic with no subscriptions are lost.
    /// </summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must be
    /// between 5 and 100.
    /// The number of delivery attempts is defined as 1 + (the sum of number of
    /// NACKs and number of times the acknowledgement deadline has been exceeded for the message).
    /// A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that
    /// client libraries may automatically extend ack_deadlines.
    /// This field will be honored on a best effort basis.
    /// If this parameter is 0, a default value of 5 is used.
    /// </summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// A policy that specifies the conditions for this subscription&apos;s expiration.
/// A subscription is considered active as long as any connected subscriber
/// is successfully consuming messages from the subscription or is issuing
/// operations on the subscription. If expirationPolicy is not set, a default
/// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
/// resource never expires.  The minimum allowed value for expirationPolicy.ttl
/// is 1 day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderExpirationPolicy
{
    /// <summary>
    /// Specifies the &quot;time-to-live&quot; duration for an associated resource. The
    /// resource expires if it is not active for a period of ttl.
    /// If ttl is set to &quot; &quot;, the associated resource never expires.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example - &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderMessageTransformsJavascriptUdf
{
    /// <summary>
    /// JavaScript code that contains a function function_name with the
    /// following signature:
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderMessageTransforms
{
    /// <summary>
    /// Controls whether or not to use this transform. If not set or false,
    /// the transform will be applied to messages. Default: true.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
    /// each one must have a unique function_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("javascriptUdf")]
    public V1beta2SubscriptionStatusAtProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// When set, the payload to the push endpoint is not wrapped.Sets the
/// data field as the HTTP body for delivery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderPushConfigNoWrapper
{
    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>
/// If specified, Pub/Sub will generate and attach an OIDC JWT token as
/// an Authorization header in the HTTP request for every pushed message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderPushConfigOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. The audience claim
    /// identifies the recipients that the JWT is intended for. The audience
    /// value is a single case-sensitive string. Having multiple values (array)
    /// for the audience field is not supported. More info about the OIDC JWT
    /// token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3
    /// Note: if not specified, the Push endpoint URL will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating the OIDC token.
    /// The caller (for subscriptions.create, subscriptions.patch, and
    /// subscriptions.modifyPushConfig RPCs) must have the
    /// iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// If push delivery is used with this subscription, this field is used to
/// configure it. An empty pushConfig signifies that the subscriber will
/// pull and ack messages using API methods.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderPushConfig
{
    /// <summary>
    /// Endpoint configuration attributes.
    /// Every endpoint has a set of API supported attributes that can
    /// be used to control different aspects of the message delivery.
    /// The currently supported attribute is x-goog-version, which you
    /// can use to change the format of the pushed message. This
    /// attribute indicates the version of the data expected by
    /// the endpoint. This controls the shape of the pushed message
    /// (i.e., its fields and metadata). The endpoint version is
    /// based on the version of the Pub/Sub API.
    /// If not present during the subscriptions.create call,
    /// it will default to the version of the API used to make
    /// such call. If not present during a subscriptions.modifyPushConfig
    /// call, its value will not be changed. subscriptions.get
    /// calls will always return a valid version, even if the
    /// subscription was created without this attribute.
    /// The possible values for this attribute are:
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// When set, the payload to the push endpoint is not wrapped.Sets the
    /// data field as the HTTP body for delivery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("noWrapper")]
    public V1beta2SubscriptionStatusAtProviderPushConfigNoWrapper? NoWrapper { get; set; }

    /// <summary>
    /// If specified, Pub/Sub will generate and attach an OIDC JWT token as
    /// an Authorization header in the HTTP request for every pushed message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2SubscriptionStatusAtProviderPushConfigOidcToken? OidcToken { get; set; }

    /// <summary>
    /// A URL locating the endpoint to which messages should be pushed.
    /// For example, a Webhook endpoint might use
    /// &quot;https://example.com/push&quot;.
    /// </summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary>
/// A policy that specifies how Pub/Sub retries message delivery for this subscription.
/// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
/// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProviderRetryPolicy
{
    /// <summary>
    /// The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>
    /// The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusAtProvider
{
    /// <summary>
    /// This value is the maximum time after a subscriber receives a message
    /// before the subscriber should acknowledge the message. After message
    /// delivery but before the ack deadline expires and before the message is
    /// acknowledged, it is an outstanding message and will not be delivered
    /// again during that time (on a best-effort basis).
    /// For pull subscriptions, this value is used as the initial value for
    /// the ack deadline. To override this value for a given message, call
    /// subscriptions.modifyAckDeadline with the corresponding ackId if using
    /// pull. The minimum custom deadline you can specify is 10 seconds. The
    /// maximum custom deadline you can specify is 600 seconds (10 minutes).
    /// If this parameter is 0, a default value of 10 seconds is used.
    /// For push delivery, this value is also used to set the request timeout
    /// for the call to the push endpoint.
    /// If the subscriber never acknowledges the message, the Pub/Sub system
    /// will eventually redeliver the message.
    /// </summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>
    /// If delivery to BigQuery is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryConfig")]
    public V1beta2SubscriptionStatusAtProviderBigqueryConfig? BigqueryConfig { get; set; }

    /// <summary>
    /// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageConfig")]
    public V1beta2SubscriptionStatusAtProviderCloudStorageConfig? CloudStorageConfig { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for dead lettering messages in
    /// this subscription. If dead_letter_policy is not set, dead lettering
    /// is disabled.
    /// The Cloud Pub/Sub service account associated with this subscription&apos;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Acknowledge() messages on this subscription.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deadLetterPolicy")]
    public V1beta2SubscriptionStatusAtProviderDeadLetterPolicy? DeadLetterPolicy { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// If true, Pub/Sub provides the following guarantees for the delivery
    /// of a message with a given value of messageId on this Subscriptions&apos;:
    /// </summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>
    /// If true, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>
    /// A policy that specifies the conditions for this subscription&apos;s expiration.
    /// A subscription is considered active as long as any connected subscriber
    /// is successfully consuming messages from the subscription or is issuing
    /// operations on the subscription. If expirationPolicy is not set, a default
    /// policy with ttl of 31 days will be used.  If it is set but ttl is &quot; &quot;, the
    /// resource never expires.  The minimum allowed value for expirationPolicy.ttl
    /// is 1 day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expirationPolicy")]
    public V1beta2SubscriptionStatusAtProviderExpirationPolicy? ExpirationPolicy { get; set; }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&apos;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&apos;t modify the filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/subscriptions/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// How long to retain unacknowledged messages in the subscription&apos;s
    /// backlog, from the moment a message is published. If
    /// retain_acked_messages is true, then this also configures the retention
    /// of acknowledged messages, and thus configures how far back in time a
    /// subscriptions.seek can be done. Defaults to 7 days. Cannot be more
    /// than 31 days (&quot;2678400s&quot;) or less than 10 minutes (&quot;600s&quot;).
    /// A duration in seconds with up to nine fractional digits, terminated
    /// by &apos;s&apos;. Example: &quot;600.5s&quot;.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2SubscriptionStatusAtProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// If push delivery is used with this subscription, this field is used to
    /// configure it. An empty pushConfig signifies that the subscriber will
    /// pull and ack messages using API methods.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pushConfig")]
    public V1beta2SubscriptionStatusAtProviderPushConfig? PushConfig { get; set; }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If true, then
    /// messages are not expunged from the subscription&apos;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery for this subscription.
    /// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
    /// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2SubscriptionStatusAtProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatusConditions
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

/// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subscription is the Schema for the Subscriptions API. A named resource representing the stream of messages from a single, specific topic, to be delivered to the subscribing application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SubscriptionSpec>, IStatus<V1beta2SubscriptionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Subscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SubscriptionSpec Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
    [JsonPropertyName("status")]
    public V1beta2SubscriptionStatus? Status { get; set; }
}