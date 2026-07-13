#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.services.k8s.aws;
/// <summary>FlowLog is the Schema for the FlowLogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FlowLogList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FlowLog>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FlowLogList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "flowlogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowLogList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FlowLog objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FlowLog> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogSpecDeliverLogsPermissionRefFrom
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
public partial class V1alpha1FlowLogSpecDeliverLogsPermissionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FlowLogSpecDeliverLogsPermissionRefFrom? From { get; set; }
}

/// <summary>The destination options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogSpecDestinationOptions
{
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    [JsonPropertyName("hiveCompatiblePartitions")]
    public bool? HiveCompatiblePartitions { get; set; }

    [JsonPropertyName("perHourPartition")]
    public bool? PerHourPartition { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// FlowLogSpec defines the desired state of FlowLog.
/// 
/// Describes a flow log.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogSpec
{
    /// <summary>
    /// The ARN of the IAM role that allows Amazon EC2 to publish flow logs to the
    /// log destination.
    /// 
    /// This parameter is required if the destination type is cloud-watch-logs, or
    /// if the destination type is kinesis-data-firehose and the delivery stream
    /// and the resources to monitor are in different accounts.
    /// </summary>
    [JsonPropertyName("deliverLogsPermissionARN")]
    public string? DeliverLogsPermissionARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("deliverLogsPermissionRef")]
    public V1alpha1FlowLogSpecDeliverLogsPermissionRef? DeliverLogsPermissionRef { get; set; }

    /// <summary>The destination options.</summary>
    [JsonPropertyName("destinationOptions")]
    public V1alpha1FlowLogSpecDestinationOptions? DestinationOptions { get; set; }

    /// <summary>
    /// The destination for the flow log data. The meaning of this parameter depends
    /// on the destination type.
    /// 
    ///   - If the destination type is cloud-watch-logs, specify the ARN of a CloudWatch
    ///     Logs log group. For example: arn:aws:logs:region:account_id:log-group:my_group
    ///     Alternatively, use the LogGroupName parameter.
    /// 
    ///   - If the destination type is s3, specify the ARN of an S3 bucket. For
    ///     example: arn:aws:s3:::my_bucket/my_subfolder/ The subfolder is optional.
    ///     Note that you can&apos;t use AWSLogs as a subfolder name.
    /// 
    ///   - If the destination type is kinesis-data-firehose, specify the ARN of
    ///     a Kinesis Data Firehose delivery stream. For example: arn:aws:firehose:region:account_id:deliverystream:my_stream
    /// </summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>
    /// The type of destination for the flow log data.
    /// 
    /// Default: cloud-watch-logs
    /// </summary>
    [JsonPropertyName("logDestinationType")]
    public string? LogDestinationType { get; set; }

    /// <summary>
    /// The fields to include in the flow log record. List the fields in the order
    /// in which they should appear. If you omit this parameter, the flow log is
    /// created using the default format. If you specify this parameter, you must
    /// include at least one field. For more information about the available fields,
    /// see Flow log records (https://docs.aws.amazon.com/vpc/latest/userguide/flow-log-records.html)
    /// in the Amazon VPC User Guide or Transit Gateway Flow Log records (https://docs.aws.amazon.com/vpc/latest/tgw/tgw-flow-logs.html#flow-log-records)
    /// in the Amazon Web Services Transit Gateway Guide.
    /// 
    /// Specify the fields using the ${field-id} format, separated by spaces.
    /// </summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    /// <summary>
    /// The name of a new or existing CloudWatch Logs log group where Amazon EC2
    /// publishes your flow logs.
    /// 
    /// This parameter is valid only if the destination type is cloud-watch-logs.
    /// </summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>
    /// The maximum interval of time during which a flow of packets is captured and
    /// aggregated into a flow log record. The possible values are 60 seconds (1
    /// minute) or 600 seconds (10 minutes). This parameter must be 60 seconds for
    /// transit gateway resource types.
    /// 
    /// When a network interface is attached to a Nitro-based instance (https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html),
    /// the aggregation interval is always 60 seconds or less, regardless of the
    /// value that you specify.
    /// 
    /// Default: 600
    /// </summary>
    [JsonPropertyName("maxAggregationInterval")]
    public long? MaxAggregationInterval { get; set; }

    [JsonPropertyName("resourceID")]
    public required string ResourceID { get; set; }

    /// <summary>The type of resource to monitor.</summary>
    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1FlowLogSpecTags>? Tags { get; set; }

    /// <summary>
    /// The type of traffic to monitor (accepted traffic, rejected traffic, or all
    /// traffic). This parameter is not supported for transit gateway resource types.
    /// It is required for the other resource types.
    /// </summary>
    [JsonPropertyName("trafficType")]
    public string? TrafficType { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogStatusAckResourceMetadata
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
public partial class V1alpha1FlowLogStatusConditions
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

/// <summary>
/// Information about the error that occurred. For more information about errors,
/// see Error codes (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/errors-overview.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogStatusUnsuccessfulError
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Information about items that were not successfully processed in a batch call.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogStatusUnsuccessful
{
    /// <summary>
    /// Information about the error that occurred. For more information about errors,
    /// see Error codes (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/errors-overview.html).
    /// </summary>
    [JsonPropertyName("error")]
    public V1alpha1FlowLogStatusUnsuccessfulError? Error { get; set; }

    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary>FlowLogStatus defines the observed state of FlowLog</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FlowLogStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FlowLogStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Unique, case-sensitive identifier that you provide to ensure the idempotency
    /// of the request.
    /// </summary>
    [JsonPropertyName("clientToken")]
    public string? ClientToken { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FlowLogStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("flowLogID")]
    public string? FlowLogID { get; set; }

    /// <summary>Information about the flow logs that could not be created successfully.</summary>
    [JsonPropertyName("unsuccessful")]
    public IList<V1alpha1FlowLogStatusUnsuccessful>? Unsuccessful { get; set; }
}

/// <summary>FlowLog is the Schema for the FlowLogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FlowLog : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FlowLogSpec?>, IStatus<V1alpha1FlowLogStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FlowLog";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "flowlogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowLog";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// FlowLogSpec defines the desired state of FlowLog.
    /// 
    /// Describes a flow log.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1FlowLogSpec? Spec { get; set; }

    /// <summary>FlowLogStatus defines the observed state of FlowLog</summary>
    [JsonPropertyName("status")]
    public V1alpha1FlowLogStatus? Status { get; set; }
}