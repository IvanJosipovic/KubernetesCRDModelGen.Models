#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatch.services.k8s.aws;
/// <summary>MetricStream is the Schema for the MetricStreams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetricStreamList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetricStream>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetricStreamList";
    public const string KubeGroup = "cloudwatch.services.k8s.aws";
    public const string KubePluralName = "metricstreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricStreamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MetricStream objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MetricStream> Items { get; set; }
}

/// <summary>
/// This structure contains a metric namespace and optionally, a list of metric
/// names, to either include in a metric stream or exclude from a metric stream.
/// 
/// A metric stream&apos;s filters can include up to 1000 total names. This limit
/// applies to the sum of namespace names and metric names in the filters. For
/// example, this could include 10 metric namespace filters with 99 metrics each,
/// or 20 namespace filters with 49 metrics specified in each filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecExcludeFilters
{
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecFirehoseRefFrom
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
public partial class V1alpha1MetricStreamSpecFirehoseRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1MetricStreamSpecFirehoseRefFrom? From { get; set; }
}

/// <summary>
/// This structure contains a metric namespace and optionally, a list of metric
/// names, to either include in a metric stream or exclude from a metric stream.
/// 
/// A metric stream&apos;s filters can include up to 1000 total names. This limit
/// applies to the sum of namespace names and metric names in the filters. For
/// example, this could include 10 metric namespace filters with 99 metrics each,
/// or 20 namespace filters with 49 metrics specified in each filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecIncludeFilters
{
    [JsonPropertyName("metricNames")]
    public IList<string>? MetricNames { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecRoleRefFrom
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
public partial class V1alpha1MetricStreamSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1MetricStreamSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// This object contains the information for one metric that is to be streamed
/// with additional statistics.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecStatisticsConfigurationsIncludeMetrics
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// By default, a metric stream always sends the MAX, MIN, SUM, and SAMPLECOUNT
/// statistics for each metric that is streamed. This structure contains information
/// for one metric that includes additional statistics in the stream. For more
/// information about statistics, see CloudWatch, listed in CloudWatch statistics
/// definitions (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecStatisticsConfigurations
{
    [JsonPropertyName("additionalStatistics")]
    public IList<string>? AdditionalStatistics { get; set; }

    [JsonPropertyName("includeMetrics")]
    public IList<V1alpha1MetricStreamSpecStatisticsConfigurationsIncludeMetrics>? IncludeMetrics { get; set; }
}

/// <summary>A key-value pair associated with a CloudWatch resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>MetricStreamSpec defines the desired state of MetricStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamSpec
{
    /// <summary>
    /// If you specify this parameter, the stream sends metrics from all metric namespaces
    /// except for the namespaces that you specify here.
    /// 
    /// You cannot include ExcludeFilters and IncludeFilters in the same operation.
    /// </summary>
    [JsonPropertyName("excludeFilters")]
    public IList<V1alpha1MetricStreamSpecExcludeFilters>? ExcludeFilters { get; set; }

    /// <summary>
    /// The ARN of the Amazon Kinesis Data Firehose delivery stream to use for this
    /// metric stream. This Amazon Kinesis Data Firehose delivery stream must already
    /// exist and must be in the same account as the metric stream.
    /// </summary>
    [JsonPropertyName("firehoseARN")]
    public string? FirehoseARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("firehoseRef")]
    public V1alpha1MetricStreamSpecFirehoseRef? FirehoseRef { get; set; }

    /// <summary>
    /// If you specify this parameter, the stream sends only the metrics from the
    /// metric namespaces that you specify here.
    /// 
    /// You cannot include IncludeFilters and ExcludeFilters in the same operation.
    /// </summary>
    [JsonPropertyName("includeFilters")]
    public IList<V1alpha1MetricStreamSpecIncludeFilters>? IncludeFilters { get; set; }

    /// <summary>
    /// If you are creating a metric stream in a monitoring account, specify true
    /// to include metrics from source accounts in the metric stream.
    /// </summary>
    [JsonPropertyName("includeLinkedAccountsMetrics")]
    public bool? IncludeLinkedAccountsMetrics { get; set; }

    /// <summary>
    /// If you are creating a new metric stream, this is the name for the new stream.
    /// The name must be different than the names of other metric streams in this
    /// account and Region.
    /// 
    /// If you are updating a metric stream, specify the name of that stream here.
    /// 
    /// Valid characters are A-Z, a-z, 0-9, &quot;-&quot; and &quot;_&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The output format for the stream. Valid values are json, opentelemetry1.0,
    /// and opentelemetry0.7. For more information about metric stream output formats,
    /// see Metric streams output formats (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-metric-streams-formats.html).
    /// </summary>
    [JsonPropertyName("outputFormat")]
    public required string OutputFormat { get; set; }

    /// <summary>
    /// The ARN of an IAM role that this metric stream will use to access Amazon
    /// Kinesis Data Firehose resources. This IAM role must already exist and must
    /// be in the same account as the metric stream. This IAM role must include the
    /// following permissions:
    /// 
    ///   - firehose:PutRecord
    /// 
    ///   - firehose:PutRecordBatch
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
    public V1alpha1MetricStreamSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// By default, a metric stream always sends the MAX, MIN, SUM, and SAMPLECOUNT
    /// statistics for each metric that is streamed. You can use this parameter to
    /// have the metric stream also send additional statistics in the stream. This
    /// array can have up to 100 members.
    /// 
    /// For each entry in this array, you specify one or more metrics and the list
    /// of additional statistics to stream for those metrics. The additional statistics
    /// that you can stream depend on the stream&apos;s OutputFormat. If the OutputFormat
    /// is json, you can stream any additional statistic that is supported by CloudWatch,
    /// listed in CloudWatch statistics definitions (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html.html).
    /// If the OutputFormat is opentelemetry1.0 or opentelemetry0.7, you can stream
    /// percentile statistics such as p95, p99.9, and so on.
    /// </summary>
    [JsonPropertyName("statisticsConfigurations")]
    public IList<V1alpha1MetricStreamSpecStatisticsConfigurations>? StatisticsConfigurations { get; set; }

    /// <summary>
    /// A list of key-value pairs to associate with the metric stream. You can associate
    /// as many as 50 tags with a metric stream.
    /// 
    /// Tags can help you organize and categorize your resources. You can also use
    /// them to scope user permissions by granting a user permission to access or
    /// change only resources with certain tag values.
    /// 
    /// You can use this parameter only when you are creating a new metric stream.
    /// If you are using this operation to update an existing metric stream, any
    /// tags you specify in this parameter are ignored. To change the tags of an
    /// existing metric stream, use TagResource (https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html)
    /// or UntagResource (https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UntagResource.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1MetricStreamSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamStatusAckResourceMetadata
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
public partial class V1alpha1MetricStreamStatusConditions
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

/// <summary>MetricStreamStatus defines the observed state of MetricStream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStreamStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1MetricStreamStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetricStreamStatusConditions>? Conditions { get; set; }
}

/// <summary>MetricStream is the Schema for the MetricStreams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetricStream : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetricStreamSpec?>, IStatus<V1alpha1MetricStreamStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetricStream";
    public const string KubeGroup = "cloudwatch.services.k8s.aws";
    public const string KubePluralName = "metricstreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricStream";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetricStreamSpec defines the desired state of MetricStream.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MetricStreamSpec? Spec { get; set; }

    /// <summary>MetricStreamStatus defines the observed state of MetricStream</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetricStreamStatus? Status { get; set; }
}