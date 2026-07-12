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
/// <summary>Repository is the Schema for the Repositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Repository>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryList";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "repositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Repository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Repository> Items { get; set; }
}

/// <summary>
/// The encryption configuration for the repository. This determines how the
/// contents of your repository are encrypted at rest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecEncryptionConfiguration
{
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>
/// The imageScanningConfiguration parameter is being deprecated, in favor of
/// specifying the image scanning configuration at the registry level. For more
/// information, see PutRegistryScanningConfiguration.
/// 
/// The image scanning configuration for the repository. This determines whether
/// images are scanned for known vulnerabilities after being pushed to the repository.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecImageScanningConfiguration
{
    [JsonPropertyName("scanOnPush")]
    public bool? ScanOnPush { get; set; }
}

/// <summary>
/// A filter that specifies which image tags should be excluded from the repository&apos;s
/// image tag mutability setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecImageTagMutabilityExclusionFilters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// RepositorySpec defines the desired state of Repository.
/// 
/// An object representing a repository.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpec
{
    /// <summary>
    /// The encryption configuration for the repository. This determines how the
    /// contents of your repository are encrypted at rest.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1RepositorySpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>
    /// The imageScanningConfiguration parameter is being deprecated, in favor of
    /// specifying the image scanning configuration at the registry level. For more
    /// information, see PutRegistryScanningConfiguration.
    /// 
    /// The image scanning configuration for the repository. This determines whether
    /// images are scanned for known vulnerabilities after being pushed to the repository.
    /// </summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1alpha1RepositorySpecImageScanningConfiguration? ImageScanningConfiguration { get; set; }

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
    /// repository&apos;s image tag mutability setting.
    /// </summary>
    [JsonPropertyName("imageTagMutabilityExclusionFilters")]
    public IList<V1alpha1RepositorySpecImageTagMutabilityExclusionFilters>? ImageTagMutabilityExclusionFilters { get; set; }

    /// <summary>The JSON repository policy text to apply to the repository.</summary>
    [JsonPropertyName("lifecyclePolicy")]
    public string? LifecyclePolicy { get; set; }

    /// <summary>
    /// The name to use for the repository. The repository name may be specified
    /// on its own (such as nginx-web-app) or it can be prepended with a namespace
    /// to group the repository into a category (such as project-a/nginx-web-app).
    /// 
    /// The repository name must start with a letter and can only contain lowercase
    /// letters, numbers, hyphens, underscores, and forward slashes.
    /// 
    /// Regex Pattern: `^(?:[a-z0-9]+(?:[._-][a-z0-9]+)*/)*[a-z0-9]+(?:[._-][a-z0-9]+)*$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The JSON repository policy text to apply to the repository. For more information,
    /// see Amazon ECR repository policies (https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policy-examples.html)
    /// in the Amazon Elastic Container Registry User Guide.
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>
    /// The Amazon Web Services account ID associated with the registry to create
    /// the repository. If you do not specify a registry, the default registry is
    /// assumed.
    /// 
    /// Regex Pattern: `^[0-9]{12}$`
    /// </summary>
    [JsonPropertyName("registryID")]
    public string? RegistryID { get; set; }

    /// <summary>
    /// The metadata that you apply to the repository to help you categorize and
    /// organize them. Each tag consists of a key and an optional value, both of
    /// which you define. Tag keys can have a maximum character length of 128 characters,
    /// and tag values can have a maximum length of 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RepositorySpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAckResourceMetadata
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
public partial class V1alpha1RepositoryStatusConditions
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

/// <summary>RepositoryStatus defines the observed state of Repository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RepositoryStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time, in JavaScript date format, when the repository was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The URI for the repository. You can use this URI for container image push
    /// and pull operations.
    /// </summary>
    [JsonPropertyName("repositoryURI")]
    public string? RepositoryURI { get; set; }
}

/// <summary>Repository is the Schema for the Repositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Repository : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RepositorySpec?>, IStatus<V1alpha1RepositoryStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Repository";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "repositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Repository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RepositorySpec defines the desired state of Repository.
    /// 
    /// An object representing a repository.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RepositorySpec? Spec { get; set; }

    /// <summary>RepositoryStatus defines the observed state of Repository</summary>
    [JsonPropertyName("status")]
    public V1alpha1RepositoryStatus? Status { get; set; }
}