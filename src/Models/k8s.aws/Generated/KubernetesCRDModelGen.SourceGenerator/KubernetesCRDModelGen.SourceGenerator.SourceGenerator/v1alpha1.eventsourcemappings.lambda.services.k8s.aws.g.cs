#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.services.k8s.aws;
/// <summary>EventSourceMapping is the Schema for the EventSourceMappings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventSourceMappingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EventSourceMapping>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventSourceMappingList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "eventsourcemappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSourceMappingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1EventSourceMapping objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1EventSourceMapping> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRefFrom? From { get; set; }
}

/// <summary>
/// Specific access configuration settings that tell Lambda how to authenticate
/// with your schema registry.
/// 
/// If you&apos;re working with an Glue schema registry, don&apos;t provide authentication
/// details in this object. Instead, ensure that your execution role has the
/// required permissions for Lambda to access your cluster.
/// 
/// If you&apos;re working with a Confluent schema registry, choose the authentication
/// method in the Type field, and provide the Secrets Manager secret ARN in the
/// URI field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigs
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference field for URI</summary>
    [JsonPropertyName("uriRef")]
    public V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRef? UriRef { get; set; }
}

/// <summary>
/// Specific schema validation configuration settings that tell Lambda the message
/// attributes you want to validate and filter using your schema registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfigs
{
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Specific configuration settings for a Kafka schema registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    [JsonPropertyName("accessConfigs")]
    public IList<V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigs>? AccessConfigs { get; set; }

    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    [JsonPropertyName("schemaRegistryURI")]
    public string? SchemaRegistryURI { get; set; }

    [JsonPropertyName("schemaValidationConfigs")]
    public IList<V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfigs>? SchemaValidationConfigs { get; set; }
}

/// <summary>
/// Specific configuration settings for an Amazon Managed Streaming for Apache
/// Kafka (Amazon MSK) event source.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfig
{
    [JsonPropertyName("consumerGroupID")]
    public string? ConsumerGroupID { get; set; }

    /// <summary>Specific configuration settings for a Kafka schema registry.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

/// <summary>
/// A destination for events that failed processing. For more information, see
/// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecDestinationConfigOnFailure
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>
/// A destination for events that were processed successfully.
/// 
/// To retain records of successful asynchronous invocations (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations),
/// you can configure an Amazon SNS topic, Amazon SQS queue, Lambda function,
/// or Amazon EventBridge event bus as the destination.
/// 
/// OnSuccess is not supported in CreateEventSourceMapping or UpdateEventSourceMapping
/// requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecDestinationConfigOnSuccess
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>
/// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) A
/// configuration object that specifies the destination of an event after Lambda
/// processes it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecDestinationConfig
{
    /// <summary>
    /// A destination for events that failed processing. For more information, see
    /// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("onFailure")]
    public V1alpha1EventSourceMappingSpecDestinationConfigOnFailure? OnFailure { get; set; }

    /// <summary>
    /// A destination for events that were processed successfully.
    /// 
    /// To retain records of successful asynchronous invocations (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations),
    /// you can configure an Amazon SNS topic, Amazon SQS queue, Lambda function,
    /// or Amazon EventBridge event bus as the destination.
    /// 
    /// OnSuccess is not supported in CreateEventSourceMapping or UpdateEventSourceMapping
    /// requests.
    /// </summary>
    [JsonPropertyName("onSuccess")]
    public V1alpha1EventSourceMappingSpecDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecEventSourceRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecEventSourceRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EventSourceMappingSpecEventSourceRefFrom? From { get; set; }
}

/// <summary>
/// A structure within a FilterCriteria object that defines an event filtering
/// pattern.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecFilterCriteriaFilters
{
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// An object that defines the filter criteria that determine whether Lambda
/// should process an event. For more information, see Lambda event filtering
/// (https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecFilterCriteria
{
    [JsonPropertyName("filters")]
    public IList<V1alpha1EventSourceMappingSpecFilterCriteriaFilters>? Filters { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecFunctionRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecFunctionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EventSourceMappingSpecFunctionRefFrom? From { get; set; }
}

/// <summary>
/// (Amazon MSK, and self-managed Apache Kafka only) The logging configuration
/// for your event source. For more information, see Event source mapping logging
/// (https://docs.aws.amazon.com/lambda/latest/dg/esm-logging.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecLoggingConfig
{
    [JsonPropertyName("systemLogLevel")]
    public string? SystemLogLevel { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecQueueRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecQueueRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EventSourceMappingSpecQueueRefsFrom? From { get; set; }
}

/// <summary>
/// (Amazon SQS only) The scaling configuration for the event source. For more
/// information, see Configuring maximum concurrency for Amazon SQS event sources
/// (https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-max-concurrency).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecScalingConfig
{
    [JsonPropertyName("maximumConcurrency")]
    public long? MaximumConcurrency { get; set; }
}

/// <summary>The self-managed Apache Kafka cluster to receive records from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedEventSource
{
    [JsonPropertyName("endpoints")]
    public IDictionary<string, IList<string>>? Endpoints { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRefFrom? From { get; set; }
}

/// <summary>
/// Specific access configuration settings that tell Lambda how to authenticate
/// with your schema registry.
/// 
/// If you&apos;re working with an Glue schema registry, don&apos;t provide authentication
/// details in this object. Instead, ensure that your execution role has the
/// required permissions for Lambda to access your cluster.
/// 
/// If you&apos;re working with a Confluent schema registry, choose the authentication
/// method in the Type field, and provide the Secrets Manager secret ARN in the
/// URI field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigs
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference field for URI</summary>
    [JsonPropertyName("uriRef")]
    public V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigsUriRef? UriRef { get; set; }
}

/// <summary>
/// Specific schema validation configuration settings that tell Lambda the message
/// attributes you want to validate and filter using your schema registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfigs
{
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Specific configuration settings for a Kafka schema registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfig
{
    [JsonPropertyName("accessConfigs")]
    public IList<V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigAccessConfigs>? AccessConfigs { get; set; }

    [JsonPropertyName("eventRecordFormat")]
    public string? EventRecordFormat { get; set; }

    [JsonPropertyName("schemaRegistryURI")]
    public string? SchemaRegistryURI { get; set; }

    [JsonPropertyName("schemaValidationConfigs")]
    public IList<V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfigs>? SchemaValidationConfigs { get; set; }
}

/// <summary>Specific configuration settings for a self-managed Apache Kafka event source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfig
{
    [JsonPropertyName("consumerGroupID")]
    public string? ConsumerGroupID { get; set; }

    /// <summary>Specific configuration settings for a Kafka schema registry.</summary>
    [JsonPropertyName("schemaRegistryConfig")]
    public V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfigSchemaRegistryConfig? SchemaRegistryConfig { get; set; }
}

/// <summary>
/// To secure and define access to your event source, you can specify the authentication
/// protocol, VPC components, or virtual host.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpecSourceAccessConfigurations
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("uRI")]
    public string? URI { get; set; }
}

/// <summary>EventSourceMappingSpec defines the desired state of EventSourceMapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingSpec
{
    /// <summary>
    /// Specific configuration settings for an Amazon Managed Streaming for Apache
    /// Kafka (Amazon MSK) event source.
    /// </summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public V1alpha1EventSourceMappingSpecAmazonManagedKafkaEventSourceConfig? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>
    /// The maximum number of records in each batch that Lambda pulls from your stream
    /// or queue and sends to your function. Lambda passes all of the records in
    /// the batch to the function in a single call, up to the payload limit for synchronous
    /// invocation (6 MB).
    /// 
    ///   - Amazon Kinesis – Default 100. Max 10,000.
    /// 
    ///   - Amazon DynamoDB Streams – Default 100. Max 10,000.
    /// 
    ///   - Amazon Simple Queue Service – Default 10. For standard queues the
    ///     max is 10,000. For FIFO queues the max is 10.
    /// 
    ///   - Amazon Managed Streaming for Apache Kafka – Default 100. Max 10,000.
    /// 
    ///   - Self-managed Apache Kafka – Default 100. Max 10,000.
    /// 
    ///   - Amazon MQ (ActiveMQ and RabbitMQ) – Default 100. Max 10,000.
    /// 
    ///   - DocumentDB – Default 100. Max 10,000.
    /// </summary>
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    /// <summary>
    /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) If
    /// the function returns an error, split the batch in two and retry.
    /// </summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>
    /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) A
    /// configuration object that specifies the destination of an event after Lambda
    /// processes it.
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1alpha1EventSourceMappingSpecDestinationConfig? DestinationConfig { get; set; }

    /// <summary>
    /// When true, the event source mapping is active. When false, Lambda pauses
    /// polling and invocation.
    /// 
    /// Default: True
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the event source.
    /// 
    ///   - Amazon Kinesis – The ARN of the data stream or a stream consumer.
    /// 
    ///   - Amazon DynamoDB Streams – The ARN of the stream.
    /// 
    ///   - Amazon Simple Queue Service – The ARN of the queue.
    /// 
    ///   - Amazon Managed Streaming for Apache Kafka – The ARN of the cluster
    ///     or the ARN of the VPC connection (for cross-account event source mappings
    ///     (https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#msk-multi-vpc)).
    /// 
    ///   - Amazon MQ – The ARN of the broker.
    /// 
    ///   - Amazon DocumentDB – The ARN of the DocumentDB change stream.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(.*)$`
    /// </summary>
    [JsonPropertyName("eventSourceARN")]
    public string? EventSourceARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("eventSourceRef")]
    public V1alpha1EventSourceMappingSpecEventSourceRef? EventSourceRef { get; set; }

    /// <summary>
    /// An object that defines the filter criteria that determine whether Lambda
    /// should process an event. For more information, see Lambda event filtering
    /// (https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html).
    /// </summary>
    [JsonPropertyName("filterCriteria")]
    public V1alpha1EventSourceMappingSpecFilterCriteria? FilterCriteria { get; set; }

    /// <summary>
    /// The name or ARN of the Lambda function.
    /// 
    /// Name formats
    /// 
    ///   - Function name – MyFunction.
    /// 
    ///   - Function ARN – arn:aws:lambda:us-west-2:123456789012:function:MyFunction.
    /// 
    ///   - Version or Alias ARN – arn:aws:lambda:us-west-2:123456789012:function:MyFunction:PROD.
    /// 
    ///   - Partial ARN – 123456789012:function:MyFunction.
    /// 
    /// The length constraint applies only to the full ARN. If you specify only the
    /// function name, it&apos;s limited to 64 characters in length.
    /// 
    /// Regex Pattern: `^(arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_\.]+)(:(\$LATEST(\.PUBLISHED)?|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("functionRef")]
    public V1alpha1EventSourceMappingSpecFunctionRef? FunctionRef { get; set; }

    /// <summary>
    /// (Kinesis, DynamoDB Streams, Amazon MSK, self-managed Apache Kafka, and Amazon
    /// SQS) A list of current response type enums applied to the event source mapping.
    /// </summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary>
    /// (Amazon MSK, and self-managed Apache Kafka only) The logging configuration
    /// for your event source. For more information, see Event source mapping logging
    /// (https://docs.aws.amazon.com/lambda/latest/dg/esm-logging.html).
    /// </summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1EventSourceMappingSpecLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// The maximum amount of time, in seconds, that Lambda spends gathering records
    /// before invoking the function. You can configure MaximumBatchingWindowInSeconds
    /// to any value from 0 seconds to 300 seconds in increments of seconds.
    /// 
    /// For Kinesis, DynamoDB, and Amazon SQS event sources, the default batching
    /// window is 0 seconds. For Amazon MSK, Self-managed Apache Kafka, Amazon MQ,
    /// and DocumentDB event sources, the default batching window is 500 ms. Note
    /// that because you can only change MaximumBatchingWindowInSeconds in increments
    /// of seconds, you cannot revert back to the 500 ms default batching window
    /// after you have changed it. To restore the default batching window, you must
    /// create a new event source mapping.
    /// 
    /// Related setting: For Kinesis, DynamoDB, and Amazon SQS event sources, when
    /// you set BatchSize to a value greater than 10, you must set MaximumBatchingWindowInSeconds
    /// to at least 1.
    /// </summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>
    /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) Discard
    /// records older than the specified age. The default value is infinite (-1).
    /// </summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public long? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>
    /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) Discard
    /// records after the specified number of retries. The default value is infinite
    /// (-1). When set to infinite (-1), failed records are retried until the record
    /// expires.
    /// </summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }

    /// <summary>
    /// (Kinesis and DynamoDB Streams only) The number of batches to process from
    /// each shard concurrently.
    /// </summary>
    [JsonPropertyName("parallelizationFactor")]
    public long? ParallelizationFactor { get; set; }

    [JsonPropertyName("queueRefs")]
    public IList<V1alpha1EventSourceMappingSpecQueueRefs>? QueueRefs { get; set; }

    /// <summary>(MQ) The name of the Amazon MQ broker destination queue to consume.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>
    /// (Amazon SQS only) The scaling configuration for the event source. For more
    /// information, see Configuring maximum concurrency for Amazon SQS event sources
    /// (https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-max-concurrency).
    /// </summary>
    [JsonPropertyName("scalingConfig")]
    public V1alpha1EventSourceMappingSpecScalingConfig? ScalingConfig { get; set; }

    /// <summary>The self-managed Apache Kafka cluster to receive records from.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public V1alpha1EventSourceMappingSpecSelfManagedEventSource? SelfManagedEventSource { get; set; }

    /// <summary>Specific configuration settings for a self-managed Apache Kafka event source.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public V1alpha1EventSourceMappingSpecSelfManagedKafkaEventSourceConfig? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>
    /// An array of authentication protocols or VPC components required to secure
    /// your event source.
    /// </summary>
    [JsonPropertyName("sourceAccessConfigurations")]
    public IList<V1alpha1EventSourceMappingSpecSourceAccessConfigurations>? SourceAccessConfigurations { get; set; }

    /// <summary>
    /// The position in a stream from which to start reading. Required for Amazon
    /// Kinesis and Amazon DynamoDB Stream event sources. AT_TIMESTAMP is supported
    /// only for Amazon Kinesis streams, Amazon DocumentDB, Amazon MSK, and self-managed
    /// Apache Kafka.
    /// </summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>
    /// With StartingPosition set to AT_TIMESTAMP, the time from which to start reading.
    /// StartingPositionTimestamp cannot be in the future.
    /// </summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public DateTime? StartingPositionTimestamp { get; set; }

    /// <summary>A list of tags to apply to the event source mapping.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of the Kafka topic.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>
    /// (Kinesis and DynamoDB Streams only) The duration in seconds of a processing
    /// window for DynamoDB and Kinesis Streams event sources. A value of 0 seconds
    /// indicates no tumbling window.
    /// </summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public long? TumblingWindowInSeconds { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingStatusConditions
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

/// <summary>EventSourceMappingStatus defines the observed state of EventSourceMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventSourceMappingStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1EventSourceMappingStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventSourceMappingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The ARN of the Lambda function.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:\d{12}:function:[a-zA-Z0-9-_]+(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }

    /// <summary>
    /// The date that the event source mapping was last updated or that its state
    /// changed.
    /// </summary>
    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    /// <summary>The result of the event source mapping&apos;s last processing attempt.</summary>
    [JsonPropertyName("lastProcessingResult")]
    public string? LastProcessingResult { get; set; }

    /// <summary>
    /// The state of the event source mapping. It can be one of the following: Creating,
    /// Enabling, Enabled, Disabling, Disabled, Updating, or Deleting.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Indicates whether a user or Lambda made the last change to the event source
    /// mapping.
    /// </summary>
    [JsonPropertyName("stateTransitionReason")]
    public string? StateTransitionReason { get; set; }

    /// <summary>The identifier of the event source mapping.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>EventSourceMapping is the Schema for the EventSourceMappings API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventSourceMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventSourceMappingSpec?>, IStatus<V1alpha1EventSourceMappingStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventSourceMapping";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "eventsourcemappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSourceMapping";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSourceMappingSpec defines the desired state of EventSourceMapping.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EventSourceMappingSpec? Spec { get; set; }

    /// <summary>EventSourceMappingStatus defines the observed state of EventSourceMapping</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventSourceMappingStatus? Status { get; set; }
}