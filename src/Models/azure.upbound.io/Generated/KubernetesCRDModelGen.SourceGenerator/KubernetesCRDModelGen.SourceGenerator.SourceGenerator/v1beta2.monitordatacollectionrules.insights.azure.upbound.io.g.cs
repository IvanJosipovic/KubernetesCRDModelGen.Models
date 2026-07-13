#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>MonitorDataCollectionRule is the Schema for the MonitorDataCollectionRules API. Manages a Data Collection Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorDataCollectionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MonitorDataCollectionRule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorDataCollectionRuleList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitordatacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorDataCollectionRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MonitorDataCollectionRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MonitorDataCollectionRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecDeletionPolicyEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRef? EventHubIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelector? EventHubIdSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRef? WorkspaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector? WorkspaceResourceIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRef? ContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelector? ContainerNameSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelector
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
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecForProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRef? DataCollectionEndpointIdRef { get; set; }

    /// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelector? DataCollectionEndpointIdSelector { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderDestinations? Destinations { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta2MonitorDataCollectionRuleSpecForProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRef? EventHubIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelector? EventHubIdSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRef? WorkspaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector? WorkspaceResourceIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameRef")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRef? ContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelector? ContainerNameSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelector
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
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecInitProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
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
public partial class V1beta2MonitorDataCollectionRuleSpecInitProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdRef")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRef? DataCollectionEndpointIdRef { get; set; }

    /// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdSelector")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelector? DataCollectionEndpointIdSelector { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderDestinations? Destinations { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MonitorDataCollectionRuleSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta2MonitorDataCollectionRuleSpecInitProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecManagementPoliciesEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorDataCollectionRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorDataCollectionRuleSpec defines the desired state of MonitorDataCollectionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleSpec
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
    public V1beta2MonitorDataCollectionRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MonitorDataCollectionRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta2MonitorDataCollectionRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MonitorDataCollectionRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MonitorDataCollectionRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MonitorDataCollectionRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusAtProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderDestinations? Destinations { get; set; }

    /// <summary>The ID of the Data Collection Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MonitorDataCollectionRuleStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The immutable ID of the Data Collection Rule.</summary>
    [JsonPropertyName("immutableId")]
    public string? ImmutableId { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta2MonitorDataCollectionRuleStatusAtProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatusConditions
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

/// <summary>MonitorDataCollectionRuleStatus defines the observed state of MonitorDataCollectionRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorDataCollectionRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MonitorDataCollectionRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MonitorDataCollectionRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorDataCollectionRule is the Schema for the MonitorDataCollectionRules API. Manages a Data Collection Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorDataCollectionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MonitorDataCollectionRuleSpec>, IStatus<V1beta2MonitorDataCollectionRuleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorDataCollectionRule";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitordatacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorDataCollectionRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorDataCollectionRuleSpec defines the desired state of MonitorDataCollectionRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MonitorDataCollectionRuleSpec Spec { get; set; }

    /// <summary>MonitorDataCollectionRuleStatus defines the observed state of MonitorDataCollectionRule.</summary>
    [JsonPropertyName("status")]
    public V1beta2MonitorDataCollectionRuleStatus? Status { get; set; }
}