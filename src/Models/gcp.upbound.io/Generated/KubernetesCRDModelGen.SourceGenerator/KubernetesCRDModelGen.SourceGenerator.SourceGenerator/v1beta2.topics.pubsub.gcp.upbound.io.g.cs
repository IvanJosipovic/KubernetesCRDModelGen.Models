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
/// <summary>Topic is the Schema for the Topics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TopicList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Topic>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TopicList";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Topic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Topic> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecDeletionPolicyEnum>))]
public enum V1beta2TopicSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Settings for ingestion from Amazon Kinesis Data Streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>
    /// The Kinesis consumer ARN to used for ingestion in
    /// Enhanced Fan-Out mode. The consumer must be already
    /// created and ready to be used.
    /// </summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary>
/// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for ingestion from Azure Event Hubs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Configuration for reading Cloud Storage data in Avro binary format. The
/// bytes of each object will be set to the data field of a Pub/Sub message.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data written via Cloud Storage
/// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
/// data and attributes fields of the originally exported Pub/Sub message
/// will be restored when publishing.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data in text format. Each line of
/// text as specified by the delimiter will be set to the data field of a
/// Pub/Sub message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>
    /// The delimiter to use when using the &apos;text&apos; format. Each line of text as
    /// specified by the delimiter will be set to the &apos;data&apos; field of a Pub/Sub
    /// message. When unset, &apos;\n&apos; is used.
    /// </summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary>
/// Settings for ingestion from Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>
    /// Configuration for reading Cloud Storage data in Avro binary format. The
    /// bytes of each object will be set to the data field of a Pub/Sub message.
    /// </summary>
    [JsonPropertyName("avroFormat")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorageAvroFormat? AvroFormat { get; set; }

    /// <summary>
    /// Cloud Storage bucket. The bucket name must be without any
    /// prefix like &quot;gs://&quot;. See the bucket naming requirements:
    /// https://cloud.google.com/storage/docs/buckets#naming.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Glob pattern used to match objects that will be ingested. If unset, all
    /// objects will be ingested. See the supported patterns:
    /// https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob
    /// </summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>
    /// The timestamp set in RFC3339 text format. If set, only objects with a
    /// larger or equal timestamp will be ingested. Unset by default, meaning
    /// all objects will be ingested.
    /// </summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data written via Cloud Storage
    /// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
    /// data and attributes fields of the originally exported Pub/Sub message
    /// will be restored when publishing.
    /// </summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat? PubsubAvroFormat { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data in text format. Each line of
    /// text as specified by the delimiter will be set to the data field of a
    /// Pub/Sub message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textFormat")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorageTextFormat? TextFormat { get; set; }
}

/// <summary>
/// Settings for ingestion from Confluent Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
/// no Platform Logs will be generated.&apos;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>
    /// The minimum severity level of Platform Logs that will be written. If unspecified,
    /// no Platform Logs will be written.
    /// Default value is SEVERITY_UNSPECIFIED.
    /// Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>
/// Settings for ingestion from a data source into this topic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderIngestionDataSourceSettings
{
    /// <summary>
    /// Settings for ingestion from Amazon Kinesis Data Streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsKinesis")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsAwsKinesis? AwsKinesis { get; set; }

    /// <summary>
    /// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsMsk")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsAwsMsk? AwsMsk { get; set; }

    /// <summary>
    /// Settings for ingestion from Azure Event Hubs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azureEventHubs")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsAzureEventHubs? AzureEventHubs { get; set; }

    /// <summary>
    /// Settings for ingestion from Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorage")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsCloudStorage? CloudStorage { get; set; }

    /// <summary>
    /// Settings for ingestion from Confluent Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("confluentCloud")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsConfluentCloud? ConfluentCloud { get; set; }

    /// <summary>
    /// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
    /// no Platform Logs will be generated.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("platformLogsSettings")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettingsPlatformLogsSettings? PlatformLogsSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecForProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderKmsKeyNameSelector
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
    public V1beta2TopicSpecForProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Policy constraining the set of Google Cloud Platform regions where
/// messages published to the topic may be stored. If not present, then no
/// constraints are in effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageStoragePolicy
{
    /// <summary>
    /// A list of IDs of GCP regions where messages that are published to
    /// the topic may be persisted in storage. Messages published by
    /// publishers running in non-allowed GCP regions (or running outside
    /// of GCP altogether) will be routed for storage in one of the
    /// allowed regions. An empty list means that no regions are allowed,
    /// and is not a valid configuration.
    /// </summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>
    /// If true, allowedPersistenceRegions is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in allowedPersistenceRegions.
    /// </summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelector
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
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for making inferences using arbitrary JSON payloads.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInferenceUnstructuredInference
{
    /// <summary>
    /// A parameters object to be included in each inference request.
    /// The parameters object is combined with the data field of the Pub/Sub
    /// message to form the inference request.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>
/// AI Inference. Specifies the Vertex AI endpoint that inference
/// requests built from the Pub/Sub message data and provided parameters will
/// be sent to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsAiInference
{
    /// <summary>
    /// The endpoint to a Vertex AI model of the form
    /// projects/{project}/locations/{location}/endpoints/{endpoint} or
    /// projects/{project}/locations/{location}/publishers/{publisher}/models/{model}.
    /// Vertex AI API requests will be sent to this endpoint.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The service account to use to make prediction requests against
    /// endpoints.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// Configuration for making inferences using arbitrary JSON payloads.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unstructuredInference")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInferenceUnstructuredInference? UnstructuredInference { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransformsJavascriptUdf
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderMessageTransforms
{
    /// <summary>
    /// AI Inference. Specifies the Vertex AI endpoint that inference
    /// requests built from the Pub/Sub message data and provided parameters will
    /// be sent to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiInference")]
    public V1beta2TopicSpecForProviderMessageTransformsAiInference? AiInference { get; set; }

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
    public V1beta2TopicSpecForProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Schema in pubsub to populate firstRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Schema in pubsub to populate firstRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelector
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
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Schema in pubsub to populate lastRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Schema in pubsub to populate lastRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelector
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
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Settings for validating messages published against a schema.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProviderSchemaSettings
{
    /// <summary>
    /// The encoding of messages validated against schema.
    /// Default value is ENCODING_UNSPECIFIED.
    /// Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The minimum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against last_revision or any revision created before.</summary>
    [JsonPropertyName("firstRevisionId")]
    public string? FirstRevisionId { get; set; }

    /// <summary>Reference to a Schema in pubsub to populate firstRevisionId.</summary>
    [JsonPropertyName("firstRevisionIdRef")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdRef? FirstRevisionIdRef { get; set; }

    /// <summary>Selector for a Schema in pubsub to populate firstRevisionId.</summary>
    [JsonPropertyName("firstRevisionIdSelector")]
    public V1beta2TopicSpecForProviderSchemaSettingsFirstRevisionIdSelector? FirstRevisionIdSelector { get; set; }

    /// <summary>The maximum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against first_revision or any revision created after.</summary>
    [JsonPropertyName("lastRevisionId")]
    public string? LastRevisionId { get; set; }

    /// <summary>Reference to a Schema in pubsub to populate lastRevisionId.</summary>
    [JsonPropertyName("lastRevisionIdRef")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdRef? LastRevisionIdRef { get; set; }

    /// <summary>Selector for a Schema in pubsub to populate lastRevisionId.</summary>
    [JsonPropertyName("lastRevisionIdSelector")]
    public V1beta2TopicSpecForProviderSchemaSettingsLastRevisionIdSelector? LastRevisionIdSelector { get; set; }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be deleted-schema
    /// if the schema has been deleted.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecForProvider
{
    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public V1beta2TopicSpecForProviderIngestionDataSourceSettings? IngestionDataSourceSettings { get; set; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&apos;s PubSub service account
    /// (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta2TopicSpecForProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta2TopicSpecForProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Indicates the minimum duration to retain a message after it is published
    /// to the topic. If this field is set, messages published to the topic in
    /// the last messageRetentionDuration are always available to subscribers.
    /// For instance, it allows any attached subscription to seek to a timestamp
    /// that is up to messageRetentionDuration in the past. If this field is not
    /// set, message retention is controlled by settings on individual subscriptions.
    /// The rotation period has the format of a decimal number, followed by the
    /// letter s (seconds). Cannot be more than 31 days or less than 10 minutes.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageStoragePolicy")]
    public V1beta2TopicSpecForProviderMessageStoragePolicy? MessageStoragePolicy { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2TopicSpecForProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemaSettings")]
    public V1beta2TopicSpecForProviderSchemaSettings? SchemaSettings { get; set; }

    /// <summary>
    /// Input only. Resource manager tags to be bound to the topic. Tag keys and
    /// values have the same definition as resource manager tags. Keys must be in
    /// the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the google_tags_tag_value
    /// resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Settings for ingestion from Amazon Kinesis Data Streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>
    /// The Kinesis consumer ARN to used for ingestion in
    /// Enhanced Fan-Out mode. The consumer must be already
    /// created and ready to be used.
    /// </summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary>
/// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for ingestion from Azure Event Hubs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Configuration for reading Cloud Storage data in Avro binary format. The
/// bytes of each object will be set to the data field of a Pub/Sub message.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data written via Cloud Storage
/// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
/// data and attributes fields of the originally exported Pub/Sub message
/// will be restored when publishing.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data in text format. Each line of
/// text as specified by the delimiter will be set to the data field of a
/// Pub/Sub message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>
    /// The delimiter to use when using the &apos;text&apos; format. Each line of text as
    /// specified by the delimiter will be set to the &apos;data&apos; field of a Pub/Sub
    /// message. When unset, &apos;\n&apos; is used.
    /// </summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary>
/// Settings for ingestion from Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>
    /// Configuration for reading Cloud Storage data in Avro binary format. The
    /// bytes of each object will be set to the data field of a Pub/Sub message.
    /// </summary>
    [JsonPropertyName("avroFormat")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageAvroFormat? AvroFormat { get; set; }

    /// <summary>
    /// Cloud Storage bucket. The bucket name must be without any
    /// prefix like &quot;gs://&quot;. See the bucket naming requirements:
    /// https://cloud.google.com/storage/docs/buckets#naming.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Glob pattern used to match objects that will be ingested. If unset, all
    /// objects will be ingested. See the supported patterns:
    /// https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob
    /// </summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>
    /// The timestamp set in RFC3339 text format. If set, only objects with a
    /// larger or equal timestamp will be ingested. Unset by default, meaning
    /// all objects will be ingested.
    /// </summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data written via Cloud Storage
    /// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
    /// data and attributes fields of the originally exported Pub/Sub message
    /// will be restored when publishing.
    /// </summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat? PubsubAvroFormat { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data in text format. Each line of
    /// text as specified by the delimiter will be set to the data field of a
    /// Pub/Sub message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textFormat")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageTextFormat? TextFormat { get; set; }
}

/// <summary>
/// Settings for ingestion from Confluent Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
/// no Platform Logs will be generated.&apos;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>
    /// The minimum severity level of Platform Logs that will be written. If unspecified,
    /// no Platform Logs will be written.
    /// Default value is SEVERITY_UNSPECIFIED.
    /// Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>
/// Settings for ingestion from a data source into this topic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderIngestionDataSourceSettings
{
    /// <summary>
    /// Settings for ingestion from Amazon Kinesis Data Streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsKinesis")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAwsKinesis? AwsKinesis { get; set; }

    /// <summary>
    /// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsMsk")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAwsMsk? AwsMsk { get; set; }

    /// <summary>
    /// Settings for ingestion from Azure Event Hubs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azureEventHubs")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsAzureEventHubs? AzureEventHubs { get; set; }

    /// <summary>
    /// Settings for ingestion from Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorage")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsCloudStorage? CloudStorage { get; set; }

    /// <summary>
    /// Settings for ingestion from Confluent Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("confluentCloud")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsConfluentCloud? ConfluentCloud { get; set; }

    /// <summary>
    /// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
    /// no Platform Logs will be generated.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("platformLogsSettings")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettingsPlatformLogsSettings? PlatformLogsSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecInitProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderKmsKeyNameSelector
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
    public V1beta2TopicSpecInitProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Policy constraining the set of Google Cloud Platform regions where
/// messages published to the topic may be stored. If not present, then no
/// constraints are in effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageStoragePolicy
{
    /// <summary>
    /// A list of IDs of GCP regions where messages that are published to
    /// the topic may be persisted in storage. Messages published by
    /// publishers running in non-allowed GCP regions (or running outside
    /// of GCP altogether) will be routed for storage in one of the
    /// allowed regions. An empty list means that no regions are allowed,
    /// and is not a valid configuration.
    /// </summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>
    /// If true, allowedPersistenceRegions is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in allowedPersistenceRegions.
    /// </summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelector
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
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for making inferences using arbitrary JSON payloads.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInferenceUnstructuredInference
{
    /// <summary>
    /// A parameters object to be included in each inference request.
    /// The parameters object is combined with the data field of the Pub/Sub
    /// message to form the inference request.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>
/// AI Inference. Specifies the Vertex AI endpoint that inference
/// requests built from the Pub/Sub message data and provided parameters will
/// be sent to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsAiInference
{
    /// <summary>
    /// The endpoint to a Vertex AI model of the form
    /// projects/{project}/locations/{location}/endpoints/{endpoint} or
    /// projects/{project}/locations/{location}/publishers/{publisher}/models/{model}.
    /// Vertex AI API requests will be sent to this endpoint.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The service account to use to make prediction requests against
    /// endpoints.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// Configuration for making inferences using arbitrary JSON payloads.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unstructuredInference")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInferenceUnstructuredInference? UnstructuredInference { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransformsJavascriptUdf
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderMessageTransforms
{
    /// <summary>
    /// AI Inference. Specifies the Vertex AI endpoint that inference
    /// requests built from the Pub/Sub message data and provided parameters will
    /// be sent to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiInference")]
    public V1beta2TopicSpecInitProviderMessageTransformsAiInference? AiInference { get; set; }

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
    public V1beta2TopicSpecInitProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Schema in pubsub to populate firstRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Schema in pubsub to populate firstRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelector
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
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Schema in pubsub to populate lastRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum>))]
public enum V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Schema in pubsub to populate lastRevisionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelector
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
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Settings for validating messages published against a schema.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProviderSchemaSettings
{
    /// <summary>
    /// The encoding of messages validated against schema.
    /// Default value is ENCODING_UNSPECIFIED.
    /// Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The minimum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against last_revision or any revision created before.</summary>
    [JsonPropertyName("firstRevisionId")]
    public string? FirstRevisionId { get; set; }

    /// <summary>Reference to a Schema in pubsub to populate firstRevisionId.</summary>
    [JsonPropertyName("firstRevisionIdRef")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdRef? FirstRevisionIdRef { get; set; }

    /// <summary>Selector for a Schema in pubsub to populate firstRevisionId.</summary>
    [JsonPropertyName("firstRevisionIdSelector")]
    public V1beta2TopicSpecInitProviderSchemaSettingsFirstRevisionIdSelector? FirstRevisionIdSelector { get; set; }

    /// <summary>The maximum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against first_revision or any revision created after.</summary>
    [JsonPropertyName("lastRevisionId")]
    public string? LastRevisionId { get; set; }

    /// <summary>Reference to a Schema in pubsub to populate lastRevisionId.</summary>
    [JsonPropertyName("lastRevisionIdRef")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdRef? LastRevisionIdRef { get; set; }

    /// <summary>Selector for a Schema in pubsub to populate lastRevisionId.</summary>
    [JsonPropertyName("lastRevisionIdSelector")]
    public V1beta2TopicSpecInitProviderSchemaSettingsLastRevisionIdSelector? LastRevisionIdSelector { get; set; }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be deleted-schema
    /// if the schema has been deleted.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecInitProvider
{
    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public V1beta2TopicSpecInitProviderIngestionDataSourceSettings? IngestionDataSourceSettings { get; set; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&apos;s PubSub service account
    /// (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta2TopicSpecInitProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta2TopicSpecInitProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Indicates the minimum duration to retain a message after it is published
    /// to the topic. If this field is set, messages published to the topic in
    /// the last messageRetentionDuration are always available to subscribers.
    /// For instance, it allows any attached subscription to seek to a timestamp
    /// that is up to messageRetentionDuration in the past. If this field is not
    /// set, message retention is controlled by settings on individual subscriptions.
    /// The rotation period has the format of a decimal number, followed by the
    /// letter s (seconds). Cannot be more than 31 days or less than 10 minutes.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageStoragePolicy")]
    public V1beta2TopicSpecInitProviderMessageStoragePolicy? MessageStoragePolicy { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2TopicSpecInitProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemaSettings")]
    public V1beta2TopicSpecInitProviderSchemaSettings? SchemaSettings { get; set; }

    /// <summary>
    /// Input only. Resource manager tags to be bound to the topic. Tag keys and
    /// values have the same definition as resource manager tags. Keys must be in
    /// the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the google_tags_tag_value
    /// resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecManagementPoliciesEnum>))]
public enum V1beta2TopicSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TopicSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TopicSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TopicSpec defines the desired state of Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicSpec
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
    public V1beta2TopicSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TopicSpecForProvider ForProvider { get; set; }

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
    public V1beta2TopicSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2TopicSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Settings for ingestion from Amazon Kinesis Data Streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>
    /// The Kinesis consumer ARN to used for ingestion in
    /// Enhanced Fan-Out mode. The consumer must be already
    /// created and ready to be used.
    /// </summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary>
/// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for ingestion from Azure Event Hubs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Configuration for reading Cloud Storage data in Avro binary format. The
/// bytes of each object will be set to the data field of a Pub/Sub message.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data written via Cloud Storage
/// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
/// data and attributes fields of the originally exported Pub/Sub message
/// will be restored when publishing.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary>
/// Configuration for reading Cloud Storage data in text format. Each line of
/// text as specified by the delimiter will be set to the data field of a
/// Pub/Sub message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>
    /// The delimiter to use when using the &apos;text&apos; format. Each line of text as
    /// specified by the delimiter will be set to the &apos;data&apos; field of a Pub/Sub
    /// message. When unset, &apos;\n&apos; is used.
    /// </summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary>
/// Settings for ingestion from Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>
    /// Configuration for reading Cloud Storage data in Avro binary format. The
    /// bytes of each object will be set to the data field of a Pub/Sub message.
    /// </summary>
    [JsonPropertyName("avroFormat")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageAvroFormat? AvroFormat { get; set; }

    /// <summary>
    /// Cloud Storage bucket. The bucket name must be without any
    /// prefix like &quot;gs://&quot;. See the bucket naming requirements:
    /// https://cloud.google.com/storage/docs/buckets#naming.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Glob pattern used to match objects that will be ingested. If unset, all
    /// objects will be ingested. See the supported patterns:
    /// https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob
    /// </summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>
    /// The timestamp set in RFC3339 text format. If set, only objects with a
    /// larger or equal timestamp will be ingested. Unset by default, meaning
    /// all objects will be ingested.
    /// </summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data written via Cloud Storage
    /// subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The
    /// data and attributes fields of the originally exported Pub/Sub message
    /// will be restored when publishing.
    /// </summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat? PubsubAvroFormat { get; set; }

    /// <summary>
    /// Configuration for reading Cloud Storage data in text format. Each line of
    /// text as specified by the delimiter will be set to the data field of a
    /// Pub/Sub message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textFormat")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageTextFormat? TextFormat { get; set; }
}

/// <summary>
/// Settings for ingestion from Confluent Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
/// no Platform Logs will be generated.&apos;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>
    /// The minimum severity level of Platform Logs that will be written. If unspecified,
    /// no Platform Logs will be written.
    /// Default value is SEVERITY_UNSPECIFIED.
    /// Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>
/// Settings for ingestion from a data source into this topic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderIngestionDataSourceSettings
{
    /// <summary>
    /// Settings for ingestion from Amazon Kinesis Data Streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsKinesis")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAwsKinesis? AwsKinesis { get; set; }

    /// <summary>
    /// Settings for ingestion from Amazon Managed Streaming for Apache Kafka.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsMsk")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAwsMsk? AwsMsk { get; set; }

    /// <summary>
    /// Settings for ingestion from Azure Event Hubs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azureEventHubs")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsAzureEventHubs? AzureEventHubs { get; set; }

    /// <summary>
    /// Settings for ingestion from Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorage")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsCloudStorage? CloudStorage { get; set; }

    /// <summary>
    /// Settings for ingestion from Confluent Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("confluentCloud")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsConfluentCloud? ConfluentCloud { get; set; }

    /// <summary>
    /// Settings for Platform Logs regarding ingestion to Pub/Sub. If unset,
    /// no Platform Logs will be generated.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("platformLogsSettings")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettingsPlatformLogsSettings? PlatformLogsSettings { get; set; }
}

/// <summary>
/// Policy constraining the set of Google Cloud Platform regions where
/// messages published to the topic may be stored. If not present, then no
/// constraints are in effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderMessageStoragePolicy
{
    /// <summary>
    /// A list of IDs of GCP regions where messages that are published to
    /// the topic may be persisted in storage. Messages published by
    /// publishers running in non-allowed GCP regions (or running outside
    /// of GCP altogether) will be routed for storage in one of the
    /// allowed regions. An empty list means that no regions are allowed,
    /// and is not a valid configuration.
    /// </summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>
    /// If true, allowedPersistenceRegions is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in allowedPersistenceRegions.
    /// </summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary>
/// Configuration for making inferences using arbitrary JSON payloads.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderMessageTransformsAiInferenceUnstructuredInference
{
    /// <summary>
    /// A parameters object to be included in each inference request.
    /// The parameters object is combined with the data field of the Pub/Sub
    /// message to form the inference request.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>
/// AI Inference. Specifies the Vertex AI endpoint that inference
/// requests built from the Pub/Sub message data and provided parameters will
/// be sent to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderMessageTransformsAiInference
{
    /// <summary>
    /// The endpoint to a Vertex AI model of the form
    /// projects/{project}/locations/{location}/endpoints/{endpoint} or
    /// projects/{project}/locations/{location}/publishers/{publisher}/models/{model}.
    /// Vertex AI API requests will be sent to this endpoint.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The service account to use to make prediction requests against
    /// endpoints.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// Configuration for making inferences using arbitrary JSON payloads.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unstructuredInference")]
    public V1beta2TopicStatusAtProviderMessageTransformsAiInferenceUnstructuredInference? UnstructuredInference { get; set; }
}

/// <summary>
/// Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource,
/// each one must have a unique function_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderMessageTransformsJavascriptUdf
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderMessageTransforms
{
    /// <summary>
    /// AI Inference. Specifies the Vertex AI endpoint that inference
    /// requests built from the Pub/Sub message data and provided parameters will
    /// be sent to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiInference")]
    public V1beta2TopicStatusAtProviderMessageTransformsAiInference? AiInference { get; set; }

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
    public V1beta2TopicStatusAtProviderMessageTransformsJavascriptUdf? JavascriptUdf { get; set; }
}

/// <summary>
/// Settings for validating messages published against a schema.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProviderSchemaSettings
{
    /// <summary>
    /// The encoding of messages validated against schema.
    /// Default value is ENCODING_UNSPECIFIED.
    /// Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The minimum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against last_revision or any revision created before.</summary>
    [JsonPropertyName("firstRevisionId")]
    public string? FirstRevisionId { get; set; }

    /// <summary>The maximum (inclusive) revision allowed for validating messages. If empty or not present, allow any revision to be validated against first_revision or any revision created after.</summary>
    [JsonPropertyName("lastRevisionId")]
    public string? LastRevisionId { get; set; }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be deleted-schema
    /// if the schema has been deleted.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusAtProvider
{
    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/topics/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public V1beta2TopicStatusAtProviderIngestionDataSourceSettings? IngestionDataSourceSettings { get; set; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&apos;s PubSub service account
    /// (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Indicates the minimum duration to retain a message after it is published
    /// to the topic. If this field is set, messages published to the topic in
    /// the last messageRetentionDuration are always available to subscribers.
    /// For instance, it allows any attached subscription to seek to a timestamp
    /// that is up to messageRetentionDuration in the past. If this field is not
    /// set, message retention is controlled by settings on individual subscriptions.
    /// The rotation period has the format of a decimal number, followed by the
    /// letter s (seconds). Cannot be more than 31 days or less than 10 minutes.
    /// </summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageStoragePolicy")]
    public V1beta2TopicStatusAtProviderMessageStoragePolicy? MessageStoragePolicy { get; set; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta2TopicStatusAtProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemaSettings")]
    public V1beta2TopicStatusAtProviderSchemaSettings? SchemaSettings { get; set; }

    /// <summary>
    /// Input only. Resource manager tags to be bound to the topic. Tag keys and
    /// values have the same definition as resource manager tags. Keys must be in
    /// the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the google_tags_tag_value
    /// resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatusConditions
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

/// <summary>TopicStatus defines the observed state of Topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TopicStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Topic is the Schema for the Topics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Topic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TopicSpec>, IStatus<V1beta2TopicStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Topic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicSpec defines the desired state of Topic</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TopicSpec Spec { get; set; }

    /// <summary>TopicStatus defines the observed state of Topic.</summary>
    [JsonPropertyName("status")]
    public V1beta2TopicStatus? Status { get; set; }
}