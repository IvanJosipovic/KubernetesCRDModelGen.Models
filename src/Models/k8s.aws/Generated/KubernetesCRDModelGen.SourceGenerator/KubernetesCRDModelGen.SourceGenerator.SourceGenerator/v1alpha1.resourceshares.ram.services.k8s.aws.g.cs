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
/// <summary>ResourceShare is the Schema for the ResourceShares API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourceShareList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResourceShare>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourceShareList";
    public const string KubeGroup = "ram.services.k8s.aws";
    public const string KubePluralName = "resourceshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ram.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceShareList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResourceShare objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResourceShare> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceShareSpecPermissionRefsFrom
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
public partial class V1alpha1ResourceShareSpecPermissionRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ResourceShareSpecPermissionRefsFrom? From { get; set; }
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
public partial class V1alpha1ResourceShareSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ResourceShareSpec defines the desired state of ResourceShare.
/// 
/// Describes a resource share in RAM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceShareSpec
{
    /// <summary>
    /// Specifies whether principals outside your organization in Organizations can
    /// be associated with a resource share. A value of true lets you share with
    /// individual Amazon Web Services accounts that are not in your organization.
    /// A value of false only has meaning if your account is a member of an Amazon
    /// Web Services Organization. The default value is true.
    /// </summary>
    [JsonPropertyName("allowExternalPrincipals")]
    public bool? AllowExternalPrincipals { get; set; }

    /// <summary>Specifies the name of the resource share.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies the Amazon Resource Names (ARNs) (https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html)
    /// of the RAM permission to associate with the resource share. If you do not
    /// specify an ARN for the permission, RAM automatically attaches the default
    /// version of the permission for each resource type. You can associate only
    /// one permission with each resource type included in the resource share.
    /// </summary>
    [JsonPropertyName("permissionARNs")]
    public IList<string>? PermissionARNs { get; set; }

    [JsonPropertyName("permissionRefs")]
    public IList<V1alpha1ResourceShareSpecPermissionRefs>? PermissionRefs { get; set; }

    /// <summary>
    /// Specifies a list of one or more principals to associate with the resource
    /// share.
    /// 
    /// You can include the following values:
    /// 
    ///   - An Amazon Web Services account ID, for example: 123456789012
    /// 
    ///   - An Amazon Resource Name (ARN) (https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html)
    ///     of an organization in Organizations, for example: organizations::123456789012:organization/o-exampleorgid
    /// 
    ///   - An ARN of an organizational unit (OU) in Organizations, for example:
    ///     organizations::123456789012:ou/o-exampleorgid/ou-examplerootid-exampleouid123
    /// 
    ///   - An ARN of an IAM role, for example: iam::123456789012:role/rolename
    /// 
    ///   - An ARN of an IAM user, for example: iam::123456789012user/username
    /// 
    /// Not all resource types can be shared with IAM roles and users. For more information,
    /// see Sharing with IAM roles and users (https://docs.aws.amazon.com/ram/latest/userguide/permissions.html#permissions-rbp-supported-resource-types)
    /// in the Resource Access Manager User Guide.
    /// </summary>
    [JsonPropertyName("principals")]
    public IList<string>? Principals { get; set; }

    /// <summary>
    /// Specifies a list of one or more ARNs of the resources to associate with the
    /// resource share.
    /// </summary>
    [JsonPropertyName("resourceARNs")]
    public IList<string>? ResourceARNs { get; set; }

    /// <summary>
    /// Specifies from which source accounts the service principal has access to
    /// the resources in this resource share.
    /// </summary>
    [JsonPropertyName("sources")]
    public IList<string>? Sources { get; set; }

    /// <summary>
    /// A list of one or more tag key and value pairs. The tag key must be present
    /// and not be an empty string. The tag value must be present but can be an empty
    /// string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ResourceShareSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceShareStatusAckResourceMetadata
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
public partial class V1alpha1ResourceShareStatusConditions
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

/// <summary>ResourceShareStatus defines the observed state of ResourceShare</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceShareStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResourceShareStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResourceShareStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time when the resource share was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

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

    /// <summary>The date and time when the resource share was last updated.</summary>
    [JsonPropertyName("lastUpdatedTime")]
    public DateTime? LastUpdatedTime { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the resource share.</summary>
    [JsonPropertyName("owningAccountID")]
    public string? OwningAccountID { get; set; }

    /// <summary>The current status of the resource share.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A message about the status of the resource share.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>ResourceShare is the Schema for the ResourceShares API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourceShare : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResourceShareSpec?>, IStatus<V1alpha1ResourceShareStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourceShare";
    public const string KubeGroup = "ram.services.k8s.aws";
    public const string KubePluralName = "resourceshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ram.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceShare";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResourceShareSpec defines the desired state of ResourceShare.
    /// 
    /// Describes a resource share in RAM.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResourceShareSpec? Spec { get; set; }

    /// <summary>ResourceShareStatus defines the observed state of ResourceShare</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResourceShareStatus? Status { get; set; }
}