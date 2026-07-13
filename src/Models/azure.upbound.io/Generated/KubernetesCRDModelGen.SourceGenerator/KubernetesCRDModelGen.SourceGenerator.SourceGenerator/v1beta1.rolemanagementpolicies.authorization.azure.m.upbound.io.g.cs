#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.m.upbound.io;
/// <summary>RoleManagementPolicy is the Schema for the RoleManagementPolicys API. Manages Azure PIM Role Management Policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RoleManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RoleManagementPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RoleManagementPolicyList";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "rolemanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleManagementPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RoleManagementPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RoleManagementPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are User and Group.
    /// The type of object acting as an approver
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// An approval_stage block as defined below.
/// The approval stages for the activation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderActivationRulesApprovalStage
{
    /// <summary>
    /// One or more primary_approver blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1RoleManagementPolicySpecForProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1RoleManagementPolicySpecForProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D. Possible values are PT30M, PT1H, PT1H30M, PT2H, PT2H30M, PT3H, PT3H30M, PT4H, PT4H30M, PT5H, PT5H30M, PT6H, PT6H30M, PT7H, PT7H30M, PT8H, PT8H30M, PT9H, PT9H30M, PT10H, PT10H30M, PT11H, PT11H30M, PT12H, PT12H30M, PT13H, PT13H30M, PT14H, PT14H30M, PT15H, PT15H30M, PT16H, PT16H30M, PT17H, PT17H30M, PT18H, PT18H30M, PT19H, PT19H30M, PT20H, PT20H30M, PT21H, PT21H30M, PT22H, PT22H30M, PT23H, PT23H30M and P1D.
    /// The time after which the an activation can be valid for
    /// </summary>
    [JsonPropertyName("maximumDuration")]
    public string? MaximumDuration { get; set; }

    /// <summary>
    /// Is approval required for activation. If true an approval_stage block must be provided.
    /// Whether an approval is required for activation
    /// </summary>
    [JsonPropertyName("requireApproval")]
    public bool? RequireApproval { get; set; }

    /// <summary>
    /// Is a justification required during activation of the role.
    /// Whether a justification is required during activation
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to activate the role. Conflicts with required_conditional_access_authentication_context.
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information requrired during activation of the role.
    /// Whether ticket information is required during activation
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }

    /// <summary>
    /// The Entra ID Conditional Access context that must be present for activation. Conflicts with require_multifactor_authentication.
    /// Whether a conditional access context is required during activation
    /// </summary>
    [JsonPropertyName("requiredConditionalAccessAuthenticationContext")]
    public string? RequiredConditionalAccessAuthenticationContext { get; set; }
}

/// <summary>
/// An active_assignment_rules block as defined below.
/// The rules for active assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderActiveAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>
    /// Is a justification required to create new assignments.
    /// Whether a justification is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to create new assignments.
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information required to create new assignments.
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }
}

/// <summary>
/// An eligible_assignment_rules block as defined below.
/// The rules for eligible assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderEligibleAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notfications on active role assignments.
/// Notifications about active assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below for configuring notifications on activation of eligible role.
/// Notifications about activations of eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notification on eligible role assignments.
/// Notifications about eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RoleDefinition in authorization to populate roleDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RoleDefinition in authorization to populate roleDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProviderScopeSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecForProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1RoleManagementPolicySpecForProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1RoleManagementPolicySpecForProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1RoleManagementPolicySpecForProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1RoleManagementPolicySpecForProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The scoped Role Definition ID of the role for which this policy will apply. Changing this forces a new resource to be created.
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>Reference to a RoleDefinition in authorization to populate roleDefinitionId.</summary>
    [JsonPropertyName("roleDefinitionIdRef")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdRef? RoleDefinitionIdRef { get; set; }

    /// <summary>Selector for a RoleDefinition in authorization to populate roleDefinitionId.</summary>
    [JsonPropertyName("roleDefinitionIdSelector")]
    public V1beta1RoleManagementPolicySpecForProviderRoleDefinitionIdSelector? RoleDefinitionIdSelector { get; set; }

    /// <summary>
    /// The scope to which this Role Management Policy will apply. Can refer to a management group, a subscription, a resource group or a resource. Changing this forces a new resource to be created.
    /// The scope of the role to which this policy will apply
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1RoleManagementPolicySpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1RoleManagementPolicySpecForProviderScopeSelector? ScopeSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are User and Group.
    /// The type of object acting as an approver
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// An approval_stage block as defined below.
/// The approval stages for the activation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderActivationRulesApprovalStage
{
    /// <summary>
    /// One or more primary_approver blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1RoleManagementPolicySpecInitProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1RoleManagementPolicySpecInitProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D. Possible values are PT30M, PT1H, PT1H30M, PT2H, PT2H30M, PT3H, PT3H30M, PT4H, PT4H30M, PT5H, PT5H30M, PT6H, PT6H30M, PT7H, PT7H30M, PT8H, PT8H30M, PT9H, PT9H30M, PT10H, PT10H30M, PT11H, PT11H30M, PT12H, PT12H30M, PT13H, PT13H30M, PT14H, PT14H30M, PT15H, PT15H30M, PT16H, PT16H30M, PT17H, PT17H30M, PT18H, PT18H30M, PT19H, PT19H30M, PT20H, PT20H30M, PT21H, PT21H30M, PT22H, PT22H30M, PT23H, PT23H30M and P1D.
    /// The time after which the an activation can be valid for
    /// </summary>
    [JsonPropertyName("maximumDuration")]
    public string? MaximumDuration { get; set; }

    /// <summary>
    /// Is approval required for activation. If true an approval_stage block must be provided.
    /// Whether an approval is required for activation
    /// </summary>
    [JsonPropertyName("requireApproval")]
    public bool? RequireApproval { get; set; }

    /// <summary>
    /// Is a justification required during activation of the role.
    /// Whether a justification is required during activation
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to activate the role. Conflicts with required_conditional_access_authentication_context.
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information requrired during activation of the role.
    /// Whether ticket information is required during activation
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }

    /// <summary>
    /// The Entra ID Conditional Access context that must be present for activation. Conflicts with require_multifactor_authentication.
    /// Whether a conditional access context is required during activation
    /// </summary>
    [JsonPropertyName("requiredConditionalAccessAuthenticationContext")]
    public string? RequiredConditionalAccessAuthenticationContext { get; set; }
}

/// <summary>
/// An active_assignment_rules block as defined below.
/// The rules for active assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderActiveAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>
    /// Is a justification required to create new assignments.
    /// Whether a justification is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to create new assignments.
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information required to create new assignments.
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }
}

/// <summary>
/// An eligible_assignment_rules block as defined below.
/// The rules for eligible assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderEligibleAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notfications on active role assignments.
/// Notifications about active assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below for configuring notifications on activation of eligible role.
/// Notifications about activations of eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notification on eligible role assignments.
/// Notifications about eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RoleDefinition in authorization to populate roleDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RoleDefinition in authorization to populate roleDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProviderScopeSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecInitProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1RoleManagementPolicySpecInitProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1RoleManagementPolicySpecInitProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1RoleManagementPolicySpecInitProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1RoleManagementPolicySpecInitProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The scoped Role Definition ID of the role for which this policy will apply. Changing this forces a new resource to be created.
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>Reference to a RoleDefinition in authorization to populate roleDefinitionId.</summary>
    [JsonPropertyName("roleDefinitionIdRef")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdRef? RoleDefinitionIdRef { get; set; }

    /// <summary>Selector for a RoleDefinition in authorization to populate roleDefinitionId.</summary>
    [JsonPropertyName("roleDefinitionIdSelector")]
    public V1beta1RoleManagementPolicySpecInitProviderRoleDefinitionIdSelector? RoleDefinitionIdSelector { get; set; }

    /// <summary>
    /// The scope to which this Role Management Policy will apply. Can refer to a management group, a subscription, a resource group or a resource. Changing this forces a new resource to be created.
    /// The scope of the role to which this policy will apply
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1RoleManagementPolicySpecInitProviderScopeSelector? ScopeSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleManagementPolicySpecManagementPoliciesEnum>))]
public enum V1beta1RoleManagementPolicySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RoleManagementPolicySpec defines the desired state of RoleManagementPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RoleManagementPolicySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RoleManagementPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RoleManagementPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RoleManagementPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RoleManagementPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are User and Group.
    /// The type of object acting as an approver
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// An approval_stage block as defined below.
/// The approval stages for the activation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderActivationRulesApprovalStage
{
    /// <summary>
    /// One or more primary_approver blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1RoleManagementPolicyStatusAtProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1RoleManagementPolicyStatusAtProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D. Possible values are PT30M, PT1H, PT1H30M, PT2H, PT2H30M, PT3H, PT3H30M, PT4H, PT4H30M, PT5H, PT5H30M, PT6H, PT6H30M, PT7H, PT7H30M, PT8H, PT8H30M, PT9H, PT9H30M, PT10H, PT10H30M, PT11H, PT11H30M, PT12H, PT12H30M, PT13H, PT13H30M, PT14H, PT14H30M, PT15H, PT15H30M, PT16H, PT16H30M, PT17H, PT17H30M, PT18H, PT18H30M, PT19H, PT19H30M, PT20H, PT20H30M, PT21H, PT21H30M, PT22H, PT22H30M, PT23H, PT23H30M and P1D.
    /// The time after which the an activation can be valid for
    /// </summary>
    [JsonPropertyName("maximumDuration")]
    public string? MaximumDuration { get; set; }

    /// <summary>
    /// Is approval required for activation. If true an approval_stage block must be provided.
    /// Whether an approval is required for activation
    /// </summary>
    [JsonPropertyName("requireApproval")]
    public bool? RequireApproval { get; set; }

    /// <summary>
    /// Is a justification required during activation of the role.
    /// Whether a justification is required during activation
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to activate the role. Conflicts with required_conditional_access_authentication_context.
    /// Whether multi-factor authentication is required during activation
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information requrired during activation of the role.
    /// Whether ticket information is required during activation
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }

    /// <summary>
    /// The Entra ID Conditional Access context that must be present for activation. Conflicts with require_multifactor_authentication.
    /// Whether a conditional access context is required during activation
    /// </summary>
    [JsonPropertyName("requiredConditionalAccessAuthenticationContext")]
    public string? RequiredConditionalAccessAuthenticationContext { get; set; }
}

/// <summary>
/// An active_assignment_rules block as defined below.
/// The rules for active assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderActiveAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>
    /// Is a justification required to create new assignments.
    /// Whether a justification is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireJustification")]
    public bool? RequireJustification { get; set; }

    /// <summary>
    /// Is multi-factor authentication required to create new assignments.
    /// Whether multi-factor authentication is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireMultifactorAuthentication")]
    public bool? RequireMultifactorAuthentication { get; set; }

    /// <summary>
    /// Is ticket information required to create new assignments.
    /// Whether ticket information is required to make an assignment
    /// </summary>
    [JsonPropertyName("requireTicketInfo")]
    public bool? RequireTicketInfo { get; set; }
}

/// <summary>
/// An eligible_assignment_rules block as defined below.
/// The rules for eligible assignment of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderEligibleAssignmentRules
{
    /// <summary>
    /// Must an assignment have an expiry date. false allows permanent assignment.
    /// Must the assignment have an expiry date
    /// </summary>
    [JsonPropertyName("expirationRequired")]
    public bool? ExpirationRequired { get; set; }

    /// <summary>
    /// The maximum length of time an assignment can be valid, as an ISO8601 duration. Permitted values: P15D, P30D, P90D, P180D, or P365D.
    /// The duration after which assignments expire
    /// </summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notfications on active role assignments.
/// Notifications about active assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below for configuring notifications on activation of eligible role.
/// Notifications about activations of eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAdminNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Approver notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsApproverNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Assignee notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
{
    /// <summary>
    /// A list of additional email addresses that will receive these notifications.
    /// The additional recipients to notify
    /// </summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>
    /// Should the default recipients receive these notifications.
    /// Whether the default recipients are notified
    /// </summary>
    [JsonPropertyName("defaultRecipients")]
    public bool? DefaultRecipients { get; set; }

    /// <summary>
    /// What level of notifications should be sent. Options are All or Critical.
    /// What level of notifications are sent
    /// </summary>
    [JsonPropertyName("notificationLevel")]
    public string? NotificationLevel { get; set; }
}

/// <summary>
/// A notification_target block as defined below to configure notification on eligible role assignments.
/// Notifications about eligible assignments
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusAtProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1RoleManagementPolicyStatusAtProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1RoleManagementPolicyStatusAtProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// (String) The description of this policy.
    /// The Description of the policy
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1RoleManagementPolicyStatusAtProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>(String) The ID of this policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// (String) The name of this policy, which is typically a UUID and may change over time.
    /// The name of the policy
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1RoleManagementPolicyStatusAtProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The scoped Role Definition ID of the role for which this policy will apply. Changing this forces a new resource to be created.
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope to which this Role Management Policy will apply. Can refer to a management group, a subscription, a resource group or a resource. Changing this forces a new resource to be created.
    /// The scope of the role to which this policy will apply
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RoleManagementPolicyStatus defines the observed state of RoleManagementPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleManagementPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RoleManagementPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RoleManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RoleManagementPolicy is the Schema for the RoleManagementPolicys API. Manages Azure PIM Role Management Policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RoleManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RoleManagementPolicySpec>, IStatus<V1beta1RoleManagementPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RoleManagementPolicy";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "rolemanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleManagementPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RoleManagementPolicySpec defines the desired state of RoleManagementPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RoleManagementPolicySpec Spec { get; set; }

    /// <summary>RoleManagementPolicyStatus defines the observed state of RoleManagementPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1RoleManagementPolicyStatus? Status { get; set; }
}