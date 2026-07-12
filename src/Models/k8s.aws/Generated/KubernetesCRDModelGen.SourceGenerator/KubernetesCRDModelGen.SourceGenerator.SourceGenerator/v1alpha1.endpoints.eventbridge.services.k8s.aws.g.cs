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
/// <summary>Endpoint is the Schema for the Endpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Endpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "eventbridge.services.k8s.aws";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventbridge.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Endpoint> Items { get; set; }
}

/// <summary>The event buses the endpoint is associated with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecEventBuses
{
    [JsonPropertyName("eventBusARN")]
    public string? EventBusARN { get; set; }
}

/// <summary>
/// Enable or disable event replication. The default state is ENABLED which means
/// you must supply a RoleArn. If you don&apos;t have a RoleArn or you don&apos;t want
/// event replication enabled, set the state to DISABLED.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecReplicationConfig
{
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecRoleRefFrom
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
public partial class V1alpha1EndpointSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1EndpointSpecRoleRefFrom? From { get; set; }
}

/// <summary>The primary Region of the endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecRoutingConfigFailoverConfigPrimary
{
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }
}

/// <summary>
/// The secondary Region that processes events when failover is triggered or
/// replication is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecRoutingConfigFailoverConfigSecondary
{
    [JsonPropertyName("route")]
    public string? Route { get; set; }
}

/// <summary>
/// The failover configuration for an endpoint. This includes what triggers failover
/// and what happens when it&apos;s triggered.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecRoutingConfigFailoverConfig
{
    /// <summary>The primary Region of the endpoint.</summary>
    [JsonPropertyName("primary")]
    public V1alpha1EndpointSpecRoutingConfigFailoverConfigPrimary? Primary { get; set; }

    /// <summary>
    /// The secondary Region that processes events when failover is triggered or
    /// replication is enabled.
    /// </summary>
    [JsonPropertyName("secondary")]
    public V1alpha1EndpointSpecRoutingConfigFailoverConfigSecondary? Secondary { get; set; }
}

/// <summary>Configure the routing policy, including the health check and secondary Region..</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecRoutingConfig
{
    /// <summary>
    /// The failover configuration for an endpoint. This includes what triggers failover
    /// and what happens when it&apos;s triggered.
    /// </summary>
    [JsonPropertyName("failoverConfig")]
    public V1alpha1EndpointSpecRoutingConfigFailoverConfig? FailoverConfig { get; set; }
}

/// <summary>
/// EndpointSpec defines the desired state of Endpoint.
/// 
/// A global endpoint used to improve your application&apos;s availability by making
/// it regional-fault tolerant. For more information about global endpoints,
/// see Making applications Regional-fault tolerant with global endpoints and
/// event replication (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html)
/// in the Amazon EventBridge User Guide .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpec
{
    /// <summary>
    /// A description of the global endpoint.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Define the event buses used.
    /// 
    /// The names of the event buses must be identical in each Region.
    /// </summary>
    [JsonPropertyName("eventBuses")]
    public required IList<V1alpha1EndpointSpecEventBuses> EventBuses { get; set; }

    /// <summary>
    /// The name of the global endpoint. For example, &quot;Name&quot;:&quot;us-east-2-custom_bus_A-endpoint&quot;.
    /// 
    /// Regex Pattern: `^[\.\-_A-Za-z0-9]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Enable or disable event replication. The default state is ENABLED which means
    /// you must supply a RoleArn. If you don&apos;t have a RoleArn or you don&apos;t want
    /// event replication enabled, set the state to DISABLED.
    /// </summary>
    [JsonPropertyName("replicationConfig")]
    public V1alpha1EndpointSpecReplicationConfig? ReplicationConfig { get; set; }

    /// <summary>
    /// The ARN of the role used for replication.
    /// 
    /// Regex Pattern: `^arn:aws[a-z-]*:iam::\d{12}:role\/[\w+=,.@/-]+$`
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
    public V1alpha1EndpointSpecRoleRef? RoleRef { get; set; }

    /// <summary>Configure the routing policy, including the health check and secondary Region..</summary>
    [JsonPropertyName("routingConfig")]
    public required V1alpha1EndpointSpecRoutingConfig RoutingConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusAckResourceMetadata
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
public partial class V1alpha1EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1EndpointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>The state of the endpoint that was created by this request.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The reason the endpoint you asked for information about is in its current
    /// state.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EndpointSpec?>, IStatus<V1alpha1EndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "eventbridge.services.k8s.aws";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventbridge.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// EndpointSpec defines the desired state of Endpoint.
    /// 
    /// A global endpoint used to improve your application&apos;s availability by making
    /// it regional-fault tolerant. For more information about global endpoints,
    /// see Making applications Regional-fault tolerant with global endpoints and
    /// event replication (https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html)
    /// in the Amazon EventBridge User Guide .
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1EndpointSpec? Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1EndpointStatus? Status { get; set; }
}