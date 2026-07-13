#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatchlogs.services.k8s.aws;
/// <summary>LogGroup is the Schema for the LogGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LogGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LogGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LogGroupList";
    public const string KubeGroup = "cloudwatchlogs.services.k8s.aws";
    public const string KubePluralName = "loggroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatchlogs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LogGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LogGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LogGroup> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LogGroupSpecKmsKeyRefFrom
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
public partial class V1alpha1LogGroupSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1LogGroupSpecKmsKeyRefFrom? From { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LogGroupSpecSubscriptionFilters
{
    [JsonPropertyName("destinationARN")]
    public string? DestinationARN { get; set; }

    /// <summary>
    /// The method used to distribute log data to the destination, which can be either
    /// random or grouped by log stream.
    /// </summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    [JsonPropertyName("filterName")]
    public string? FilterName { get; set; }

    /// <summary>
    /// A symbolic description of how CloudWatch Logs should interpret the data in
    /// each log event. For example, a log event can contain timestamps, IP addresses,
    /// strings, and so on. You use the filter pattern to specify what to look for
    /// in the log event message.
    /// </summary>
    [JsonPropertyName("filterPattern")]
    public string? FilterPattern { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }
}

/// <summary>
/// LogGroupSpec defines the desired state of LogGroup.
/// 
/// Represents a log group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LogGroupSpec
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the KMS key to use when encrypting log
    /// data. For more information, see Amazon Resource Names (https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms).
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1LogGroupSpecKmsKeyRef? KmsKeyRef { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("retentionDays")]
    public long? RetentionDays { get; set; }

    [JsonPropertyName("subscriptionFilters")]
    public IList<V1alpha1LogGroupSpecSubscriptionFilters>? SubscriptionFilters { get; set; }

    /// <summary>
    /// The key-value pairs to use for the tags.
    /// 
    /// You can grant users access to certain log groups while preventing them from
    /// accessing other log groups. To do so, tag your groups and use IAM policies
    /// that refer to those tags. To assign tags when you create a log group, you
    /// must have either the logs:TagResource or logs:TagLogGroup permission. For
    /// more information about tagging, see Tagging Amazon Web Services resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html). For more
    /// information about using tags to control access, see Controlling access to
    /// Amazon Web Services resources using tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LogGroupStatusAckResourceMetadata
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
public partial class V1alpha1LogGroupStatusConditions
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

/// <summary>LogGroupStatus defines the observed state of LogGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LogGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1LogGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LogGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The creation time of the log group, expressed as the number of milliseconds
    /// after Jan 1, 1970 00:00:00 UTC.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public long? CreationTime { get; set; }

    /// <summary>
    /// Displays whether this log group has a protection policy, or whether it had
    /// one in the past. For more information, see PutDataProtectionPolicy (https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html).
    /// </summary>
    [JsonPropertyName("dataProtectionStatus")]
    public string? DataProtectionStatus { get; set; }

    /// <summary>The number of metric filters.</summary>
    [JsonPropertyName("metricFilterCount")]
    public long? MetricFilterCount { get; set; }

    [JsonPropertyName("retentionInDays")]
    public long? RetentionInDays { get; set; }

    /// <summary>The number of bytes stored.</summary>
    [JsonPropertyName("storedBytes")]
    public long? StoredBytes { get; set; }
}

/// <summary>LogGroup is the Schema for the LogGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LogGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LogGroupSpec?>, IStatus<V1alpha1LogGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LogGroup";
    public const string KubeGroup = "cloudwatchlogs.services.k8s.aws";
    public const string KubePluralName = "loggroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatchlogs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LogGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// LogGroupSpec defines the desired state of LogGroup.
    /// 
    /// Represents a log group.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1LogGroupSpec? Spec { get; set; }

    /// <summary>LogGroupStatus defines the observed state of LogGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1LogGroupStatus? Status { get; set; }
}