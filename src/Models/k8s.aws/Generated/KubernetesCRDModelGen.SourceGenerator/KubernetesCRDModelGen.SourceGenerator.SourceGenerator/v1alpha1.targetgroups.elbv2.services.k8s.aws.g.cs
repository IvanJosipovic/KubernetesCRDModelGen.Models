#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.services.k8s.aws;
/// <summary>TargetGroup is the Schema for the TargetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TargetGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TargetGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TargetGroupList";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "targetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TargetGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TargetGroup> Items { get; set; }
}

/// <summary>Information about a target group attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpecAttributes
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// [HTTP/HTTPS health checks] The HTTP or gRPC codes to use when checking for
/// a successful response from a target. For target groups with a protocol of
/// TCP, TCP_UDP, UDP or TLS the range is 200-599. For target groups with a protocol
/// of HTTP or HTTPS, the range is 200-499. For target groups with a protocol
/// of GENEVE, the range is 200-399.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpecMatcher
{
    [JsonPropertyName("grpcCode")]
    public string? GrpcCode { get; set; }

    [JsonPropertyName("httpCode")]
    public string? HttpCode { get; set; }
}

/// <summary>Information about a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Information about a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpecTargets
{
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpecVpcRefFrom
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
public partial class V1alpha1TargetGroupSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1TargetGroupSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// TargetGroupSpec defines the desired state of TargetGroup.
/// 
/// Information about a target group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupSpec
{
    /// <summary>The target group attributes.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1TargetGroupSpecAttributes>? Attributes { get; set; }

    /// <summary>
    /// Indicates whether health checks are enabled. If the target type is lambda,
    /// health checks are disabled by default but can be enabled. If the target type
    /// is instance, ip, or alb, health checks are always enabled and can&apos;t be disabled.
    /// </summary>
    [JsonPropertyName("healthCheckEnabled")]
    public bool? HealthCheckEnabled { get; set; }

    /// <summary>
    /// The approximate amount of time, in seconds, between health checks of an individual
    /// target. The range is 5-300. If the target group protocol is TCP, TLS, UDP,
    /// TCP_UDP, HTTP or HTTPS, the default is 30 seconds. If the target group protocol
    /// is GENEVE, the default is 10 seconds. If the target type is lambda, the default
    /// is 35 seconds.
    /// </summary>
    [JsonPropertyName("healthCheckIntervalSeconds")]
    public long? HealthCheckIntervalSeconds { get; set; }

    /// <summary>
    /// [HTTP/HTTPS health checks] The destination for health checks on the targets.
    /// 
    /// [HTTP1 or HTTP2 protocol version] The ping path. The default is /.
    /// 
    /// [GRPC protocol version] The path of a custom health check method with the
    /// format /package.service/method. The default is /Amazon Web Services.ALB/healthcheck.
    /// </summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>
    /// The port the load balancer uses when performing health checks on targets.
    /// If the protocol is HTTP, HTTPS, TCP, TLS, UDP, or TCP_UDP, the default is
    /// traffic-port, which is the port on which each target receives traffic from
    /// the load balancer. If the protocol is GENEVE, the default is port 80.
    /// </summary>
    [JsonPropertyName("healthCheckPort")]
    public string? HealthCheckPort { get; set; }

    /// <summary>
    /// The protocol the load balancer uses when performing health checks on targets.
    /// For Application Load Balancers, the default is HTTP. For Network Load Balancers
    /// and Gateway Load Balancers, the default is TCP. The TCP protocol is not supported
    /// for health checks if the protocol of the target group is HTTP or HTTPS. The
    /// GENEVE, TLS, UDP, and TCP_UDP protocols are not supported for health checks.
    /// </summary>
    [JsonPropertyName("healthCheckProtocol")]
    public string? HealthCheckProtocol { get; set; }

    /// <summary>
    /// The amount of time, in seconds, during which no response from a target means
    /// a failed health check. The range is 2–120 seconds. For target groups with
    /// a protocol of HTTP, the default is 6 seconds. For target groups with a protocol
    /// of TCP, TLS or HTTPS, the default is 10 seconds. For target groups with a
    /// protocol of GENEVE, the default is 5 seconds. If the target type is lambda,
    /// the default is 30 seconds.
    /// </summary>
    [JsonPropertyName("healthCheckTimeoutSeconds")]
    public long? HealthCheckTimeoutSeconds { get; set; }

    /// <summary>
    /// The number of consecutive health check successes required before considering
    /// a target healthy. The range is 2-10. If the target group protocol is TCP,
    /// TCP_UDP, UDP, TLS, HTTP or HTTPS, the default is 5. For target groups with
    /// a protocol of GENEVE, the default is 5. If the target type is lambda, the
    /// default is 5.
    /// </summary>
    [JsonPropertyName("healthyThresholdCount")]
    public long? HealthyThresholdCount { get; set; }

    /// <summary>The IP address type. The default value is ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>
    /// [HTTP/HTTPS health checks] The HTTP or gRPC codes to use when checking for
    /// a successful response from a target. For target groups with a protocol of
    /// TCP, TCP_UDP, UDP or TLS the range is 200-599. For target groups with a protocol
    /// of HTTP or HTTPS, the range is 200-499. For target groups with a protocol
    /// of GENEVE, the range is 200-399.
    /// </summary>
    [JsonPropertyName("matcher")]
    public V1alpha1TargetGroupSpecMatcher? Matcher { get; set; }

    /// <summary>
    /// The name of the target group.
    /// 
    /// This name must be unique per region per account, can have a maximum of 32
    /// characters, must contain only alphanumeric characters or hyphens, and must
    /// not begin or end with a hyphen.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The port on which the targets receive traffic. This port is used unless you
    /// specify a port override when registering the target. If the target is a Lambda
    /// function, this parameter does not apply. If the protocol is GENEVE, the supported
    /// port is 6081.
    /// </summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// The protocol to use for routing traffic to the targets. For Application Load
    /// Balancers, the supported protocols are HTTP and HTTPS. For Network Load Balancers,
    /// the supported protocols are TCP, TLS, UDP, or TCP_UDP. For Gateway Load Balancers,
    /// the supported protocol is GENEVE. A TCP_UDP listener must be associated with
    /// a TCP_UDP target group. If the target is a Lambda function, this parameter
    /// does not apply.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// [HTTP/HTTPS protocol] The protocol version. Specify GRPC to send requests
    /// to targets using gRPC. Specify HTTP2 to send requests to targets using HTTP/2.
    /// The default is HTTP1, which sends requests to targets using HTTP/1.1.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The tags to assign to the target group.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1TargetGroupSpecTags>? Tags { get; set; }

    /// <summary>
    /// The type of target that you must specify when registering targets with this
    /// target group. You can&apos;t specify targets for a target group using more than
    /// one target type.
    /// 
    ///   - instance - Register targets by instance ID. This is the default value.
    /// 
    ///   - ip - Register targets by IP address. You can specify IP addresses from
    ///     the subnets of the virtual private cloud (VPC) for the target group, the
    ///     RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the
    ///     RFC 6598 range (100.64.0.0/10). You can&apos;t specify publicly routable IP
    ///     addresses.
    /// 
    ///   - lambda - Register a single Lambda function as a target.
    /// 
    ///   - alb - Register a single Application Load Balancer as a target.
    /// </summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>The targets.</summary>
    [JsonPropertyName("targets")]
    public IList<V1alpha1TargetGroupSpecTargets>? Targets { get; set; }

    /// <summary>
    /// The number of consecutive health check failures required before considering
    /// a target unhealthy. The range is 2-10. If the target group protocol is TCP,
    /// TCP_UDP, UDP, TLS, HTTP or HTTPS, the default is 2. For target groups with
    /// a protocol of GENEVE, the default is 2. If the target type is lambda, the
    /// default is 5.
    /// </summary>
    [JsonPropertyName("unhealthyThresholdCount")]
    public long? UnhealthyThresholdCount { get; set; }

    /// <summary>
    /// The identifier of the virtual private cloud (VPC). If the target is a Lambda
    /// function, this parameter does not apply. Otherwise, this parameter is required.
    /// </summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1TargetGroupSpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupStatusAckResourceMetadata
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
public partial class V1alpha1TargetGroupStatusConditions
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

/// <summary>TargetGroupStatus defines the observed state of TargetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TargetGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TargetGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TargetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the load balancer that routes traffic to
    /// this target group. You can use each target group with only one load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerARNs")]
    public IList<string>? LoadBalancerARNs { get; set; }
}

/// <summary>TargetGroup is the Schema for the TargetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TargetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TargetGroupSpec?>, IStatus<V1alpha1TargetGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TargetGroup";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "targetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// TargetGroupSpec defines the desired state of TargetGroup.
    /// 
    /// Information about a target group.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1TargetGroupSpec? Spec { get; set; }

    /// <summary>TargetGroupStatus defines the observed state of TargetGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1TargetGroupStatus? Status { get; set; }
}