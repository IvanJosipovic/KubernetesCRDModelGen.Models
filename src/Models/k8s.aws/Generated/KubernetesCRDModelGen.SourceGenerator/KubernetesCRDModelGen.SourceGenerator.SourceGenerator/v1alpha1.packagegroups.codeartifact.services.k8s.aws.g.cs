#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codeartifact.services.k8s.aws;
/// <summary>PackageGroup is the Schema for the PackageGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PackageGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PackageGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PackageGroupList";
    public const string KubeGroup = "codeartifact.services.k8s.aws";
    public const string KubePluralName = "packagegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codeartifact.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PackageGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PackageGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PackageGroup> Items { get; set; }
}

/// <summary>
/// A tag is a key-value pair that can be used to manage, search for, or filter
/// resources in CodeArtifact.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PackageGroupSpec defines the desired state of PackageGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupSpec
{
    /// <summary>
    /// The contact information for the created package group.
    /// 
    /// Regex Pattern: `^\P{C}*$`
    /// </summary>
    [JsonPropertyName("contactInfo")]
    public string? ContactInfo { get; set; }

    /// <summary>
    /// A description of the package group.
    /// 
    /// Regex Pattern: `^\P{C}*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name of the domain in which you want to create a package group.
    /// 
    /// Regex Pattern: `^[a-z][a-z0-9\-]{0,48}[a-z0-9]$`
    /// </summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    /// <summary>
    /// The 12-digit account number of the Amazon Web Services account that owns
    /// the domain. It does not include dashes or spaces.
    /// 
    /// Regex Pattern: `^[0-9]{12}$`
    /// </summary>
    [JsonPropertyName("domainOwner")]
    public string? DomainOwner { get; set; }

    /// <summary>
    /// The pattern of the package group to create. The pattern is also the identifier
    /// of the package group.
    /// 
    /// Regex Pattern: `^[^\p{C}\p{IsWhitespace}]+$`
    /// </summary>
    [JsonPropertyName("pattern")]
    public required string Pattern { get; set; }

    /// <summary>One or more tag key-value pairs for the package group.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1PackageGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatusAckResourceMetadata
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
public partial class V1alpha1PackageGroupStatusConditions
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

/// <summary>Information about the identifiers of a package group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatusOriginConfigurationRestrictionsInheritedFrom
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Contains information about the configured restrictions of the origin controls
/// of a package group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatusOriginConfigurationRestrictions
{
    [JsonPropertyName("effectiveMode")]
    public string? EffectiveMode { get; set; }

    /// <summary>Information about the identifiers of a package group.</summary>
    [JsonPropertyName("inheritedFrom")]
    public V1alpha1PackageGroupStatusOriginConfigurationRestrictionsInheritedFrom? InheritedFrom { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("repositoriesCount")]
    public long? RepositoriesCount { get; set; }
}

/// <summary>
/// The package group origin configuration that determines how package versions
/// can enter repositories.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatusOriginConfiguration
{
    [JsonPropertyName("restrictions")]
    public IDictionary<string, V1alpha1PackageGroupStatusOriginConfigurationRestrictions>? Restrictions { get; set; }
}

/// <summary>The direct parent package group of the package group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatusParent
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>PackageGroupStatus defines the observed state of PackageGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PackageGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PackageGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PackageGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A timestamp that represents the date and time the package group was created.</summary>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// The name of the domain that contains the package group.
    /// 
    /// Regex Pattern: `^[a-z][a-z0-9\-]{0,48}[a-z0-9]$`
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// The package group origin configuration that determines how package versions
    /// can enter repositories.
    /// </summary>
    [JsonPropertyName("originConfiguration")]
    public V1alpha1PackageGroupStatusOriginConfiguration? OriginConfiguration { get; set; }

    /// <summary>The direct parent package group of the package group.</summary>
    [JsonPropertyName("parent")]
    public V1alpha1PackageGroupStatusParent? Parent { get; set; }
}

/// <summary>PackageGroup is the Schema for the PackageGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PackageGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PackageGroupSpec?>, IStatus<V1alpha1PackageGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PackageGroup";
    public const string KubeGroup = "codeartifact.services.k8s.aws";
    public const string KubePluralName = "packagegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codeartifact.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PackageGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PackageGroupSpec defines the desired state of PackageGroup.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1PackageGroupSpec? Spec { get; set; }

    /// <summary>PackageGroupStatus defines the observed state of PackageGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1PackageGroupStatus? Status { get; set; }
}