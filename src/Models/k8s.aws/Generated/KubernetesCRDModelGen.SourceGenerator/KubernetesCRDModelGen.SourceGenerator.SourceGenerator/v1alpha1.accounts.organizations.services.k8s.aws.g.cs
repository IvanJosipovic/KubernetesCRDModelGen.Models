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
/// <summary>Account is the Schema for the Accounts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AccountList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Account>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AccountList";
    public const string KubeGroup = "organizations.services.k8s.aws";
    public const string KubePluralName = "accounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Account objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Account> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccountSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AccountSpec defines the desired state of Account.
/// 
/// Contains information about an Amazon Web Services account that is a member
/// of an organization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccountSpec
{
    /// <summary>
    /// The email address of the owner to assign to the new member account. This
    /// email address must not already be associated with another Amazon Web Services
    /// account. You must use a valid email address to complete account creation.
    /// 
    /// The rules for a valid email address:
    /// 
    ///   - The address must be a minimum of 6 and a maximum of 64 characters long.
    /// 
    ///   - All characters must be 7-bit ASCII characters.
    /// 
    ///   - There must be one and only one @ symbol, which separates the local name
    ///     from the domain name.
    /// 
    /// Regex Pattern: `^[^\s@]+@[^\s@]+\.[^\s@]+$`
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// If set to ALLOW, the new account enables IAM users to access account billing
    /// information if they have the required permissions. If set to DENY, only the
    /// root user of the new account can access account billing information. For
    /// more information, see About IAM access to the Billing and Cost Management
    /// console (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// 
    /// If you don&apos;t specify this parameter, the value defaults to ALLOW, and IAM
    /// users and roles with the required permissions can access billing information
    /// for the new account.
    /// </summary>
    [JsonPropertyName("iamUserAccessToBilling")]
    public string? IamUserAccessToBilling { get; set; }

    /// <summary>
    /// The friendly name of the member account.
    /// 
    /// Regex Pattern: `^[\u0020-\u007E]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The name of an IAM role that Organizations automatically preconfigures in
    /// the new member account. This role trusts the management account, allowing
    /// users in the management account to assume the role, as permitted by the management
    /// account administrator. The role has administrator permissions in the new
    /// member account.
    /// 
    /// If you don&apos;t specify this parameter, the role name defaults to OrganizationAccountAccessRole.
    /// 
    /// For more information about how to use this role to access the member account,
    /// see the following links:
    /// 
    ///   - Creating the OrganizationAccountAccessRole in an invited member account
    ///     (https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_access.html#orgs_manage_accounts_create-cross-account-role)
    ///     in the Organizations User Guide
    /// 
    ///   - Steps 2 and 3 in IAM Tutorial: Delegate access across Amazon Web Services
    ///     accounts using IAM roles (https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_cross-account-with-roles.html)
    ///     in the IAM User Guide
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) that is used to validate
    /// this parameter. The pattern can include uppercase letters, lowercase letters,
    /// digits with no spaces, and any of the following characters: =,.@-
    /// 
    /// Regex Pattern: `^[\w+=,.@-]{1,64}$`
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>
    /// A list of tags that you want to attach to the newly created account. For
    /// each tag in the list, you must specify both a tag key and a value. You can
    /// set the value to an empty string, but you can&apos;t set it to null. For more
    /// information about tagging, see Tagging Organizations resources (https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html)
    /// in the Organizations User Guide.
    /// 
    /// If any one of the tags is not valid or if you exceed the maximum allowed
    /// number of tags for an account, then the entire request fails and the account
    /// is not created.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1AccountSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccountStatusAckResourceMetadata
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
public partial class V1alpha1AccountStatusConditions
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

/// <summary>AccountStatus defines the observed state of Account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AccountStatus
{
    /// <summary>
    /// If the account was created successfully, the unique identifier (ID) of the
    /// new account.
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) for an account ID string
    /// requires exactly 12 digits.
    /// 
    /// Regex Pattern: `^\d{12}$`
    /// </summary>
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AccountStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The date and time that the account was created and the request completed.</summary>
    [JsonPropertyName("completedTimestamp")]
    public DateTime? CompletedTimestamp { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AccountStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique identifier (ID) that references this request. You get this value
    /// from the response of the initial CreateAccount request to create the account.
    /// 
    /// The regex pattern (http://wikipedia.org/wiki/regex) for a create account
    /// request ID string requires &quot;car-&quot; followed by from 8 to 32 lowercase letters
    /// or digits.
    /// 
    /// Regex Pattern: `^car-[a-z0-9]{8,32}$`
    /// </summary>
    [JsonPropertyName("createAccountRequestID")]
    public string? CreateAccountRequestID { get; set; }

    /// <summary>
    /// If the request failed, a description of the reason for the failure.
    /// 
    ///    * ACCOUNT_LIMIT_EXCEEDED: The account couldn&apos;t be created because you
    ///    reached the limit on the number of accounts in your organization.
    /// 
    ///    * CONCURRENT_ACCOUNT_MODIFICATION: You already submitted a request with
    ///    the same information.
    /// 
    ///    * EMAIL_ALREADY_EXISTS: The account could not be created because another
    ///    Amazon Web Services account with that email address already exists.
    /// 
    ///    * FAILED_BUSINESS_VALIDATION: The Amazon Web Services account that owns
    ///    your organization failed to receive business license validation.
    /// 
    ///    * GOVCLOUD_ACCOUNT_ALREADY_EXISTS: The account in the Amazon Web Services
    ///    GovCloud (US) Region could not be created because this Region already
    ///    includes an account with that email address.
    /// 
    ///    * IDENTITY_INVALID_BUSINESS_VALIDATION: The Amazon Web Services account
    ///    that owns your organization can&apos;t complete business license validation
    ///    because it doesn&apos;t have valid identity data.
    /// 
    ///    * INVALID_ADDRESS: The account could not be created because the address
    ///    you provided is not valid.
    /// 
    ///    * INVALID_EMAIL: The account could not be created because the email address
    ///    you provided is not valid.
    /// 
    ///    * INVALID_PAYMENT_INSTRUMENT: The Amazon Web Services account that owns
    ///    your organization does not have a supported payment method associated
    ///    with the account. Amazon Web Services does not support cards issued by
    ///    financial institutions in Russia or Belarus. For more information, see
    ///    Managing your Amazon Web Services payments (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html).
    /// 
    ///    * INTERNAL_FAILURE: The account could not be created because of an internal
    ///    failure. Try again later. If the problem persists, contact Amazon Web
    ///    Services Customer Support.
    /// 
    ///    * MISSING_BUSINESS_VALIDATION: The Amazon Web Services account that owns
    ///    your organization has not received Business Validation.
    /// 
    ///    * MISSING_PAYMENT_INSTRUMENT: You must configure the management account
    ///    with a valid payment method, such as a credit card.
    /// 
    ///    * PENDING_BUSINESS_VALIDATION: The Amazon Web Services account that owns
    ///    your organization is still in the process of completing business license
    ///    validation.
    /// 
    ///    * UNKNOWN_BUSINESS_VALIDATION: The Amazon Web Services account that owns
    ///    your organization has an unknown issue with business license validation.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// If the account was created successfully, the unique identifier (ID) of the
    /// new account in the Amazon Web Services GovCloud (US) Region.
    /// 
    /// Regex Pattern: `^\d{12}$`
    /// </summary>
    [JsonPropertyName("govCloudAccountID")]
    public string? GovCloudAccountID { get; set; }

    /// <summary>The date and time that the request was made for the account creation.</summary>
    [JsonPropertyName("requestedTimestamp")]
    public DateTime? RequestedTimestamp { get; set; }

    /// <summary>The status of the asynchronous request to create an Amazon Web Services account.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Account is the Schema for the Accounts API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Account : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AccountSpec?>, IStatus<V1alpha1AccountStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Account";
    public const string KubeGroup = "organizations.services.k8s.aws";
    public const string KubePluralName = "accounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Account";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AccountSpec defines the desired state of Account.
    /// 
    /// Contains information about an Amazon Web Services account that is a member
    /// of an organization.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AccountSpec? Spec { get; set; }

    /// <summary>AccountStatus defines the observed state of Account</summary>
    [JsonPropertyName("status")]
    public V1alpha1AccountStatus? Status { get; set; }
}