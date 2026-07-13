#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>OnlineTable is the Schema for the OnlineTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OnlineTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OnlineTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OnlineTableList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "onlinetables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OnlineTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1OnlineTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1OnlineTable> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineTableSpecDeletionPolicyEnum>))]
public enum V1beta1OnlineTableSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecForProviderSpecRunContinuously
{
}

/// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecForProviderSpecRunTriggered
{
}

/// <summary>object containing specification of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecForProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports &quot;triggered&quot; scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public V1beta1OnlineTableSpecForProviderSpecRunContinuously? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public V1beta1OnlineTableSpecForProviderSpecRunTriggered? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecForProvider
{
    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1OnlineTableSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public V1beta1OnlineTableSpecForProviderSpec? Spec { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecInitProviderSpecRunContinuously
{
}

/// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecInitProviderSpecRunTriggered
{
}

/// <summary>object containing specification of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecInitProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports &quot;triggered&quot; scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public V1beta1OnlineTableSpecInitProviderSpecRunContinuously? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public V1beta1OnlineTableSpecInitProviderSpecRunTriggered? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
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
public partial class V1beta1OnlineTableSpecInitProvider
{
    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1OnlineTableSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public V1beta1OnlineTableSpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineTableSpecManagementPoliciesEnum>))]
public enum V1beta1OnlineTableSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineTableSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1OnlineTableSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineTableSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1OnlineTableSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineTableSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineTableSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OnlineTableSpec defines the desired state of OnlineTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableSpec
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
    public V1beta1OnlineTableSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1OnlineTableSpecForProvider ForProvider { get; set; }

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
    public V1beta1OnlineTableSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1OnlineTableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OnlineTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OnlineTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderSpecRunContinuously
{
}

/// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderSpecRunTriggered
{
}

/// <summary>object containing specification of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports &quot;triggered&quot; scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>ID of the associated Delta Live Table pipeline.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public V1beta1OnlineTableStatusAtProviderSpecRunContinuously? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public V1beta1OnlineTableStatusAtProviderSpecRunTriggered? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusContinuousUpdateStatusInitialPipelineSyncProgress
{
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary>object describing status of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusContinuousUpdateStatus
{
    [JsonPropertyName("initialPipelineSyncProgress")]
    public V1beta1OnlineTableStatusAtProviderStatusContinuousUpdateStatusInitialPipelineSyncProgress? InitialPipelineSyncProgress { get; set; }

    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>object describing status of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusFailedStatus
{
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusProvisioningStatusInitialPipelineSyncProgress
{
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary>object describing status of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusProvisioningStatus
{
    [JsonPropertyName("initialPipelineSyncProgress")]
    public V1beta1OnlineTableStatusAtProviderStatusProvisioningStatusInitialPipelineSyncProgress? InitialPipelineSyncProgress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusTriggeredUpdateStatusTriggeredUpdateProgress
{
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary>object describing status of the online table:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatusTriggeredUpdateStatus
{
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("triggeredUpdateProgress")]
    public V1beta1OnlineTableStatusAtProviderStatusTriggeredUpdateStatusTriggeredUpdateProgress? TriggeredUpdateProgress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProviderStatus
{
    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("continuousUpdateStatus")]
    public V1beta1OnlineTableStatusAtProviderStatusContinuousUpdateStatus? ContinuousUpdateStatus { get; set; }

    /// <summary>The state of the online table.</summary>
    [JsonPropertyName("detailedState")]
    public string? DetailedState { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("failedStatus")]
    public V1beta1OnlineTableStatusAtProviderStatusFailedStatus? FailedStatus { get; set; }

    /// <summary>A text description of the current state of the online table.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("provisioningStatus")]
    public V1beta1OnlineTableStatusAtProviderStatusProvisioningStatus? ProvisioningStatus { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("triggeredUpdateStatus")]
    public V1beta1OnlineTableStatusAtProviderStatusTriggeredUpdateStatus? TriggeredUpdateStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusAtProvider
{
    /// <summary>The same as the name of the online table.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1OnlineTableStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public V1beta1OnlineTableStatusAtProviderSpec? Spec { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1OnlineTableStatusAtProviderStatus>? Status { get; set; }

    /// <summary>Data serving REST API URL for this table.</summary>
    [JsonPropertyName("tableServingUrl")]
    public string? TableServingUrl { get; set; }

    /// <summary>The provisioning state of the online table entity in Unity Catalog. This is distinct from the state of the data synchronization pipeline (i.e. the table may be in &quot;ACTIVE&quot; but the pipeline may be in &quot;PROVISIONING&quot; as it runs asynchronously).</summary>
    [JsonPropertyName("unityCatalogProvisioningState")]
    public string? UnityCatalogProvisioningState { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatusConditions
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

/// <summary>OnlineTableStatus defines the observed state of OnlineTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineTableStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1OnlineTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OnlineTableStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OnlineTable is the Schema for the OnlineTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OnlineTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OnlineTableSpec>, IStatus<V1beta1OnlineTableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OnlineTable";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "onlinetables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OnlineTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OnlineTableSpec defines the desired state of OnlineTable</summary>
    [JsonPropertyName("spec")]
    public required V1beta1OnlineTableSpec Spec { get; set; }

    /// <summary>OnlineTableStatus defines the observed state of OnlineTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1OnlineTableStatus? Status { get; set; }
}