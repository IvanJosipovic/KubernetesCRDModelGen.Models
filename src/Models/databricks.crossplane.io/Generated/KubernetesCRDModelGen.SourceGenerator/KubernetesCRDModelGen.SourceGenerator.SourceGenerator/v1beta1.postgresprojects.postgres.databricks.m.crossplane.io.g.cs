#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgres.databricks.m.crossplane.io;
/// <summary>PostgresProject is the Schema for the PostgresProjects API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresProjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PostgresProject>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresProjectList";
    public const string KubeGroup = "postgres.databricks.m.crossplane.io";
    public const string KubePluralName = "postgresprojects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresProjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PostgresProject objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PostgresProject> Items { get; set; }
}

/// <summary>
/// Configuration for the initial default branch created as part of project creation.
/// Allows overriding branch protection. These settings only apply at creation time
/// and do not affect resources created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderInitialBranchSpec
{
    /// <summary>Whether the initial default branch should be protected from deletion</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }
}

/// <summary>Settings for HA configuration of the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderInitialEndpointSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
/// created project. If omitted, the initial endpoint created will have default settings, without high availability
/// configured. This field does not apply to any endpoints created after project creation. Use
/// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderInitialEndpointSpec
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>Settings for HA configuration of the endpoint</summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresProjectSpecForProviderInitialEndpointSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderSpecCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderSpecDefaultEndpointSettings
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>what you want the resource to be.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProviderSpec
{
    /// <summary>
    /// The desired budget policy to associate with the project.
    /// See status.budget_policy_id for the policy that is actually applied to the project
    /// </summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// Custom tags to associate with the project. Forwarded to LBM for billing and cost tracking.
    /// To update tags, provide the new tag list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To clear all tags, provide an empty list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To preserve existing tags, omit this field from the update_mask (or use wildcard &quot;*&quot; which auto-excludes empty tags)
    /// </summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1PostgresProjectSpecForProviderSpecCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The full resource path for the default branch of the project
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
    [JsonPropertyName("defaultEndpointSettings")]
    public V1beta1PostgresProjectSpecForProviderSpecDefaultEndpointSettings? DefaultEndpointSettings { get; set; }

    /// <summary>Human-readable project name. Length should be between 1 and 256 characters</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to enable PG native password login on all endpoints in this project. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>The number of seconds to retain the shared history for point in time recovery for all branches in this project. Value should be between 172800s (2 days) and 3024000s (35 days)</summary>
    [JsonPropertyName("historyRetentionDuration")]
    public string? HistoryRetentionDuration { get; set; }

    /// <summary>The major Postgres version number. The set of supported versions may vary; consult the API documentation for currently accepted values</summary>
    [JsonPropertyName("pgVersion")]
    public double? PgVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecForProvider
{
    /// <summary>
    /// Configuration for the initial default branch created as part of project creation.
    /// Allows overriding branch protection. These settings only apply at creation time
    /// and do not affect resources created after project creation
    /// </summary>
    [JsonPropertyName("initialBranchSpec")]
    public V1beta1PostgresProjectSpecForProviderInitialBranchSpec? InitialBranchSpec { get; set; }

    /// <summary>
    /// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
    /// created project. If omitted, the initial endpoint created will have default settings, without high availability
    /// configured. This field does not apply to any endpoints created after project creation. Use
    /// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
    /// </summary>
    [JsonPropertyName("initialEndpointSpec")]
    public V1beta1PostgresProjectSpecForProviderInitialEndpointSpec? InitialEndpointSpec { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresProjectSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// If true, permanently deletes the project (hard delete).
    /// If false or unset, performs a soft delete
    /// </summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>what you want the resource to be.</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresProjectSpecForProviderSpec? Spec { get; set; }
}

/// <summary>
/// Configuration for the initial default branch created as part of project creation.
/// Allows overriding branch protection. These settings only apply at creation time
/// and do not affect resources created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderInitialBranchSpec
{
    /// <summary>Whether the initial default branch should be protected from deletion</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }
}

/// <summary>Settings for HA configuration of the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderInitialEndpointSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
/// created project. If omitted, the initial endpoint created will have default settings, without high availability
/// configured. This field does not apply to any endpoints created after project creation. Use
/// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderInitialEndpointSpec
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>Settings for HA configuration of the endpoint</summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresProjectSpecInitProviderInitialEndpointSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderSpecCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderSpecDefaultEndpointSettings
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>what you want the resource to be.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpecInitProviderSpec
{
    /// <summary>
    /// The desired budget policy to associate with the project.
    /// See status.budget_policy_id for the policy that is actually applied to the project
    /// </summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// Custom tags to associate with the project. Forwarded to LBM for billing and cost tracking.
    /// To update tags, provide the new tag list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To clear all tags, provide an empty list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To preserve existing tags, omit this field from the update_mask (or use wildcard &quot;*&quot; which auto-excludes empty tags)
    /// </summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1PostgresProjectSpecInitProviderSpecCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The full resource path for the default branch of the project
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
    [JsonPropertyName("defaultEndpointSettings")]
    public V1beta1PostgresProjectSpecInitProviderSpecDefaultEndpointSettings? DefaultEndpointSettings { get; set; }

    /// <summary>Human-readable project name. Length should be between 1 and 256 characters</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to enable PG native password login on all endpoints in this project. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>The number of seconds to retain the shared history for point in time recovery for all branches in this project. Value should be between 172800s (2 days) and 3024000s (35 days)</summary>
    [JsonPropertyName("historyRetentionDuration")]
    public string? HistoryRetentionDuration { get; set; }

    /// <summary>The major Postgres version number. The set of supported versions may vary; consult the API documentation for currently accepted values</summary>
    [JsonPropertyName("pgVersion")]
    public double? PgVersion { get; set; }
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
public partial class V1beta1PostgresProjectSpecInitProvider
{
    /// <summary>
    /// Configuration for the initial default branch created as part of project creation.
    /// Allows overriding branch protection. These settings only apply at creation time
    /// and do not affect resources created after project creation
    /// </summary>
    [JsonPropertyName("initialBranchSpec")]
    public V1beta1PostgresProjectSpecInitProviderInitialBranchSpec? InitialBranchSpec { get; set; }

    /// <summary>
    /// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
    /// created project. If omitted, the initial endpoint created will have default settings, without high availability
    /// configured. This field does not apply to any endpoints created after project creation. Use
    /// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
    /// </summary>
    [JsonPropertyName("initialEndpointSpec")]
    public V1beta1PostgresProjectSpecInitProviderInitialEndpointSpec? InitialEndpointSpec { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresProjectSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// If true, permanently deletes the project (hard delete).
    /// If false or unset, performs a soft delete
    /// </summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>what you want the resource to be.</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresProjectSpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresProjectSpecManagementPoliciesEnum>))]
public enum V1beta1PostgresProjectSpecManagementPoliciesEnum
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
public partial class V1beta1PostgresProjectSpecProviderConfigRef
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
public partial class V1beta1PostgresProjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PostgresProjectSpec defines the desired state of PostgresProject</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PostgresProjectSpecForProvider ForProvider { get; set; }

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
    public V1beta1PostgresProjectSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PostgresProjectSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PostgresProjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PostgresProjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for the initial default branch created as part of project creation.
/// Allows overriding branch protection. These settings only apply at creation time
/// and do not affect resources created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderInitialBranchSpec
{
    /// <summary>Whether the initial default branch should be protected from deletion</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }
}

/// <summary>Settings for HA configuration of the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderInitialEndpointSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
/// created project. If omitted, the initial endpoint created will have default settings, without high availability
/// configured. This field does not apply to any endpoints created after project creation. Use
/// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderInitialEndpointSpec
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>Settings for HA configuration of the endpoint</summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresProjectStatusAtProviderInitialEndpointSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderSpecCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderSpecDefaultEndpointSettings
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>what you want the resource to be.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderSpec
{
    /// <summary>
    /// The desired budget policy to associate with the project.
    /// See status.budget_policy_id for the policy that is actually applied to the project
    /// </summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// Custom tags to associate with the project. Forwarded to LBM for billing and cost tracking.
    /// To update tags, provide the new tag list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To clear all tags, provide an empty list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To preserve existing tags, omit this field from the update_mask (or use wildcard &quot;*&quot; which auto-excludes empty tags)
    /// </summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1PostgresProjectStatusAtProviderSpecCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The full resource path for the default branch of the project
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
    [JsonPropertyName("defaultEndpointSettings")]
    public V1beta1PostgresProjectStatusAtProviderSpecDefaultEndpointSettings? DefaultEndpointSettings { get; set; }

    /// <summary>Human-readable project name. Length should be between 1 and 256 characters</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to enable PG native password login on all endpoints in this project. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>The number of seconds to retain the shared history for point in time recovery for all branches in this project. Value should be between 172800s (2 days) and 3024000s (35 days)</summary>
    [JsonPropertyName("historyRetentionDuration")]
    public string? HistoryRetentionDuration { get; set; }

    /// <summary>The major Postgres version number. The set of supported versions may vary; consult the API documentation for currently accepted values</summary>
    [JsonPropertyName("pgVersion")]
    public double? PgVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderStatusCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderStatusDefaultEndpointSettings
{
    /// <summary>The maximum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units for the initial endpoint</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the initial endpoint is automatically suspended.
    /// If specified, should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>what the resource actually is.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProviderStatus
{
    /// <summary>The logical size limit for a branch</summary>
    [JsonPropertyName("branchLogicalSizeLimitBytes")]
    public double? BranchLogicalSizeLimitBytes { get; set; }

    /// <summary>
    /// The desired budget policy to associate with the project.
    /// See status.budget_policy_id for the policy that is actually applied to the project
    /// </summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The most recent time when any endpoint of this project was active</summary>
    [JsonPropertyName("computeLastActiveTime")]
    public string? ComputeLastActiveTime { get; set; }

    /// <summary>
    /// Custom tags to associate with the project. Forwarded to LBM for billing and cost tracking.
    /// To update tags, provide the new tag list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To clear all tags, provide an empty list and include &quot;spec.custom_tags&quot; in the update_mask.
    /// To preserve existing tags, omit this field from the update_mask (or use wildcard &quot;*&quot; which auto-excludes empty tags)
    /// </summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1PostgresProjectStatusAtProviderStatusCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The full resource path for the default branch of the project
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>(ProjectDefaultEndpointSettings, optional)</summary>
    [JsonPropertyName("defaultEndpointSettings")]
    public V1beta1PostgresProjectStatusAtProviderStatusDefaultEndpointSettings? DefaultEndpointSettings { get; set; }

    /// <summary>Human-readable project name. Length should be between 1 and 256 characters</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to enable PG native password login on all endpoints in this project. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>The number of seconds to retain the shared history for point in time recovery for all branches in this project. Value should be between 172800s (2 days) and 3024000s (35 days)</summary>
    [JsonPropertyName("historyRetentionDuration")]
    public string? HistoryRetentionDuration { get; set; }

    /// <summary>The email of the project owner</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The major Postgres version number. The set of supported versions may vary; consult the API documentation for currently accepted values</summary>
    [JsonPropertyName("pgVersion")]
    public double? PgVersion { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The current space occupied by the project in storage</summary>
    [JsonPropertyName("syntheticStorageSizeBytes")]
    public double? SyntheticStorageSizeBytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusAtProvider
{
    /// <summary>A timestamp indicating when the project was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// A timestamp indicating when the project was soft-deleted.
    /// Empty if the project is not deleted, otherwise set to a timestamp in the past
    /// </summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Configuration for the initial default branch created as part of project creation.
    /// Allows overriding branch protection. These settings only apply at creation time
    /// and do not affect resources created after project creation
    /// </summary>
    [JsonPropertyName("initialBranchSpec")]
    public V1beta1PostgresProjectStatusAtProviderInitialBranchSpec? InitialBranchSpec { get; set; }

    /// <summary>
    /// Configuration settings for the initial Read/Write endpoint created inside the initial branch for a newly
    /// created project. If omitted, the initial endpoint created will have default settings, without high availability
    /// configured. This field does not apply to any endpoints created after project creation. Use
    /// spec.default_endpoint_settings to configure default settings for endpoints created after project creation
    /// </summary>
    [JsonPropertyName("initialEndpointSpec")]
    public V1beta1PostgresProjectStatusAtProviderInitialEndpointSpec? InitialEndpointSpec { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresProjectStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// If true, permanently deletes the project (hard delete).
    /// If false or unset, performs a soft delete
    /// </summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>
    /// A timestamp indicating when the project is scheduled for permanent deletion.
    /// Empty if the project is not deleted, otherwise set to a timestamp in the future
    /// </summary>
    [JsonPropertyName("purgeTime")]
    public string? PurgeTime { get; set; }

    /// <summary>what you want the resource to be.</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresProjectStatusAtProviderSpec? Spec { get; set; }

    /// <summary>what the resource actually is.</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresProjectStatusAtProviderStatus? Status { get; set; }

    /// <summary>System-generated unique ID for the project</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>A timestamp indicating when the project was last updated</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatusConditions
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

/// <summary>PostgresProjectStatus defines the observed state of PostgresProject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresProjectStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PostgresProjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PostgresProjectStatusConditions>? Conditions { get; set; }

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

/// <summary>PostgresProject is the Schema for the PostgresProjects API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresProject : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PostgresProjectSpec>, IStatus<V1beta1PostgresProjectStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresProject";
    public const string KubeGroup = "postgres.databricks.m.crossplane.io";
    public const string KubePluralName = "postgresprojects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresProject";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PostgresProjectSpec defines the desired state of PostgresProject</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PostgresProjectSpec Spec { get; set; }

    /// <summary>PostgresProjectStatus defines the observed state of PostgresProject.</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresProjectStatus? Status { get; set; }
}