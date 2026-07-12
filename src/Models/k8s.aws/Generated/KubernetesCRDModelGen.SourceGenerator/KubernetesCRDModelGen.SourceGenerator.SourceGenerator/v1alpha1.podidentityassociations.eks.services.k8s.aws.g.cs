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
/// <summary>PodIdentityAssociation is the Schema for the PodIdentityAssociations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PodIdentityAssociationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PodIdentityAssociation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PodIdentityAssociationList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "podidentityassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PodIdentityAssociationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PodIdentityAssociation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PodIdentityAssociation> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationSpecClusterRefFrom
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
public partial class V1alpha1PodIdentityAssociationSpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1PodIdentityAssociationSpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationSpecRoleRefFrom
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
public partial class V1alpha1PodIdentityAssociationSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1PodIdentityAssociationSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationSpecTargetRoleRefFrom
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
public partial class V1alpha1PodIdentityAssociationSpecTargetRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1PodIdentityAssociationSpecTargetRoleRefFrom? From { get; set; }
}

/// <summary>
/// PodIdentityAssociationSpec defines the desired state of PodIdentityAssociation.
/// 
/// Amazon EKS Pod Identity associations provide the ability to manage credentials
/// for your applications, similar to the way that Amazon EC2 instance profiles
/// provide credentials to Amazon EC2 instances.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationSpec
{
    /// <summary>
    /// A unique, case-sensitive identifier that you provide to ensurethe idempotency
    /// of the request.
    /// </summary>
    [JsonPropertyName("clientRequestToken")]
    public string? ClientRequestToken { get; set; }

    /// <summary>The name of the cluster to create the EKS Pod Identity association in.</summary>
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
    public V1alpha1PodIdentityAssociationSpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// Disable the automatic sessions tags that are appended by EKS Pod Identity.
    /// 
    /// EKS Pod Identity adds a pre-defined set of session tags when it assumes the
    /// role. You can use these tags to author a single role that can work across
    /// resources by allowing access to Amazon Web Services resources based on matching
    /// tags. By default, EKS Pod Identity attaches six tags, including tags for
    /// cluster name, namespace, and service account name. For the list of tags added
    /// by EKS Pod Identity, see List of session tags added by EKS Pod Identity (https://docs.aws.amazon.com/eks/latest/userguide/pod-id-abac.html#pod-id-abac-tags)
    /// in the Amazon EKS User Guide.
    /// 
    /// Amazon Web Services compresses inline session policies, managed policy ARNs,
    /// and session tags into a packed binary format that has a separate limit. If
    /// you receive a PackedPolicyTooLarge error indicating the packed binary format
    /// has exceeded the size limit, you can attempt to reduce the size by disabling
    /// the session tags added by EKS Pod Identity.
    /// </summary>
    [JsonPropertyName("disableSessionTags")]
    public bool? DisableSessionTags { get; set; }

    /// <summary>
    /// The name of the Kubernetes namespace inside the cluster to create the EKS
    /// Pod Identity association in. The service account and the Pods that use the
    /// service account must be in this namespace.
    /// </summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>
    /// An optional IAM policy in JSON format (as an escaped string) that applies
    /// additional restrictions to this pod identity association beyond the IAM policies
    /// attached to the IAM role. This policy is applied as the intersection of the
    /// role&apos;s policies and this policy, allowing you to reduce the permissions that
    /// applications in the pods can use. Use this policy to enforce least privilege
    /// access while still leveraging a shared IAM role across multiple applications.
    /// 
    /// Important considerations
    /// 
    ///   - Session tags: When using this policy, disableSessionTags must be set
    ///     to true.
    /// 
    ///   - Target role permissions: If you specify both a TargetRoleArn and a policy,
    ///     the policy restrictions apply only to the target role&apos;s permissions, not
    ///     to the initial role used for assuming the target role.
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role to associate with the service
    /// account. The EKS Pod Identity agent manages credentials to assume this role
    /// for applications in the containers in the Pods that use this service account.
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
    public V1alpha1PodIdentityAssociationSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// The name of the Kubernetes service account inside the cluster to associate
    /// the IAM credentials with.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public required string ServiceAccount { get; set; }

    /// <summary>
    /// Metadata that assists with categorization and organization. Each tag consists
    /// of a key and an optional value. You define both. Tags don&apos;t propagate to
    /// any other cluster or Amazon Web Services resources.
    /// 
    /// The following basic restrictions apply to tags:
    /// 
    ///   - Maximum number of tags per resource – 50
    /// 
    ///   - For each resource, each tag key must be unique, and each tag key can
    ///     have only one value.
    /// 
    ///   - Maximum key length – 128 Unicode characters in UTF-8
    /// 
    ///   - Maximum value length – 256 Unicode characters in UTF-8
    /// 
    ///   - If your tagging schema is used across multiple services and resources,
    ///     remember that other services may have restrictions on allowed characters.
    ///     Generally allowed characters are: letters, numbers, and spaces representable
    ///     in UTF-8, and the following characters: + - = . _ : / @.
    /// 
    ///   - Tag keys and values are case-sensitive.
    /// 
    ///   - Do not use aws:, AWS:, or any upper or lowercase combination of such
    ///     as a prefix for either keys or values as it is reserved for Amazon Web
    ///     Services use. You cannot edit or delete tag keys or values with this prefix.
    ///     Tags with this prefix do not count against your tags per resource limit.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the target IAM role to associate with the
    /// service account. This role is assumed by using the EKS Pod Identity association
    /// role, then the credentials for this role are injected into the Pod.
    /// 
    /// When you run applications on Amazon EKS, your application might need to access
    /// Amazon Web Services resources from a different role that exists in the same
    /// or different Amazon Web Services account. For example, your application running
    /// in “Account A” might need to access resources, such as Amazon S3 buckets
    /// in “Account B” or within “Account A” itself. You can create a association
    /// to access Amazon Web Services resources in “Account B” by creating two
    /// IAM roles: a role in “Account A” and a role in “Account B” (which
    /// can be the same or different account), each with the necessary trust and
    /// permission policies. After you provide these roles in the IAM role and Target
    /// IAM role fields, EKS will perform role chaining to ensure your application
    /// gets the required permissions. This means Role A will assume Role B, allowing
    /// your Pods to securely access resources like S3 buckets in the target account.
    /// </summary>
    [JsonPropertyName("targetRoleARN")]
    public string? TargetRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("targetRoleRef")]
    public V1alpha1PodIdentityAssociationSpecTargetRoleRef? TargetRoleRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationStatusAckResourceMetadata
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
public partial class V1alpha1PodIdentityAssociationStatusConditions
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

/// <summary>PodIdentityAssociationStatus defines the observed state of PodIdentityAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PodIdentityAssociationStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PodIdentityAssociationStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the association.</summary>
    [JsonPropertyName("associationARN")]
    public string? AssociationARN { get; set; }

    /// <summary>The ID of the association.</summary>
    [JsonPropertyName("associationID")]
    public string? AssociationID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PodIdentityAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp that the association was created at.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The unique identifier for this EKS Pod Identity association for a target
    /// IAM role. You put this value in the trust policy of the target role, in a
    /// Condition to match the sts.ExternalId. This ensures that the target role
    /// can only be assumed by this association. This prevents the confused deputy
    /// problem. For more information about the confused deputy problem, see The
    /// confused deputy problem (https://docs.aws.amazon.com/IAM/latest/UserGuide/confused-deputy.html)
    /// in the IAM User Guide.
    /// 
    /// If you want to use the same target role with multiple associations or other
    /// roles, use independent statements in the trust policy to allow sts:AssumeRole
    /// access from each role.
    /// </summary>
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    /// <summary>The most recent timestamp that the association was modified at.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>If defined, the EKS Pod Identity association is owned by an Amazon EKS add-on.</summary>
    [JsonPropertyName("ownerARN")]
    public string? OwnerARN { get; set; }
}

/// <summary>PodIdentityAssociation is the Schema for the PodIdentityAssociations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PodIdentityAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PodIdentityAssociationSpec?>, IStatus<V1alpha1PodIdentityAssociationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PodIdentityAssociation";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "podidentityassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PodIdentityAssociation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// PodIdentityAssociationSpec defines the desired state of PodIdentityAssociation.
    /// 
    /// Amazon EKS Pod Identity associations provide the ability to manage credentials
    /// for your applications, similar to the way that Amazon EC2 instance profiles
    /// provide credentials to Amazon EC2 instances.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1PodIdentityAssociationSpec? Spec { get; set; }

    /// <summary>PodIdentityAssociationStatus defines the observed state of PodIdentityAssociation</summary>
    [JsonPropertyName("status")]
    public V1alpha1PodIdentityAssociationStatus? Status { get; set; }
}