#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53resolver.services.k8s.aws;
/// <summary>ResolverQueryLogConfig is the Schema for the ResolverQueryLogConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverQueryLogConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResolverQueryLogConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverQueryLogConfigList";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverquerylogconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverQueryLogConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResolverQueryLogConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResolverQueryLogConfig> Items { get; set; }
}

/// <summary>
/// One tag that you want to add to the specified resource. A tag consists of
/// a Key (a name for the tag) and a Value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverQueryLogConfigSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ResolverQueryLogConfigSpec defines the desired state of ResolverQueryLogConfig.
/// 
/// In the response to a CreateResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverQueryLogConfig.html),
/// DeleteResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverQueryLogConfig.html),
/// GetResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverQueryLogConfig.html),
/// or ListResolverQueryLogConfigs (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html)
/// request, a complex type that contains settings for one query logging configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverQueryLogConfigSpec
{
    /// <summary>
    /// The ARN of the resource that you want Resolver to send query logs. You can
    /// send query logs to an S3 bucket, a CloudWatch Logs log group, or a Kinesis
    /// Data Firehose delivery stream. Examples of valid values include the following:
    /// 
    ///   - S3 bucket: arn:aws:s3:::amzn-s3-demo-bucket You can optionally append
    ///     a file prefix to the end of the ARN. arn:aws:s3:::amzn-s3-demo-bucket/development/
    /// 
    ///   - CloudWatch Logs log group: arn:aws:logs:us-west-1:123456789012:log-group:/mystack-testgroup-12ABC1AB12A1:*
    /// 
    ///   - Kinesis Data Firehose delivery stream: arn:aws:kinesis:us-east-2:0123456789:stream/my_stream_name
    /// </summary>
    [JsonPropertyName("destinationARN")]
    public required string DestinationARN { get; set; }

    /// <summary>
    /// The name that you want to give the query logging configuration.
    /// 
    /// Regex Pattern: `^(?!^[0-9]+$)([a-zA-Z0-9\-_&apos; &apos;]+)$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of the tag keys and values that you want to associate with the query
    /// logging configuration.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ResolverQueryLogConfigSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverQueryLogConfigStatusAckResourceMetadata
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
public partial class V1alpha1ResolverQueryLogConfigStatusConditions
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

/// <summary>ResolverQueryLogConfigStatus defines the observed state of ResolverQueryLogConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverQueryLogConfigStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResolverQueryLogConfigStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The number of VPCs that are associated with the query logging configuration.</summary>
    [JsonPropertyName("associationCount")]
    public long? AssociationCount { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResolverQueryLogConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time that the query logging configuration was created, in Unix
    /// time format and Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>The ID for the query logging configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The Amazon Web Services account ID for the account that created the query
    /// logging configuration.
    /// </summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>
    /// An indication of whether the query logging configuration is shared with other
    /// Amazon Web Services accounts, or was shared with the current account by another
    /// Amazon Web Services account. Sharing is configured through Resource Access
    /// Manager (RAM).
    /// </summary>
    [JsonPropertyName("shareStatus")]
    public string? ShareStatus { get; set; }

    /// <summary>
    /// The status of the specified query logging configuration. Valid values include
    /// the following:
    /// 
    ///    * CREATING: Resolver is creating the query logging configuration.
    /// 
    ///    * CREATED: The query logging configuration was successfully created. Resolver
    ///    is logging queries that originate in the specified VPC.
    /// 
    ///    * DELETING: Resolver is deleting this query logging configuration.
    /// 
    ///    * FAILED: Resolver can&apos;t deliver logs to the location that is specified
    ///    in the query logging configuration. Here are two common causes: The specified
    ///    destination (for example, an Amazon S3 bucket) was deleted. Permissions
    ///    don&apos;t allow sending logs to the destination.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ResolverQueryLogConfig is the Schema for the ResolverQueryLogConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverQueryLogConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResolverQueryLogConfigSpec?>, IStatus<V1alpha1ResolverQueryLogConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverQueryLogConfig";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverquerylogconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverQueryLogConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResolverQueryLogConfigSpec defines the desired state of ResolverQueryLogConfig.
    /// 
    /// In the response to a CreateResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverQueryLogConfig.html),
    /// DeleteResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverQueryLogConfig.html),
    /// GetResolverQueryLogConfig (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverQueryLogConfig.html),
    /// or ListResolverQueryLogConfigs (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html)
    /// request, a complex type that contains settings for one query logging configuration.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResolverQueryLogConfigSpec? Spec { get; set; }

    /// <summary>ResolverQueryLogConfigStatus defines the observed state of ResolverQueryLogConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResolverQueryLogConfigStatus? Status { get; set; }
}