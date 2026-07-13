#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.services.k8s.aws;
/// <summary>InstanceProfile is the Schema for the InstanceProfiles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InstanceProfileList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1InstanceProfile>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InstanceProfileList";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "instanceprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1InstanceProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1InstanceProfile> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceProfileSpecRoleRefFrom
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
public partial class V1alpha1InstanceProfileSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1InstanceProfileSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// A structure that represents user-provided metadata that can be associated
/// with an IAM resource. For more information about tagging, see Tagging IAM
/// resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceProfileSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// InstanceProfileSpec defines the desired state of InstanceProfile.
/// 
/// Contains information about an instance profile.
/// 
/// This data type is used as a response element in the following operations:
/// 
///   - CreateInstanceProfile
/// 
///   - GetInstanceProfile
/// 
///   - ListInstanceProfiles
/// 
///   - ListInstanceProfilesForRole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceProfileSpec
{
    /// <summary>
    /// The name of the instance profile to create.
    /// 
    /// This parameter allows (through its regex pattern (http://wikipedia.org/wiki/regex))
    /// a string of characters consisting of upper and lowercase alphanumeric characters
    /// with no spaces. You can also include any of the following characters: _+=,.@-
    /// 
    /// Regex Pattern: `^[\w+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The path to the instance profile. For more information about paths, see IAM
    /// Identifiers (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
    /// in the IAM User Guide.
    /// 
    /// This parameter is optional. If it is not included, it defaults to a slash
    /// (/).
    /// 
    /// This parameter allows (through its regex pattern (http://wikipedia.org/wiki/regex))
    /// a string of characters consisting of either a forward slash (/) by itself
    /// or a string that must begin and end with forward slashes. In addition, it
    /// can contain any ASCII character from the ! (\u0021) through the DEL character
    /// (\u007F), including most punctuation characters, digits, and upper and lowercased
    /// letters.
    /// 
    /// Regex Pattern: `^(\u002F)|(\u002F[\u0021-\u007E]+\u002F)$`
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

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
    public V1alpha1InstanceProfileSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the newly created IAM instance
    /// profile. Each tag consists of a key name and an associated value. For more
    /// information about tagging, see Tagging IAM resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
    /// in the IAM User Guide.
    /// 
    /// If any one of the tags is invalid or if you exceed the allowed maximum number
    /// of tags, then the entire request fails and the resource is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1InstanceProfileSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceProfileStatusAckResourceMetadata
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
public partial class V1alpha1InstanceProfileStatusConditions
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

/// <summary>InstanceProfileStatus defines the observed state of InstanceProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceProfileStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1InstanceProfileStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1InstanceProfileStatusConditions>? Conditions { get; set; }

    /// <summary>The date when the instance profile was created.</summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// The stable and unique string identifying the instance profile. For more information
    /// about IDs, see IAM identifiers (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
    /// in the IAM User Guide.
    /// 
    /// Regex Pattern: `^[\w]+$`
    /// </summary>
    [JsonPropertyName("instanceProfileID")]
    public string? InstanceProfileID { get; set; }
}

/// <summary>InstanceProfile is the Schema for the InstanceProfiles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InstanceProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1InstanceProfileSpec?>, IStatus<V1alpha1InstanceProfileStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InstanceProfile";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "instanceprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// InstanceProfileSpec defines the desired state of InstanceProfile.
    /// 
    /// Contains information about an instance profile.
    /// 
    /// This data type is used as a response element in the following operations:
    /// 
    ///   - CreateInstanceProfile
    /// 
    ///   - GetInstanceProfile
    /// 
    ///   - ListInstanceProfiles
    /// 
    ///   - ListInstanceProfilesForRole
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1InstanceProfileSpec? Spec { get; set; }

    /// <summary>InstanceProfileStatus defines the observed state of InstanceProfile</summary>
    [JsonPropertyName("status")]
    public V1alpha1InstanceProfileStatus? Status { get; set; }
}