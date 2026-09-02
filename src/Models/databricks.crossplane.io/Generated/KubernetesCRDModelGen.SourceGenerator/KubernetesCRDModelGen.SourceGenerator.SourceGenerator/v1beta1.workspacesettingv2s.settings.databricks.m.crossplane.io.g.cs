#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.settings.databricks.m.crossplane.io;
/// <summary>WorkspaceSettingV2 is the Schema for the WorkspaceSettingV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspaceSettingV2List : IKubernetesObject<V1ListMeta>, IItems<V1beta1WorkspaceSettingV2>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspaceSettingV2List";
    public const string KubeGroup = "settings.databricks.m.crossplane.io";
    public const string KubePluralName = "workspacesettingv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceSettingV2List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1WorkspaceSettingV2 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1WorkspaceSettingV2> Items { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderEffectiveRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProviderRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2SpecForProviderStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecForProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2SpecForProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2SpecForProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1WorkspaceSettingV2SpecForProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2SpecForProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1WorkspaceSettingV2SpecForProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1WorkspaceSettingV2SpecForProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2SpecForProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1WorkspaceSettingV2SpecForProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1WorkspaceSettingV2SpecForProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1WorkspaceSettingV2SpecForProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1WorkspaceSettingV2SpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2SpecForProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1WorkspaceSettingV2SpecForProviderStringVal? StringVal { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderEffectiveRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecInitProviderRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2SpecInitProviderStringVal
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
public partial class V1beta1WorkspaceSettingV2SpecInitProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2SpecInitProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1WorkspaceSettingV2SpecInitProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1WorkspaceSettingV2SpecInitProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2SpecInitProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1WorkspaceSettingV2SpecInitProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1WorkspaceSettingV2SpecInitProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1WorkspaceSettingV2SpecInitProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1WorkspaceSettingV2SpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2SpecInitProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1WorkspaceSettingV2SpecInitProviderStringVal? StringVal { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSettingV2SpecManagementPoliciesEnum>))]
public enum V1beta1WorkspaceSettingV2SpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WorkspaceSettingV2Spec defines the desired state of WorkspaceSettingV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2Spec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WorkspaceSettingV2SpecForProvider ForProvider { get; set; }

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
    public V1beta1WorkspaceSettingV2SpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkspaceSettingV2SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSettingV2SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSettingV2SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingAccessPolicy
{
    /// <summary>Possible values are: ALLOW_ALL_DOMAINS, ALLOW_APPROVED_DOMAINS, DENY_ALL_DOMAINS</summary>
    [JsonPropertyName("accessPolicyType")]
    public string? AccessPolicyType { get; set; }
}

/// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingApprovedDomains
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("approvedDomains")]
    public IList<string>? ApprovedDomains { get; set; }
}

/// <summary>Effective setting value for allowed_apps_user_api_scopes setting. This is the final effective value of setting. To set a value use allowed_apps_user_api_scopes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAllowedAppsUserApiScopes
{
    /// <summary>(list of string, optional)</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }
}

/// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule
{
    /// <summary>Possible values are: FRIDAY, MONDAY, SATURDAY, SUNDAY, THURSDAY, TUESDAY, WEDNESDAY</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Possible values are: EVERY_WEEK, FIRST_AND_THIRD_OF_MONTH, FIRST_OF_MONTH, FOURTH_OF_MONTH, SECOND_AND_FOURTH_OF_MONTH, SECOND_OF_MONTH, THIRD_OF_MONTH</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWindowStartTime, optional)</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedScheduleWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow
{
    /// <summary>(ClusterAutoRestartMessageMaintenanceWindowWeekDayBasedSchedule, optional)</summary>
    [JsonPropertyName("weekDayBasedSchedule")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindowWeekDayBasedSchedule? WeekDayBasedSchedule { get; set; }
}

/// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspace
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("canToggle")]
    public bool? CanToggle { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(ClusterAutoRestartMessageEnablementDetails, optional)</summary>
    [JsonPropertyName("enablementDetails")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceEnablementDetails? EnablementDetails { get; set; }

    /// <summary>(ClusterAutoRestartMessageMaintenanceWindow, optional)</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspaceMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("restartEvenIfNoUpdatesAvailable")]
    public bool? RestartEvenIfNoUpdatesAvailable { get; set; }
}

/// <summary>Effective setting value for boolean type setting. This is the final effective value of setting. To set a value use boolean_val</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveBooleanVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Effective setting value for collaboration_platform_connectivity setting. This is the final effective value of setting. To set a value use collaboration_platform_connectivity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveCollaborationPlatformConnectivity
{
    /// <summary>Possible values are: ALLOW_ALL, ALLOW_SLACK, ALLOW_TEAMS, DENY_ALL</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }
}

/// <summary>Effective setting value for integer type setting. This is the final effective value of setting. To set a value use integer_val</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Effective setting value for operational_email_custom_recipient setting. This is the final effective value of setting. To set a value use operational_email_custom_recipient</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectivePersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderEffectiveStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderIntegerVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderOperationalEmailCustomRecipient
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderPersonalCompute
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProviderRestrictWorkspaceAdmins
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
public partial class V1beta1WorkspaceSettingV2StatusAtProviderStringVal
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusAtProvider
{
    /// <summary>Setting value for aibi_dashboard_embedding_access_policy setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_access_policy for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAibiDashboardEmbeddingAccessPolicy? AibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Setting value for aibi_dashboard_embedding_approved_domains setting. This is the setting value set by consumers, check effective_aibi_dashboard_embedding_approved_domains for final setting value</summary>
    [JsonPropertyName("aibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAibiDashboardEmbeddingApprovedDomains? AibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Setting value for allowed_apps_user_api_scopes setting. This is the setting value set by consumers, check effective_allowed_apps_user_api_scopes for final setting value</summary>
    [JsonPropertyName("allowedAppsUserApiScopes")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAllowedAppsUserApiScopes? AllowedAppsUserApiScopes { get; set; }

    /// <summary>Setting value for automatic_cluster_update_workspace setting. This is the setting value set by consumers, check effective_automatic_cluster_update_workspace for final setting value</summary>
    [JsonPropertyName("automaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2StatusAtProviderAutomaticClusterUpdateWorkspace? AutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Setting value for boolean type setting. This is the setting value set by consumers, check effective_boolean_val for final setting value</summary>
    [JsonPropertyName("booleanVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderBooleanVal? BooleanVal { get; set; }

    /// <summary>Setting value for collaboration_platform_connectivity setting. This is the setting value set by consumers, check effective_collaboration_platform_connectivity for final setting value</summary>
    [JsonPropertyName("collaborationPlatformConnectivity")]
    public V1beta1WorkspaceSettingV2StatusAtProviderCollaborationPlatformConnectivity? CollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_access_policy setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_access_policy</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingAccessPolicy")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingAccessPolicy? EffectiveAibiDashboardEmbeddingAccessPolicy { get; set; }

    /// <summary>Effective setting value for aibi_dashboard_embedding_approved_domains setting. This is the final effective value of setting. To set a value use aibi_dashboard_embedding_approved_domains</summary>
    [JsonPropertyName("effectiveAibiDashboardEmbeddingApprovedDomains")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAibiDashboardEmbeddingApprovedDomains? EffectiveAibiDashboardEmbeddingApprovedDomains { get; set; }

    /// <summary>Effective setting value for allowed_apps_user_api_scopes setting. This is the final effective value of setting. To set a value use allowed_apps_user_api_scopes</summary>
    [JsonPropertyName("effectiveAllowedAppsUserApiScopes")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAllowedAppsUserApiScopes? EffectiveAllowedAppsUserApiScopes { get; set; }

    /// <summary>Effective setting value for automatic_cluster_update_workspace setting. This is the final effective value of setting. To set a value use automatic_cluster_update_workspace</summary>
    [JsonPropertyName("effectiveAutomaticClusterUpdateWorkspace")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveAutomaticClusterUpdateWorkspace? EffectiveAutomaticClusterUpdateWorkspace { get; set; }

    /// <summary>Effective setting value for boolean type setting. This is the final effective value of setting. To set a value use boolean_val</summary>
    [JsonPropertyName("effectiveBooleanVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveBooleanVal? EffectiveBooleanVal { get; set; }

    /// <summary>Effective setting value for collaboration_platform_connectivity setting. This is the final effective value of setting. To set a value use collaboration_platform_connectivity</summary>
    [JsonPropertyName("effectiveCollaborationPlatformConnectivity")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveCollaborationPlatformConnectivity? EffectiveCollaborationPlatformConnectivity { get; set; }

    /// <summary>Effective setting value for integer type setting. This is the final effective value of setting. To set a value use integer_val</summary>
    [JsonPropertyName("effectiveIntegerVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveIntegerVal? EffectiveIntegerVal { get; set; }

    /// <summary>Effective setting value for operational_email_custom_recipient setting. This is the final effective value of setting. To set a value use operational_email_custom_recipient</summary>
    [JsonPropertyName("effectiveOperationalEmailCustomRecipient")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveOperationalEmailCustomRecipient? EffectiveOperationalEmailCustomRecipient { get; set; }

    /// <summary>Effective setting value for personal_compute setting. This is the final effective value of setting. To set a value use personal_compute</summary>
    [JsonPropertyName("effectivePersonalCompute")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectivePersonalCompute? EffectivePersonalCompute { get; set; }

    /// <summary>Effective setting value for restrict_workspace_admins setting. This is the final effective value of setting. To set a value use restrict_workspace_admins</summary>
    [JsonPropertyName("effectiveRestrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveRestrictWorkspaceAdmins? EffectiveRestrictWorkspaceAdmins { get; set; }

    /// <summary>Effective setting value for string type setting. This is the final effective value of setting. To set a value use string_val</summary>
    [JsonPropertyName("effectiveStringVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderEffectiveStringVal? EffectiveStringVal { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Setting value for integer type setting. This is the setting value set by consumers, check effective_integer_val for final setting value</summary>
    [JsonPropertyName("integerVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderIntegerVal? IntegerVal { get; set; }

    /// <summary>Setting value for operational_email_custom_recipient setting. This is the setting value set by consumers, check effective_operational_email_custom_recipient for final setting value</summary>
    [JsonPropertyName("operationalEmailCustomRecipient")]
    public V1beta1WorkspaceSettingV2StatusAtProviderOperationalEmailCustomRecipient? OperationalEmailCustomRecipient { get; set; }

    /// <summary>Setting value for personal_compute setting. This is the setting value set by consumers, check effective_personal_compute for final setting value</summary>
    [JsonPropertyName("personalCompute")]
    public V1beta1WorkspaceSettingV2StatusAtProviderPersonalCompute? PersonalCompute { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1WorkspaceSettingV2StatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Setting value for restrict_workspace_admins setting. This is the setting value set by consumers, check effective_restrict_workspace_admins for final setting value</summary>
    [JsonPropertyName("restrictWorkspaceAdmins")]
    public V1beta1WorkspaceSettingV2StatusAtProviderRestrictWorkspaceAdmins? RestrictWorkspaceAdmins { get; set; }

    /// <summary>Setting value for string type setting. This is the setting value set by consumers, check effective_string_val for final setting value</summary>
    [JsonPropertyName("stringVal")]
    public V1beta1WorkspaceSettingV2StatusAtProviderStringVal? StringVal { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2StatusConditions
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

/// <summary>WorkspaceSettingV2Status defines the observed state of WorkspaceSettingV2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSettingV2Status
{
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspaceSettingV2StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspaceSettingV2StatusConditions>? Conditions { get; set; }

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

/// <summary>WorkspaceSettingV2 is the Schema for the WorkspaceSettingV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspaceSettingV2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSettingV2Spec>, IStatus<V1beta1WorkspaceSettingV2Status?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspaceSettingV2";
    public const string KubeGroup = "settings.databricks.m.crossplane.io";
    public const string KubePluralName = "workspacesettingv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceSettingV2";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkspaceSettingV2Spec defines the desired state of WorkspaceSettingV2</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WorkspaceSettingV2Spec Spec { get; set; }

    /// <summary>WorkspaceSettingV2Status defines the observed state of WorkspaceSettingV2.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspaceSettingV2Status? Status { get; set; }
}