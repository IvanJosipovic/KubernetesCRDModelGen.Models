#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ram.services.k8s.aws;
/// <summary>Permission is the Schema for the Permissions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PermissionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Permission>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PermissionList";
    public const string KubeGroup = "ram.services.k8s.aws";
    public const string KubePluralName = "permissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ram.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PermissionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Permission objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Permission> Items { get; set; }
}

/// <summary>
/// A structure containing a tag. A tag is metadata that you can attach to your
/// resources to help organize and categorize them. You can also use them to
/// help you secure your resources. For more information, see Controlling access
/// to Amazon Web Services resources using tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html).
/// 
/// For more information about tags, see Tagging Amazon Web Services resources
/// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html) in the Amazon
/// Web Services General Reference Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PermissionSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PermissionSpec defines the desired state of Permission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PermissionSpec
{
    /// <summary>
    /// Specifies the name of the customer managed permission. The name must be unique
    /// within the Amazon Web Services Region.
    /// 
    /// Regex Pattern: `^[\w.-]*$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A string in JSON format string that contains the following elements of a
    /// resource-based policy:
    /// 
    ///   - Effect: must be set to ALLOW.
    /// 
    ///   - Action: specifies the actions that are allowed by this customer managed
    ///     permission. The list must contain only actions that are supported by the
    ///     specified resource type. For a list of all actions supported by each resource
    ///     type, see Actions, resources, and condition keys for Amazon Web Services
    ///     services (https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html)
    ///     in the Identity and Access Management User Guide.
    /// 
    ///   - Condition: (optional) specifies conditional parameters that must evaluate
    ///     to true when a user attempts an action for that action to be allowed.
    ///     For more information about the Condition element, see IAM policies: Condition
    ///     element (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition.html)
    ///     in the Identity and Access Management User Guide.
    /// 
    /// This template can&apos;t include either the Resource or Principal elements. Those
    /// are both filled in by RAM when it instantiates the resource-based policy
    /// on each resource shared using this managed permission. The Resource comes
    /// from the ARN of the specific resource that you are sharing. The Principal
    /// comes from the list of identities added to the resource share.
    /// </summary>
    [JsonPropertyName("policyTemplate")]
    public required string PolicyTemplate { get; set; }

    /// <summary>
    /// Specifies the name of the resource type that this customer managed permission
    /// applies to.
    /// 
    /// The format is : and is not case sensitive. For example, to specify an Amazon
    /// EC2 Subnet, you can use the string ec2:subnet. To see the list of valid values
    /// for this parameter, query the ListResourceTypes operation.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; set; }

    /// <summary>
    /// Specifies a list of one or more tag key and value pairs to attach to the
    /// permission.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1PermissionSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PermissionStatusAckResourceMetadata
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
public partial class V1alpha1PermissionStatusConditions
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

/// <summary>PermissionStatus defines the observed state of Permission</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PermissionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PermissionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PermissionStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time when the permission was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Specifies whether the version of the managed permission used by this resource
    /// share is the default version for this managed permission.
    /// </summary>
    [JsonPropertyName("defaultVersion")]
    public bool? DefaultVersion { get; set; }

    /// <summary>
    /// Indicates what features are available for this resource share. This parameter
    /// can have one of the following values:
    /// 
    ///    * STANDARD – A resource share that supports all functionality. These
    ///    resource shares are visible to all principals you share the resource share
    ///    with. You can modify these resource shares in RAM using the console or
    ///    APIs. This resource share might have been created by RAM, or it might
    ///    have been CREATED_FROM_POLICY and then promoted.
    /// 
    ///    * CREATED_FROM_POLICY – The customer manually shared a resource by attaching
    ///    a resource-based policy. That policy did not match any existing managed
    ///    permissions, so RAM created this customer managed permission automatically
    ///    on the customer&apos;s behalf based on the attached policy document. This type
    ///    of resource share is visible only to the Amazon Web Services account that
    ///    created it. You can&apos;t modify it in RAM unless you promote it. For more
    ///    information, see PromoteResourceShareCreatedFromPolicy.
    /// 
    ///    * PROMOTING_TO_STANDARD – This resource share was originally CREATED_FROM_POLICY,
    ///    but the customer ran the PromoteResourceShareCreatedFromPolicy and that
    ///    operation is still in progress. This value changes to STANDARD when complete.
    /// </summary>
    [JsonPropertyName("featureSet")]
    public string? FeatureSet { get; set; }

    /// <summary>
    /// Specifies whether the managed permission associated with this resource share
    /// is the default managed permission for all resources of this resource type.
    /// </summary>
    [JsonPropertyName("isResourceTypeDefault")]
    public bool? IsResourceTypeDefault { get; set; }

    /// <summary>The date and time when the permission was last updated.</summary>
    [JsonPropertyName("lastUpdatedTime")]
    public DateTime? LastUpdatedTime { get; set; }

    /// <summary>
    /// The type of managed permission. This can be one of the following values:
    /// 
    ///    * AWS_MANAGED – Amazon Web Services created and manages this managed
    ///    permission. You can associate it with your resource shares, but you can&apos;t
    ///    modify it.
    /// 
    ///    * CUSTOMER_MANAGED – You, or another principal in your account created
    ///    this managed permission. You can associate it with your resource shares
    ///    and create new versions that have different permissions.
    /// </summary>
    [JsonPropertyName("permissionType")]
    public string? PermissionType { get; set; }

    /// <summary>The current status of the permission.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The version of the permission associated with this resource share.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Permission is the Schema for the Permissions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Permission : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PermissionSpec?>, IStatus<V1alpha1PermissionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Permission";
    public const string KubeGroup = "ram.services.k8s.aws";
    public const string KubePluralName = "permissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ram.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Permission";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PermissionSpec defines the desired state of Permission.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1PermissionSpec? Spec { get; set; }

    /// <summary>PermissionStatus defines the observed state of Permission</summary>
    [JsonPropertyName("status")]
    public V1alpha1PermissionStatus? Status { get; set; }
}