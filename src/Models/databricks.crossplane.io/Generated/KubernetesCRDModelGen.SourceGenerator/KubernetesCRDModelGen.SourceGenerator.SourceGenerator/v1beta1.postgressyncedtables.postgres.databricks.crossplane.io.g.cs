#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgres.databricks.crossplane.io;
/// <summary>PostgresSyncedTable is the Schema for the PostgresSyncedTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresSyncedTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PostgresSyncedTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresSyncedTableList";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgressyncedtables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresSyncedTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PostgresSyncedTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PostgresSyncedTable> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresSyncedTableSpecDeletionPolicyEnum>))]
public enum V1beta1PostgresSyncedTableSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specification for creating a new pipeline.
/// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecForProviderSpecNewPipelineSpec
{
    /// <summary>Budget policy to set on the newly created pipeline</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// UC catalog for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be a standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageCatalog")]
    public string? StorageCatalog { get; set; }

    /// <summary>
    /// UC schema for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be in the standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageSchema")]
    public string? StorageSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecForProviderSpecTypeOverrides
{
    /// <summary>Name of the source column whose target PostgreSQL type should be overridden</summary>
    [JsonPropertyName("columnName")]
    public string? ColumnName { get; set; }

    /// <summary>PostgreSQL-specific target type to use for the column. Possible values are: PG_SPECIFIC_TYPE_VECTOR</summary>
    [JsonPropertyName("pgType")]
    public string? PgType { get; set; }

    /// <summary>
    /// Size parameter for the target type. Required when pg_type is PG_SPECIFIC_TYPE_VECTOR
    /// or PG_SPECIFIC_TYPE_HALFVEC (specifies the vector dimension, e.g., 1024)
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary>
/// Configuration details of the synced table, such as the source table, scheduling policy, etc.
/// This attribute is specified at creation time and most fields are returned as is on subsequent queries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecForProviderSpec
{
    /// <summary>
    /// When true, enables accelerated sync mode for the initial data load.
    /// This significantly improves performance for large tables.
    /// Requires workspace-level enablement through Lakebase Accelerated Sync preview
    /// </summary>
    [JsonPropertyName("acceleratedSync")]
    public bool? AcceleratedSync { get; set; }

    /// <summary>The full resource name the branch associated with the table.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// If true, the synced table&apos;s logical database and schema resources in PG
    /// will be created if they do not already exist.
    /// The request will fail if this is false and the database/schema do not exist.
    /// </summary>
    [JsonPropertyName("createDatabaseObjectsIfMissing")]
    public bool? CreateDatabaseObjectsIfMissing { get; set; }

    /// <summary>
    /// ID of an existing pipeline to bin-pack this synced table into.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("existingPipelineId")]
    public string? ExistingPipelineId { get; set; }

    /// <summary>
    /// Specification for creating a new pipeline.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("newPipelineSpec")]
    public V1beta1PostgresSyncedTableSpecForProviderSpecNewPipelineSpec? NewPipelineSpec { get; set; }

    /// <summary>The Postgres database name where the synced table will be created in.</summary>
    [JsonPropertyName("postgresDatabase")]
    public string? PostgresDatabase { get; set; }

    /// <summary>Primary Key columns to be used for data insert/update in the destination</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>Scheduling policy of the underlying pipeline. Possible values are: CONTINUOUS, SNAPSHOT, TRIGGERED</summary>
    [JsonPropertyName("schedulingPolicy")]
    public string? SchedulingPolicy { get; set; }

    /// <summary>Three-part (catalog, schema, table) name of the source Delta table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }

    /// <summary>
    /// Override the default Delta-&gt;PG type mapping for specific columns.
    /// A TypeOverride with PG_SPECIFIC_TYPE_UNSPECIFIED is rejected; a valid pg_type must be set
    /// </summary>
    [JsonPropertyName("typeOverrides")]
    public IList<V1beta1PostgresSyncedTableSpecForProviderSpecTypeOverrides>? TypeOverrides { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecForProvider
{
    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresSyncedTableSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Configuration details of the synced table, such as the source table, scheduling policy, etc.
    /// This attribute is specified at creation time and most fields are returned as is on subsequent queries
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresSyncedTableSpecForProviderSpec? Spec { get; set; }

    /// <summary>part Unity Catalog name: catalog.schema.table</summary>
    [JsonPropertyName("syncedTableId")]
    public string? SyncedTableId { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specification for creating a new pipeline.
/// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecInitProviderSpecNewPipelineSpec
{
    /// <summary>Budget policy to set on the newly created pipeline</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// UC catalog for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be a standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageCatalog")]
    public string? StorageCatalog { get; set; }

    /// <summary>
    /// UC schema for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be in the standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageSchema")]
    public string? StorageSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecInitProviderSpecTypeOverrides
{
    /// <summary>Name of the source column whose target PostgreSQL type should be overridden</summary>
    [JsonPropertyName("columnName")]
    public string? ColumnName { get; set; }

    /// <summary>PostgreSQL-specific target type to use for the column. Possible values are: PG_SPECIFIC_TYPE_VECTOR</summary>
    [JsonPropertyName("pgType")]
    public string? PgType { get; set; }

    /// <summary>
    /// Size parameter for the target type. Required when pg_type is PG_SPECIFIC_TYPE_VECTOR
    /// or PG_SPECIFIC_TYPE_HALFVEC (specifies the vector dimension, e.g., 1024)
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary>
/// Configuration details of the synced table, such as the source table, scheduling policy, etc.
/// This attribute is specified at creation time and most fields are returned as is on subsequent queries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecInitProviderSpec
{
    /// <summary>
    /// When true, enables accelerated sync mode for the initial data load.
    /// This significantly improves performance for large tables.
    /// Requires workspace-level enablement through Lakebase Accelerated Sync preview
    /// </summary>
    [JsonPropertyName("acceleratedSync")]
    public bool? AcceleratedSync { get; set; }

    /// <summary>The full resource name the branch associated with the table.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// If true, the synced table&apos;s logical database and schema resources in PG
    /// will be created if they do not already exist.
    /// The request will fail if this is false and the database/schema do not exist.
    /// </summary>
    [JsonPropertyName("createDatabaseObjectsIfMissing")]
    public bool? CreateDatabaseObjectsIfMissing { get; set; }

    /// <summary>
    /// ID of an existing pipeline to bin-pack this synced table into.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("existingPipelineId")]
    public string? ExistingPipelineId { get; set; }

    /// <summary>
    /// Specification for creating a new pipeline.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("newPipelineSpec")]
    public V1beta1PostgresSyncedTableSpecInitProviderSpecNewPipelineSpec? NewPipelineSpec { get; set; }

    /// <summary>The Postgres database name where the synced table will be created in.</summary>
    [JsonPropertyName("postgresDatabase")]
    public string? PostgresDatabase { get; set; }

    /// <summary>Primary Key columns to be used for data insert/update in the destination</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>Scheduling policy of the underlying pipeline. Possible values are: CONTINUOUS, SNAPSHOT, TRIGGERED</summary>
    [JsonPropertyName("schedulingPolicy")]
    public string? SchedulingPolicy { get; set; }

    /// <summary>Three-part (catalog, schema, table) name of the source Delta table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }

    /// <summary>
    /// Override the default Delta-&gt;PG type mapping for specific columns.
    /// A TypeOverride with PG_SPECIFIC_TYPE_UNSPECIFIED is rejected; a valid pg_type must be set
    /// </summary>
    [JsonPropertyName("typeOverrides")]
    public IList<V1beta1PostgresSyncedTableSpecInitProviderSpecTypeOverrides>? TypeOverrides { get; set; }
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
public partial class V1beta1PostgresSyncedTableSpecInitProvider
{
    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresSyncedTableSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Configuration details of the synced table, such as the source table, scheduling policy, etc.
    /// This attribute is specified at creation time and most fields are returned as is on subsequent queries
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresSyncedTableSpecInitProviderSpec? Spec { get; set; }

    /// <summary>part Unity Catalog name: catalog.schema.table</summary>
    [JsonPropertyName("syncedTableId")]
    public string? SyncedTableId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresSyncedTableSpecManagementPoliciesEnum>))]
public enum V1beta1PostgresSyncedTableSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresSyncedTableSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresSyncedTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PostgresSyncedTableSpec defines the desired state of PostgresSyncedTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableSpec
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
    public V1beta1PostgresSyncedTableSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1PostgresSyncedTableSpecForProvider ForProvider { get; set; }

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
    public V1beta1PostgresSyncedTableSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1PostgresSyncedTableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PostgresSyncedTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PostgresSyncedTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specification for creating a new pipeline.
/// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderSpecNewPipelineSpec
{
    /// <summary>Budget policy to set on the newly created pipeline</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>
    /// UC catalog for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be a standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageCatalog")]
    public string? StorageCatalog { get; set; }

    /// <summary>
    /// UC schema for the pipeline to store intermediate files (checkpoints, event logs etc).
    /// This needs to be in the standard catalog where the user has permissions to create Delta tables
    /// </summary>
    [JsonPropertyName("storageSchema")]
    public string? StorageSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderSpecTypeOverrides
{
    /// <summary>Name of the source column whose target PostgreSQL type should be overridden</summary>
    [JsonPropertyName("columnName")]
    public string? ColumnName { get; set; }

    /// <summary>PostgreSQL-specific target type to use for the column. Possible values are: PG_SPECIFIC_TYPE_VECTOR</summary>
    [JsonPropertyName("pgType")]
    public string? PgType { get; set; }

    /// <summary>
    /// Size parameter for the target type. Required when pg_type is PG_SPECIFIC_TYPE_VECTOR
    /// or PG_SPECIFIC_TYPE_HALFVEC (specifies the vector dimension, e.g., 1024)
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary>
/// Configuration details of the synced table, such as the source table, scheduling policy, etc.
/// This attribute is specified at creation time and most fields are returned as is on subsequent queries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderSpec
{
    /// <summary>
    /// When true, enables accelerated sync mode for the initial data load.
    /// This significantly improves performance for large tables.
    /// Requires workspace-level enablement through Lakebase Accelerated Sync preview
    /// </summary>
    [JsonPropertyName("acceleratedSync")]
    public bool? AcceleratedSync { get; set; }

    /// <summary>The full resource name the branch associated with the table.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// If true, the synced table&apos;s logical database and schema resources in PG
    /// will be created if they do not already exist.
    /// The request will fail if this is false and the database/schema do not exist.
    /// </summary>
    [JsonPropertyName("createDatabaseObjectsIfMissing")]
    public bool? CreateDatabaseObjectsIfMissing { get; set; }

    /// <summary>
    /// ID of an existing pipeline to bin-pack this synced table into.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("existingPipelineId")]
    public string? ExistingPipelineId { get; set; }

    /// <summary>
    /// Specification for creating a new pipeline.
    /// At most one of existing_pipeline_id and new_pipeline_spec should be defined.
    /// </summary>
    [JsonPropertyName("newPipelineSpec")]
    public V1beta1PostgresSyncedTableStatusAtProviderSpecNewPipelineSpec? NewPipelineSpec { get; set; }

    /// <summary>The Postgres database name where the synced table will be created in.</summary>
    [JsonPropertyName("postgresDatabase")]
    public string? PostgresDatabase { get; set; }

    /// <summary>Primary Key columns to be used for data insert/update in the destination</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>Scheduling policy of the underlying pipeline. Possible values are: CONTINUOUS, SNAPSHOT, TRIGGERED</summary>
    [JsonPropertyName("schedulingPolicy")]
    public string? SchedulingPolicy { get; set; }

    /// <summary>Three-part (catalog, schema, table) name of the source Delta table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }

    /// <summary>
    /// Override the default Delta-&gt;PG type mapping for specific columns.
    /// A TypeOverride with PG_SPECIFIC_TYPE_UNSPECIFIED is rejected; a valid pg_type must be set
    /// </summary>
    [JsonPropertyName("typeOverrides")]
    public IList<V1beta1PostgresSyncedTableStatusAtProviderSpecTypeOverrides>? TypeOverrides { get; set; }
}

/// <summary>(DeltaTableSyncInfo)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderStatusLastSyncDeltaTableSyncInfo
{
    /// <summary>
    /// The timestamp when the above Delta version was committed in the source Delta table.
    /// Note: This is the Delta commit time, not the time the data was written to the synced table
    /// </summary>
    [JsonPropertyName("deltaCommitTime")]
    public string? DeltaCommitTime { get; set; }

    /// <summary>The Delta Lake commit version that was last successfully synced</summary>
    [JsonPropertyName("deltaCommitVersion")]
    public double? DeltaCommitVersion { get; set; }
}

/// <summary>Summary of the last successful synchronization from source to destination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderStatusLastSync
{
    /// <summary>(DeltaTableSyncInfo)</summary>
    [JsonPropertyName("deltaTableSyncInfo")]
    public V1beta1PostgresSyncedTableStatusAtProviderStatusLastSyncDeltaTableSyncInfo? DeltaTableSyncInfo { get; set; }

    /// <summary>
    /// The end timestamp of the most recent successful synchronization.
    /// This is the time when the data is available in the synced table
    /// </summary>
    [JsonPropertyName("syncEndTime")]
    public string? SyncEndTime { get; set; }

    /// <summary>
    /// The starting timestamp of the most recent successful synchronization from the source table
    /// to the destination (synced) table.
    /// Note this is the starting timestamp of the sync operation, not the end time.
    /// E.g., for a batch, this is the time when the sync operation started
    /// </summary>
    [JsonPropertyName("syncStartTime")]
    public string? SyncStartTime { get; set; }
}

/// <summary>(SyncedTablePipelineProgress)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderStatusOngoingSyncProgress
{
    /// <summary>The estimated time remaining to complete this update in seconds</summary>
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    /// <summary>
    /// The source table Delta version that was last processed by the pipeline. The pipeline may not
    /// have completely processed this version yet
    /// </summary>
    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    /// <summary>The completion ratio of this update. This is a number between 0 and 1</summary>
    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    /// <summary>The number of rows that have been synced in this update</summary>
    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    /// <summary>The total number of rows that need to be synced in this update. This number may be an estimate</summary>
    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary>Synced Table data synchronization status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProviderStatus
{
    /// <summary>The state of the synced table. Possible values are: SYNCED_TABLE_OFFLINE, SYNCED_TABLE_OFFLINE_FAILED, SYNCED_TABLE_ONLINE, SYNCED_TABLE_ONLINE_CONTINUOUS_UPDATE, SYNCED_TABLE_ONLINE_NO_PENDING_UPDATE, SYNCED_TABLE_ONLINE_PIPELINE_FAILED, SYNCED_TABLE_ONLINE_TRIGGERED_UPDATE, SYNCED_TABLE_ONLINE_UPDATING_PIPELINE_RESOURCES, SYNCED_TABLE_PROVISIONING, SYNCED_TABLE_PROVISIONING_INITIAL_SNAPSHOT, SYNCED_TABLE_PROVISIONING_PIPELINE_RESOURCES</summary>
    [JsonPropertyName("detailedState")]
    public string? DetailedState { get; set; }

    /// <summary>The last source table Delta version that was successfully synced to the synced table</summary>
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    /// <summary>Summary of the last successful synchronization from source to destination</summary>
    [JsonPropertyName("lastSync")]
    public V1beta1PostgresSyncedTableStatusAtProviderStatusLastSync? LastSync { get; set; }

    /// <summary>
    /// The end timestamp of the last time any data was synchronized from the source table to the synced
    /// table. This is when the data is available in the synced table
    /// </summary>
    [JsonPropertyName("lastSyncTime")]
    public string? LastSyncTime { get; set; }

    /// <summary>A text description of the current state of the synced table</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(SyncedTablePipelineProgress)</summary>
    [JsonPropertyName("ongoingSyncProgress")]
    public V1beta1PostgresSyncedTableStatusAtProviderStatusOngoingSyncProgress? OngoingSyncProgress { get; set; }

    /// <summary>ID of the associated pipeline</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>The full resource name of the project associated with the table.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The current phase of the data synchronization pipeline. Possible values are: PROVISIONING_PHASE_INDEX_SCAN, PROVISIONING_PHASE_INDEX_SORT, PROVISIONING_PHASE_MAIN</summary>
    [JsonPropertyName("provisioningPhase")]
    public string? ProvisioningPhase { get; set; }

    /// <summary>The provisioning state of the synced table entity in Unity Catalog. Possible values are: ACTIVE, DEGRADED, DELETING, FAILED, PROVISIONING, UPDATING</summary>
    [JsonPropertyName("unityCatalogProvisioningState")]
    public string? UnityCatalogProvisioningState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusAtProvider
{
    /// <summary>(string)</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresSyncedTableStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Configuration details of the synced table, such as the source table, scheduling policy, etc.
    /// This attribute is specified at creation time and most fields are returned as is on subsequent queries
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresSyncedTableStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Synced Table data synchronization status</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresSyncedTableStatusAtProviderStatus? Status { get; set; }

    /// <summary>part Unity Catalog name: catalog.schema.table</summary>
    [JsonPropertyName("syncedTableId")]
    public string? SyncedTableId { get; set; }

    /// <summary>The Unity Catalog table ID for this synced table</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatusConditions
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

/// <summary>PostgresSyncedTableStatus defines the observed state of PostgresSyncedTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresSyncedTableStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PostgresSyncedTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PostgresSyncedTableStatusConditions>? Conditions { get; set; }

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

/// <summary>PostgresSyncedTable is the Schema for the PostgresSyncedTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresSyncedTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PostgresSyncedTableSpec>, IStatus<V1beta1PostgresSyncedTableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresSyncedTable";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgressyncedtables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresSyncedTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PostgresSyncedTableSpec defines the desired state of PostgresSyncedTable</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PostgresSyncedTableSpec Spec { get; set; }

    /// <summary>PostgresSyncedTableStatus defines the observed state of PostgresSyncedTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresSyncedTableStatus? Status { get; set; }
}