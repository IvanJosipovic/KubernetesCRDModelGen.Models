#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>
/// Storage version of v1api20230311.DataCollectionRule
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2023-03-11/dataCollectionRules_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230311storageDataCollectionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20230311storageDataCollectionRule>
{
    public const string KubeApiVersion = "v1api20230311storage";
    public const string KubeKind = "DataCollectionRuleList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "datacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20230311storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCollectionRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230311storageDataCollectionRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230311storageDataCollectionRule> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AgentSetting
/// A setting used to control an agent behavior on a host machine
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecAgentSettingsLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AgentSettingsSpec
/// An agent setting
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecAgentSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logs")]
    public IList<V1api20230311storageDataCollectionRuleSpecAgentSettingsLogs>? Logs { get; set; }
}

/// <summary>DataCollectionEndpointReference: The resource ID of the data collection endpoint that this rule can be used with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataCollectionEndpointReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataFlow
/// Definition of which streams are sent to which destinations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataFlows
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    [JsonPropertyName("captureOverflow")]
    public bool? CaptureOverflow { get; set; }

    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDataSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesDataImportsEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>Storage version of v1api20230311.DataImportSources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesDataImports
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230311.EventHubDataSource</summary>
    [JsonPropertyName("eventHub")]
    public V1api20230311storageDataCollectionRuleSpecDataSourcesDataImportsEventHub? EventHub { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ExtensionDataSource
/// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor
/// Agent.
/// Collected from either Windows and Linux machines, depending on which extension is defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesExtensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    [JsonPropertyName("extensionSettings")]
    public IDictionary<string, JsonNode>? ExtensionSettings { get; set; }

    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.IisLogsDataSource
/// Enables IIS logs to be collected by this data collection rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesIisLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFileTextSettings
/// Settings for text log files
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesLogFilesSettingsText
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFileSettings
/// Settings for different log file formats
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesLogFilesSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.LogFileTextSettings
    /// Settings for text log files
    /// </summary>
    [JsonPropertyName("text")]
    public V1api20230311storageDataCollectionRuleSpecDataSourcesLogFilesSettingsText? Text { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFilesDataSource
/// Definition of which custom log files will be collected by this data collection rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesLogFiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.LogFileSettings
    /// Settings for different log file formats
    /// </summary>
    [JsonPropertyName("settings")]
    public V1api20230311storageDataCollectionRuleSpecDataSourcesLogFilesSettings? Settings { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PerfCounterDataSource
/// Definition of which performance counters will be collected and how they will be collected by this data collection
/// rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesPerformanceCounters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PlatformTelemetryDataSource
/// Definition of platform telemetry data source configuration
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesPlatformTelemetry
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PrometheusForwarderDataSource
/// Definition of Prometheus metrics forwarding configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesPrometheusForwarder
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("labelIncludeFilter")]
    public IDictionary<string, string>? LabelIncludeFilter { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.SyslogDataSource
/// Definition of which syslog data will be collected and how it will be collected.
/// Only collected from Linux machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesSyslog
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.WindowsEventLogDataSource
/// Definition of which Windows Event Log events will be collected and how they will be collected.
/// Only collected from
/// Windows machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesWindowsEventLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }

    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.WindowsFirewallLogsDataSource
/// Enables Firewall logs to be collected by this data collection rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSourcesWindowsFirewallLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("profileFilter")]
    public IList<string>? ProfileFilter { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataSourcesSpec
/// Specification of data sources that will be collected.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDataSources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230311.DataImportSources</summary>
    [JsonPropertyName("dataImports")]
    public V1api20230311storageDataCollectionRuleSpecDataSourcesDataImports? DataImports { get; set; }

    [JsonPropertyName("extensions")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesExtensions>? Extensions { get; set; }

    [JsonPropertyName("iisLogs")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesIisLogs>? IisLogs { get; set; }

    [JsonPropertyName("logFiles")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesLogFiles>? LogFiles { get; set; }

    [JsonPropertyName("performanceCounters")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesPerformanceCounters>? PerformanceCounters { get; set; }

    [JsonPropertyName("platformTelemetry")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    [JsonPropertyName("prometheusForwarder")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    [JsonPropertyName("syslog")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesSyslog>? Syslog { get; set; }

    [JsonPropertyName("windowsEventLogs")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesWindowsEventLogs>? WindowsEventLogs { get; set; }

    [JsonPropertyName("windowsFirewallLogs")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataSourcesWindowsFirewallLogs>? WindowsFirewallLogs { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the Adx resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsAzureDataExplorerResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AdxDestination
/// Azure Data Explorer (Adx) destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsAzureDataExplorer
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the Adx resource.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsAzureDataExplorerResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AzureMonitorMetricsDestination
/// Azure Monitor Metrics destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsAzureMonitorMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsEventHubResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsEventHubs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsEventHubResourceReference? EventHubResourceReference { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsDirectEventHubResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDirectDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsDirectEventHubResourceReference? EventHubResourceReference { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>WorkspaceResourceReference: The resource ID of the Log Analytics workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsLogAnalyticsWorkspaceResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogAnalyticsDestination
/// Log Analytics destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsLogAnalytics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WorkspaceResourceReference: The resource ID of the Log Analytics workspace.</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsLogAnalyticsWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.MicrosoftFabricDestination
/// Microsoft Fabric destination (non-Azure).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsMicrosoftFabric
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>AccountResourceReference: The resource ID of the monitoring account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsMonitoringAccountsAccountResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.MonitoringAccountDestination
/// Monitoring account destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsMonitoringAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AccountResourceReference: The resource ID of the monitoring account.</summary>
    [JsonPropertyName("accountResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsMonitoringAccountsAccountResourceReference? AccountResourceReference { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageAccountsStorageAccountResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlobDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsStorageAccountsStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageBlobsDirectStorageAccountResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlobDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageBlobsDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsStorageBlobsDirectStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageTablesDirectStorageAccountResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageTableDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinationsStorageTablesDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsStorageTablesDirectStorageAccountResourceReference? StorageAccountResourceReference { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DestinationsSpec
/// Specification of destinations that can be used in data flows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecDestinations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureDataExplorer")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsAzureDataExplorer>? AzureDataExplorer { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.AzureMonitorMetricsDestination
    /// Azure Monitor Metrics destination.
    /// </summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1api20230311storageDataCollectionRuleSpecDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    [JsonPropertyName("eventHubs")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsEventHubs>? EventHubs { get; set; }

    [JsonPropertyName("eventHubsDirect")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsEventHubsDirect>? EventHubsDirect { get; set; }

    [JsonPropertyName("logAnalytics")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsLogAnalytics>? LogAnalytics { get; set; }

    [JsonPropertyName("microsoftFabric")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsMicrosoftFabric>? MicrosoftFabric { get; set; }

    [JsonPropertyName("monitoringAccounts")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsMonitoringAccounts>? MonitoringAccounts { get; set; }

    [JsonPropertyName("storageAccounts")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsStorageAccounts>? StorageAccounts { get; set; }

    [JsonPropertyName("storageBlobsDirect")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsStorageBlobsDirect>? StorageBlobsDirect { get; set; }

    [JsonPropertyName("storageTablesDirect")]
    public IList<V1api20230311storageDataCollectionRuleSpecDestinationsStorageTablesDirect>? StorageTablesDirect { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230311storageDataCollectionRuleSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ManagedServiceIdentity
/// Managed service identity (system assigned and/or user assigned identities)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230311storageDataCollectionRuleSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataCollectionRuleOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230311storageDataCollectionRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230311storageDataCollectionRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference: Resource Id of the storage account that hosts the blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentDataStorageBlobs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobUrl")]
    public string? BlobUrl { get; set; }

    [JsonPropertyName("lookupType")]
    public string? LookupType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceReference: Resource Id of the storage account that hosts the blob</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.EnrichmentData
/// All the enrichment data sources referenced in data flows
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageBlobs")]
    public IList<V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentDataStorageBlobs>? StorageBlobs { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ReferencesSpec
/// This section defines all the references that may be used in other sections of the DCR
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecReferences
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.EnrichmentData
    /// All the enrichment data sources referenced in data flows
    /// </summary>
    [JsonPropertyName("enrichmentData")]
    public V1api20230311storageDataCollectionRuleSpecReferencesEnrichmentData? EnrichmentData { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ColumnDefinition
/// Definition of custom data column.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecStreamDeclarationsColumns
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.StreamDeclaration
/// Declaration of a custom stream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpecStreamDeclarations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("columns")]
    public IList<V1api20230311storageDataCollectionRuleSpecStreamDeclarationsColumns>? Columns { get; set; }
}

/// <summary>Storage version of v1api20230311.DataCollectionRule_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.AgentSettingsSpec
    /// An agent setting
    /// </summary>
    [JsonPropertyName("agentSettings")]
    public V1api20230311storageDataCollectionRuleSpecAgentSettings? AgentSettings { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DataCollectionEndpointReference: The resource ID of the data collection endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointReference")]
    public V1api20230311storageDataCollectionRuleSpecDataCollectionEndpointReference? DataCollectionEndpointReference { get; set; }

    [JsonPropertyName("dataFlows")]
    public IList<V1api20230311storageDataCollectionRuleSpecDataFlows>? DataFlows { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DataSourcesSpec
    /// Specification of data sources that will be collected.
    /// </summary>
    [JsonPropertyName("dataSources")]
    public V1api20230311storageDataCollectionRuleSpecDataSources? DataSources { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DestinationsSpec
    /// Specification of destinations that can be used in data flows.
    /// </summary>
    [JsonPropertyName("destinations")]
    public V1api20230311storageDataCollectionRuleSpecDestinations? Destinations { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.ManagedServiceIdentity
    /// Managed service identity (system assigned and/or user assigned identities)
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230311storageDataCollectionRuleSpecIdentity? Identity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DataCollectionRuleOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230311storageDataCollectionRuleSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230311storageDataCollectionRuleSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.ReferencesSpec
    /// This section defines all the references that may be used in other sections of the DCR
    /// </summary>
    [JsonPropertyName("references")]
    public V1api20230311storageDataCollectionRuleSpecReferences? References { get; set; }

    [JsonPropertyName("streamDeclarations")]
    public IDictionary<string, V1api20230311storageDataCollectionRuleSpecStreamDeclarations>? StreamDeclarations { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AgentSetting_STATUS
/// A setting used to control an agent behavior on a host machine
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusAgentSettingsLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AgentSettingsSpec_STATUS
/// An agent setting
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusAgentSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logs")]
    public IList<V1api20230311storageDataCollectionRuleStatusAgentSettingsLogs>? Logs { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataFlow_STATUS
/// Definition of which streams are sent to which destinations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataFlows
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    [JsonPropertyName("captureOverflow")]
    public bool? CaptureOverflow { get; set; }

    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDataSource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesDataImportsEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>Storage version of v1api20230311.DataImportSources_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesDataImports
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230311.EventHubDataSource_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V1api20230311storageDataCollectionRuleStatusDataSourcesDataImportsEventHub? EventHub { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ExtensionDataSource_STATUS
/// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor
/// Agent.
/// Collected from either Windows and Linux machines, depending on which extension is defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesExtensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    [JsonPropertyName("extensionSettings")]
    public IDictionary<string, JsonNode>? ExtensionSettings { get; set; }

    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.IisLogsDataSource_STATUS
/// Enables IIS logs to be collected by this data collection rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesIisLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFileTextSettings_STATUS
/// Settings for text log files
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesLogFilesSettingsText
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFileSettings_STATUS
/// Settings for different log file formats
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesLogFilesSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.LogFileTextSettings_STATUS
    /// Settings for text log files
    /// </summary>
    [JsonPropertyName("text")]
    public V1api20230311storageDataCollectionRuleStatusDataSourcesLogFilesSettingsText? Text { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogFilesDataSource_STATUS
/// Definition of which custom log files will be collected by this data collection rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesLogFiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.LogFileSettings_STATUS
    /// Settings for different log file formats
    /// </summary>
    [JsonPropertyName("settings")]
    public V1api20230311storageDataCollectionRuleStatusDataSourcesLogFilesSettings? Settings { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PerfCounterDataSource_STATUS
/// Definition of which performance counters will be collected and how they will be collected by this data collection
/// rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesPerformanceCounters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PlatformTelemetryDataSource_STATUS
/// Definition of platform telemetry data source configuration
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesPlatformTelemetry
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.PrometheusForwarderDataSource_STATUS
/// Definition of Prometheus metrics forwarding configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesPrometheusForwarder
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("labelIncludeFilter")]
    public IDictionary<string, string>? LabelIncludeFilter { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.SyslogDataSource_STATUS
/// Definition of which syslog data will be collected and how it will be collected.
/// Only collected from Linux machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesSyslog
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.WindowsEventLogDataSource_STATUS
/// Definition of which Windows Event Log events will be collected and how they will be collected.
/// Only collected from
/// Windows machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesWindowsEventLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }

    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.WindowsFirewallLogsDataSource_STATUS
/// Enables Firewall logs to be collected by this data collection rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSourcesWindowsFirewallLogs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("profileFilter")]
    public IList<string>? ProfileFilter { get; set; }

    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataSourcesSpec_STATUS
/// Specification of data sources that will be collected.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDataSources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230311.DataImportSources_STATUS</summary>
    [JsonPropertyName("dataImports")]
    public V1api20230311storageDataCollectionRuleStatusDataSourcesDataImports? DataImports { get; set; }

    [JsonPropertyName("extensions")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesExtensions>? Extensions { get; set; }

    [JsonPropertyName("iisLogs")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesIisLogs>? IisLogs { get; set; }

    [JsonPropertyName("logFiles")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesLogFiles>? LogFiles { get; set; }

    [JsonPropertyName("performanceCounters")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesPerformanceCounters>? PerformanceCounters { get; set; }

    [JsonPropertyName("platformTelemetry")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    [JsonPropertyName("prometheusForwarder")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    [JsonPropertyName("syslog")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesSyslog>? Syslog { get; set; }

    [JsonPropertyName("windowsEventLogs")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesWindowsEventLogs>? WindowsEventLogs { get; set; }

    [JsonPropertyName("windowsFirewallLogs")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataSourcesWindowsFirewallLogs>? WindowsFirewallLogs { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AdxDestination_STATUS
/// Azure Data Explorer (Adx) destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsAzureDataExplorer
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.AzureMonitorMetricsDestination_STATUS
/// Azure Monitor Metrics destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsAzureMonitorMetrics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsEventHubs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.EventHubDirectDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsEventHubsDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.LogAnalyticsDestination_STATUS
/// Log Analytics destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsLogAnalytics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.MicrosoftFabricDestination_STATUS
/// Microsoft Fabric destination (non-Azure).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsMicrosoftFabric
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.MonitoringAccountDestination_STATUS
/// Monitoring account destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsMonitoringAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("accountResourceId")]
    public string? AccountResourceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlobDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsStorageAccounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlobDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsStorageBlobsDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageTableDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinationsStorageTablesDirect
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DestinationsSpec_STATUS
/// Specification of destinations that can be used in data flows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusDestinations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureDataExplorer")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsAzureDataExplorer>? AzureDataExplorer { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.AzureMonitorMetricsDestination_STATUS
    /// Azure Monitor Metrics destination.
    /// </summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1api20230311storageDataCollectionRuleStatusDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    [JsonPropertyName("eventHubs")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsEventHubs>? EventHubs { get; set; }

    [JsonPropertyName("eventHubsDirect")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsEventHubsDirect>? EventHubsDirect { get; set; }

    [JsonPropertyName("logAnalytics")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsLogAnalytics>? LogAnalytics { get; set; }

    [JsonPropertyName("microsoftFabric")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsMicrosoftFabric>? MicrosoftFabric { get; set; }

    [JsonPropertyName("monitoringAccounts")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsMonitoringAccounts>? MonitoringAccounts { get; set; }

    [JsonPropertyName("storageAccounts")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsStorageAccounts>? StorageAccounts { get; set; }

    [JsonPropertyName("storageBlobsDirect")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsStorageBlobsDirect>? StorageBlobsDirect { get; set; }

    [JsonPropertyName("storageTablesDirect")]
    public IList<V1api20230311storageDataCollectionRuleStatusDestinationsStorageTablesDirect>? StorageTablesDirect { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.EndpointsSpec_STATUS
/// This defines all the ingestion endpoints that can be used by this rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logsIngestion")]
    public string? LogsIngestion { get; set; }

    [JsonPropertyName("metricsIngestion")]
    public string? MetricsIngestion { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.UserAssignedIdentity_STATUS
/// User assigned identity properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ManagedServiceIdentity_STATUS
/// Managed service identity (system assigned and/or user assigned identities)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230311storageDataCollectionRuleStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.Metadata_STATUS
/// Metadata about the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusMetadata
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("provisionedBy")]
    public string? ProvisionedBy { get; set; }

    [JsonPropertyName("provisionedByImmutableId")]
    public string? ProvisionedByImmutableId { get; set; }

    [JsonPropertyName("provisionedByResourceId")]
    public string? ProvisionedByResourceId { get; set; }
}

/// <summary>Storage version of v1api20230311.StorageBlob_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusReferencesEnrichmentDataStorageBlobs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobUrl")]
    public string? BlobUrl { get; set; }

    [JsonPropertyName("lookupType")]
    public string? LookupType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.EnrichmentData_STATUS
/// All the enrichment data sources referenced in data flows
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusReferencesEnrichmentData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageBlobs")]
    public IList<V1api20230311storageDataCollectionRuleStatusReferencesEnrichmentDataStorageBlobs>? StorageBlobs { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ReferencesSpec_STATUS
/// This section defines all the references that may be used in other sections of the DCR
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusReferences
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.EnrichmentData_STATUS
    /// All the enrichment data sources referenced in data flows
    /// </summary>
    [JsonPropertyName("enrichmentData")]
    public V1api20230311storageDataCollectionRuleStatusReferencesEnrichmentData? EnrichmentData { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.ColumnDefinition_STATUS
/// Definition of custom data column.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusStreamDeclarationsColumns
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.StreamDeclaration_STATUS
/// Declaration of a custom stream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusStreamDeclarations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("columns")]
    public IList<V1api20230311storageDataCollectionRuleStatusStreamDeclarationsColumns>? Columns { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataCollectionRuleResource_STATUS
/// Definition of ARM tracked top level resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230311storageDataCollectionRuleStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.AgentSettingsSpec_STATUS
    /// An agent setting
    /// </summary>
    [JsonPropertyName("agentSettings")]
    public V1api20230311storageDataCollectionRuleStatusAgentSettings? AgentSettings { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20230311storageDataCollectionRuleStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    [JsonPropertyName("dataFlows")]
    public IList<V1api20230311storageDataCollectionRuleStatusDataFlows>? DataFlows { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DataSourcesSpec_STATUS
    /// Specification of data sources that will be collected.
    /// </summary>
    [JsonPropertyName("dataSources")]
    public V1api20230311storageDataCollectionRuleStatusDataSources? DataSources { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DestinationsSpec_STATUS
    /// Specification of destinations that can be used in data flows.
    /// </summary>
    [JsonPropertyName("destinations")]
    public V1api20230311storageDataCollectionRuleStatusDestinations? Destinations { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.EndpointsSpec_STATUS
    /// This defines all the ingestion endpoints that can be used by this rule
    /// </summary>
    [JsonPropertyName("endpoints")]
    public V1api20230311storageDataCollectionRuleStatusEndpoints? Endpoints { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.ManagedServiceIdentity_STATUS
    /// Managed service identity (system assigned and/or user assigned identities)
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230311storageDataCollectionRuleStatusIdentity? Identity { get; set; }

    [JsonPropertyName("immutableId")]
    public string? ImmutableId { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.Metadata_STATUS
    /// Metadata about the resource
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1api20230311storageDataCollectionRuleStatusMetadata? Metadata { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.ReferencesSpec_STATUS
    /// This section defines all the references that may be used in other sections of the DCR
    /// </summary>
    [JsonPropertyName("references")]
    public V1api20230311storageDataCollectionRuleStatusReferences? References { get; set; }

    [JsonPropertyName("streamDeclarations")]
    public IDictionary<string, V1api20230311storageDataCollectionRuleStatusStreamDeclarations>? StreamDeclarations { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20230311storageDataCollectionRuleStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230311.DataCollectionRule
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2023-03-11/dataCollectionRules_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230311storageDataCollectionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230311storageDataCollectionRuleSpec?>, IStatus<V1api20230311storageDataCollectionRuleStatus?>
{
    public const string KubeApiVersion = "v1api20230311storage";
    public const string KubeKind = "DataCollectionRule";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "datacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20230311storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCollectionRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230311.DataCollectionRule_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230311storageDataCollectionRuleSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20230311.DataCollectionRuleResource_STATUS
    /// Definition of ARM tracked top level resource.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20230311storageDataCollectionRuleStatus? Status { get; set; }
}