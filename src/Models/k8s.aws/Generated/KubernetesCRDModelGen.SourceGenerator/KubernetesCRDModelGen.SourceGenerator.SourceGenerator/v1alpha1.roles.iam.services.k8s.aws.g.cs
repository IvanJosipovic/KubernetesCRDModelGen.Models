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
/// <summary>Role is the Schema for the Roles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Role>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RoleList";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "roles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Role objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Role> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleSpecPermissionsBoundaryRefFrom
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
public partial class V1alpha1RoleSpecPermissionsBoundaryRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RoleSpecPermissionsBoundaryRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleSpecPolicyRefsFrom
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
public partial class V1alpha1RoleSpecPolicyRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RoleSpecPolicyRefsFrom? From { get; set; }
}

/// <summary>
/// A structure that represents user-provided metadata that can be associated
/// with an IAM resource. For more information about tagging, see Tagging IAM
/// resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// RoleSpec defines the desired state of Role.
/// 
/// Contains information about an IAM role. This structure is returned as a response
/// element in several API operations that interact with roles.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleSpec
{
    /// <summary>
    /// The trust relationship policy document that grants an entity permission to
    /// assume the role.
    /// 
    /// In IAM, you must provide a JSON policy that has been converted to a string.
    /// However, for CloudFormation templates formatted in YAML, you can provide
    /// the policy in JSON or YAML format. CloudFormation always converts a YAML
    /// policy to JSON format before submitting it to IAM.
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
    /// Upon success, the response includes the same trust policy in JSON format.
    /// 
    /// Regex Pattern: `^[\u0009\u000A\u000D\u0020-\u00FF]+$`
    /// </summary>
    [JsonPropertyName("assumeRolePolicyDocument")]
    public required string AssumeRolePolicyDocument { get; set; }

    /// <summary>
    /// A description of the role.
    /// 
    /// Regex Pattern: `^[\u0009\u000A\u000D\u0020-\u007E\u00A1-\u00FF]*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("inlinePolicies")]
    public IDictionary<string, string>? InlinePolicies { get; set; }

    /// <summary>
    /// The maximum session duration (in seconds) that you want to set for the specified
    /// role. If you do not specify a value for this setting, the default value of
    /// one hour is applied. This setting can have a value from 1 hour to 12 hours.
    /// 
    /// Anyone who assumes the role from the CLI or API can use the DurationSeconds
    /// API parameter or the duration-seconds CLI parameter to request a longer session.
    /// The MaxSessionDuration setting determines the maximum duration that can be
    /// requested using the DurationSeconds parameter. If users don&apos;t specify a value
    /// for the DurationSeconds parameter, their security credentials are valid for
    /// one hour by default. This applies when you use the AssumeRole* API operations
    /// or the assume-role* CLI operations but does not apply when you use those
    /// operations to create a console URL. For more information, see Using IAM roles
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html) in the
    /// IAM User Guide.
    /// </summary>
    [JsonPropertyName("maxSessionDuration")]
    public long? MaxSessionDuration { get; set; }

    /// <summary>
    /// The name of the role to create.
    /// 
    /// IAM user, group, role, and policy names must be unique within the account.
    /// Names are not distinguished by case. For example, you cannot create resources
    /// named both &quot;MyResource&quot; and &quot;myresource&quot;.
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
    /// The path to the role. For more information about paths, see IAM Identifiers
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
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

    /// <summary>
    /// The ARN of the managed policy that is used to set the permissions boundary
    /// for the role.
    /// 
    /// A permissions boundary policy defines the maximum permissions that identity-based
    /// policies can grant to an entity, but does not grant permissions. Permissions
    /// boundaries do not define the maximum permissions that a resource-based policy
    /// can grant to an entity. To learn more, see Permissions boundaries for IAM
    /// entities (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html)
    /// in the IAM User Guide.
    /// 
    /// For more information about policy types, see Policy types (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policy-types)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("permissionsBoundary")]
    public string? PermissionsBoundary { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("permissionsBoundaryRef")]
    public V1alpha1RoleSpecPermissionsBoundaryRef? PermissionsBoundaryRef { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    [JsonPropertyName("policyRefs")]
    public IList<V1alpha1RoleSpecPolicyRefs>? PolicyRefs { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the new role. Each tag consists
    /// of a key name and an associated value. For more information about tagging,
    /// see Tagging IAM resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
    /// in the IAM User Guide.
    /// 
    /// If any one of the tags is invalid or if you exceed the allowed maximum number
    /// of tags, then the entire request fails and the resource is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RoleSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleStatusAckResourceMetadata
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
public partial class V1alpha1RoleStatusConditions
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

/// <summary>
/// Contains information about the last time that an IAM role was used. This
/// includes the date and time and the Region in which the role was last used.
/// Activity is only reported for the trailing 400 days. This period can be shorter
/// if your Region began supporting these features within the last year. The
/// role might have been used more than 400 days ago. For more information, see
/// Regions where data is tracked (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period)
/// in the IAM user Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleStatusRoleLastUsed
{
    [JsonPropertyName("lastUsedDate")]
    public DateTime? LastUsedDate { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>RoleStatus defines the observed state of Role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RoleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RoleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time, in ISO 8601 date-time format (http://www.iso.org/iso/iso8601),
    /// when the role was created.
    /// </summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// The stable and unique string identifying the role. For more information about
    /// IDs, see IAM identifiers (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
    /// in the IAM User Guide.
    /// 
    /// Regex Pattern: `^[\w]+$`
    /// </summary>
    [JsonPropertyName("roleID")]
    public string? RoleID { get; set; }

    /// <summary>
    /// Contains information about the last time that an IAM role was used. This
    /// includes the date and time and the Region in which the role was last used.
    /// Activity is only reported for the trailing 400 days. This period can be shorter
    /// if your Region began supporting these features within the last year. The
    /// role might have been used more than 400 days ago. For more information, see
    /// Regions where data is tracked (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period)
    /// in the IAM user Guide.
    /// </summary>
    [JsonPropertyName("roleLastUsed")]
    public V1alpha1RoleStatusRoleLastUsed? RoleLastUsed { get; set; }
}

/// <summary>Role is the Schema for the Roles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Role : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RoleSpec?>, IStatus<V1alpha1RoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Role";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "roles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Role";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RoleSpec defines the desired state of Role.
    /// 
    /// Contains information about an IAM role. This structure is returned as a response
    /// element in several API operations that interact with roles.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RoleSpec? Spec { get; set; }

    /// <summary>RoleStatus defines the observed state of Role</summary>
    [JsonPropertyName("status")]
    public V1alpha1RoleStatus? Status { get; set; }
}