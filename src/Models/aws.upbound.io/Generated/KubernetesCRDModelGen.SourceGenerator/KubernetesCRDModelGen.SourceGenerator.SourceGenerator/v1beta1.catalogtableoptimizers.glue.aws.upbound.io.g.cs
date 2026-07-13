#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>CatalogTableOptimizer is the Schema for the CatalogTableOptimizers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTableOptimizerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CatalogTableOptimizer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTableOptimizerList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "catalogtableoptimizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CatalogTableOptimizerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CatalogTableOptimizer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CatalogTableOptimizer> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecDeletionPolicyEnum>))]
public enum V1beta1CatalogTableOptimizerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
{
    /// <summary>Specifies a directory in which to look for files. You may choose a sub-directory rather than the top-level table location. Defaults to the table&apos;s location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The number of days that orphan files should be retained before file deletion. Defaults to 3.</summary>
    [JsonPropertyName("orphanFileRetentionPeriodInDays")]
    public double? OrphanFileRetentionPeriodInDays { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderConfigurationOrphanFileDeletionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecForProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderConfigurationRetentionConfigurationIcebergConfiguration
{
    /// <summary>If set to false, snapshots are only deleted from table metadata, and the underlying data and metadata files are not deleted. Defaults to false.</summary>
    [JsonPropertyName("cleanExpiredFiles")]
    public bool? CleanExpiredFiles { get; set; }

    /// <summary>The number of Iceberg snapshots to retain within the retention period. Defaults to 1 or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("numberOfSnapshotsToRetain")]
    public double? NumberOfSnapshotsToRetain { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }

    /// <summary>The number of days to retain the Iceberg snapshots. Defaults to 5, or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("snapshotRetentionPeriodInDays")]
    public double? SnapshotRetentionPeriodInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderConfigurationRetentionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecForProviderConfigurationRetentionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderConfiguration
{
    /// <summary>Indicates whether the table optimizer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The configuration block for an orphan file deletion optimizer. See Orphan File Deletion Configuration for additional details.</summary>
    [JsonPropertyName("orphanFileDeletionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecForProviderConfigurationOrphanFileDeletionConfiguration>? OrphanFileDeletionConfiguration { get; set; }

    /// <summary>The configuration block for a snapshot retention optimizer. See Retention Configuration for additional details.</summary>
    [JsonPropertyName("retentionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecForProviderConfigurationRetentionConfiguration>? RetentionConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to use for the table optimizer.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelector
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
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecForProvider
{
    /// <summary>The Catalog ID of the table.</summary>
    [JsonPropertyName("catalogId")]
    public required string CatalogId { get; set; }

    /// <summary>A configuration block that defines the table optimizer settings. See Configuration for additional details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1CatalogTableOptimizerSpecForProviderConfiguration>? Configuration { get; set; }

    /// <summary>The name of the database in the catalog in which the table resides.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CatalogTableOptimizerSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>The type of table optimizer. Valid values are compaction, retention, and orphan_file_deletion.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecInitProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
{
    /// <summary>Specifies a directory in which to look for files. You may choose a sub-directory rather than the top-level table location. Defaults to the table&apos;s location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The number of days that orphan files should be retained before file deletion. Defaults to 3.</summary>
    [JsonPropertyName("orphanFileRetentionPeriodInDays")]
    public double? OrphanFileRetentionPeriodInDays { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecInitProviderConfigurationOrphanFileDeletionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecInitProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecInitProviderConfigurationRetentionConfigurationIcebergConfiguration
{
    /// <summary>If set to false, snapshots are only deleted from table metadata, and the underlying data and metadata files are not deleted. Defaults to false.</summary>
    [JsonPropertyName("cleanExpiredFiles")]
    public bool? CleanExpiredFiles { get; set; }

    /// <summary>The number of Iceberg snapshots to retain within the retention period. Defaults to 1 or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("numberOfSnapshotsToRetain")]
    public double? NumberOfSnapshotsToRetain { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }

    /// <summary>The number of days to retain the Iceberg snapshots. Defaults to 5, or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("snapshotRetentionPeriodInDays")]
    public double? SnapshotRetentionPeriodInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecInitProviderConfigurationRetentionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecInitProviderConfigurationRetentionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecInitProviderConfiguration
{
    /// <summary>Indicates whether the table optimizer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The configuration block for an orphan file deletion optimizer. See Orphan File Deletion Configuration for additional details.</summary>
    [JsonPropertyName("orphanFileDeletionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecInitProviderConfigurationOrphanFileDeletionConfiguration>? OrphanFileDeletionConfiguration { get; set; }

    /// <summary>The configuration block for a snapshot retention optimizer. See Retention Configuration for additional details.</summary>
    [JsonPropertyName("retentionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerSpecInitProviderConfigurationRetentionConfiguration>? RetentionConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to use for the table optimizer.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
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
public partial class V1beta1CatalogTableOptimizerSpecInitProvider
{
    /// <summary>A configuration block that defines the table optimizer settings. See Configuration for additional details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1CatalogTableOptimizerSpecInitProviderConfiguration>? Configuration { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>The type of table optimizer. Valid values are compaction, retention, and orphan_file_deletion.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecManagementPoliciesEnum>))]
public enum V1beta1CatalogTableOptimizerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableOptimizerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CatalogTableOptimizerSpec defines the desired state of CatalogTableOptimizer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerSpec
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
    public V1beta1CatalogTableOptimizerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1CatalogTableOptimizerSpecForProvider ForProvider { get; set; }

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
    public V1beta1CatalogTableOptimizerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1CatalogTableOptimizerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CatalogTableOptimizerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CatalogTableOptimizerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration
{
    /// <summary>Specifies a directory in which to look for files. You may choose a sub-directory rather than the top-level table location. Defaults to the table&apos;s location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The number of days that orphan files should be retained before file deletion. Defaults to 3.</summary>
    [JsonPropertyName("orphanFileRetentionPeriodInDays")]
    public double? OrphanFileRetentionPeriodInDays { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProviderConfigurationOrphanFileDeletionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerStatusAtProviderConfigurationOrphanFileDeletionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProviderConfigurationRetentionConfigurationIcebergConfiguration
{
    /// <summary>If set to false, snapshots are only deleted from table metadata, and the underlying data and metadata files are not deleted. Defaults to false.</summary>
    [JsonPropertyName("cleanExpiredFiles")]
    public bool? CleanExpiredFiles { get; set; }

    /// <summary>The number of Iceberg snapshots to retain within the retention period. Defaults to 1 or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("numberOfSnapshotsToRetain")]
    public double? NumberOfSnapshotsToRetain { get; set; }

    /// <summary>interval in hours between orphan file deletion job runs. Defaults to 24.</summary>
    [JsonPropertyName("runRateInHours")]
    public double? RunRateInHours { get; set; }

    /// <summary>The number of days to retain the Iceberg snapshots. Defaults to 5, or the corresponding Iceberg table configuration field if it exists.</summary>
    [JsonPropertyName("snapshotRetentionPeriodInDays")]
    public double? SnapshotRetentionPeriodInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProviderConfigurationRetentionConfiguration
{
    /// <summary>The configuration for an Iceberg orphan file deletion optimizer.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public IList<V1beta1CatalogTableOptimizerStatusAtProviderConfigurationRetentionConfigurationIcebergConfiguration>? IcebergConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProviderConfiguration
{
    /// <summary>Indicates whether the table optimizer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The configuration block for an orphan file deletion optimizer. See Orphan File Deletion Configuration for additional details.</summary>
    [JsonPropertyName("orphanFileDeletionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerStatusAtProviderConfigurationOrphanFileDeletionConfiguration>? OrphanFileDeletionConfiguration { get; set; }

    /// <summary>The configuration block for a snapshot retention optimizer. See Retention Configuration for additional details.</summary>
    [JsonPropertyName("retentionConfiguration")]
    public IList<V1beta1CatalogTableOptimizerStatusAtProviderConfigurationRetentionConfiguration>? RetentionConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to use for the table optimizer.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusAtProvider
{
    /// <summary>The Catalog ID of the table.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A configuration block that defines the table optimizer settings. See Configuration for additional details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1CatalogTableOptimizerStatusAtProviderConfiguration>? Configuration { get; set; }

    /// <summary>The name of the database in the catalog in which the table resides.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>The type of table optimizer. Valid values are compaction, retention, and orphan_file_deletion.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatusConditions
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

/// <summary>CatalogTableOptimizerStatus defines the observed state of CatalogTableOptimizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableOptimizerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CatalogTableOptimizerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CatalogTableOptimizerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CatalogTableOptimizer is the Schema for the CatalogTableOptimizers API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTableOptimizer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CatalogTableOptimizerSpec>, IStatus<V1beta1CatalogTableOptimizerStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTableOptimizer";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "catalogtableoptimizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CatalogTableOptimizer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CatalogTableOptimizerSpec defines the desired state of CatalogTableOptimizer</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CatalogTableOptimizerSpec Spec { get; set; }

    /// <summary>CatalogTableOptimizerStatus defines the observed state of CatalogTableOptimizer.</summary>
    [JsonPropertyName("status")]
    public V1beta1CatalogTableOptimizerStatus? Status { get; set; }
}