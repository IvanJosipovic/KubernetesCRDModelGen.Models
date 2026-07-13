#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtrail.services.k8s.aws;
/// <summary>Trail is the Schema for the Trails API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TrailList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Trail>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TrailList";
    public const string KubeGroup = "cloudtrail.services.k8s.aws";
    public const string KubePluralName = "trails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrailList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Trail objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Trail> Items { get; set; }
}

/// <summary>
/// A custom key-value pair associated with a resource such as a CloudTrail trail,
/// event data store, dashboard, or channel.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrailSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// TrailSpec defines the desired state of Trail.
/// 
/// The settings for a trail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrailSpec
{
    /// <summary>
    /// Specifies a log group name using an Amazon Resource Name (ARN), a unique
    /// identifier that represents the log group to which CloudTrail logs will be
    /// delivered. You must use a log group that exists in your account.
    /// 
    /// Not required unless you specify CloudWatchLogsRoleArn.
    /// </summary>
    [JsonPropertyName("cloudWatchLogsLogGroupARN")]
    public string? CloudWatchLogsLogGroupARN { get; set; }

    /// <summary>
    /// Specifies the role for the CloudWatch Logs endpoint to assume to write to
    /// a user&apos;s log group. You must use a role that exists in your account.
    /// </summary>
    [JsonPropertyName("cloudWatchLogsRoleARN")]
    public string? CloudWatchLogsRoleARN { get; set; }

    /// <summary>
    /// Specifies whether log file integrity validation is enabled. The default is
    /// false.
    /// 
    /// When you disable log file integrity validation, the chain of digest files
    /// is broken after one hour. CloudTrail does not create digest files for log
    /// files that were delivered during a period in which log file integrity validation
    /// was disabled. For example, if you enable log file integrity validation at
    /// noon on January 1, disable it at noon on January 2, and re-enable it at noon
    /// on January 10, digest files will not be created for the log files delivered
    /// from noon on January 2 to noon on January 10. The same applies whenever you
    /// stop CloudTrail logging or delete a trail.
    /// </summary>
    [JsonPropertyName("enableLogFileValidation")]
    public bool? EnableLogFileValidation { get; set; }

    /// <summary>
    /// Specifies whether the trail is publishing events from global services such
    /// as IAM to the log files.
    /// </summary>
    [JsonPropertyName("includeGlobalServiceEvents")]
    public bool? IncludeGlobalServiceEvents { get; set; }

    /// <summary>
    /// Specifies whether the trail is created in the current Region or in all Regions.
    /// The default is false, which creates a trail only in the Region where you
    /// are signed in. As a best practice, consider creating trails that log events
    /// in all Regions.
    /// </summary>
    [JsonPropertyName("isMultiRegionTrail")]
    public bool? IsMultiRegionTrail { get; set; }

    /// <summary>
    /// Specifies whether the trail is created for all accounts in an organization
    /// in Organizations, or only for the current Amazon Web Services account. The
    /// default is false, and cannot be true unless the call is made on behalf of
    /// an Amazon Web Services account that is the management account or delegated
    /// administrator account for an organization in Organizations.
    /// </summary>
    [JsonPropertyName("isOrganizationTrail")]
    public bool? IsOrganizationTrail { get; set; }

    /// <summary>
    /// Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail.
    /// The value can be an alias name prefixed by alias/, a fully specified ARN
    /// to an alias, a fully specified ARN to a key, or a globally unique identifier.
    /// 
    /// CloudTrail also supports KMS multi-Region keys. For more information about
    /// multi-Region keys, see Using multi-Region keys (https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html)
    /// in the Key Management Service Developer Guide.
    /// 
    /// Examples:
    /// 
    ///   - alias/MyAliasName
    /// 
    ///   - arn:aws:kms:us-east-2:123456789012:alias/MyAliasName
    /// 
    ///   - arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012
    /// 
    ///   - 12345678-1234-1234-1234-123456789012
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// Specifies the name of the trail. The name must meet the following requirements:
    /// 
    ///   - Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores
    ///     (_), or dashes (-)
    /// 
    ///   - Start with a letter or number, and end with a letter or number
    /// 
    ///   - Be between 3 and 128 characters
    /// 
    ///   - Have no adjacent periods, underscores or dashes. Names like my-_namespace
    ///     and my--namespace are not valid.
    /// 
    ///   - Not be in IP address format (for example, 192.168.5.4)
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies the name of the Amazon S3 bucket designated for publishing log
    /// files. For information about bucket naming rules, see Bucket naming rules
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html)
    /// in the Amazon Simple Storage Service User Guide.
    /// </summary>
    [JsonPropertyName("s3BucketName")]
    public required string S3BucketName { get; set; }

    /// <summary>
    /// Specifies the Amazon S3 key prefix that comes after the name of the bucket
    /// you have designated for log file delivery. For more information, see Finding
    /// Your CloudTrail Log Files (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/get-and-view-cloudtrail-log-files.html#cloudtrail-find-log-files).
    /// The maximum length is 200 characters.
    /// </summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>
    /// Specifies the name of the Amazon SNS topic defined for notification of log
    /// file delivery. The maximum length is 256 characters.
    /// </summary>
    [JsonPropertyName("snsTopicName")]
    public string? SnsTopicName { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1TrailSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrailStatusAckResourceMetadata
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
public partial class V1alpha1TrailStatusConditions
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

/// <summary>TrailStatus defines the observed state of Trail</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrailStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TrailStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TrailStatusConditions>? Conditions { get; set; }

    /// <summary>Specifies whether log file integrity validation is enabled.</summary>
    [JsonPropertyName("logFileValidationEnabled")]
    public bool? LogFileValidationEnabled { get; set; }

    /// <summary>
    /// Specifies the ARN of the Amazon SNS topic that CloudTrail uses to send notifications
    /// when log files are delivered. The format of a topic ARN is:
    /// 
    /// arn:aws:sns:us-east-2:123456789012:MyTopic
    /// </summary>
    [JsonPropertyName("snsTopicARN")]
    public string? SnsTopicARN { get; set; }
}

/// <summary>Trail is the Schema for the Trails API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Trail : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TrailSpec?>, IStatus<V1alpha1TrailStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Trail";
    public const string KubeGroup = "cloudtrail.services.k8s.aws";
    public const string KubePluralName = "trails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Trail";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// TrailSpec defines the desired state of Trail.
    /// 
    /// The settings for a trail.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1TrailSpec? Spec { get; set; }

    /// <summary>TrailStatus defines the observed state of Trail</summary>
    [JsonPropertyName("status")]
    public V1alpha1TrailStatus? Status { get; set; }
}