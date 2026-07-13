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
/// <summary>PullThroughCacheRule is the Schema for the PullThroughCacheRules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PullThroughCacheRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PullThroughCacheRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PullThroughCacheRuleList";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "pullthroughcacherules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PullThroughCacheRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PullThroughCacheRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PullThroughCacheRule> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PullThroughCacheRuleSpecCredentialRefFrom
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
public partial class V1alpha1PullThroughCacheRuleSpecCredentialRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1PullThroughCacheRuleSpecCredentialRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PullThroughCacheRuleSpecCustomRoleRefFrom
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
public partial class V1alpha1PullThroughCacheRuleSpecCustomRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1PullThroughCacheRuleSpecCustomRoleRefFrom? From { get; set; }
}

/// <summary>
/// PullThroughCacheRuleSpec defines the desired state of PullThroughCacheRule.
/// 
/// The details of a pull through cache rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PullThroughCacheRuleSpec
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager
    /// secret that identifies the credentials to authenticate to the upstream registry.
    /// 
    /// Regex Pattern: `^arn:aws(-\w+)*:secretsmanager:[a-zA-Z0-9-:]+:secret:ecr\-pullthroughcache\/[a-zA-Z0-9\/_+=.@-]+$`
    /// </summary>
    [JsonPropertyName("credentialARN")]
    public string? CredentialARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("credentialRef")]
    public V1alpha1PullThroughCacheRuleSpecCredentialRef? CredentialRef { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the IAM role to be assumed by Amazon ECR to
    /// authenticate to the ECR upstream registry. This role must be in the same
    /// account as the registry that you are configuring.
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
    public V1alpha1PullThroughCacheRuleSpecCustomRoleRef? CustomRoleRef { get; set; }

    /// <summary>
    /// The repository name prefix to use when caching images from the source registry.
    /// 
    /// There is always an assumed / applied to the end of the prefix. If you specify
    /// ecr-public as the prefix, Amazon ECR treats that as ecr-public/.
    /// 
    /// Regex Pattern: `^((?:[a-z0-9]+(?:[._-][a-z0-9]+)*/)*[a-z0-9]+(?:[._-][a-z0-9]+)*/?|ROOT)$`
    /// </summary>
    [JsonPropertyName("ecrRepositoryPrefix")]
    public required string EcrRepositoryPrefix { get; set; }

    /// <summary>
    /// The Amazon Web Services account ID associated with the registry to create
    /// the pull through cache rule for. If you do not specify a registry, the default
    /// registry is assumed.
    /// 
    /// Regex Pattern: `^[0-9]{12}$`
    /// </summary>
    [JsonPropertyName("registryID")]
    public string? RegistryID { get; set; }

    /// <summary>The name of the upstream registry.</summary>
    [JsonPropertyName("upstreamRegistry")]
    public string? UpstreamRegistry { get; set; }

    /// <summary>
    /// The registry URL of the upstream public registry to use as the source for
    /// the pull through cache rule. The following is the syntax to use for each
    /// supported upstream registry.
    /// 
    ///   - Amazon ECR (ecr) – .dkr.ecr..amazonaws.com
    /// 
    ///   - Amazon ECR Public (ecr-public) – public.ecr.aws
    /// 
    ///   - Docker Hub (docker-hub) – registry-1.docker.io
    /// 
    ///   - GitHub Container Registry (github-container-registry) – ghcr.io
    /// 
    ///   - GitLab Container Registry (gitlab-container-registry) – registry.gitlab.com
    /// 
    ///   - Kubernetes (k8s) – registry.k8s.io
    /// 
    ///   - Microsoft Azure Container Registry (azure-container-registry) – .azurecr.io
    /// 
    ///   - Quay (quay) – quay.io
    /// </summary>
    [JsonPropertyName("upstreamRegistryURL")]
    public required string UpstreamRegistryURL { get; set; }

    /// <summary>
    /// The repository name prefix of the upstream registry to match with the upstream
    /// repository name. When this field isn&apos;t specified, Amazon ECR will use the
    /// ROOT.
    /// 
    /// Regex Pattern: `^((?:[a-z0-9]+(?:[._-][a-z0-9]+)*/)*[a-z0-9]+(?:[._-][a-z0-9]+)*/?|ROOT)$`
    /// </summary>
    [JsonPropertyName("upstreamRepositoryPrefix")]
    public string? UpstreamRepositoryPrefix { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PullThroughCacheRuleStatusAckResourceMetadata
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
public partial class V1alpha1PullThroughCacheRuleStatusConditions
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

/// <summary>PullThroughCacheRuleStatus defines the observed state of PullThroughCacheRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PullThroughCacheRuleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PullThroughCacheRuleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PullThroughCacheRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time, in JavaScript date format, when the pull through cache
    /// rule was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }
}

/// <summary>PullThroughCacheRule is the Schema for the PullThroughCacheRules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PullThroughCacheRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PullThroughCacheRuleSpec?>, IStatus<V1alpha1PullThroughCacheRuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PullThroughCacheRule";
    public const string KubeGroup = "ecr.services.k8s.aws";
    public const string KubePluralName = "pullthroughcacherules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecr.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PullThroughCacheRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// PullThroughCacheRuleSpec defines the desired state of PullThroughCacheRule.
    /// 
    /// The details of a pull through cache rule.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1PullThroughCacheRuleSpec? Spec { get; set; }

    /// <summary>PullThroughCacheRuleStatus defines the observed state of PullThroughCacheRule</summary>
    [JsonPropertyName("status")]
    public V1alpha1PullThroughCacheRuleStatus? Status { get; set; }
}