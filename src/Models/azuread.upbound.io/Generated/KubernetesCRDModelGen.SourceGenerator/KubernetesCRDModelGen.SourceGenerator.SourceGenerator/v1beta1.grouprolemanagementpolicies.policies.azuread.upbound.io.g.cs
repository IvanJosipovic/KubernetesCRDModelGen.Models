#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policies.azuread.upbound.io;
/// <summary>GroupRoleManagementPolicy is the Schema for the GroupRoleManagementPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GroupRoleManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GroupRoleManagementPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GroupRoleManagementPolicyList";
    public const string KubeGroup = "policies.azuread.upbound.io";
    public const string KubePluralName = "grouprolemanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.azuread.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GroupRoleManagementPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GroupRoleManagementPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GroupRoleManagementPolicy> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecDeletionPolicyEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are singleUser and groupMembers.
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderActivationRulesApprovalStage
{
    /// <summary>
    /// blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1GroupRoleManagementPolicySpecForProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1GroupRoleManagementPolicySpecForProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D.
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
    /// The Entra ID Conditional Access context that must be present for activation (e.g c1). Conflicts with require_multifactor_authentication.
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderActiveAssignmentRules
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderEligibleAssignmentRules
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolutionEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolveEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecForProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1GroupRoleManagementPolicySpecForProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1GroupRoleManagementPolicySpecForProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1GroupRoleManagementPolicySpecForProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// The ID of the Azure AD group for which the policy applies.
    /// ID of the group to which this policy is assigned
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1GroupRoleManagementPolicySpecForProviderGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1GroupRoleManagementPolicySpecForProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The type of assignment this policy coveres. Can be either member or owner.
    /// The ID of the role of this policy to the group
    /// </summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are singleUser and groupMembers.
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderActivationRulesApprovalStage
{
    /// <summary>
    /// blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1GroupRoleManagementPolicySpecInitProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D.
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
    /// The Entra ID Conditional Access context that must be present for activation (e.g c1). Conflicts with require_multifactor_authentication.
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderActiveAssignmentRules
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderEligibleAssignmentRules
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolutionEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolveEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
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
public partial class V1beta1GroupRoleManagementPolicySpecInitProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// The ID of the Azure AD group for which the policy applies.
    /// ID of the group to which this policy is assigned
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1GroupRoleManagementPolicySpecInitProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The type of assignment this policy coveres. Can be either member or owner.
    /// The ID of the role of this policy to the group
    /// </summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecManagementPoliciesEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GroupRoleManagementPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GroupRoleManagementPolicySpec defines the desired state of GroupRoleManagementPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicySpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1GroupRoleManagementPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1GroupRoleManagementPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1GroupRoleManagementPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GroupRoleManagementPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GroupRoleManagementPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GroupRoleManagementPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRulesApprovalStagePrimaryApprover
{
    /// <summary>
    /// The ID of the object which will act as an approver.
    /// The ID of the object to act as an approver
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The type of object acting as an approver. Possible options are singleUser and groupMembers.
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRulesApprovalStage
{
    /// <summary>
    /// blocks as defined below.
    /// The IDs of the users or groups who can approve the activation
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRulesApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An activation_rules block as defined below.
/// The activation rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRules
{
    /// <summary>
    /// An approval_stage block as defined below.
    /// The approval stages for the activation
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRulesApprovalStage? ApprovalStage { get; set; }

    /// <summary>
    /// The maximum length of time an activated role can be valid, in an ISO8601 Duration format (e.g. PT8H). Valid range is PT30M to PT23H30M, in 30 minute increments, or PT1D.
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
    /// The Entra ID Conditional Access context that must be present for activation (e.g c1). Conflicts with require_multifactor_authentication.
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderActiveAssignmentRules
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderEligibleAssignmentRules
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivations
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivationsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_settings block as defined above.
/// Admin notification settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAdminNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsApproverNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAssigneeNotifications
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
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignments
{
    /// <summary>
    /// A notification_settings block as defined above.
    /// Admin notification settings
    /// </summary>
    [JsonPropertyName("adminNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAdminNotifications? AdminNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Approver notification settings
    /// </summary>
    [JsonPropertyName("approverNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsApproverNotifications? ApproverNotifications { get; set; }

    /// <summary>
    /// A notification_settings block as defined above.
    /// Assignee notification settings
    /// </summary>
    [JsonPropertyName("assigneeNotifications")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignmentsAssigneeNotifications? AssigneeNotifications { get; set; }
}

/// <summary>
/// A notification_rules block as defined below.
/// The notification rules of the policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRules
{
    /// <summary>
    /// A notification_target block as defined below to configure notfications on active role assignments.
    /// Notifications about active assignments
    /// </summary>
    [JsonPropertyName("activeAssignments")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesActiveAssignments? ActiveAssignments { get; set; }

    /// <summary>
    /// A notification_target block as defined below for configuring notifications on activation of eligible role.
    /// Notifications about activations of eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleActivations")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleActivations? EligibleActivations { get; set; }

    /// <summary>
    /// A notification_target block as defined below to configure notification on eligible role assignments.
    /// Notifications about eligible assignments
    /// </summary>
    [JsonPropertyName("eligibleAssignments")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRulesEligibleAssignments? EligibleAssignments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusAtProvider
{
    /// <summary>
    /// An activation_rules block as defined below.
    /// The activation rules of the policy
    /// </summary>
    [JsonPropertyName("activationRules")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderActivationRules? ActivationRules { get; set; }

    /// <summary>
    /// An active_assignment_rules block as defined below.
    /// The rules for active assignment of the policy
    /// </summary>
    [JsonPropertyName("activeAssignmentRules")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderActiveAssignmentRules? ActiveAssignmentRules { get; set; }

    /// <summary>
    /// (String) The description of this policy.
    /// Description of the policy
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// (String) The display name of this policy.
    /// The display name of the policy
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// An eligible_assignment_rules block as defined below.
    /// The rules for eligible assignment of the policy
    /// </summary>
    [JsonPropertyName("eligibleAssignmentRules")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderEligibleAssignmentRules? EligibleAssignmentRules { get; set; }

    /// <summary>
    /// The ID of the Azure AD group for which the policy applies.
    /// ID of the group to which this policy is assigned
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>(String) The ID of this policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A notification_rules block as defined below.
    /// The notification rules of the policy
    /// </summary>
    [JsonPropertyName("notificationRules")]
    public V1beta1GroupRoleManagementPolicyStatusAtProviderNotificationRules? NotificationRules { get; set; }

    /// <summary>
    /// The type of assignment this policy coveres. Can be either member or owner.
    /// The ID of the role of this policy to the group
    /// </summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatusConditions
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

/// <summary>GroupRoleManagementPolicyStatus defines the observed state of GroupRoleManagementPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupRoleManagementPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GroupRoleManagementPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GroupRoleManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GroupRoleManagementPolicy is the Schema for the GroupRoleManagementPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GroupRoleManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GroupRoleManagementPolicySpec>, IStatus<V1beta1GroupRoleManagementPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GroupRoleManagementPolicy";
    public const string KubeGroup = "policies.azuread.upbound.io";
    public const string KubePluralName = "grouprolemanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.azuread.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GroupRoleManagementPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GroupRoleManagementPolicySpec defines the desired state of GroupRoleManagementPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GroupRoleManagementPolicySpec Spec { get; set; }

    /// <summary>GroupRoleManagementPolicyStatus defines the observed state of GroupRoleManagementPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1GroupRoleManagementPolicyStatus? Status { get; set; }
}