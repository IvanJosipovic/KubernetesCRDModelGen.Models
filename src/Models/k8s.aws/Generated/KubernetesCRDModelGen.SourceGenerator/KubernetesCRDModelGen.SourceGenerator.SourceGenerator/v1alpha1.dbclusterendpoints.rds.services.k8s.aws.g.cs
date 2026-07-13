#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.services.k8s.aws;
/// <summary>DBClusterEndpoint is the Schema for the DBClusterEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBClusterEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterEndpointList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusterendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBClusterEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBClusterEndpoint> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterEndpointSpecDbClusterIdentifierRefFrom
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
public partial class V1alpha1DBClusterEndpointSpecDbClusterIdentifierRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterEndpointSpecDbClusterIdentifierRefFrom? From { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterEndpointSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBClusterEndpointSpec defines the desired state of DBClusterEndpoint.
/// 
/// This data type represents the information you need to connect to an Amazon
/// Aurora DB cluster. This data type is used as a response element in the following
/// actions:
/// 
///   - CreateDBClusterEndpoint
/// 
///   - DescribeDBClusterEndpoints
/// 
///   - ModifyDBClusterEndpoint
/// 
///   - DeleteDBClusterEndpoint
/// 
/// For the data structure that represents Amazon RDS DB instance endpoints,
/// see Endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterEndpointSpec
{
    /// <summary>
    /// The identifier to use for the new endpoint. This parameter is stored as a
    /// lowercase string.
    /// </summary>
    [JsonPropertyName("dbClusterEndpointIdentifier")]
    public required string DbClusterEndpointIdentifier { get; set; }

    /// <summary>
    /// The DB cluster identifier of the DB cluster associated with the endpoint.
    /// This parameter is stored as a lowercase string.
    /// </summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbClusterIdentifierRef")]
    public V1alpha1DBClusterEndpointSpecDbClusterIdentifierRef? DbClusterIdentifierRef { get; set; }

    /// <summary>The type of the endpoint, one of: READER, WRITER, ANY.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// List of DB instance identifiers that aren&apos;t part of the custom endpoint group.
    /// All other eligible instances are reachable through the custom endpoint. This
    /// parameter is relevant only if the list of static members is empty.
    /// </summary>
    [JsonPropertyName("excludedMembers")]
    public IList<string>? ExcludedMembers { get; set; }

    /// <summary>List of DB instance identifiers that are part of the custom endpoint group.</summary>
    [JsonPropertyName("staticMembers")]
    public IList<string>? StaticMembers { get; set; }

    /// <summary>The tags to be assigned to the Amazon RDS resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBClusterEndpointSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterEndpointStatusAckResourceMetadata
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
public partial class V1alpha1DBClusterEndpointStatusConditions
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

/// <summary>DBClusterEndpointStatus defines the observed state of DBClusterEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterEndpointStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBClusterEndpointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBClusterEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A unique system-generated identifier for an endpoint. It remains the same
    /// for the whole life of the endpoint.
    /// </summary>
    [JsonPropertyName("dbClusterEndpointResourceIdentifier")]
    public string? DbClusterEndpointResourceIdentifier { get; set; }

    /// <summary>The DNS address of the endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The current status of the endpoint. One of: creating, available, deleting,
    /// inactive, modifying. The inactive state applies to an endpoint that can&apos;t
    /// be used for a certain kind of cluster, such as a writer endpoint for a read-only
    /// secondary cluster in a global database.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>DBClusterEndpoint is the Schema for the DBClusterEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBClusterEndpointSpec?>, IStatus<V1alpha1DBClusterEndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterEndpoint";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusterendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBClusterEndpointSpec defines the desired state of DBClusterEndpoint.
    /// 
    /// This data type represents the information you need to connect to an Amazon
    /// Aurora DB cluster. This data type is used as a response element in the following
    /// actions:
    /// 
    ///   - CreateDBClusterEndpoint
    /// 
    ///   - DescribeDBClusterEndpoints
    /// 
    ///   - ModifyDBClusterEndpoint
    /// 
    ///   - DeleteDBClusterEndpoint
    /// 
    /// For the data structure that represents Amazon RDS DB instance endpoints,
    /// see Endpoint.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBClusterEndpointSpec? Spec { get; set; }

    /// <summary>DBClusterEndpointStatus defines the observed state of DBClusterEndpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBClusterEndpointStatus? Status { get; set; }
}