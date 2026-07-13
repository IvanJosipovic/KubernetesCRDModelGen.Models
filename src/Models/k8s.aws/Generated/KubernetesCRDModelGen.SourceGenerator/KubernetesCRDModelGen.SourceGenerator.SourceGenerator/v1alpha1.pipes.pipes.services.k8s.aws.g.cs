#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pipes.services.k8s.aws;
/// <summary>Pipe is the Schema for the Pipes API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PipeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Pipe>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PipeList";
    public const string KubeGroup = "pipes.services.k8s.aws";
    public const string KubePluralName = "pipes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pipes.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PipeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Pipe objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Pipe> Items { get; set; }
}

/// <summary>
/// These are custom parameter to be used when the target is an API Gateway REST
/// APIs or EventBridge ApiDestinations. In the latter case, these are merged
/// with any InvocationParameters specified on the Connection, with any values
/// from the Connection taking precedence.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecEnrichmentParametersHttpParameters
{
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>The parameters required to set up enrichment on your pipe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecEnrichmentParameters
{
    /// <summary>
    /// These are custom parameter to be used when the target is an API Gateway REST
    /// APIs or EventBridge ApiDestinations. In the latter case, these are merged
    /// with any InvocationParameters specified on the Connection, with any values
    /// from the Connection taking precedence.
    /// </summary>
    [JsonPropertyName("httpParameters")]
    public V1alpha1PipeSpecEnrichmentParametersHttpParameters? HttpParameters { get; set; }

    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary>The Secrets Manager secret that stores your broker credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersActiveMQBrokerParametersCredentials
{
    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using an Active MQ broker as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersActiveMQBrokerParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    /// <summary>The Secrets Manager secret that stores your broker credentials.</summary>
    [JsonPropertyName("credentials")]
    public V1alpha1PipeSpecSourceParametersActiveMQBrokerParametersCredentials? Credentials { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>
/// A DeadLetterConfig object that contains information about a dead-letter queue
/// configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersDynamoDBStreamParametersDeadLetterConfig
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a DynamoDB stream as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersDynamoDBStreamParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    /// <summary>
    /// A DeadLetterConfig object that contains information about a dead-letter queue
    /// configuration.
    /// </summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1alpha1PipeSpecSourceParametersDynamoDBStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public long? MaximumRecordAgeInSeconds { get; set; }

    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }

    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    [JsonPropertyName("parallelizationFactor")]
    public long? ParallelizationFactor { get; set; }

    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>
/// Filter events using an event pattern. For more information, see Events and
/// Event Patterns (https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html)
/// in the Amazon EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersFilterCriteriaFilters
{
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// The collection of event patterns used to filter events.
/// 
/// To remove a filter, specify a FilterCriteria object with an empty array of
/// Filter objects.
/// 
/// For more information, see Events and Event Patterns (https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html)
/// in the Amazon EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersFilterCriteria
{
    [JsonPropertyName("filters")]
    public IList<V1alpha1PipeSpecSourceParametersFilterCriteriaFilters>? Filters { get; set; }
}

/// <summary>
/// A DeadLetterConfig object that contains information about a dead-letter queue
/// configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersKinesisStreamParametersDeadLetterConfig
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersKinesisStreamParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    /// <summary>
    /// A DeadLetterConfig object that contains information about a dead-letter queue
    /// configuration.
    /// </summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1alpha1PipeSpecSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public long? MaximumRecordAgeInSeconds { get; set; }

    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }

    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    [JsonPropertyName("parallelizationFactor")]
    public long? ParallelizationFactor { get; set; }

    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    [JsonPropertyName("startingPositionTimestamp")]
    public DateTime? StartingPositionTimestamp { get; set; }
}

/// <summary>The Secrets Manager secret that stores your stream credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersManagedStreamingKafkaParametersCredentials
{
    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("clientCertificateTLSAuth")]
    public string? ClientCertificateTLSAuth { get; set; }

    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("saslSCRAM512Auth")]
    public string? SaslSCRAM512Auth { get; set; }
}

/// <summary>The parameters for using an MSK stream as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersManagedStreamingKafkaParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    [JsonPropertyName("consumerGroupID")]
    public string? ConsumerGroupID { get; set; }

    /// <summary>The Secrets Manager secret that stores your stream credentials.</summary>
    [JsonPropertyName("credentials")]
    public V1alpha1PipeSpecSourceParametersManagedStreamingKafkaParametersCredentials? Credentials { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The Secrets Manager secret that stores your broker credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersRabbitMQBrokerParametersCredentials
{
    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using a Rabbit MQ broker as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersRabbitMQBrokerParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    /// <summary>The Secrets Manager secret that stores your broker credentials.</summary>
    [JsonPropertyName("credentials")]
    public V1alpha1PipeSpecSourceParametersRabbitMQBrokerParametersCredentials? Credentials { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    [JsonPropertyName("virtualHost")]
    public string? VirtualHost { get; set; }
}

/// <summary>The Secrets Manager secret that stores your stream credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersSelfManagedKafkaParametersCredentials
{
    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }

    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("clientCertificateTLSAuth")]
    public string? ClientCertificateTLSAuth { get; set; }

    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("saslSCRAM256Auth")]
    public string? SaslSCRAM256Auth { get; set; }

    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("saslSCRAM512Auth")]
    public string? SaslSCRAM512Auth { get; set; }
}

/// <summary>
/// This structure specifies the VPC subnets and security groups for the stream,
/// and whether a public IP address is to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersSelfManagedKafkaParametersVpc
{
    /// <summary>List of SecurityGroupId.</summary>
    [JsonPropertyName("securityGroup")]
    public IList<string>? SecurityGroup { get; set; }

    /// <summary>List of SubnetId.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// The parameters for using a self-managed Apache Kafka stream as a source.
/// 
/// A self managed cluster refers to any Apache Kafka cluster not hosted by Amazon
/// Web Services. This includes both clusters you manage yourself, as well as
/// those hosted by a third-party provider, such as Confluent Cloud (https://www.confluent.io/),
/// CloudKarafka (https://www.cloudkarafka.com/), or Redpanda (https://redpanda.com/).
/// For more information, see Apache Kafka streams as a source (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-kafka.html)
/// in the Amazon EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersSelfManagedKafkaParameters
{
    [JsonPropertyName("additionalBootstrapServers")]
    public IList<string>? AdditionalBootstrapServers { get; set; }

    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    [JsonPropertyName("consumerGroupID")]
    public string? ConsumerGroupID { get; set; }

    /// <summary>The Secrets Manager secret that stores your stream credentials.</summary>
    [JsonPropertyName("credentials")]
    public V1alpha1PipeSpecSourceParametersSelfManagedKafkaParametersCredentials? Credentials { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>// Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("serverRootCaCertificate")]
    public string? ServerRootCaCertificate { get; set; }

    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the stream,
    /// and whether a public IP address is to be used.
    /// </summary>
    [JsonPropertyName("vpc")]
    public V1alpha1PipeSpecSourceParametersSelfManagedKafkaParametersVpc? Vpc { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParametersSqsQueueParameters
{
    [JsonPropertyName("batchSize")]
    public long? BatchSize { get; set; }

    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public long? MaximumBatchingWindowInSeconds { get; set; }
}

/// <summary>The parameters required to set up a source for your pipe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecSourceParameters
{
    /// <summary>The parameters for using an Active MQ broker as a source.</summary>
    [JsonPropertyName("activeMQBrokerParameters")]
    public V1alpha1PipeSpecSourceParametersActiveMQBrokerParameters? ActiveMQBrokerParameters { get; set; }

    /// <summary>The parameters for using a DynamoDB stream as a source.</summary>
    [JsonPropertyName("dynamoDBStreamParameters")]
    public V1alpha1PipeSpecSourceParametersDynamoDBStreamParameters? DynamoDBStreamParameters { get; set; }

    /// <summary>
    /// The collection of event patterns used to filter events.
    /// 
    /// To remove a filter, specify a FilterCriteria object with an empty array of
    /// Filter objects.
    /// 
    /// For more information, see Events and Event Patterns (https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html)
    /// in the Amazon EventBridge User Guide.
    /// </summary>
    [JsonPropertyName("filterCriteria")]
    public V1alpha1PipeSpecSourceParametersFilterCriteria? FilterCriteria { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1alpha1PipeSpecSourceParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using an MSK stream as a source.</summary>
    [JsonPropertyName("managedStreamingKafkaParameters")]
    public V1alpha1PipeSpecSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters { get; set; }

    /// <summary>The parameters for using a Rabbit MQ broker as a source.</summary>
    [JsonPropertyName("rabbitMQBrokerParameters")]
    public V1alpha1PipeSpecSourceParametersRabbitMQBrokerParameters? RabbitMQBrokerParameters { get; set; }

    /// <summary>
    /// The parameters for using a self-managed Apache Kafka stream as a source.
    /// 
    /// A self managed cluster refers to any Apache Kafka cluster not hosted by Amazon
    /// Web Services. This includes both clusters you manage yourself, as well as
    /// those hosted by a third-party provider, such as Confluent Cloud (https://www.confluent.io/),
    /// CloudKarafka (https://www.cloudkarafka.com/), or Redpanda (https://redpanda.com/).
    /// For more information, see Apache Kafka streams as a source (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-kafka.html)
    /// in the Amazon EventBridge User Guide.
    /// </summary>
    [JsonPropertyName("selfManagedKafkaParameters")]
    public V1alpha1PipeSpecSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a source.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1alpha1PipeSpecSourceParametersSqsQueueParameters? SqsQueueParameters { get; set; }
}

/// <summary>
/// The array properties for the submitted job, such as the size of the array.
/// The array size can be between 2 and 10,000. If you specify array properties
/// for a job, it becomes an array job. This parameter is used only if the target
/// is an Batch job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersArrayProperties
{
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

/// <summary>
/// The environment variables to send to the container. You can add new environment
/// variables, which are added to the container at launch, or you can override
/// the existing environment variables from the Docker image or the task definition.
/// 
/// Environment variables cannot start with &quot;Batch&quot;. This naming convention is
/// reserved for variables that Batch sets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverridesEnvironment
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The type and amount of a resource to assign to a container. The supported
/// resources include GPU, MEMORY, and VCPU.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverridesResourceRequirements
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The overrides that are sent to a container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverrides
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverridesEnvironment>? Environment { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("resourceRequirements")]
    public IList<V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverridesResourceRequirements>? ResourceRequirements { get; set; }
}

/// <summary>An object that represents an Batch job dependency.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersDependsOn
{
    [JsonPropertyName("jobID")]
    public string? JobID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// The retry strategy that&apos;s associated with a job. For more information, see
/// Automated job retries (https://docs.aws.amazon.com/batch/latest/userguide/job_retries.html)
/// in the Batch User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParametersRetryStrategy
{
    [JsonPropertyName("attempts")]
    public long? Attempts { get; set; }
}

/// <summary>The parameters for using an Batch job as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersBatchJobParameters
{
    /// <summary>
    /// The array properties for the submitted job, such as the size of the array.
    /// The array size can be between 2 and 10,000. If you specify array properties
    /// for a job, it becomes an array job. This parameter is used only if the target
    /// is an Batch job.
    /// </summary>
    [JsonPropertyName("arrayProperties")]
    public V1alpha1PipeSpecTargetParametersBatchJobParametersArrayProperties? ArrayProperties { get; set; }

    /// <summary>The overrides that are sent to a container.</summary>
    [JsonPropertyName("containerOverrides")]
    public V1alpha1PipeSpecTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides { get; set; }

    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1PipeSpecTargetParametersBatchJobParametersDependsOn>? DependsOn { get; set; }

    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>
    /// The retry strategy that&apos;s associated with a job. For more information, see
    /// Automated job retries (https://docs.aws.amazon.com/batch/latest/userguide/job_retries.html)
    /// in the Batch User Guide.
    /// </summary>
    [JsonPropertyName("retryStrategy")]
    public V1alpha1PipeSpecTargetParametersBatchJobParametersRetryStrategy? RetryStrategy { get; set; }
}

/// <summary>The parameters for using an CloudWatch Logs log stream as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersCloudWatchLogsParameters
{
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>
/// The details of a capacity provider strategy. To learn more, see CapacityProviderStrategyItem
/// (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CapacityProviderStrategyItem.html)
/// in the Amazon ECS API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersCapacityProviderStrategy
{
    [JsonPropertyName("base")]
    public long? Base { get; set; }

    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>
/// This structure specifies the VPC subnets and security groups for the task,
/// and whether a public IP address is to be used. This structure is relevant
/// only for ECS tasks that use the awsvpc network mode.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersNetworkConfigurationAwsVPCConfiguration
{
    [JsonPropertyName("assignPublicIP")]
    public string? AssignPublicIP { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>This structure specifies the network configuration for an Amazon ECS task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersNetworkConfiguration
{
    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the task,
    /// and whether a public IP address is to be used. This structure is relevant
    /// only for ECS tasks that use the awsvpc network mode.
    /// </summary>
    [JsonPropertyName("awsVPCConfiguration")]
    public V1alpha1PipeSpecTargetParametersEcsTaskParametersNetworkConfigurationAwsVPCConfiguration? AwsVPCConfiguration { get; set; }
}

/// <summary>
/// The environment variables to send to the container. You can add new environment
/// variables, which are added to the container at launch, or you can override
/// the existing environment variables from the Docker image or the task definition.
/// You must also specify a container name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesEnvironment
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A list of files containing the environment variables to pass to a container.
/// You can specify up to ten environment files. The file must have a .env file
/// extension. Each line in an environment file should contain an environment
/// variable in VARIABLE=VALUE format. Lines beginning with # are treated as
/// comments and are ignored. For more information about the environment variable
/// file syntax, see Declare default environment variables in file (https://docs.docker.com/compose/env-file/).
/// 
/// If there are environment variables specified using the environment parameter
/// in a container definition, they take precedence over the variables contained
/// within an environment file. If multiple environment files are specified that
/// contain the same variable, they&apos;re processed from the top down. We recommend
/// that you use unique variable names. For more information, see Specifying
/// environment variables (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/taskdef-envfiles.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// This parameter is only supported for tasks hosted on Fargate using the following
/// platform versions:
/// 
///   - Linux platform version 1.4.0 or later.
/// 
///   - Windows platform version 1.0.0 or later.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesEnvironmentFiles
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The type and amount of a resource to assign to a container. The supported
/// resource types are GPUs and Elastic Inference accelerators. For more information,
/// see Working with GPUs on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-gpu.html)
/// or Working with Amazon Elastic Inference on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html)
/// in the Amazon Elastic Container Service Developer Guide
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesResourceRequirements
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The overrides that are sent to a container. An empty container override can
/// be passed in. An example of an empty container override is {&quot;containerOverrides&quot;:
/// [ ] }. If a non-empty container override is specified, the name parameter
/// must be included.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverrides
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("cpu")]
    public long? Cpu { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesEnvironment>? Environment { get; set; }

    [JsonPropertyName("environmentFiles")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesEnvironmentFiles>? EnvironmentFiles { get; set; }

    [JsonPropertyName("memory")]
    public long? Memory { get; set; }

    [JsonPropertyName("memoryReservation")]
    public long? MemoryReservation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceRequirements")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverridesResourceRequirements>? ResourceRequirements { get; set; }
}

/// <summary>
/// The amount of ephemeral storage to allocate for the task. This parameter
/// is used to expand the total amount of ephemeral storage available, beyond
/// the default amount, for tasks hosted on Fargate. For more information, see
/// Fargate task storage (https://docs.aws.amazon.com/AmazonECS/latest/userguide/using_data_volumes.html)
/// in the Amazon ECS User Guide for Fargate.
/// 
/// This parameter is only supported for tasks hosted on Fargate using Linux
/// platform version 1.4.0 or later. This parameter is not supported for Windows
/// containers on Fargate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesEphemeralStorage
{
    [JsonPropertyName("sizeInGiB")]
    public long? SizeInGiB { get; set; }
}

/// <summary>
/// Details on an Elastic Inference accelerator task override. This parameter
/// is used to override the Elastic Inference accelerator specified in the task
/// definition. For more information, see Working with Amazon Elastic Inference
/// on Amazon ECS (https://docs.aws.amazon.com/AmazonECS/latest/userguide/ecs-inference.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverrides
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }
}

/// <summary>The overrides that are associated with a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersOverrides
{
    [JsonPropertyName("containerOverrides")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesContainerOverrides>? ContainerOverrides { get; set; }

    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>
    /// The amount of ephemeral storage to allocate for the task. This parameter
    /// is used to expand the total amount of ephemeral storage available, beyond
    /// the default amount, for tasks hosted on Fargate. For more information, see
    /// Fargate task storage (https://docs.aws.amazon.com/AmazonECS/latest/userguide/using_data_volumes.html)
    /// in the Amazon ECS User Guide for Fargate.
    /// 
    /// This parameter is only supported for tasks hosted on Fargate using Linux
    /// platform version 1.4.0 or later. This parameter is not supported for Windows
    /// containers on Fargate.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage { get; set; }

    [JsonPropertyName("executionRoleARN")]
    public string? ExecutionRoleARN { get; set; }

    [JsonPropertyName("inferenceAcceleratorOverrides")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverrides>? InferenceAcceleratorOverrides { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    [JsonPropertyName("taskRoleARN")]
    public string? TaskRoleARN { get; set; }
}

/// <summary>
/// An object representing a constraint on task placement. To learn more, see
/// Task Placement Constraints (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersPlacementConstraints
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// The task placement strategy for a task or service. To learn more, see Task
/// Placement Strategies (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-strategies.html)
/// in the Amazon Elastic Container Service Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersPlacementStrategy
{
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// A key-value pair associated with an Amazon Web Services resource. In EventBridge,
/// rules and event buses support tagging.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParametersTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The parameters for using an Amazon ECS task as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEcsTaskParameters
{
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    [JsonPropertyName("enableECSManagedTags")]
    public bool? EnableECSManagedTags { get; set; }

    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>This structure specifies the network configuration for an Amazon ECS task.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1PipeSpecTargetParametersEcsTaskParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The overrides that are associated with a task.</summary>
    [JsonPropertyName("overrides")]
    public V1alpha1PipeSpecTargetParametersEcsTaskParametersOverrides? Overrides { get; set; }

    [JsonPropertyName("placementConstraints")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersPlacementConstraints>? PlacementConstraints { get; set; }

    [JsonPropertyName("placementStrategy")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersPlacementStrategy>? PlacementStrategy { get; set; }

    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    [JsonPropertyName("referenceID")]
    public string? ReferenceID { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1PipeSpecTargetParametersEcsTaskParametersTags>? Tags { get; set; }

    [JsonPropertyName("taskCount")]
    public long? TaskCount { get; set; }

    [JsonPropertyName("taskDefinitionARN")]
    public string? TaskDefinitionARN { get; set; }
}

/// <summary>The parameters for using an EventBridge event bus as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersEventBridgeEventBusParameters
{
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    [JsonPropertyName("endpointID")]
    public string? EndpointID { get; set; }

    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// These are custom parameter to be used when the target is an API Gateway REST
/// APIs or EventBridge ApiDestinations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersHttpParameters
{
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersKinesisStreamParameters
{
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>The parameters for using a Lambda function as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersLambdaFunctionParameters
{
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>
/// These are custom parameters to be used when the target is a Amazon Redshift
/// cluster to invoke the Amazon Redshift Data API BatchExecuteStatement.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersRedshiftDataParameters
{
    /// <summary>// Redshift Database</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>// Database user name</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>// For targets, can either specify an ARN or a jsonpath pointing to the ARN.</summary>
    [JsonPropertyName("secretManagerARN")]
    public string? SecretManagerARN { get; set; }

    /// <summary>// A list of SQLs.</summary>
    [JsonPropertyName("sqls")]
    public IList<string>? Sqls { get; set; }

    /// <summary>
    /// // A name for Redshift DataAPI statement which can be used as filter of//
    /// ListStatement.
    /// </summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary>
/// Name/Value pair of a parameter to start execution of a SageMaker Model Building
/// Pipeline.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersSageMakerPipelineParametersPipelineParameterList
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The parameters for using a SageMaker pipeline as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersSageMakerPipelineParameters
{
    [JsonPropertyName("pipelineParameterList")]
    public IList<V1alpha1PipeSpecTargetParametersSageMakerPipelineParametersPipelineParameterList>? PipelineParameterList { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersSqsQueueParameters
{
    [JsonPropertyName("messageDeduplicationID")]
    public string? MessageDeduplicationID { get; set; }

    [JsonPropertyName("messageGroupID")]
    public string? MessageGroupID { get; set; }
}

/// <summary>The parameters for using a Step Functions state machine as a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParametersStepFunctionStateMachineParameters
{
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>
/// The parameters required to set up a target for your pipe.
/// 
/// For more information about pipe target parameters, including how to use dynamic
/// path parameters, see Target parameters (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-event-target.html)
/// in the Amazon EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpecTargetParameters
{
    /// <summary>The parameters for using an Batch job as a target.</summary>
    [JsonPropertyName("batchJobParameters")]
    public V1alpha1PipeSpecTargetParametersBatchJobParameters? BatchJobParameters { get; set; }

    /// <summary>The parameters for using an CloudWatch Logs log stream as a target.</summary>
    [JsonPropertyName("cloudWatchLogsParameters")]
    public V1alpha1PipeSpecTargetParametersCloudWatchLogsParameters? CloudWatchLogsParameters { get; set; }

    /// <summary>The parameters for using an Amazon ECS task as a target.</summary>
    [JsonPropertyName("ecsTaskParameters")]
    public V1alpha1PipeSpecTargetParametersEcsTaskParameters? EcsTaskParameters { get; set; }

    /// <summary>The parameters for using an EventBridge event bus as a target.</summary>
    [JsonPropertyName("eventBridgeEventBusParameters")]
    public V1alpha1PipeSpecTargetParametersEventBridgeEventBusParameters? EventBridgeEventBusParameters { get; set; }

    /// <summary>
    /// These are custom parameter to be used when the target is an API Gateway REST
    /// APIs or EventBridge ApiDestinations.
    /// </summary>
    [JsonPropertyName("httpParameters")]
    public V1alpha1PipeSpecTargetParametersHttpParameters? HttpParameters { get; set; }

    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a target.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1alpha1PipeSpecTargetParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using a Lambda function as a target.</summary>
    [JsonPropertyName("lambdaFunctionParameters")]
    public V1alpha1PipeSpecTargetParametersLambdaFunctionParameters? LambdaFunctionParameters { get; set; }

    /// <summary>
    /// These are custom parameters to be used when the target is a Amazon Redshift
    /// cluster to invoke the Amazon Redshift Data API BatchExecuteStatement.
    /// </summary>
    [JsonPropertyName("redshiftDataParameters")]
    public V1alpha1PipeSpecTargetParametersRedshiftDataParameters? RedshiftDataParameters { get; set; }

    /// <summary>The parameters for using a SageMaker pipeline as a target.</summary>
    [JsonPropertyName("sageMakerPipelineParameters")]
    public V1alpha1PipeSpecTargetParametersSageMakerPipelineParameters? SageMakerPipelineParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a target.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1alpha1PipeSpecTargetParametersSqsQueueParameters? SqsQueueParameters { get; set; }

    /// <summary>The parameters for using a Step Functions state machine as a target.</summary>
    [JsonPropertyName("stepFunctionStateMachineParameters")]
    public V1alpha1PipeSpecTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters { get; set; }
}

/// <summary>
/// PipeSpec defines the desired state of Pipe.
/// 
/// An object that represents a pipe. Amazon EventBridgePipes connect event sources
/// to targets and reduces the need for specialized knowledge and integration
/// code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeSpec
{
    /// <summary>
    /// A description of the pipe.
    /// 
    /// Regex Pattern: `^.*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The state the pipe should be in.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// The ARN of the enrichment resource.
    /// 
    /// Regex Pattern: `^$|arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-]+):([a-z]{2,4}((-gov)|(-de)|(-iso([a-z]?)))?-[a-z]+(-\d{1})?)?:(\d{12})?:(.+)$`
    /// </summary>
    [JsonPropertyName("enrichment")]
    public string? Enrichment { get; set; }

    /// <summary>The parameters required to set up enrichment on your pipe.</summary>
    [JsonPropertyName("enrichmentParameters")]
    public V1alpha1PipeSpecEnrichmentParameters? EnrichmentParameters { get; set; }

    /// <summary>
    /// The name of the pipe.
    /// 
    /// Regex Pattern: `^[\.\-_A-Za-z0-9]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The ARN of the role that allows the pipe to send data to the target.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:iam::\d{12}:role/?[a-zA-Z0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>
    /// The ARN of the source resource.
    /// 
    /// Regex Pattern: `^smk://(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9]):[0-9]{1,5}|arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-]+):([a-z]{2,4}((-gov)|(-de)|(-iso([a-z]?)))?-[a-z]+(-\d{1})?)?:(\d{12})?:(.+)$`
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; set; }

    /// <summary>The parameters required to set up a source for your pipe.</summary>
    [JsonPropertyName("sourceParameters")]
    public V1alpha1PipeSpecSourceParameters? SourceParameters { get; set; }

    /// <summary>The list of key-value pairs to associate with the pipe.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The ARN of the target resource.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-]+):([a-z]{2,4}((-gov)|(-de)|(-iso([a-z]?)))?-[a-z]+(-\d{1})?)?:(\d{12})?:(.+)$`
    /// </summary>
    [JsonPropertyName("target")]
    public required string Target { get; set; }

    /// <summary>
    /// The parameters required to set up a target for your pipe.
    /// 
    /// For more information about pipe target parameters, including how to use dynamic
    /// path parameters, see Target parameters (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-event-target.html)
    /// in the Amazon EventBridge User Guide.
    /// </summary>
    [JsonPropertyName("targetParameters")]
    public V1alpha1PipeSpecTargetParameters? TargetParameters { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeStatusAckResourceMetadata
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
public partial class V1alpha1PipeStatusConditions
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

/// <summary>PipeStatus defines the observed state of Pipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipeStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PipeStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PipeStatusConditions>? Conditions { get; set; }

    /// <summary>The time the pipe was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>The state the pipe is in.</summary>
    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    /// <summary>
    /// When the pipe was last updated, in ISO-8601 format (https://www.w3.org/TR/NOTE-datetime)
    /// (YYYY-MM-DDThh:mm:ss.sTZD).
    /// </summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// The reason the pipe is in its current state.
    /// 
    /// Regex Pattern: `^.*$`
    /// </summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }
}

/// <summary>Pipe is the Schema for the Pipes API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Pipe : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PipeSpec?>, IStatus<V1alpha1PipeStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Pipe";
    public const string KubeGroup = "pipes.services.k8s.aws";
    public const string KubePluralName = "pipes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pipes.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Pipe";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// PipeSpec defines the desired state of Pipe.
    /// 
    /// An object that represents a pipe. Amazon EventBridgePipes connect event sources
    /// to targets and reduces the need for specialized knowledge and integration
    /// code.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1PipeSpec? Spec { get; set; }

    /// <summary>PipeStatus defines the observed state of Pipe</summary>
    [JsonPropertyName("status")]
    public V1alpha1PipeStatus? Status { get; set; }
}