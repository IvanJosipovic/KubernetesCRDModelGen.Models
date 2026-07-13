#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.upbound.io;
/// <summary>TopicRule is the Schema for the TopicRules API. Creates and manages an AWS IoT topic rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TopicRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2TopicRule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TopicRuleList";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "topicrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iot.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TopicRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2TopicRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2TopicRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecDeletionPolicyEnum>))]
public enum V1beta2TopicRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleSpecForProviderDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleSpecForProviderErrorActionDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleSpecForProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleSpecForProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelector
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
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelector
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
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta2TopicRuleSpecForProviderErrorActionSnsTargetArnSelector? TargetArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleSpecForProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleSpecForProviderErrorActionTimestreamTimestamp? Timestamp { get; set; }
}

/// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderErrorAction
{
    [JsonPropertyName("cloudwatchAlarm")]
    public V1beta2TopicRuleSpecForProviderErrorActionCloudwatchAlarm? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2TopicRuleSpecForProviderErrorActionCloudwatchLogs? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public V1beta2TopicRuleSpecForProviderErrorActionCloudwatchMetric? CloudwatchMetric { get; set; }

    [JsonPropertyName("dynamodb")]
    public V1beta2TopicRuleSpecForProviderErrorActionDynamodb? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public V1beta2TopicRuleSpecForProviderErrorActionDynamodbv2? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public V1beta2TopicRuleSpecForProviderErrorActionElasticsearch? Elasticsearch { get; set; }

    [JsonPropertyName("firehose")]
    public V1beta2TopicRuleSpecForProviderErrorActionFirehose? Firehose { get; set; }

    [JsonPropertyName("http")]
    public V1beta2TopicRuleSpecForProviderErrorActionHttp? Http { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public V1beta2TopicRuleSpecForProviderErrorActionIotAnalytics? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public V1beta2TopicRuleSpecForProviderErrorActionIotEvents? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public V1beta2TopicRuleSpecForProviderErrorActionKafka? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public V1beta2TopicRuleSpecForProviderErrorActionKinesis? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public V1beta2TopicRuleSpecForProviderErrorActionLambda? Lambda { get; set; }

    [JsonPropertyName("republish")]
    public V1beta2TopicRuleSpecForProviderErrorActionRepublish? Republish { get; set; }

    [JsonPropertyName("s3")]
    public V1beta2TopicRuleSpecForProviderErrorActionS3? S3 { get; set; }

    [JsonPropertyName("sns")]
    public V1beta2TopicRuleSpecForProviderErrorActionSns? Sns { get; set; }

    [JsonPropertyName("sqs")]
    public V1beta2TopicRuleSpecForProviderErrorActionSqs? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public V1beta2TopicRuleSpecForProviderErrorActionStepFunctions? StepFunctions { get; set; }

    [JsonPropertyName("timestream")]
    public V1beta2TopicRuleSpecForProviderErrorActionTimestream? Timestream { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleSpecForProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleSpecForProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsRoleArnSelector
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
    public V1beta2TopicRuleSpecForProviderSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSnsTargetArnSelector
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
    public V1beta2TopicRuleSpecForProviderSnsTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2TopicRuleSpecForProviderSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta2TopicRuleSpecForProviderSnsTargetArnSelector? TargetArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleSpecForProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleSpecForProviderTimestreamTimestamp? Timestamp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecForProvider
{
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta2TopicRuleSpecForProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2TopicRuleSpecForProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta2TopicRuleSpecForProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("dynamodb")]
    public IList<V1beta2TopicRuleSpecForProviderDynamodb>? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta2TopicRuleSpecForProviderDynamodbv2>? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public IList<V1beta2TopicRuleSpecForProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public V1beta2TopicRuleSpecForProviderErrorAction? ErrorAction { get; set; }

    [JsonPropertyName("firehose")]
    public IList<V1beta2TopicRuleSpecForProviderFirehose>? Firehose { get; set; }

    [JsonPropertyName("http")]
    public IList<V1beta2TopicRuleSpecForProviderHttp>? Http { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta2TopicRuleSpecForProviderIotAnalytics>? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public IList<V1beta2TopicRuleSpecForProviderIotEvents>? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public IList<V1beta2TopicRuleSpecForProviderKafka>? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public IList<V1beta2TopicRuleSpecForProviderKinesis>? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public IList<V1beta2TopicRuleSpecForProviderLambda>? Lambda { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("republish")]
    public IList<V1beta2TopicRuleSpecForProviderRepublish>? Republish { get; set; }

    [JsonPropertyName("s3")]
    public IList<V1beta2TopicRuleSpecForProviderS3>? S3 { get; set; }

    [JsonPropertyName("sns")]
    public IList<V1beta2TopicRuleSpecForProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    [JsonPropertyName("sqs")]
    public IList<V1beta2TopicRuleSpecForProviderSqs>? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public IList<V1beta2TopicRuleSpecForProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("timestream")]
    public IList<V1beta2TopicRuleSpecForProviderTimestream>? Timestream { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleSpecInitProviderDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleSpecInitProviderErrorActionDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleSpecInitProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleSpecInitProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelector
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
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelector
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
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSnsTargetArnSelector? TargetArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleSpecInitProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleSpecInitProviderErrorActionTimestreamTimestamp? Timestamp { get; set; }
}

/// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderErrorAction
{
    [JsonPropertyName("cloudwatchAlarm")]
    public V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchAlarm? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchLogs? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public V1beta2TopicRuleSpecInitProviderErrorActionCloudwatchMetric? CloudwatchMetric { get; set; }

    [JsonPropertyName("dynamodb")]
    public V1beta2TopicRuleSpecInitProviderErrorActionDynamodb? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public V1beta2TopicRuleSpecInitProviderErrorActionDynamodbv2? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public V1beta2TopicRuleSpecInitProviderErrorActionElasticsearch? Elasticsearch { get; set; }

    [JsonPropertyName("firehose")]
    public V1beta2TopicRuleSpecInitProviderErrorActionFirehose? Firehose { get; set; }

    [JsonPropertyName("http")]
    public V1beta2TopicRuleSpecInitProviderErrorActionHttp? Http { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public V1beta2TopicRuleSpecInitProviderErrorActionIotAnalytics? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public V1beta2TopicRuleSpecInitProviderErrorActionIotEvents? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public V1beta2TopicRuleSpecInitProviderErrorActionKafka? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public V1beta2TopicRuleSpecInitProviderErrorActionKinesis? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public V1beta2TopicRuleSpecInitProviderErrorActionLambda? Lambda { get; set; }

    [JsonPropertyName("republish")]
    public V1beta2TopicRuleSpecInitProviderErrorActionRepublish? Republish { get; set; }

    [JsonPropertyName("s3")]
    public V1beta2TopicRuleSpecInitProviderErrorActionS3? S3 { get; set; }

    [JsonPropertyName("sns")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSns? Sns { get; set; }

    [JsonPropertyName("sqs")]
    public V1beta2TopicRuleSpecInitProviderErrorActionSqs? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public V1beta2TopicRuleSpecInitProviderErrorActionStepFunctions? StepFunctions { get; set; }

    [JsonPropertyName("timestream")]
    public V1beta2TopicRuleSpecInitProviderErrorActionTimestream? Timestream { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleSpecInitProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleSpecInitProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsRoleArnSelector
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
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSnsTargetArnSelector
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
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2TopicRuleSpecInitProviderSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta2TopicRuleSpecInitProviderSnsTargetArnSelector? TargetArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecInitProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleSpecInitProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleSpecInitProviderTimestreamTimestamp? Timestamp { get; set; }
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
public partial class V1beta2TopicRuleSpecInitProvider
{
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta2TopicRuleSpecInitProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2TopicRuleSpecInitProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta2TopicRuleSpecInitProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("dynamodb")]
    public IList<V1beta2TopicRuleSpecInitProviderDynamodb>? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta2TopicRuleSpecInitProviderDynamodbv2>? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public IList<V1beta2TopicRuleSpecInitProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public V1beta2TopicRuleSpecInitProviderErrorAction? ErrorAction { get; set; }

    [JsonPropertyName("firehose")]
    public IList<V1beta2TopicRuleSpecInitProviderFirehose>? Firehose { get; set; }

    [JsonPropertyName("http")]
    public IList<V1beta2TopicRuleSpecInitProviderHttp>? Http { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta2TopicRuleSpecInitProviderIotAnalytics>? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public IList<V1beta2TopicRuleSpecInitProviderIotEvents>? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public IList<V1beta2TopicRuleSpecInitProviderKafka>? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public IList<V1beta2TopicRuleSpecInitProviderKinesis>? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public IList<V1beta2TopicRuleSpecInitProviderLambda>? Lambda { get; set; }

    [JsonPropertyName("republish")]
    public IList<V1beta2TopicRuleSpecInitProviderRepublish>? Republish { get; set; }

    [JsonPropertyName("s3")]
    public IList<V1beta2TopicRuleSpecInitProviderS3>? S3 { get; set; }

    [JsonPropertyName("sns")]
    public IList<V1beta2TopicRuleSpecInitProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    [JsonPropertyName("sqs")]
    public IList<V1beta2TopicRuleSpecInitProviderSqs>? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public IList<V1beta2TopicRuleSpecInitProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("timestream")]
    public IList<V1beta2TopicRuleSpecInitProviderTimestream>? Timestream { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecManagementPoliciesEnum>))]
public enum V1beta2TopicRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TopicRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TopicRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TopicRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TopicRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TopicRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TopicRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TopicRuleSpec defines the desired state of TopicRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleSpec
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
    public V1beta2TopicRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TopicRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta2TopicRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2TopicRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TopicRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TopicRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleStatusAtProviderDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are &quot;INSERT&quot;, &quot;UPDATE&quot;, or &quot;DELETE&quot;.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;.</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public V1beta2TopicRuleStatusAtProviderErrorActionDynamodbv2PutItem? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleStatusAtProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleStatusAtProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleStatusAtProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleStatusAtProviderErrorActionTimestreamTimestamp? Timestamp { get; set; }
}

/// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderErrorAction
{
    [JsonPropertyName("cloudwatchAlarm")]
    public V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchAlarm? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchLogs? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public V1beta2TopicRuleStatusAtProviderErrorActionCloudwatchMetric? CloudwatchMetric { get; set; }

    [JsonPropertyName("dynamodb")]
    public V1beta2TopicRuleStatusAtProviderErrorActionDynamodb? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public V1beta2TopicRuleStatusAtProviderErrorActionDynamodbv2? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public V1beta2TopicRuleStatusAtProviderErrorActionElasticsearch? Elasticsearch { get; set; }

    [JsonPropertyName("firehose")]
    public V1beta2TopicRuleStatusAtProviderErrorActionFirehose? Firehose { get; set; }

    [JsonPropertyName("http")]
    public V1beta2TopicRuleStatusAtProviderErrorActionHttp? Http { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public V1beta2TopicRuleStatusAtProviderErrorActionIotAnalytics? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public V1beta2TopicRuleStatusAtProviderErrorActionIotEvents? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public V1beta2TopicRuleStatusAtProviderErrorActionKafka? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public V1beta2TopicRuleStatusAtProviderErrorActionKinesis? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public V1beta2TopicRuleStatusAtProviderErrorActionLambda? Lambda { get; set; }

    [JsonPropertyName("republish")]
    public V1beta2TopicRuleStatusAtProviderErrorActionRepublish? Republish { get; set; }

    [JsonPropertyName("s3")]
    public V1beta2TopicRuleStatusAtProviderErrorActionS3? S3 { get; set; }

    [JsonPropertyName("sns")]
    public V1beta2TopicRuleStatusAtProviderErrorActionSns? Sns { get; set; }

    [JsonPropertyName("sqs")]
    public V1beta2TopicRuleStatusAtProviderErrorActionSqs? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public V1beta2TopicRuleStatusAtProviderErrorActionStepFunctions? StepFunctions { get; set; }

    [JsonPropertyName("timestream")]
    public V1beta2TopicRuleStatusAtProviderErrorActionTimestream? Timestream { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: &apos;\n&apos; (newline), &apos;\t&apos; (tab), &apos;\r\n&apos; (Windows newline), &apos;,&apos; (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta2TopicRuleStatusAtProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action&apos;s VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2TopicRuleStatusAtProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;.</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2TopicRuleStatusAtProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record&apos;s timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public V1beta2TopicRuleStatusAtProviderTimestreamTimestamp? Timestamp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusAtProvider
{
    /// <summary>The ARN of the topic rule</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta2TopicRuleStatusAtProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2TopicRuleStatusAtProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta2TopicRuleStatusAtProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("dynamodb")]
    public IList<V1beta2TopicRuleStatusAtProviderDynamodb>? Dynamodb { get; set; }

    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta2TopicRuleStatusAtProviderDynamodbv2>? Dynamodbv2 { get; set; }

    [JsonPropertyName("elasticsearch")]
    public IList<V1beta2TopicRuleStatusAtProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public V1beta2TopicRuleStatusAtProviderErrorAction? ErrorAction { get; set; }

    [JsonPropertyName("firehose")]
    public IList<V1beta2TopicRuleStatusAtProviderFirehose>? Firehose { get; set; }

    [JsonPropertyName("http")]
    public IList<V1beta2TopicRuleStatusAtProviderHttp>? Http { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta2TopicRuleStatusAtProviderIotAnalytics>? IotAnalytics { get; set; }

    [JsonPropertyName("iotEvents")]
    public IList<V1beta2TopicRuleStatusAtProviderIotEvents>? IotEvents { get; set; }

    [JsonPropertyName("kafka")]
    public IList<V1beta2TopicRuleStatusAtProviderKafka>? Kafka { get; set; }

    [JsonPropertyName("kinesis")]
    public IList<V1beta2TopicRuleStatusAtProviderKinesis>? Kinesis { get; set; }

    [JsonPropertyName("lambda")]
    public IList<V1beta2TopicRuleStatusAtProviderLambda>? Lambda { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("republish")]
    public IList<V1beta2TopicRuleStatusAtProviderRepublish>? Republish { get; set; }

    [JsonPropertyName("s3")]
    public IList<V1beta2TopicRuleStatusAtProviderS3>? S3 { get; set; }

    [JsonPropertyName("sns")]
    public IList<V1beta2TopicRuleStatusAtProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    [JsonPropertyName("sqs")]
    public IList<V1beta2TopicRuleStatusAtProviderSqs>? Sqs { get; set; }

    [JsonPropertyName("stepFunctions")]
    public IList<V1beta2TopicRuleStatusAtProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("timestream")]
    public IList<V1beta2TopicRuleStatusAtProviderTimestream>? Timestream { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatusConditions
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

/// <summary>TopicRuleStatus defines the observed state of TopicRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TopicRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TopicRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TopicRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TopicRule is the Schema for the TopicRules API. Creates and manages an AWS IoT topic rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TopicRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TopicRuleSpec>, IStatus<V1beta2TopicRuleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TopicRule";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "topicrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iot.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TopicRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicRuleSpec defines the desired state of TopicRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TopicRuleSpec Spec { get; set; }

    /// <summary>TopicRuleStatus defines the observed state of TopicRule.</summary>
    [JsonPropertyName("status")]
    public V1beta2TopicRuleStatus? Status { get; set; }
}