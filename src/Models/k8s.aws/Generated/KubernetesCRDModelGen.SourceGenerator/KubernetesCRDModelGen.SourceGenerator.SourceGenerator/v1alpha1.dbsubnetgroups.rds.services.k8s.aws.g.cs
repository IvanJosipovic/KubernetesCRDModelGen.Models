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
/// <summary>DBSubnetGroup is the Schema for the DBSubnetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBSubnetGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBSubnetGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBSubnetGroupList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbsubnetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBSubnetGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBSubnetGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBSubnetGroup> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupSpecSubnetRefsFrom
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
public partial class V1alpha1DBSubnetGroupSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBSubnetGroupSpecSubnetRefsFrom? From { get; set; }
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
public partial class V1alpha1DBSubnetGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBSubnetGroupSpec defines the desired state of DBSubnetGroup.
/// 
/// Contains the details of an Amazon RDS DB subnet group.
/// 
/// This data type is used as a response element in the DescribeDBSubnetGroups
/// action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupSpec
{
    /// <summary>The description for the DB subnet group.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The name for the DB subnet group. This value is stored as a lowercase string.
    /// 
    /// Constraints:
    /// 
    ///   - Must contain no more than 255 letters, numbers, periods, underscores,
    ///     spaces, or hyphens.
    /// 
    ///   - Must not be default.
    /// 
    ///   - First character must be a letter.
    /// 
    /// Example: mydbsubnetgroup
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The EC2 Subnet IDs for the DB subnet group.</summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1DBSubnetGroupSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Tags to assign to the DB subnet group.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBSubnetGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupStatusAckResourceMetadata
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
public partial class V1alpha1DBSubnetGroupStatusConditions
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
/// Contains Availability Zone information.
/// 
/// This data type is used as an element in the OrderableDBInstanceOption data
/// type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupStatusSubnetsSubnetAvailabilityZone
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A data type that represents an Outpost.
/// 
/// For more information about RDS on Outposts, see Amazon RDS on Amazon Web
/// Services Outposts (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html)
/// in the Amazon RDS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupStatusSubnetsSubnetOutpost
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>
/// This data type is used as a response element for the DescribeDBSubnetGroups
/// operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupStatusSubnets
{
    /// <summary>
    /// Contains Availability Zone information.
    /// 
    /// This data type is used as an element in the OrderableDBInstanceOption data
    /// type.
    /// </summary>
    [JsonPropertyName("subnetAvailabilityZone")]
    public V1alpha1DBSubnetGroupStatusSubnetsSubnetAvailabilityZone? SubnetAvailabilityZone { get; set; }

    [JsonPropertyName("subnetIdentifier")]
    public string? SubnetIdentifier { get; set; }

    /// <summary>
    /// A data type that represents an Outpost.
    /// 
    /// For more information about RDS on Outposts, see Amazon RDS on Amazon Web
    /// Services Outposts (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html)
    /// in the Amazon RDS User Guide.
    /// </summary>
    [JsonPropertyName("subnetOutpost")]
    public V1alpha1DBSubnetGroupStatusSubnetsSubnetOutpost? SubnetOutpost { get; set; }

    [JsonPropertyName("subnetStatus")]
    public string? SubnetStatus { get; set; }
}

/// <summary>DBSubnetGroupStatus defines the observed state of DBSubnetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSubnetGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBSubnetGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBSubnetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Provides the status of the DB subnet group.</summary>
    [JsonPropertyName("subnetGroupStatus")]
    public string? SubnetGroupStatus { get; set; }

    /// <summary>Contains a list of Subnet elements.</summary>
    [JsonPropertyName("subnets")]
    public IList<V1alpha1DBSubnetGroupStatusSubnets>? Subnets { get; set; }

    /// <summary>
    /// The network type of the DB subnet group.
    /// 
    /// Valid values:
    /// 
    ///    * IPV4
    /// 
    ///    * DUAL
    /// 
    /// A DBSubnetGroup can support only the IPv4 protocol or the IPv4 and the IPv6
    /// protocols (DUAL).
    /// 
    /// For more information, see Working with a DB instance in a VPC (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html)
    /// in the Amazon RDS User Guide.
    /// </summary>
    [JsonPropertyName("supportedNetworkTypes")]
    public IList<string>? SupportedNetworkTypes { get; set; }

    /// <summary>Provides the VpcId of the DB subnet group.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>DBSubnetGroup is the Schema for the DBSubnetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBSubnetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBSubnetGroupSpec?>, IStatus<V1alpha1DBSubnetGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBSubnetGroup";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbsubnetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBSubnetGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBSubnetGroupSpec defines the desired state of DBSubnetGroup.
    /// 
    /// Contains the details of an Amazon RDS DB subnet group.
    /// 
    /// This data type is used as a response element in the DescribeDBSubnetGroups
    /// action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBSubnetGroupSpec? Spec { get; set; }

    /// <summary>DBSubnetGroupStatus defines the observed state of DBSubnetGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBSubnetGroupStatus? Status { get; set; }
}