#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.settings.databricks.crossplane.io;
/// <summary>AccountSettingV2 is the Schema for the AccountSettingV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountSettingV2List : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccountSettingV2>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountSettingV2List";
    public const string KubeGroup = "settings.databricks.crossplane.io";
    public const string KubePluralName = "accountsettingv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountSettingV2List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccountSettingV2 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccountSettingV2> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountSettingV2SpecDeletionPolicyEnum>))]
public enum V1beta1AccountSettingV2SpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderEffectiveRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProviderStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecForProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2SpecForProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2SpecForProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1AccountSettingV2SpecForProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2SpecForProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1AccountSettingV2SpecForProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1AccountSettingV2SpecForProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1AccountSettingV2SpecForProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2SpecForProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1AccountSettingV2SpecForProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1AccountSettingV2SpecForProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1AccountSettingV2SpecForProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2SpecForProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1AccountSettingV2SpecForProviderStringVal? StringVal { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderEffectiveRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProviderStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecInitProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2SpecInitProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2SpecInitProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1AccountSettingV2SpecInitProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2SpecInitProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1AccountSettingV2SpecInitProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1AccountSettingV2SpecInitProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1AccountSettingV2SpecInitProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2SpecInitProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1AccountSettingV2SpecInitProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1AccountSettingV2SpecInitProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1AccountSettingV2SpecInitProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2SpecInitProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1AccountSettingV2SpecInitProviderStringVal? StringVal { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountSettingV2SpecManagementPoliciesEnum>))]
public enum V1beta1AccountSettingV2SpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccountSettingV2SpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSettingV2SpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AccountSettingV2Spec defines the desired state of AccountSettingV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2Spec
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
    public V1beta1AccountSettingV2SpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AccountSettingV2SpecForProvider ForProvider { get; set; }

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
    public V1beta1AccountSettingV2SpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AccountSettingV2SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountSettingV2SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountSettingV2SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Effective setting value for allowed_apps_user_api_scopes setting. This is the final effective value of setting. To set a value use allowed_apps_user_api_scopes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
{
    /// <summary>The feature is force enabled if compliance mode is active</summary>
    [JsonPropertyName("forcedForComplianceMode")]
    public bool? ForcedForComplianceMode { get; set; }

    /// <summary>The feature is unavailable if the corresponding entitlement disabled (see getShieldEntitlementEnable)</summary>
    [JsonPropertyName("unavailableForDisabledEntitlement")]
    public bool? UnavailableForDisabledEntitlement { get; set; }

    /// <summary>The feature is unavailable if the customer doesn&apos;t have enterprise tier</summary>
    [JsonPropertyName("unavailableForNonEnterpriseTier")]
    public bool? UnavailableForNonEnterpriseTier { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for boolean type setting. This is the final effective value of setting. To set a value use boolean_val</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Effective setting value for collaboration_platform_connectivity setting. This is the final effective value of setting. To set a value use collaboration_platform_connectivity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for integer type setting. This is the final effective value of setting. To set a value use integer_val</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Effective setting value for operational_email_custom_recipient setting. This is the final effective value of setting. To set a value use operational_email_custom_recipient</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Effective setting value for string type setting. This is the final effective value of setting. To set a value use string_val</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderEffectiveStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderRestrictWorkspaceAdmins
{
    /// <summary>
    /// When true, workspace admins cannot create governance tags.
    /// ALLOW_ALL status does not override this; they are independent
    /// </summary>
    [JsonPropertyName("disableGovTagCreation")]
    public bool? DisableGovTagCreation { get; set; }

    /// <summary>Possible values are: ALLOW_ALL, RESTRICT_TOKENS_AND_JOB_RUN_AS</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProviderStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusAtProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2StatusAtProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2StatusAtProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1AccountSettingV2StatusAtProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2StatusAtProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1AccountSettingV2StatusAtProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1AccountSettingV2StatusAtProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for allowed_apps_user_api_scopes setting. This is the final effective value of setting. To set a value use allowed_apps_user_api_scopes</summary>
    [JsonPropertyName("effectiveAllowedAppsUserApiScopes")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAllowedAppsUserApiScopes? EffectiveAllowedAppsUserApiScopes { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for boolean type setting. This is the final effective value of setting. To set a value use boolean_val</summary>
    [JsonPropertyName("effectiveBooleanVal")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveBooleanVal? EffectiveBooleanVal { get; set; }

    /// <summary>Effective setting value for collaboration_platform_connectivity setting. This is the final effective value of setting. To set a value use collaboration_platform_connectivity</summary>
    [JsonPropertyName("effectiveCollaborationPlatformConnectivity")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveCollaborationPlatformConnectivity? EffectiveCollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for integer type setting. This is the final effective value of setting. To set a value use integer_val</summary>
    [JsonPropertyName("effectiveIntegerVal")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveIntegerVal? EffectiveIntegerVal { get; set; }

    /// <summary>Effective setting value for operational_email_custom_recipient setting. This is the final effective value of setting. To set a value use operational_email_custom_recipient</summary>
    [JsonPropertyName("effectiveOperationalEmailCustomRecipient")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveOperationalEmailCustomRecipient? EffectiveOperationalEmailCustomRecipient { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1AccountSettingV2StatusAtProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Effective setting value for string type setting. This is the final effective value of setting. To set a value use string_val</summary>
    [JsonPropertyName("effectiveStringVal")]
    public V1beta1AccountSettingV2StatusAtProviderEffectiveStringVal? EffectiveStringVal { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1AccountSettingV2StatusAtProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1AccountSettingV2StatusAtProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1AccountSettingV2StatusAtProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1AccountSettingV2StatusAtProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1AccountSettingV2StatusAtProviderStringVal? StringVal { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2StatusConditions
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

/// <summary>AccountSettingV2Status defines the observed state of AccountSettingV2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSettingV2Status
{
    [JsonPropertyName("atProvider")]
    public V1beta1AccountSettingV2StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountSettingV2StatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccountSettingV2 is the Schema for the AccountSettingV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountSettingV2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountSettingV2Spec>, IStatus<V1beta1AccountSettingV2Status?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountSettingV2";
    public const string KubeGroup = "settings.databricks.crossplane.io";
    public const string KubePluralName = "accountsettingv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountSettingV2";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountSettingV2Spec defines the desired state of AccountSettingV2</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccountSettingV2Spec Spec { get; set; }

    /// <summary>AccountSettingV2Status defines the observed state of AccountSettingV2.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountSettingV2Status? Status { get; set; }
}