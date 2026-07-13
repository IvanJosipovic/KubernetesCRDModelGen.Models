#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.services.k8s.aws;
/// <summary>Grant is the Schema for the Grants API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GrantList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Grant>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GrantList";
    public const string KubeGroup = "kms.services.k8s.aws";
    public const string KubePluralName = "grants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GrantList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Grant objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Grant> Items { get; set; }
}

/// <summary>
/// Specifies a grant constraint.
/// 
/// Do not include confidential or sensitive information in this field. This
/// field may be displayed in plaintext in CloudTrail logs and other output.
/// 
/// KMS supports the EncryptionContextEquals and EncryptionContextSubset grant
/// constraints, which allow the permissions in the grant only when the encryption
/// context in the request matches (EncryptionContextEquals) or includes (EncryptionContextSubset)
/// the encryption context specified in the constraint.
/// 
/// The encryption context grant constraints are supported only on grant operations
/// (https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations)
/// that include an EncryptionContext parameter, such as cryptographic operations
/// on symmetric encryption KMS keys. Grants with grant constraints can include
/// the DescribeKey and RetireGrant operations, but the constraint doesn&apos;t apply
/// to these operations. If a grant with a grant constraint includes the CreateGrant
/// operation, the constraint requires that any grants created with the CreateGrant
/// permission have an equally strict or stricter encryption context constraint.
/// 
/// You cannot use an encryption context grant constraint for cryptographic operations
/// with asymmetric KMS keys or HMAC KMS keys. Operations with these keys don&apos;t
/// support an encryption context.
/// 
/// Each constraint value can include up to 8 encryption context pairs. The encryption
/// context value in each constraint cannot exceed 384 characters. For information
/// about grant constraints, see Using grant constraints (https://docs.aws.amazon.com/kms/latest/developerguide/create-grant-overview.html#grant-constraints)
/// in the Key Management Service Developer Guide. For more information about
/// encryption context, see Encryption context (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context)
/// in the Key Management Service Developer Guide .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GrantSpecConstraints
{
    [JsonPropertyName("encryptionContextEquals")]
    public IDictionary<string, string>? EncryptionContextEquals { get; set; }

    [JsonPropertyName("encryptionContextSubset")]
    public IDictionary<string, string>? EncryptionContextSubset { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GrantSpecKeyRefFrom
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
public partial class V1alpha1GrantSpecKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1GrantSpecKeyRefFrom? From { get; set; }
}

/// <summary>GrantSpec defines the desired state of Grant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GrantSpec
{
    /// <summary>
    /// Specifies a grant constraint.
    /// 
    /// Do not include confidential or sensitive information in this field. This
    /// field may be displayed in plaintext in CloudTrail logs and other output.
    /// 
    /// KMS supports the EncryptionContextEquals and EncryptionContextSubset grant
    /// constraints, which allow the permissions in the grant only when the encryption
    /// context in the request matches (EncryptionContextEquals) or includes (EncryptionContextSubset)
    /// the encryption context specified in the constraint.
    /// 
    /// The encryption context grant constraints are supported only on grant operations
    /// (https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations)
    /// that include an EncryptionContext parameter, such as cryptographic operations
    /// on symmetric encryption KMS keys. Grants with grant constraints can include
    /// the DescribeKey and RetireGrant operations, but the constraint doesn&apos;t apply
    /// to these operations. If a grant with a grant constraint includes the CreateGrant
    /// operation, the constraint requires that any grants created with the CreateGrant
    /// permission have an equally strict or stricter encryption context constraint.
    /// 
    /// You cannot use an encryption context grant constraint for cryptographic operations
    /// with asymmetric KMS keys or HMAC KMS keys. Operations with these keys don&apos;t
    /// support an encryption context.
    /// 
    /// Each constraint value can include up to 8 encryption context pairs. The encryption
    /// context value in each constraint cannot exceed 384 characters. For information
    /// about grant constraints, see Using grant constraints (https://docs.aws.amazon.com/kms/latest/developerguide/create-grant-overview.html#grant-constraints)
    /// in the Key Management Service Developer Guide. For more information about
    /// encryption context, see Encryption context (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context)
    /// in the Key Management Service Developer Guide .
    /// </summary>
    [JsonPropertyName("constraints")]
    public V1alpha1GrantSpecConstraints? Constraints { get; set; }

    /// <summary>
    /// A list of grant tokens.
    /// 
    /// Use a grant token when your permission to call this operation comes from
    /// a new grant that has not yet achieved eventual consistency. For more information,
    /// see Grant token (https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token)
    /// and Using a grant token (https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token)
    /// in the Key Management Service Developer Guide.
    /// </summary>
    [JsonPropertyName("grantTokens")]
    public IList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The identity that gets the permissions specified in the grant.
    /// 
    /// To specify the grantee principal, use the Amazon Resource Name (ARN) of an
    /// Amazon Web Services principal. Valid principals include Amazon Web Services
    /// accounts, IAM users, IAM roles, federated users, and assumed role users.
    /// For help with the ARN syntax for a principal, see IAM ARNs (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns)
    /// in the Identity and Access Management User Guide .
    /// 
    /// Regex Pattern: `^[\w+=,.@:/-]+$`
    /// </summary>
    [JsonPropertyName("granteePrincipal")]
    public required string GranteePrincipal { get; set; }

    /// <summary>
    /// Identifies the KMS key for the grant. The grant gives principals permission
    /// to use this KMS key.
    /// 
    /// Specify the key ID or key ARN of the KMS key. To specify a KMS key in adifferent
    /// Amazon Web Services account, you must use the key ARN.
    /// 
    /// For example:
    /// 
    ///   - Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab
    /// 
    ///   - Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
    /// 
    /// To get the key ID and key ARN for a KMS key, use ListKeys or DescribeKey.
    /// </summary>
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("keyRef")]
    public V1alpha1GrantSpecKeyRef? KeyRef { get; set; }

    /// <summary>
    /// A friendly name for the grant. Use this value to prevent the unintended creation
    /// of duplicate grants when retrying this request.
    /// 
    /// Do not include confidential or sensitive information in this field. This
    /// field may be displayed in plaintext in CloudTrail logs and other output.
    /// 
    /// When this value is absent, all CreateGrant requests result in a new grant
    /// with a unique GrantId even if all the supplied parameters are identical.
    /// This can result in unintended duplicates when you retry the CreateGrant request.
    /// 
    /// When this value is present, you can retry a CreateGrant request with identical
    /// parameters; if the grant already exists, the original GrantId is returned
    /// without creating a new grant. Note that the returned grant token is unique
    /// with every CreateGrant request, even when a duplicate GrantId is returned.
    /// All grant tokens for the same grant ID can be used interchangeably.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9:/_-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A list of operations that the grant permits.
    /// 
    /// This list must include only operations that are permitted in a grant. Also,
    /// the operation must be supported on the KMS key. For example, you cannot create
    /// a grant for a symmetric encryption KMS key that allows the Sign operation,
    /// or a grant for an asymmetric KMS key that allows the GenerateDataKey operation.
    /// If you try, KMS returns a ValidationError exception. For details, see Grant
    /// operations (https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations)
    /// in the Key Management Service Developer Guide.
    /// </summary>
    [JsonPropertyName("operations")]
    public required IList<string> Operations { get; set; }

    /// <summary>
    /// The principal that has permission to use the RetireGrant operation to retire
    /// the grant.
    /// 
    /// To specify the principal, use the Amazon Resource Name (ARN) (https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html)
    /// of an Amazon Web Services principal. Valid principals include Amazon Web
    /// Services accounts, IAM users, IAM roles, federated users, and assumed role
    /// users. For help with the ARN syntax for a principal, see IAM ARNs (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns)
    /// in the Identity and Access Management User Guide .
    /// 
    /// The grant determines the retiring principal. Other principals might have
    /// permission to retire the grant or revoke the grant. For details, see RevokeGrant
    /// and Retiring and revoking grants (https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete)
    /// in the Key Management Service Developer Guide.
    /// 
    /// Regex Pattern: `^[\w+=,.@:/-]+$`
    /// </summary>
    [JsonPropertyName("retiringPrincipal")]
    public string? RetiringPrincipal { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GrantStatusAckResourceMetadata
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
public partial class V1alpha1GrantStatusConditions
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

/// <summary>GrantStatus defines the observed state of Grant</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GrantStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1GrantStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GrantStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique identifier for the grant.
    /// 
    /// You can use the GrantId in a ListGrants, RetireGrant, or RevokeGrant operation.
    /// </summary>
    [JsonPropertyName("grantID")]
    public string? GrantID { get; set; }

    /// <summary>
    /// The grant token.
    /// 
    /// Use a grant token when your permission to call this operation comes from
    /// a new grant that has not yet achieved eventual consistency. For more information,
    /// see Grant token (https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token)
    /// and Using a grant token (https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token)
    /// in the Key Management Service Developer Guide.
    /// </summary>
    [JsonPropertyName("grantToken")]
    public string? GrantToken { get; set; }
}

/// <summary>Grant is the Schema for the Grants API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Grant : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GrantSpec?>, IStatus<V1alpha1GrantStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Grant";
    public const string KubeGroup = "kms.services.k8s.aws";
    public const string KubePluralName = "grants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Grant";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GrantSpec defines the desired state of Grant.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1GrantSpec? Spec { get; set; }

    /// <summary>GrantStatus defines the observed state of Grant</summary>
    [JsonPropertyName("status")]
    public V1alpha1GrantStatus? Status { get; set; }
}