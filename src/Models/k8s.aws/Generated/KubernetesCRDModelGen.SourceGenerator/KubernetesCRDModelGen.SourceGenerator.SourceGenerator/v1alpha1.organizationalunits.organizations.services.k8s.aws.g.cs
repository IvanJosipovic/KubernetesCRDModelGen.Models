#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.organizations.services.k8s.aws;
/// <summary>OrganizationalUnit is the Schema for the OrganizationalUnits API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationalUnitList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OrganizationalUnit>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationalUnitList";
    public const string KubeGroup = "organizations.services.k8s.aws";
    public const string KubePluralName = "organizationalunits";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationalUnitList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1OrganizationalUnit objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1OrganizationalUnit> Items { get; set; }
}

/// <summary>
/// A custom key-value pair associated with a resource within your organization.
/// 
/// You can attach tags to any of the following organization resources.
/// 
///   - Amazon Web Services account
/// 
///   - Organizational unit (OU)
/// 
///   - Organization root
/// 
///   - Policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationalUnitSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// OrganizationalUnitSpec defines the desired state of OrganizationalUnit.
/// 
/// Contains details about an organizational unit (OU). An OU is a container
/// of Amazon Web Services accounts within a root of an organization. Policies
/// that are attached to an OU apply to all accounts contained in that OU and
/// in any child OUs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationalUnitSpec
{
    /// <summary>
    /// The friendly name to assign to the new OU.
    /// 
    /// Regex Pattern: `^[\s\S]*$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The unique identifier (ID) of the parent root or OU that you want to create
    /// the new OU in.
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) for a parent ID string
    /// requires one of the following:
    /// 
    ///   - Root - A string that begins with &quot;r-&quot; followed by from 4 to 32 lowercase
    ///     letters or digits.
    /// 
    ///   - Organizational unit (OU) - A string that begins with &quot;ou-&quot; followed
    ///     by from 4 to 32 lowercase letters or digits (the ID of the root that the
    ///     OU is in). This string is followed by a second &quot;-&quot; dash and from 8 to
    ///     32 additional lowercase letters or digits.
    /// 
    /// Regex Pattern: `^(r-[0-9a-z]{4,32})|(ou-[0-9a-z]{4,32}-[a-z0-9]{8,32})$`
    /// </summary>
    [JsonPropertyName("parentID")]
    public required string ParentID { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the newly created OU. For each
    /// tag in the list, you must specify both a tag key and a value. You can set
    /// the value to an empty string, but you can&apos;t set it to null. For more information
    /// about tagging, see Tagging Organizations resources (https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html)
    /// in the Organizations User Guide.
    /// 
    /// If any one of the tags is not valid or if you exceed the allowed number of
    /// tags for an OU, then the entire request fails and the OU is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1OrganizationalUnitSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationalUnitStatusAckResourceMetadata
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
public partial class V1alpha1OrganizationalUnitStatusConditions
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

/// <summary>OrganizationalUnitStatus defines the observed state of OrganizationalUnit</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationalUnitStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1OrganizationalUnitStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationalUnitStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique identifier (ID) associated with this OU. The ID is unique to the
    /// organization only.
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) for an organizational
    /// unit ID string requires &quot;ou-&quot; followed by from 4 to 32 lowercase letters
    /// or digits (the ID of the root that contains the OU). This string is followed
    /// by a second &quot;-&quot; dash and from 8 to 32 additional lowercase letters or digits.
    /// 
    /// Regex Pattern: `^ou-[0-9a-z]{4,32}-[a-z0-9]{8,32}$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OrganizationalUnit is the Schema for the OrganizationalUnits API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationalUnit : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrganizationalUnitSpec?>, IStatus<V1alpha1OrganizationalUnitStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationalUnit";
    public const string KubeGroup = "organizations.services.k8s.aws";
    public const string KubePluralName = "organizationalunits";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationalUnit";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// OrganizationalUnitSpec defines the desired state of OrganizationalUnit.
    /// 
    /// Contains details about an organizational unit (OU). An OU is a container
    /// of Amazon Web Services accounts within a root of an organization. Policies
    /// that are attached to an OU apply to all accounts contained in that OU and
    /// in any child OUs.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1OrganizationalUnitSpec? Spec { get; set; }

    /// <summary>OrganizationalUnitStatus defines the observed state of OrganizationalUnit</summary>
    [JsonPropertyName("status")]
    public V1alpha1OrganizationalUnitStatus? Status { get; set; }
}