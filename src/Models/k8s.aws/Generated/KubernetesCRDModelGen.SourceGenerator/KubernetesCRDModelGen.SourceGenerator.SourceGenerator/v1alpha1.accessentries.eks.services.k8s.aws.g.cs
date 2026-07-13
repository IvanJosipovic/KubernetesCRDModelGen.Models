#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eks.services.k8s.aws;
/// <summary>AccessEntry is the Schema for the AccessEntries API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessEntryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AccessEntry>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessEntryList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "accessentries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessEntryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AccessEntry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AccessEntry> Items { get; set; }
}

/// <summary>The scope of an AccessPolicy that&apos;s associated to an AccessEntry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntrySpecAccessPoliciesAccessScope
{
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntrySpecAccessPolicies
{
    /// <summary>The scope of an AccessPolicy that&apos;s associated to an AccessEntry.</summary>
    [JsonPropertyName("accessScope")]
    public V1alpha1AccessEntrySpecAccessPoliciesAccessScope? AccessScope { get; set; }

    [JsonPropertyName("policyARN")]
    public string? PolicyARN { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntrySpecClusterRefFrom
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
public partial class V1alpha1AccessEntrySpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AccessEntrySpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// AccessEntrySpec defines the desired state of AccessEntry.
/// 
/// An access entry allows an IAM principal (user or role) to access your cluster.
/// Access entries can replace the need to maintain the aws-auth ConfigMap for
/// authentication. For more information about access entries, see Access entries
/// (https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html) in
/// the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntrySpec
{
    [JsonPropertyName("accessPolicies")]
    public IList<V1alpha1AccessEntrySpecAccessPolicies>? AccessPolicies { get; set; }

    /// <summary>The name of your cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1AccessEntrySpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// The value for name that you&apos;ve specified for kind: Group as a subject in
    /// a Kubernetes RoleBinding or ClusterRoleBinding object. Amazon EKS doesn&apos;t
    /// confirm that the value for name exists in any bindings on your cluster. You
    /// can specify one or more names.
    /// 
    /// Kubernetes authorizes the principalArn of the access entry to access any
    /// cluster objects that you&apos;ve specified in a Kubernetes Role or ClusterRole
    /// object that is also specified in a binding&apos;s roleRef. For more information
    /// about creating Kubernetes RoleBinding, ClusterRoleBinding, Role, or ClusterRole
    /// objects, see Using RBAC Authorization in the Kubernetes documentation (https://kubernetes.io/docs/reference/access-authn-authz/rbac/).
    /// 
    /// If you want Amazon EKS to authorize the principalArn (instead of, or in addition
    /// to Kubernetes authorizing the principalArn), you can associate one or more
    /// access policies to the access entry using AssociateAccessPolicy. If you associate
    /// any access policies, the principalARN has all permissions assigned in the
    /// associated access policies and all permissions in any Kubernetes Role or
    /// ClusterRole objects that the group names are bound to.
    /// </summary>
    [JsonPropertyName("kubernetesGroups")]
    public IList<string>? KubernetesGroups { get; set; }

    /// <summary>
    /// The ARN of the IAM principal for the AccessEntry. You can specify one ARN
    /// for each access entry. You can&apos;t specify the same ARN in more than one access
    /// entry. This value can&apos;t be changed after access entry creation.
    /// 
    /// The valid principals differ depending on the type of the access entry in
    /// the type field. For STANDARD access entries, you can use every IAM principal
    /// type. For nodes (EC2 (for EKS Auto Mode), EC2_LINUX, EC2_WINDOWS, FARGATE_LINUX,
    /// and HYBRID_LINUX), the only valid ARN is IAM roles. You can&apos;t use the STS
    /// session principal type with access entries because this is a temporary principal
    /// for each session and not a permanent identity that can be assigned permissions.
    /// 
    /// IAM best practices (https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#bp-users-federation-idp)
    /// recommend using IAM roles with temporary credentials, rather than IAM users
    /// with long-term credentials.
    /// </summary>
    [JsonPropertyName("principalARN")]
    public required string PrincipalARN { get; set; }

    /// <summary>
    /// Metadata that assists with categorization and organization. Each tag consists
    /// of a key and an optional value. You define both. Tags don&apos;t propagate to
    /// any other cluster or Amazon Web Services resources.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The type of the new access entry. Valid values are STANDARD, FARGATE_LINUX,
    /// EC2_LINUX, EC2_WINDOWS, EC2 (for EKS Auto Mode), HYBRID_LINUX, and HYPERPOD_LINUX.
    /// 
    /// If the principalArn is for an IAM role that&apos;s used for self-managed Amazon
    /// EC2 nodes, specify EC2_LINUX or EC2_WINDOWS. Amazon EKS grants the necessary
    /// permissions to the node for you. If the principalArn is for any other purpose,
    /// specify STANDARD. If you don&apos;t specify a value, Amazon EKS sets the value
    /// to STANDARD. If you have the access mode of the cluster set to API_AND_CONFIG_MAP,
    /// it&apos;s unnecessary to create access entries for IAM roles used with Fargate
    /// profiles or managed Amazon EC2 nodes, because Amazon EKS creates entries
    /// in the aws-auth ConfigMap for the roles. You can&apos;t change this value once
    /// you&apos;ve created the access entry.
    /// 
    /// If you set the value to EC2_LINUX or EC2_WINDOWS, you can&apos;t specify values
    /// for kubernetesGroups, or associate an AccessPolicy to the access entry.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The username to authenticate to Kubernetes with. We recommend not specifying
    /// a username and letting Amazon EKS specify it for you. For more information
    /// about the value Amazon EKS specifies for you, or constraints before specifying
    /// your own username, see Creating access entries (https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html#creating-access-entries)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntryStatusAckResourceMetadata
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
public partial class V1alpha1AccessEntryStatusConditions
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

/// <summary>AccessEntryStatus defines the observed state of AccessEntry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccessEntryStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AccessEntryStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AccessEntryStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix epoch timestamp at object creation.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>The Unix epoch timestamp for the last modification to the object.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }
}

/// <summary>AccessEntry is the Schema for the AccessEntries API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccessEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccessEntrySpec?>, IStatus<V1alpha1AccessEntryStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccessEntry";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "accessentries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessEntry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AccessEntrySpec defines the desired state of AccessEntry.
    /// 
    /// An access entry allows an IAM principal (user or role) to access your cluster.
    /// Access entries can replace the need to maintain the aws-auth ConfigMap for
    /// authentication. For more information about access entries, see Access entries
    /// (https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html) in
    /// the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AccessEntrySpec? Spec { get; set; }

    /// <summary>AccessEntryStatus defines the observed state of AccessEntry</summary>
    [JsonPropertyName("status")]
    public V1alpha1AccessEntryStatus? Status { get; set; }
}