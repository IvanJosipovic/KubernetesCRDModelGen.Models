#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventbridge.services.k8s.aws;
/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Rule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleList";
    public const string KubeGroup = "eventbridge.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventbridge.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Rule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Rule> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecEventBusRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecEventBusRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RuleSpecEventBusRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecRoleRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RuleSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// A key-value pair associated with an Amazon Web Services resource. In EventBridge,
/// rules and event buses support tagging.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The array properties for the submitted job, such as the size of the array.
/// The array size can be between 2 and 10,000. If you specify array properties
/// for a job, it becomes an array job. This parameter is used only if the target
/// is an Batch job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsBatchParametersArrayProperties
{
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

/// <summary>
/// The retry strategy to use for failed jobs, if the target is an Batch job.
/// If you specify a retry strategy here, it overrides the retry strategy defined
/// in the job definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsBatchParametersRetryStrategy
{
    [JsonPropertyName("attempts")]
    public long? Attempts { get; set; }
}

/// <summary>The custom parameters to be used when the target is an Batch job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsBatchParameters
{
    /// <summary>
    /// The array properties for the submitted job, such as the size of the array.
    /// The array size can be between 2 and 10,000. If you specify array properties
    /// for a job, it becomes an array job. This parameter is used only if the target
    /// is an Batch job.
    /// </summary>
    [JsonPropertyName("arrayProperties")]
    public V1alpha1RuleSpecTargetsBatchParametersArrayProperties? ArrayProperties { get; set; }

    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>
    /// The retry strategy to use for failed jobs, if the target is an Batch job.
    /// If you specify a retry strategy here, it overrides the retry strategy defined
    /// in the job definition.
    /// </summary>
    [JsonPropertyName("retryStrategy")]
    public V1alpha1RuleSpecTargetsBatchParametersRetryStrategy? RetryStrategy { get; set; }
}

/// <summary>
/// Configuration details of the Amazon SQS queue for EventBridge to use as a
/// dead-letter queue (DLQ).
/// 
/// For more information, see Using dead-letter queues to process undelivered
/// events (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-rule-event-delivery.html#eb-rule-dlq)
/// in the EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsDeadLetterConfig
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>
/// The details of a capacity provider strategy. To learn more, see CapacityProviderStrategyItem
/// (https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CapacityProviderStrategyItem.html)
/// in the Amazon ECS API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsEcsParametersCapacityProviderStrategy
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
public partial class V1alpha1RuleSpecTargetsEcsParametersNetworkConfigurationAwsVPCConfiguration
{
    [JsonPropertyName("assignPublicIP")]
    public string? AssignPublicIP { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>This structure specifies the network configuration for an ECS task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsEcsParametersNetworkConfiguration
{
    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the task,
    /// and whether a public IP address is to be used. This structure is relevant
    /// only for ECS tasks that use the awsvpc network mode.
    /// </summary>
    [JsonPropertyName("awsVPCConfiguration")]
    public V1alpha1RuleSpecTargetsEcsParametersNetworkConfigurationAwsVPCConfiguration? AwsVPCConfiguration { get; set; }
}

/// <summary>
/// An object representing a constraint on task placement. To learn more, see
/// Task Placement Constraints (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html)
/// in the Amazon Elastic Container Service Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsEcsParametersPlacementConstraints
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
public partial class V1alpha1RuleSpecTargetsEcsParametersPlacementStrategy
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
public partial class V1alpha1RuleSpecTargetsEcsParametersTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The custom parameters to be used when the target is an Amazon ECS task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsEcsParameters
{
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1alpha1RuleSpecTargetsEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    [JsonPropertyName("enableECSManagedTags")]
    public bool? EnableECSManagedTags { get; set; }

    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>This structure specifies the network configuration for an ECS task.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1RuleSpecTargetsEcsParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    [JsonPropertyName("placementConstraints")]
    public IList<V1alpha1RuleSpecTargetsEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    [JsonPropertyName("placementStrategy")]
    public IList<V1alpha1RuleSpecTargetsEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    [JsonPropertyName("referenceID")]
    public string? ReferenceID { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleSpecTargetsEcsParametersTags>? Tags { get; set; }

    [JsonPropertyName("taskCount")]
    public long? TaskCount { get; set; }

    [JsonPropertyName("taskDefinitionARN")]
    public string? TaskDefinitionARN { get; set; }
}

/// <summary>
/// These are custom parameter to be used when the target is an API Gateway APIs
/// or EventBridge ApiDestinations. In the latter case, these are merged with
/// any InvocationParameters specified on the Connection, with any values from
/// the Connection taking precedence.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsHttpParameters
{
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>
/// Contains the parameters needed for you to provide custom input to a target
/// based on one or more pieces of data extracted from the event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsInputTransformer
{
    [JsonPropertyName("inputPathsMap")]
    public IDictionary<string, string>? InputPathsMap { get; set; }

    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary>
/// This object enables you to specify a JSON path to extract from the event
/// and use as the partition key for the Amazon Kinesis data stream, so that
/// you can control the shard to which the event goes. If you do not include
/// this parameter, the default is to use the eventId as the partition key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsKinesisParameters
{
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }
}

/// <summary>
/// These are custom parameters to be used when the target is a Amazon Redshift
/// cluster to invoke the Amazon Redshift Data API ExecuteStatement based on
/// EventBridge events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsRedshiftDataParameters
{
    /// <summary>Redshift Database</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Database user name</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>Optional SecretManager ARN which stores the database credentials</summary>
    [JsonPropertyName("secretManagerARN")]
    public string? SecretManagerARN { get; set; }

    /// <summary>A single Redshift SQL</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>A list of SQLs.</summary>
    [JsonPropertyName("sqls")]
    public IList<string>? Sqls { get; set; }

    /// <summary>A name for Redshift DataAPI statement which can be used as filter of ListStatement.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary>A RetryPolicy object that includes information about the retry policy settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsRetryPolicy
{
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public long? MaximumEventAgeInSeconds { get; set; }

    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Information about the EC2 instances that are to be sent the command, specified
/// as key-value pairs. Each RunCommandTarget block can include only one key,
/// but this key may specify multiple values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsRunCommandParametersRunCommandTargets
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// This parameter contains the criteria (either InstanceIds or a tag) used to
/// specify which EC2 instances are to be sent the command.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsRunCommandParameters
{
    [JsonPropertyName("runCommandTargets")]
    public IList<V1alpha1RuleSpecTargetsRunCommandParametersRunCommandTargets>? RunCommandTargets { get; set; }
}

/// <summary>
/// Name/Value pair of a parameter to start execution of a SageMaker Model Building
/// Pipeline.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsSageMakerPipelineParametersPipelineParameterList
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// These are custom parameters to use when the target is a SageMaker Model Building
/// Pipeline that starts based on EventBridge events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsSageMakerPipelineParameters
{
    [JsonPropertyName("pipelineParameterList")]
    public IList<V1alpha1RuleSpecTargetsSageMakerPipelineParametersPipelineParameterList>? PipelineParameterList { get; set; }
}

/// <summary>
/// This structure includes the custom parameter to be used when the target is
/// an SQS FIFO queue.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargetsSqsParameters
{
    [JsonPropertyName("messageGroupID")]
    public string? MessageGroupID { get; set; }
}

/// <summary>
/// Targets are the resources to be invoked when a rule is triggered. For a complete
/// list of services and resources that can be set as a target, see PutTargets
/// (https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutTargets.html).
/// 
/// If you are setting the event bus of another account as the target, and that
/// account granted permission to your account through an organization instead
/// of directly by the account ID, then you must specify a RoleArn with proper
/// permissions in the Target structure. For more information, see Sending and
/// Receiving Events Between Amazon Web Services Accounts (https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html)
/// in the Amazon EventBridge User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTargets
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The custom parameters to be used when the target is an Batch job.</summary>
    [JsonPropertyName("batchParameters")]
    public V1alpha1RuleSpecTargetsBatchParameters? BatchParameters { get; set; }

    /// <summary>
    /// Configuration details of the Amazon SQS queue for EventBridge to use as a
    /// dead-letter queue (DLQ).
    /// 
    /// For more information, see Using dead-letter queues to process undelivered
    /// events (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-rule-event-delivery.html#eb-rule-dlq)
    /// in the EventBridge User Guide.
    /// </summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1alpha1RuleSpecTargetsDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The custom parameters to be used when the target is an Amazon ECS task.</summary>
    [JsonPropertyName("ecsParameters")]
    public V1alpha1RuleSpecTargetsEcsParameters? EcsParameters { get; set; }

    /// <summary>
    /// These are custom parameter to be used when the target is an API Gateway APIs
    /// or EventBridge ApiDestinations. In the latter case, these are merged with
    /// any InvocationParameters specified on the Connection, with any values from
    /// the Connection taking precedence.
    /// </summary>
    [JsonPropertyName("httpParameters")]
    public V1alpha1RuleSpecTargetsHttpParameters? HttpParameters { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("input")]
    public string? Input { get; set; }

    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>
    /// Contains the parameters needed for you to provide custom input to a target
    /// based on one or more pieces of data extracted from the event.
    /// </summary>
    [JsonPropertyName("inputTransformer")]
    public V1alpha1RuleSpecTargetsInputTransformer? InputTransformer { get; set; }

    /// <summary>
    /// This object enables you to specify a JSON path to extract from the event
    /// and use as the partition key for the Amazon Kinesis data stream, so that
    /// you can control the shard to which the event goes. If you do not include
    /// this parameter, the default is to use the eventId as the partition key.
    /// </summary>
    [JsonPropertyName("kinesisParameters")]
    public V1alpha1RuleSpecTargetsKinesisParameters? KinesisParameters { get; set; }

    /// <summary>
    /// These are custom parameters to be used when the target is a Amazon Redshift
    /// cluster to invoke the Amazon Redshift Data API ExecuteStatement based on
    /// EventBridge events.
    /// </summary>
    [JsonPropertyName("redshiftDataParameters")]
    public V1alpha1RuleSpecTargetsRedshiftDataParameters? RedshiftDataParameters { get; set; }

    /// <summary>A RetryPolicy object that includes information about the retry policy settings.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1alpha1RuleSpecTargetsRetryPolicy? RetryPolicy { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// This parameter contains the criteria (either InstanceIds or a tag) used to
    /// specify which EC2 instances are to be sent the command.
    /// </summary>
    [JsonPropertyName("runCommandParameters")]
    public V1alpha1RuleSpecTargetsRunCommandParameters? RunCommandParameters { get; set; }

    /// <summary>
    /// These are custom parameters to use when the target is a SageMaker Model Building
    /// Pipeline that starts based on EventBridge events.
    /// </summary>
    [JsonPropertyName("sageMakerPipelineParameters")]
    public V1alpha1RuleSpecTargetsSageMakerPipelineParameters? SageMakerPipelineParameters { get; set; }

    /// <summary>
    /// This structure includes the custom parameter to be used when the target is
    /// an SQS FIFO queue.
    /// </summary>
    [JsonPropertyName("sqsParameters")]
    public V1alpha1RuleSpecTargetsSqsParameters? SqsParameters { get; set; }
}

/// <summary>
/// RuleSpec defines the desired state of Rule.
/// 
/// Contains information about a rule in Amazon EventBridge.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpec
{
    /// <summary>A description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name or ARN of the event bus to associate with this rule. If you omit
    /// this, the default event bus is used.
    /// 
    /// Regex Pattern: `^(arn:aws[\w-]*:events:[a-z]{2}-[a-z]+-[\w-]+:[0-9]{12}:event-bus\/)?[/\.\-_A-Za-z0-9]+$`
    /// </summary>
    [JsonPropertyName("eventBusName")]
    public string? EventBusName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("eventBusRef")]
    public V1alpha1RuleSpecEventBusRef? EventBusRef { get; set; }

    /// <summary>
    /// The event pattern. For more information, see Amazon EventBridge event patterns
    /// (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-patterns.html)
    /// in the Amazon EventBridge User Guide .
    /// </summary>
    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    /// <summary>
    /// The name of the rule that you are creating or updating.
    /// 
    /// Regex Pattern: `^[\.\-_A-Za-z0-9]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role associated with the rule.
    /// 
    /// If you&apos;re setting an event bus in another account as the target and that
    /// account granted permission to your account through an organization instead
    /// of directly by the account ID, you must specify a RoleArn with proper permissions
    /// in the Target structure, instead of here in this parameter.
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1RuleSpecRoleRef? RoleRef { get; set; }

    /// <summary>The scheduling expression. For example, &quot;cron(0 20 * * ? *)&quot; or &quot;rate(5 minutes)&quot;.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>
    /// The state of the rule.
    /// 
    /// Valid values include:
    /// 
    ///   - DISABLED: The rule is disabled. EventBridge does not match any events
    ///     against the rule.
    /// 
    ///   - ENABLED: The rule is enabled. EventBridge matches events against the
    ///     rule, except for Amazon Web Services management events delivered through
    ///     CloudTrail.
    /// 
    ///   - ENABLED_WITH_ALL_CLOUDTRAIL_MANAGEMENT_EVENTS: The rule is enabled for
    ///     all events, including Amazon Web Services management events delivered
    ///     through CloudTrail. Management events provide visibility into management
    ///     operations that are performed on resources in your Amazon Web Services
    ///     account. These are also known as control plane operations. For more information,
    ///     see Logging management events (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html#logging-management-events)
    ///     in the CloudTrail User Guide, and Filtering management events from Amazon
    ///     Web Services services (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-cloudtrail)
    ///     in the Amazon EventBridge User Guide . This value is only valid for rules
    ///     on the default (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-what-is-how-it-works-concepts.html#eb-bus-concepts-buses)
    ///     event bus or custom event buses (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-create-event-bus.html).
    ///     It does not apply to partner event buses (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-saas.html).
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The list of key-value pairs to associate with the rule.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleSpecTags>? Tags { get; set; }

    [JsonPropertyName("targets")]
    public IList<V1alpha1RuleSpecTargets>? Targets { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatusAckResourceMetadata
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
public partial class V1alpha1RuleStatusConditions
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

/// <summary>RuleStatus defines the observed state of Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RuleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RuleStatusConditions>? Conditions { get; set; }
}

/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RuleSpec?>, IStatus<V1alpha1RuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "eventbridge.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventbridge.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Rule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RuleSpec defines the desired state of Rule.
    /// 
    /// Contains information about a rule in Amazon EventBridge.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RuleSpec? Spec { get; set; }

    /// <summary>RuleStatus defines the observed state of Rule</summary>
    [JsonPropertyName("status")]
    public V1alpha1RuleStatus? Status { get; set; }
}