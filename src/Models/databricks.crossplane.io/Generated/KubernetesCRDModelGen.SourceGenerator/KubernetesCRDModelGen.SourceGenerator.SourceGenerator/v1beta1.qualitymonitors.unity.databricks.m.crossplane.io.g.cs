#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.m.crossplane.io;
/// <summary>QualityMonitor is the Schema for the QualityMonitors API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QualityMonitorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1QualityMonitor>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QualityMonitorList";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "qualitymonitors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QualityMonitorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1QualityMonitor objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1QualityMonitor> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data classification config for the monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderDataClassificationConfig
{
    /// <summary>Whether to enable data classification</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the inference log monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary>who to send notifications to on monitor failure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderNotificationsOnFailure
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>Who to send notifications to when new data classification tags are detected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderNotificationsOnNewClassificationTagDetected
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1QualityMonitorSpecForProviderNotificationsOnFailure? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public V1beta1QualityMonitorSpecForProviderNotificationsOnNewClassificationTagDetected? OnNewClassificationTagDetected { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderSchedule
{
    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>Configuration for monitoring snapshot tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderSnapshot
{
}

/// <summary>Configuration for monitoring timeseries tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecForProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>
    /// Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline
    /// table.
    /// </summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1QualityMonitorSpecForProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public V1beta1QualityMonitorSpecForProviderDataClassificationConfig? DataClassificationConfig { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public V1beta1QualityMonitorSpecForProviderInferenceLog? InferenceLog { get; set; }

    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public V1beta1QualityMonitorSpecForProviderNotifications? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QualityMonitorSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public V1beta1QualityMonitorSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can&apos;t be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1QualityMonitorSpecForProviderSnapshot? Snapshot { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public V1beta1QualityMonitorSpecForProviderTimeSeries? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can&apos;t be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data classification config for the monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderDataClassificationConfig
{
    /// <summary>Whether to enable data classification</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the inference log monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary>who to send notifications to on monitor failure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderNotificationsOnFailure
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>Who to send notifications to when new data classification tags are detected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderNotificationsOnNewClassificationTagDetected
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1QualityMonitorSpecInitProviderNotificationsOnFailure? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public V1beta1QualityMonitorSpecInitProviderNotificationsOnNewClassificationTagDetected? OnNewClassificationTagDetected { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderSchedule
{
    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>Configuration for monitoring snapshot tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderSnapshot
{
}

/// <summary>Configuration for monitoring timeseries tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpecInitProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
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
public partial class V1beta1QualityMonitorSpecInitProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>
    /// Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline
    /// table.
    /// </summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1QualityMonitorSpecInitProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public V1beta1QualityMonitorSpecInitProviderDataClassificationConfig? DataClassificationConfig { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public V1beta1QualityMonitorSpecInitProviderInferenceLog? InferenceLog { get; set; }

    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public V1beta1QualityMonitorSpecInitProviderNotifications? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QualityMonitorSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public V1beta1QualityMonitorSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can&apos;t be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1QualityMonitorSpecInitProviderSnapshot? Snapshot { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public V1beta1QualityMonitorSpecInitProviderTimeSeries? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can&apos;t be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QualityMonitorSpecManagementPoliciesEnum>))]
public enum V1beta1QualityMonitorSpecManagementPoliciesEnum
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
public partial class V1beta1QualityMonitorSpecProviderConfigRef
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
public partial class V1beta1QualityMonitorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>QualityMonitorSpec defines the desired state of QualityMonitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1QualityMonitorSpecForProvider ForProvider { get; set; }

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
    public V1beta1QualityMonitorSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1QualityMonitorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1QualityMonitorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1QualityMonitorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data classification config for the monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderDataClassificationConfig
{
    /// <summary>Whether to enable data classification</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration for the inference log monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary>who to send notifications to on monitor failure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderNotificationsOnFailure
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>Who to send notifications to when new data classification tags are detected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderNotificationsOnNewClassificationTagDetected
{
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1QualityMonitorStatusAtProviderNotificationsOnFailure? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public V1beta1QualityMonitorStatusAtProviderNotificationsOnNewClassificationTagDetected? OnNewClassificationTagDetected { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderSchedule
{
    /// <summary>Status of the Monitor</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>Configuration for monitoring snapshot tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderSnapshot
{
}

/// <summary>Configuration for monitoring timeseries tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusAtProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>
    /// Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline
    /// table.
    /// </summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta1QualityMonitorStatusAtProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The ID of the generated dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public V1beta1QualityMonitorStatusAtProviderDataClassificationConfig? DataClassificationConfig { get; set; }

    /// <summary>The full name of the drift metrics table. Format: catalog_name.schema_name.table_name.</summary>
    [JsonPropertyName("driftMetricsTableName")]
    public string? DriftMetricsTableName { get; set; }

    /// <summary>ID of this monitor is the same as the full table name of the format {catalog}.{schema_name}.{table_name}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public V1beta1QualityMonitorStatusAtProviderInferenceLog? InferenceLog { get; set; }

    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The version of the monitor config (e.g. 1,2,3). If negative, the monitor may be corrupted</summary>
    [JsonPropertyName("monitorVersion")]
    public double? MonitorVersion { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public V1beta1QualityMonitorStatusAtProviderNotifications? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>The full name of the profile metrics table. Format: catalog_name.schema_name.table_name.</summary>
    [JsonPropertyName("profileMetricsTableName")]
    public string? ProfileMetricsTableName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QualityMonitorStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public V1beta1QualityMonitorStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can&apos;t be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta1QualityMonitorStatusAtProviderSnapshot? Snapshot { get; set; }

    /// <summary>Status of the Monitor</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public V1beta1QualityMonitorStatusAtProviderTimeSeries? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can&apos;t be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatusConditions
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

/// <summary>QualityMonitorStatus defines the observed state of QualityMonitor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QualityMonitorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1QualityMonitorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1QualityMonitorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>QualityMonitor is the Schema for the QualityMonitors API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QualityMonitor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1QualityMonitorSpec>, IStatus<V1beta1QualityMonitorStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QualityMonitor";
    public const string KubeGroup = "unity.databricks.m.crossplane.io";
    public const string KubePluralName = "qualitymonitors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QualityMonitor";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QualityMonitorSpec defines the desired state of QualityMonitor</summary>
    [JsonPropertyName("spec")]
    public required V1beta1QualityMonitorSpec Spec { get; set; }

    /// <summary>QualityMonitorStatus defines the observed state of QualityMonitor.</summary>
    [JsonPropertyName("status")]
    public V1beta1QualityMonitorStatus? Status { get; set; }
}