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
/// <summary>Policy is the Schema for the Policies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Policy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Policy> Items { get; set; }
}

/// <summary>
/// A structure that represents user-provided metadata that can be associated
/// with an IAM resource. For more information about tagging, see Tagging IAM
/// resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PolicySpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// PolicySpec defines the desired state of Policy.
/// 
/// Contains information about a managed policy.
/// 
/// This data type is used as a response element in the CreatePolicy, GetPolicy,
/// and ListPolicies operations.
/// 
/// For more information about managed policies, refer to Managed policies and
/// inline policies (https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PolicySpec
{
    /// <summary>
    /// A friendly description of the policy.
    /// 
    /// Typically used to store information about the permissions defined in the
    /// policy. For example, &quot;Grants access to production DynamoDB tables.&quot;
    /// 
    /// The policy description is immutable. After a value is assigned, it cannot
    /// be changed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The friendly name of the policy.
    /// 
    /// IAM user, group, role, and policy names must be unique within the account.
    /// Names are not distinguished by case. For example, you cannot create resources
    /// named both &quot;MyResource&quot; and &quot;myresource&quot;.
    /// 
    /// Regex Pattern: `^[\w+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The path for the policy.
    /// 
    /// For more information about paths, see IAM identifiers (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
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
    /// You cannot use an asterisk (*) in the path name.
    /// 
    /// Regex Pattern: `^((/[A-Za-z0-9\.,\+@=_-]+)*)/$`
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The JSON policy document that you want to use as the content for the new
    /// policy.
    /// 
    /// You must provide policies in JSON format in IAM. However, for CloudFormation
    /// templates formatted in YAML, you can provide the policy in JSON or YAML format.
    /// CloudFormation always converts a YAML policy to JSON format before submitting
    /// it to IAM.
    /// 
    /// The maximum length of the policy document that you can pass in this operation,
    /// including whitespace, is listed below. To view the maximum character counts
    /// of a managed policy with no whitespaces, see IAM and STS character quotas
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-quotas-entity-length).
    /// 
    /// To learn more about JSON policy grammar, see Grammar of the IAM JSON policy
    /// language (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_grammar.html)
    /// in the IAM User Guide.
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) used to validate this
    /// parameter is a string of characters consisting of the following:
    /// 
    ///   - Any printable ASCII character ranging from the space character (\u0020)
    ///     through the end of the ASCII character range
    /// 
    ///   - The printable characters in the Basic Latin and Latin-1 Supplement character
    ///     set (through \u00FF)
    /// 
    ///   - The special characters tab (\u0009), line feed (\u000A), and carriage
    ///     return (\u000D)
    /// 
    /// Regex Pattern: `^[\u0009\u000A\u000D\u0020-\u00FF]+$`
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public required string PolicyDocument { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the new IAM customer managed policy.
    /// Each tag consists of a key name and an associated value. For more information
    /// about tagging, see Tagging IAM resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
    /// in the IAM User Guide.
    /// 
    /// If any one of the tags is invalid or if you exceed the allowed maximum number
    /// of tags, then the entire request fails and the resource is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1PolicySpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PolicyStatusAckResourceMetadata
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
public partial class V1alpha1PolicyStatusConditions
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

/// <summary>PolicyStatus defines the observed state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The number of entities (users, groups, and roles) that the policy is attached
    /// to.
    /// </summary>
    [JsonPropertyName("attachmentCount")]
    public long? AttachmentCount { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time, in ISO 8601 date-time format (http://www.iso.org/iso/iso8601),
    /// when the policy was created.
    /// </summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// The identifier for the version of the policy that is set as the default version.
    /// 
    /// Regex Pattern: `^v[1-9][0-9]*(\.[A-Za-z0-9-]*)?$`
    /// </summary>
    [JsonPropertyName("defaultVersionID")]
    public string? DefaultVersionID { get; set; }

    /// <summary>Specifies whether the policy can be attached to an IAM user, group, or role.</summary>
    [JsonPropertyName("isAttachable")]
    public bool? IsAttachable { get; set; }

    /// <summary>
    /// The number of entities (users and roles) for which the policy is used to
    /// set the permissions boundary.
    /// 
    /// For more information about permissions boundaries, see Permissions boundaries
    /// for IAM identities (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("permissionsBoundaryUsageCount")]
    public long? PermissionsBoundaryUsageCount { get; set; }

    /// <summary>
    /// The stable and unique string identifying the policy.
    /// 
    /// For more information about IDs, see IAM identifiers (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
    /// in the IAM User Guide.
    /// 
    /// Regex Pattern: `^[\w]+$`
    /// </summary>
    [JsonPropertyName("policyID")]
    public string? PolicyID { get; set; }

    /// <summary>
    /// The date and time, in ISO 8601 date-time format (http://www.iso.org/iso/iso8601),
    /// when the policy was last updated.
    /// 
    /// When a policy has only one version, this field contains the date and time
    /// when the policy was created. When a policy has more than one version, this
    /// field contains the date and time when the most recent policy version was
    /// created.
    /// </summary>
    [JsonPropertyName("updateDate")]
    public DateTime? UpdateDate { get; set; }
}

/// <summary>Policy is the Schema for the Policies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PolicySpec?>, IStatus<V1alpha1PolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// PolicySpec defines the desired state of Policy.
    /// 
    /// Contains information about a managed policy.
    /// 
    /// This data type is used as a response element in the CreatePolicy, GetPolicy,
    /// and ListPolicies operations.
    /// 
    /// For more information about managed policies, refer to Managed policies and
    /// inline policies (https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1PolicySpec? Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy</summary>
    [JsonPropertyName("status")]
    public V1alpha1PolicyStatus? Status { get; set; }
}