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
/// <summary>ServiceLinkedRole is the Schema for the ServiceLinkedRoles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceLinkedRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServiceLinkedRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceLinkedRoleList";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "servicelinkedroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceLinkedRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ServiceLinkedRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ServiceLinkedRole> Items { get; set; }
}

/// <summary>ServiceLinkedRoleSpec defines the desired state of ServiceLinkedRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceLinkedRoleSpec
{
    /// <summary>
    /// The service principal for the Amazon Web Services service to which this role
    /// is attached. You use a string similar to a URL but without the http:// in
    /// front. For example: elasticbeanstalk.amazonaws.com.
    /// 
    /// Service principals are unique and case-sensitive. To find the exact service
    /// principal for your service-linked role, see Amazon Web Services services
    /// that work with IAM (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html)
    /// in the IAM User Guide. Look for the services that have Yes in the Service-Linked
    /// Role column. Choose the Yes link to view the service-linked role documentation
    /// for that service.
    /// 
    /// Regex Pattern: `^[\w+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("awsServiceName")]
    public required string AwsServiceName { get; set; }

    /// <summary>
    /// A string that you provide, which is combined with the service-provided prefix
    /// to form the complete role name. If you make multiple requests for the same
    /// service, then you must supply a different CustomSuffix for each request.
    /// Otherwise the request fails with a duplicate role name error. For example,
    /// you could add -1 or -debug to the suffix.
    /// 
    /// Some services do not support the CustomSuffix parameter. If you provide an
    /// optional suffix and the operation fails, try the operation again without
    /// the suffix.
    /// 
    /// Regex Pattern: `^[\w+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("customSuffix")]
    public string? CustomSuffix { get; set; }

    /// <summary>
    /// The description of the role.
    /// 
    /// Regex Pattern: `^[\u0009\u000A\u000D\u0020-\u007E\u00A1-\u00FF]*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceLinkedRoleStatusAckResourceMetadata
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
public partial class V1alpha1ServiceLinkedRoleStatusConditions
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
/// The ARN of the policy used to set the permissions boundary for the role.
/// 
/// For more information about permissions boundaries, see Permissions boundaries
/// for IAM identities (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceLinkedRoleStatusPermissionsBoundary
{
    /// <summary>
    /// The Amazon Resource Name (ARN). ARNs are unique identifiers for Amazon Web
    /// Services resources.
    /// 
    /// For more information about ARNs, go to Amazon Resource Names (ARNs) (https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html)
    /// in the Amazon Web Services General Reference.
    /// </summary>
    [JsonPropertyName("permissionsBoundaryARN")]
    public string? PermissionsBoundaryARN { get; set; }

    [JsonPropertyName("permissionsBoundaryType")]
    public string? PermissionsBoundaryType { get; set; }
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
public partial class V1alpha1ServiceLinkedRoleStatusRoleLastUsed
{
    [JsonPropertyName("lastUsedDate")]
    public DateTime? LastUsedDate { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// A structure that represents user-provided metadata that can be associated
/// with an IAM resource. For more information about tagging, see Tagging IAM
/// resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
/// in the IAM User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceLinkedRoleStatusTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ServiceLinkedRoleStatus defines the observed state of ServiceLinkedRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceLinkedRoleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ServiceLinkedRoleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The policy that grants an entity permission to assume the role.
    /// 
    /// Regex Pattern: `^[\u0009\u000A\u000D\u0020-\u00FF]+$`
    /// </summary>
    [JsonPropertyName("assumeRolePolicyDocument")]
    public string? AssumeRolePolicyDocument { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServiceLinkedRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time, in ISO 8601 date-time format (http://www.iso.org/iso/iso8601),
    /// when the role was created.
    /// </summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// The maximum session duration (in seconds) for the specified role. Anyone
    /// who uses the CLI, or API to assume the role can specify the duration using
    /// the optional DurationSeconds API parameter or duration-seconds CLI parameter.
    /// </summary>
    [JsonPropertyName("maxSessionDuration")]
    public long? MaxSessionDuration { get; set; }

    /// <summary>
    /// The path to the role. For more information about paths, see IAM identifiers
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html)
    /// in the IAM User Guide.
    /// 
    /// Regex Pattern: `^(\u002F)|(\u002F[\u0021-\u007E]+\u002F)$`
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The ARN of the policy used to set the permissions boundary for the role.
    /// 
    /// For more information about permissions boundaries, see Permissions boundaries
    /// for IAM identities (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("permissionsBoundary")]
    public V1alpha1ServiceLinkedRoleStatusPermissionsBoundary? PermissionsBoundary { get; set; }

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
    public V1alpha1ServiceLinkedRoleStatusRoleLastUsed? RoleLastUsed { get; set; }

    /// <summary>
    /// The friendly name that identifies the role.
    /// 
    /// Regex Pattern: `^[\w+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>
    /// A list of tags that are attached to the role. For more information about
    /// tagging, see Tagging IAM resources (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html)
    /// in the IAM User Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ServiceLinkedRoleStatusTags>? Tags { get; set; }
}

/// <summary>ServiceLinkedRole is the Schema for the ServiceLinkedRoles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceLinkedRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServiceLinkedRoleSpec?>, IStatus<V1alpha1ServiceLinkedRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceLinkedRole";
    public const string KubeGroup = "iam.services.k8s.aws";
    public const string KubePluralName = "servicelinkedroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceLinkedRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceLinkedRoleSpec defines the desired state of ServiceLinkedRole.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServiceLinkedRoleSpec? Spec { get; set; }

    /// <summary>ServiceLinkedRoleStatus defines the observed state of ServiceLinkedRole</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServiceLinkedRoleStatus? Status { get; set; }
}