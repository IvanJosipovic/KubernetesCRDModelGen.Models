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
/// <summary>Capability is the Schema for the Capabilities API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CapabilityList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Capability>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CapabilityList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "capabilities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapabilityList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Capability objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Capability> Items { get; set; }
}

/// <summary>
/// Configuration for integrating Argo CD with IAM Identity CenterIAM; Identity
/// Center. This allows you to use your organization&apos;s identity provider for
/// authentication to Argo CD.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfigurationArgoCDAwsIDC
{
    [JsonPropertyName("idcInstanceARN")]
    public string? IdcInstanceARN { get; set; }

    [JsonPropertyName("idcRegion")]
    public string? IdcRegion { get; set; }
}

/// <summary>
/// Configuration for network access to the Argo CD capability&apos;s managed API
/// server endpoint. When VPC endpoint IDs are specified, public access is blocked
/// and the Argo CD server is only accessible through the specified VPC endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfigurationArgoCDNetworkAccess
{
    [JsonPropertyName("vpceIDs")]
    public IList<string>? VpceIDs { get; set; }
}

/// <summary>
/// An IAM Identity CenterIAM; Identity Center identity (user or group) that
/// can be assigned permissions in a capability.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfigurationArgoCDRbacRoleMappingsIdentities
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A mapping between an Argo CD role and IAM Identity CenterIAM; Identity Center
/// identities. This defines which users or groups have specific permissions
/// in Argo CD.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfigurationArgoCDRbacRoleMappings
{
    [JsonPropertyName("identities")]
    public IList<V1alpha1CapabilitySpecConfigurationArgoCDRbacRoleMappingsIdentities>? Identities { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>
/// Configuration settings for an Argo CD capability. This includes the Kubernetes
/// namespace, IAM Identity CenterIAM; Identity Center integration, RBAC role
/// mappings, and network access configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfigurationArgoCD
{
    /// <summary>
    /// Configuration for integrating Argo CD with IAM Identity CenterIAM; Identity
    /// Center. This allows you to use your organization&apos;s identity provider for
    /// authentication to Argo CD.
    /// </summary>
    [JsonPropertyName("awsIDC")]
    public V1alpha1CapabilitySpecConfigurationArgoCDAwsIDC? AwsIDC { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Configuration for network access to the Argo CD capability&apos;s managed API
    /// server endpoint. When VPC endpoint IDs are specified, public access is blocked
    /// and the Argo CD server is only accessible through the specified VPC endpoints.
    /// </summary>
    [JsonPropertyName("networkAccess")]
    public V1alpha1CapabilitySpecConfigurationArgoCDNetworkAccess? NetworkAccess { get; set; }

    [JsonPropertyName("rbacRoleMappings")]
    public IList<V1alpha1CapabilitySpecConfigurationArgoCDRbacRoleMappings>? RbacRoleMappings { get; set; }
}

/// <summary>
/// The configuration settings for the capability. The structure of this object
/// varies depending on the capability type. For Argo CD capabilities, you can
/// configure IAM Identity CenterIAM; Identity Center integration, RBAC role
/// mappings, and network access settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecConfiguration
{
    /// <summary>
    /// Configuration settings for an Argo CD capability. This includes the Kubernetes
    /// namespace, IAM Identity CenterIAM; Identity Center integration, RBAC role
    /// mappings, and network access configuration.
    /// </summary>
    [JsonPropertyName("argoCD")]
    public V1alpha1CapabilitySpecConfigurationArgoCD? ArgoCD { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpecRoleRefFrom
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
public partial class V1alpha1CapabilitySpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapabilitySpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// CapabilitySpec defines the desired state of Capability.
/// 
/// An object representing a managed capability in an Amazon EKS cluster. This
/// includes all configuration, status, and health information for the capability.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilitySpec
{
    /// <summary>The name of the Amazon EKS cluster where you want to create the capability.</summary>
    [JsonPropertyName("clusterName")]
    public required string ClusterName { get; set; }

    /// <summary>
    /// The configuration settings for the capability. The structure of this object
    /// varies depending on the capability type. For Argo CD capabilities, you can
    /// configure IAM Identity CenterIAM; Identity Center integration, RBAC role
    /// mappings, and network access settings.
    /// </summary>
    [JsonPropertyName("configuration")]
    public V1alpha1CapabilitySpecConfiguration? Configuration { get; set; }

    /// <summary>
    /// Specifies how Kubernetes resources managed by the capability should be handled
    /// when the capability is deleted. Currently, the only supported value is RETAIN
    /// which retains all Kubernetes resources managed by the capability when the
    /// capability is deleted.
    /// 
    /// Because resources are retained, all Kubernetes resources created by the capability
    /// should be deleted from the cluster before deleting the capability itself.
    /// After the capability is deleted, these resources become difficult to manage
    /// because the controller is no longer available.
    /// </summary>
    [JsonPropertyName("deletePropagationPolicy")]
    public required string DeletePropagationPolicy { get; set; }

    /// <summary>
    /// A unique name for the capability. The name must be unique within your cluster
    /// and can contain alphanumeric characters, hyphens, and underscores.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role that the capability uses to
    /// interact with Amazon Web Services services. This role must have a trust policy
    /// that allows the EKS service principal to assume it, and it must have the
    /// necessary permissions for the capability type you&apos;re creating.
    /// 
    /// For ACK capabilities, the role needs permissions to manage the resources
    /// you want to control through Kubernetes. For Argo CD capabilities, the role
    /// needs permissions to access Git repositories and Secrets Manager. For KRO
    /// capabilities, the role needs permissions based on the resources you&apos;ll be
    /// orchestrating.
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
    public V1alpha1CapabilitySpecRoleRef? RoleRef { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The type of capability to create. Valid values are:
    /// 
    ///   - ACK – Amazon Web Services Controllers for Kubernetes (ACK), which
    ///     lets you manage resources directly from Kubernetes.
    /// 
    ///   - ARGOCD – Argo CD for GitOps-based continuous delivery.
    /// 
    ///   - KRO – Kube Resource Orchestrator (KRO) for composing and managing
    ///     custom Kubernetes resources.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilityStatusAckResourceMetadata
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
public partial class V1alpha1CapabilityStatusConditions
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

/// <summary>An issue affecting a capability&apos;s health or operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilityStatusHealthIssues
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// Health information for the capability, including any issues that may be affecting
/// its operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilityStatusHealth
{
    [JsonPropertyName("issues")]
    public IList<V1alpha1CapabilityStatusHealthIssues>? Issues { get; set; }
}

/// <summary>CapabilityStatus defines the observed state of Capability</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapabilityStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CapabilityStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CapabilityStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix epoch timestamp in seconds for when the capability was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Health information for the capability, including any issues that may be affecting
    /// its operation.
    /// </summary>
    [JsonPropertyName("health")]
    public V1alpha1CapabilityStatusHealth? Health { get; set; }

    /// <summary>The Unix epoch timestamp in seconds for when the capability was last modified.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The current status of the capability. Valid values include:
    /// 
    ///    * CREATING – The capability is being created.
    /// 
    ///    * ACTIVE – The capability is running and available.
    /// 
    ///    * UPDATING – The capability is being updated.
    /// 
    ///    * DELETING – The capability is being deleted.
    /// 
    ///    * CREATE_FAILED – The capability creation failed.
    /// 
    ///    * UPDATE_FAILED – The capability update failed.
    /// 
    ///    * DELETE_FAILED – The capability deletion failed.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The version of the capability software that is currently running.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Capability is the Schema for the Capabilities API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Capability : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CapabilitySpec?>, IStatus<V1alpha1CapabilityStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Capability";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "capabilities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Capability";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CapabilitySpec defines the desired state of Capability.
    /// 
    /// An object representing a managed capability in an Amazon EKS cluster. This
    /// includes all configuration, status, and health information for the capability.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CapabilitySpec? Spec { get; set; }

    /// <summary>CapabilityStatus defines the observed state of Capability</summary>
    [JsonPropertyName("status")]
    public V1alpha1CapabilityStatus? Status { get; set; }
}