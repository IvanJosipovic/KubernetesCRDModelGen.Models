#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.m.upbound.io;
/// <summary>EventSourceMapping is the Schema for the EventSourceMappings API. Manages an AWS Lambda Event Source Mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventSourceMappingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EventSourceMapping>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSourceMappingList";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "eventsourcemappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSourceMappingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1EventSourceMapping objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1EventSourceMapping> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate destinationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate destinationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelector
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
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Destination configuration for failed invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource, or kafka://your-topic-name for Amazon MSK and self-managed Apache Kafka destinations.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate destinationArn.</summary>
    [JsonPropertyName("destinationArnRef")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnRef? DestinationArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate destinationArn.</summary>
    [JsonPropertyName("destinationArnSelector")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailureDestinationArnSelector? DestinationArnSelector { get; set; }
}

/// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfig
{
    /// <summary>Destination configuration for failed invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailure? OnFailure { get; set; }
}

/// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderDocumentDbEventSourceConfig
{
    /// <summary>Name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>Name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFilterCriteriaFilter
{
    /// <summary>Filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFilterCriteria
{
    /// <summary>Set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingSpecForProviderFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate functionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate functionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameSelector
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
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelector
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
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderMetricsConfig
{
    /// <summary>List containing the metrics to be produced by the event source mapping. Valid values: EventCount.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderProvisionedPollerConfig
{
    /// <summary>Maximum number of event pollers this event source can scale up to. The range is between 1 and 2000.</summary>
    [JsonPropertyName("maximumPollers")]
    public double? MaximumPollers { get; set; }

    /// <summary>Minimum number of event pollers this event source can scale down to. The range is between 1 and 200.</summary>
    [JsonPropertyName("minimumPollers")]
    public double? MinimumPollers { get; set; }

    /// <summary>The name of the provisioned poller group used to group multiple ESMs within the event source&apos;s VPC to share Event Poller Unit (EPU) capacity. You can use this option to optimize Provisioned mode costs for your ESMs. You can group up to 100 ESMs per poller group and aggregate maximum pollers across all ESMs in a group cannot exceed 2000.</summary>
    [JsonPropertyName("pollerGroupName")]
    public string? PollerGroupName { get; set; }
}

/// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be greater than or equal to 2. See Configuring maximum concurrency for Amazon SQS event sources. You need to raise a Service Quota Ticket to increase the concurrency beyond 1000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

/// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedEventSource
{
    /// <summary>Map of endpoints for the self managed source. For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProviderSourceAccessConfiguration
{
    /// <summary>Type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI for this configuration. For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource&apos;s id attribute. For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource&apos;s id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecForProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfig? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>Largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Whether to split the batch in two and retry if the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1EventSourceMappingSpecForProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public V1beta1EventSourceMappingSpecForProviderDocumentDbEventSourceConfig? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Whether the mapping is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Event source ARN - required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream. Incompatible with Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1EventSourceMappingSpecForProviderFilterCriteria? FilterCriteria { get; set; }

    /// <summary>Name or ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>List of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary>ARN of the Key Management Service (KMS) customer managed key that Lambda uses to encrypt your function&apos;s filter criteria.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EventSourceMappingSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1beta1EventSourceMappingSpecForProviderMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
    [JsonPropertyName("provisionedPollerConfig")]
    public V1beta1EventSourceMappingSpecForProviderProvisionedPollerConfig? ProvisionedPollerConfig { get; set; }

    /// <summary>Name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1EventSourceMappingSpecForProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public V1beta1EventSourceMappingSpecForProviderSelfManagedEventSource? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfig? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. See below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingSpecForProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>Position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>Timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>Duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate destinationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate destinationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelector
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
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Destination configuration for failed invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource, or kafka://your-topic-name for Amazon MSK and self-managed Apache Kafka destinations.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate destinationArn.</summary>
    [JsonPropertyName("destinationArnRef")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnRef? DestinationArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate destinationArn.</summary>
    [JsonPropertyName("destinationArnSelector")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailureDestinationArnSelector? DestinationArnSelector { get; set; }
}

/// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfig
{
    /// <summary>Destination configuration for failed invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailure? OnFailure { get; set; }
}

/// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderDocumentDbEventSourceConfig
{
    /// <summary>Name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>Name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFilterCriteriaFilter
{
    /// <summary>Filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFilterCriteria
{
    /// <summary>Set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingSpecInitProviderFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate functionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate functionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameSelector
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
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelector
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
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderMetricsConfig
{
    /// <summary>List containing the metrics to be produced by the event source mapping. Valid values: EventCount.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderProvisionedPollerConfig
{
    /// <summary>Maximum number of event pollers this event source can scale up to. The range is between 1 and 2000.</summary>
    [JsonPropertyName("maximumPollers")]
    public double? MaximumPollers { get; set; }

    /// <summary>Minimum number of event pollers this event source can scale down to. The range is between 1 and 200.</summary>
    [JsonPropertyName("minimumPollers")]
    public double? MinimumPollers { get; set; }

    /// <summary>The name of the provisioned poller group used to group multiple ESMs within the event source&apos;s VPC to share Event Poller Unit (EPU) capacity. You can use this option to optimize Provisioned mode costs for your ESMs. You can group up to 100 ESMs per poller group and aggregate maximum pollers across all ESMs in a group cannot exceed 2000.</summary>
    [JsonPropertyName("pollerGroupName")]
    public string? PollerGroupName { get; set; }
}

/// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be greater than or equal to 2. See Configuring maximum concurrency for Amazon SQS event sources. You need to raise a Service Quota Ticket to increase the concurrency beyond 1000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

/// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedEventSource
{
    /// <summary>Map of endpoints for the self managed source. For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpecInitProviderSourceAccessConfiguration
{
    /// <summary>Type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI for this configuration. For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource&apos;s id attribute. For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource&apos;s id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
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
public partial class V1beta1EventSourceMappingSpecInitProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfig? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>Largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Whether to split the batch in two and retry if the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1EventSourceMappingSpecInitProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public V1beta1EventSourceMappingSpecInitProviderDocumentDbEventSourceConfig? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Whether the mapping is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Event source ARN - required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream. Incompatible with Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1EventSourceMappingSpecInitProviderFilterCriteria? FilterCriteria { get; set; }

    /// <summary>Name or ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>List of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary>ARN of the Key Management Service (KMS) customer managed key that Lambda uses to encrypt your function&apos;s filter criteria.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EventSourceMappingSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1beta1EventSourceMappingSpecInitProviderMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
    [JsonPropertyName("provisionedPollerConfig")]
    public V1beta1EventSourceMappingSpecInitProviderProvisionedPollerConfig? ProvisionedPollerConfig { get; set; }

    /// <summary>Name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1EventSourceMappingSpecInitProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public V1beta1EventSourceMappingSpecInitProviderSelfManagedEventSource? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfig? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. See below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>Position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>Timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>Duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecManagementPoliciesEnum>))]
public enum V1beta1EventSourceMappingSpecManagementPoliciesEnum
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
public partial class V1beta1EventSourceMappingSpecProviderConfigRef
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
public partial class V1beta1EventSourceMappingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EventSourceMappingSpec defines the desired state of EventSourceMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EventSourceMappingSpecForProvider ForProvider { get; set; }

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
    public V1beta1EventSourceMappingSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventSourceMappingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventSourceMappingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventSourceMappingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

/// <summary>Destination configuration for failed invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource, or kafka://your-topic-name for Amazon MSK and self-managed Apache Kafka destinations.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }
}

/// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderDestinationConfig
{
    /// <summary>Destination configuration for failed invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1EventSourceMappingStatusAtProviderDestinationConfigOnFailure? OnFailure { get; set; }
}

/// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderDocumentDbEventSourceConfig
{
    /// <summary>Name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>Name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderFilterCriteriaFilter
{
    /// <summary>Filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderFilterCriteria
{
    /// <summary>Set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingStatusAtProviderFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderMetricsConfig
{
    /// <summary>List containing the metrics to be produced by the event source mapping. Valid values: EventCount.</summary>
    [JsonPropertyName("metrics")]
    public IList<string>? Metrics { get; set; }
}

/// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderProvisionedPollerConfig
{
    /// <summary>Maximum number of event pollers this event source can scale up to. The range is between 1 and 2000.</summary>
    [JsonPropertyName("maximumPollers")]
    public double? MaximumPollers { get; set; }

    /// <summary>Minimum number of event pollers this event source can scale down to. The range is between 1 and 200.</summary>
    [JsonPropertyName("minimumPollers")]
    public double? MinimumPollers { get; set; }

    /// <summary>The name of the provisioned poller group used to group multiple ESMs within the event source&apos;s VPC to share Event Poller Unit (EPU) capacity. You can use this option to optimize Provisioned mode costs for your ESMs. You can group up to 100 ESMs per poller group and aggregate maximum pollers across all ESMs in a group cannot exceed 2000.</summary>
    [JsonPropertyName("pollerGroupName")]
    public string? PollerGroupName { get; set; }
}

/// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be greater than or equal to 2. See Configuring maximum concurrency for Amazon SQS event sources. You need to raise a Service Quota Ticket to increase the concurrency beyond 1000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

/// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedEventSource
{
    /// <summary>Map of endpoints for the self managed source. For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig
{
    /// <summary>Authentication type Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the secret (Secrets Manager secret ARN) used to authenticate with the schema registry.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
{
    /// <summary>Message attribute to validate. Valid values: KEY, VALUE.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Block for a Kafka schema registry setting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    /// <summary>Configuration block for authentication Lambda uses to access the schema registry.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfig>? AccessConfig { get; set; }

    /// <summary>Record format that Lambda delivers to the function after schema validation. Valid values: JSON, SOURCE.</summary>
    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    /// <summary>URI of the schema registry. For AWS Glue schema registries, use the ARN of the registry. For Confluent schema registries, use the registry URL.</summary>
    [JsonPropertyName("schemaRegistryUri")]
    public string? SchemaRegistryUri { get; set; }

    /// <summary>Repeatable block that defines schema validation settings. These specify the message attributes that Lambda should validate and filter using the schema registry.</summary>
    [JsonPropertyName("schemaValidationConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig>? SchemaValidationConfig { get; set; }
}

/// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>Block for a Kafka schema registry setting. See below.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProviderSourceAccessConfiguration
{
    /// <summary>Type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI for this configuration. For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource&apos;s id attribute. For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource&apos;s id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusAtProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with self_managed_event_source and self_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfig? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>Event source mapping ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Whether to split the batch in two and retry if the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1EventSourceMappingStatusAtProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. See below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public V1beta1EventSourceMappingStatusAtProviderDocumentDbEventSourceConfig? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Whether the mapping is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Event source ARN - required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream. Incompatible with Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>Criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. See below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1EventSourceMappingStatusAtProviderFilterCriteria? FilterCriteria { get; set; }

    /// <summary>ARN of the Lambda function the event source mapping is sending events to. (Note: this is a computed value that differs from function_name above.)</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Name or ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>List of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the Key Management Service (KMS) customer managed key that Lambda uses to encrypt your function&apos;s filter criteria.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Date this resource was last modified.</summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>Result of the last AWS Lambda invocation of your Lambda function.</summary>
    [JsonPropertyName("lastProcessingResult")]
    public string? LastProcessingResult { get; set; }

    /// <summary>Maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>CloudWatch metrics configuration of the event source. Only available for stream sources (DynamoDB and Kinesis) and SQS queues. See below.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1beta1EventSourceMappingStatusAtProviderMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>Event poller configuration for the event source. Only valid for Amazon MSK or self-managed Apache Kafka sources. See below.</summary>
    [JsonPropertyName("provisionedPollerConfig")]
    public V1beta1EventSourceMappingStatusAtProviderProvisionedPollerConfig? ProvisionedPollerConfig { get; set; }

    /// <summary>Name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. See below.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1EventSourceMappingStatusAtProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. See below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public V1beta1EventSourceMappingStatusAtProviderSelfManagedEventSource? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with event_source_arn and amazon_managed_kafka_event_source_config. See below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfig? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. See below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>Position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>Timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>State of the event source mapping.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Reason the event source mapping is in its current state.</summary>
    [JsonPropertyName("stateTransitionReason")]
    public string? StateTransitionReason { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>Duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }

    /// <summary>UUID of the created event source mapping.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatusConditions
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

/// <summary>EventSourceMappingStatus defines the observed state of EventSourceMapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventSourceMappingStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EventSourceMappingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventSourceMappingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EventSourceMapping is the Schema for the EventSourceMappings API. Manages an AWS Lambda Event Source Mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventSourceMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventSourceMappingSpec>, IStatus<V1beta1EventSourceMappingStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSourceMapping";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "eventsourcemappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSourceMapping";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSourceMappingSpec defines the desired state of EventSourceMapping</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EventSourceMappingSpec Spec { get; set; }

    /// <summary>EventSourceMappingStatus defines the observed state of EventSourceMapping.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventSourceMappingStatus? Status { get; set; }
}