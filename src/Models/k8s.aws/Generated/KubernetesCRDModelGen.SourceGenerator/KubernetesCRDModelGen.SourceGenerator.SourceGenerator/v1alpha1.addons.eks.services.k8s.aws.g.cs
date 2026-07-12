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
/// <summary>Addon is the Schema for the Addons API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AddonList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Addon>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AddonList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "addons";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AddonList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Addon objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Addon> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpecClusterRefFrom
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
public partial class V1alpha1AddonSpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AddonSpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpecPodIdentityAssociationsRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpecPodIdentityAssociationsRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AddonSpecPodIdentityAssociationsRoleRefFrom? From { get; set; }
}

/// <summary>
/// A type of EKS Pod Identity association owned by an Amazon EKS add-on.
/// 
/// Each association maps a role to a service account in a namespace in the cluster.
/// 
/// For more information, see Attach an IAM Role to an Amazon EKS add-on using
/// EKS Pod Identity (https://docs.aws.amazon.com/eks/latest/userguide/add-ons-iam.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpecPodIdentityAssociations
{
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Reference field for RoleARN</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1AddonSpecPodIdentityAssociationsRoleRef? RoleRef { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpecServiceAccountRoleRefFrom
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
public partial class V1alpha1AddonSpecServiceAccountRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AddonSpecServiceAccountRoleRefFrom? From { get; set; }
}

/// <summary>
/// AddonSpec defines the desired state of Addon.
/// 
/// An Amazon EKS add-on. For more information, see Amazon EKS add-ons (https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonSpec
{
    /// <summary>
    /// The version of the add-on. The version must match one of the versions returned
    /// by DescribeAddonVersions (https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html).
    /// </summary>
    [JsonPropertyName("addonVersion")]
    public string? AddonVersion { get; set; }

    /// <summary>
    /// A unique, case-sensitive identifier that you provide to ensurethe idempotency
    /// of the request.
    /// </summary>
    [JsonPropertyName("clientRequestToken")]
    public string? ClientRequestToken { get; set; }

    /// <summary>
    /// The name of your cluster.
    /// 
    /// Regex Pattern: `^[0-9A-Za-z][A-Za-z0-9\-_]*$`
    /// </summary>
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
    public V1alpha1AddonSpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// The set of configuration values for the add-on that&apos;s created. The values
    /// that you provide are validated against the schema returned by DescribeAddonConfiguration.
    /// </summary>
    [JsonPropertyName("configurationValues")]
    public string? ConfigurationValues { get; set; }

    /// <summary>
    /// The name of the add-on. The name must match one of the names returned by
    /// DescribeAddonVersions.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// An array of EKS Pod Identity associations to be created. Each association
    /// maps a Kubernetes service account to an IAM role.
    /// 
    /// For more information, see Attach an IAM Role to an Amazon EKS add-on using
    /// EKS Pod Identity (https://docs.aws.amazon.com/eks/latest/userguide/add-ons-iam.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("podIdentityAssociations")]
    public IList<V1alpha1AddonSpecPodIdentityAssociations>? PodIdentityAssociations { get; set; }

    /// <summary>
    /// How to resolve field value conflicts for an Amazon EKS add-on. Conflicts
    /// are handled based on the value you choose:
    /// 
    ///   - None – If the self-managed version of the add-on is installed on your
    ///     cluster, Amazon EKS doesn&apos;t change the value. Creation of the add-on might
    ///     fail.
    /// 
    ///   - Overwrite – If the self-managed version of the add-on is installed
    ///     on your cluster and the Amazon EKS default value is different than the
    ///     existing value, Amazon EKS changes the value to the Amazon EKS default
    ///     value.
    /// 
    ///   - Preserve – This is similar to the NONE option. If the self-managed
    ///     version of the add-on is installed on your cluster Amazon EKS doesn&apos;t
    ///     change the add-on resource properties. Creation of the add-on might fail
    ///     if conflicts are detected. This option works differently during the update
    ///     operation. For more information, see UpdateAddon (https://docs.aws.amazon.com/eks/latest/APIReference/API_UpdateAddon.html).
    /// 
    /// If you don&apos;t currently have the self-managed version of the add-on installed
    /// on your cluster, the Amazon EKS add-on is installed. Amazon EKS sets all
    /// values to default values, regardless of the option that you specify.
    /// </summary>
    [JsonPropertyName("resolveConflicts")]
    public string? ResolveConflicts { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an existing IAM role to bind to the add-on&apos;s
    /// service account. The role must be assigned the IAM permissions required by
    /// the add-on. If you don&apos;t specify an existing IAM role, then the add-on uses
    /// the permissions assigned to the node IAM role. For more information, see
    /// Amazon EKS node IAM role (https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html)
    /// in the Amazon EKS User Guide.
    /// 
    /// To specify an existing IAM role, you must have an IAM OpenID Connect (OIDC)
    /// provider created for your cluster. For more information, see Enabling IAM
    /// roles for service accounts on your cluster (https://docs.aws.amazon.com/eks/latest/userguide/enable-iam-roles-for-service-accounts.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("serviceAccountRoleARN")]
    public string? ServiceAccountRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("serviceAccountRoleRef")]
    public V1alpha1AddonSpecServiceAccountRoleRef? ServiceAccountRoleRef { get; set; }

    /// <summary>
    /// Metadata that assists with categorization and organization. Each tag consists
    /// of a key and an optional value. You define both. Tags don&apos;t propagate to
    /// any other cluster or Amazon Web Services resources.
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
public partial class V1alpha1AddonStatusAckResourceMetadata
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
public partial class V1alpha1AddonStatusConditions
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

/// <summary>An issue related to an add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonStatusHealthIssues
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("resourceIDs")]
    public IList<string>? ResourceIDs { get; set; }
}

/// <summary>An object that represents the health of the add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonStatusHealth
{
    [JsonPropertyName("issues")]
    public IList<V1alpha1AddonStatusHealthIssues>? Issues { get; set; }
}

/// <summary>Information about an Amazon EKS add-on from the Amazon Web Services Marketplace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonStatusMarketplaceInformation
{
    [JsonPropertyName("productID")]
    public string? ProductID { get; set; }

    [JsonPropertyName("productURL")]
    public string? ProductURL { get; set; }
}

/// <summary>AddonStatus defines the observed state of Addon</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AddonStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AddonStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AddonStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix epoch timestamp at object creation.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>An object that represents the health of the add-on.</summary>
    [JsonPropertyName("health")]
    public V1alpha1AddonStatusHealth? Health { get; set; }

    /// <summary>Information about an Amazon EKS add-on from the Amazon Web Services Marketplace.</summary>
    [JsonPropertyName("marketplaceInformation")]
    public V1alpha1AddonStatusMarketplaceInformation? MarketplaceInformation { get; set; }

    /// <summary>The Unix epoch timestamp for the last modification to the object.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>The owner of the add-on.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The publisher of the add-on.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The status of the add-on.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Addon is the Schema for the Addons API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Addon : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AddonSpec?>, IStatus<V1alpha1AddonStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Addon";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "addons";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Addon";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AddonSpec defines the desired state of Addon.
    /// 
    /// An Amazon EKS add-on. For more information, see Amazon EKS add-ons (https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AddonSpec? Spec { get; set; }

    /// <summary>AddonStatus defines the observed state of Addon</summary>
    [JsonPropertyName("status")]
    public V1alpha1AddonStatus? Status { get; set; }
}