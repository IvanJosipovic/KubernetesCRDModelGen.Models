#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecr.services.k8s.aws;
/// <summary>RepositoryCreationTemplate is the Schema for the RepositoryCreationTemplates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryCreationTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RepositoryCreationTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryCreationTemplateList";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "repositorycreationtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryCreationTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RepositoryCreationTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RepositoryCreationTemplate> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateSpecCustomRoleRefFrom
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
public partial class V1alpha1RepositoryCreationTemplateSpecCustomRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RepositoryCreationTemplateSpecCustomRoleRefFrom? From { get; set; }
}

/// <summary>The encryption configuration to use for repositories created using the template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateSpecEncryptionConfiguration
{
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>
/// A filter that specifies which image tags should be excluded from the repository&apos;s
/// image tag mutability setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateSpecImageTagMutabilityExclusionFilters
{
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

/// <summary>
/// The metadata to apply to a resource to help you categorize and organize them.
/// Each tag consists of a key and a value, both of which you define. Tag keys
/// can have a maximum character length of 128 characters, and tag values can
/// have a maximum length of 256 characters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateSpecResourceTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// RepositoryCreationTemplateSpec defines the desired state of RepositoryCreationTemplate.
/// 
/// The details of the repository creation template associated with the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateSpec
{
    /// <summary>
    /// A list of enumerable strings representing the Amazon ECR repository creation
    /// scenarios that this template will apply towards. The two supported scenarios
    /// are PULL_THROUGH_CACHE and REPLICATION
    /// </summary>
    [JsonPropertyName("appliedFor")]
    public required IList<string> AppliedFor { get; set; }

    /// <summary>
    /// The ARN of the role to be assumed by Amazon ECR. This role must be in the
    /// same account as the registry that you are configuring. Amazon ECR will assume
    /// your supplied role when the customRoleArn is specified. When this field isn&apos;t
    /// specified, Amazon ECR will use the service-linked role for the repository
    /// creation template.
    /// </summary>
    [JsonPropertyName("customRoleARN")]
    public string? CustomRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("customRoleRef")]
    public V1alpha1RepositoryCreationTemplateSpecCustomRoleRef? CustomRoleRef { get; set; }

    /// <summary>A description for the repository creation template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The encryption configuration to use for repositories created using the template.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1RepositoryCreationTemplateSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>
    /// The tag mutability setting for the repository. If this parameter is omitted,
    /// the default setting of MUTABLE will be used which will allow image tags to
    /// be overwritten. If IMMUTABLE is specified, all image tags within the repository
    /// will be immutable which will prevent them from being overwritten.
    /// </summary>
    [JsonPropertyName("imageTagMutability")]
    public string? ImageTagMutability { get; set; }

    /// <summary>
    /// A list of filters that specify which image tags should be excluded from the
    /// repository creation template&apos;s image tag mutability setting.
    /// </summary>
    [JsonPropertyName("imageTagMutabilityExclusionFilters")]
    public IList<V1alpha1RepositoryCreationTemplateSpecImageTagMutabilityExclusionFilters>? ImageTagMutabilityExclusionFilters { get; set; }

    /// <summary>The lifecycle policy to use for repositories created using the template.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public string? LifecyclePolicy { get; set; }

    /// <summary>
    /// The repository namespace prefix to associate with the template. All repositories
    /// created using this namespace prefix will have the settings defined in this
    /// template applied. For example, a prefix of prod would apply to all repositories
    /// beginning with prod/. Similarly, a prefix of prod/team would apply to all
    /// repositories beginning with prod/team/.
    /// 
    /// To apply a template to all repositories in your registry that don&apos;t have
    /// an associated creation template, you can use ROOT as the prefix.
    /// 
    /// There is always an assumed / applied to the end of the prefix. If you specify
    /// ecr-public as the prefix, Amazon ECR treats that as ecr-public/. When using
    /// a pull through cache rule, the repository prefix you specify during rule
    /// creation is what you should specify as your repository creation template
    /// prefix as well.
    /// 
    /// Regex Pattern: `^((?:[a-z0-9]+(?:[._-][a-z0-9]+)*/)*[a-z0-9]+(?:[._-][a-z0-9]+)*/?|ROOT)$`
    /// </summary>
    [JsonPropertyName("prefix")]
    public required string Prefix { get; set; }

    /// <summary>
    /// The repository policy to apply to repositories created using the template.
    /// A repository policy is a permissions policy associated with a repository
    /// to control access permissions.
    /// </summary>
    [JsonPropertyName("repositoryPolicy")]
    public string? RepositoryPolicy { get; set; }

    /// <summary>
    /// The metadata to apply to the repository to help you categorize and organize.
    /// Each tag consists of a key and an optional value, both of which you define.
    /// Tag keys can have a maximum character length of 128 characters, and tag values
    /// can have a maximum length of 256 characters.
    /// </summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1alpha1RepositoryCreationTemplateSpecResourceTags>? ResourceTags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateStatusAckResourceMetadata
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
public partial class V1alpha1RepositoryCreationTemplateStatusConditions
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

/// <summary>RepositoryCreationTemplateStatus defines the observed state of RepositoryCreationTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryCreationTemplateStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RepositoryCreationTemplateStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryCreationTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time, in JavaScript date format, when the repository creation
    /// template was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The date and time, in JavaScript date format, when the repository creation
    /// template was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}

/// <summary>RepositoryCreationTemplate is the Schema for the RepositoryCreationTemplates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryCreationTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RepositoryCreationTemplateSpec?>, IStatus<V1alpha1RepositoryCreationTemplateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryCreationTemplate";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "repositorycreationtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryCreationTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RepositoryCreationTemplateSpec defines the desired state of RepositoryCreationTemplate.
    /// 
    /// The details of the repository creation template associated with the request.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RepositoryCreationTemplateSpec? Spec { get; set; }

    /// <summary>RepositoryCreationTemplateStatus defines the observed state of RepositoryCreationTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1RepositoryCreationTemplateStatus? Status { get; set; }
}