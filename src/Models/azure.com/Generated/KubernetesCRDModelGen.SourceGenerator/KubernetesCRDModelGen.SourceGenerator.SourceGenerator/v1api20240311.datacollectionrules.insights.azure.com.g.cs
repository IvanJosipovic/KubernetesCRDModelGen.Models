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
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2024-03-11/dataCollectionRules_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240311DataCollectionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20240311DataCollectionRule>
{
    public const string KubeApiVersion = "v1api20240311";
    public const string KubeKind = "DataCollectionRuleList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "datacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20240311";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCollectionRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240311DataCollectionRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240311DataCollectionRule> Items { get; set; }
}

/// <summary>
/// Name: The name of the setting.
/// Must be part of the list of supported settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecAgentSettingsLogsNameEnum>))]
public enum V1api20240311DataCollectionRuleSpecAgentSettingsLogsNameEnum
{
    [EnumMember(Value = "MaxDiskQuotaInMB"), JsonStringEnumMemberName("MaxDiskQuotaInMB")]
    MaxDiskQuotaInMB,
    [EnumMember(Value = "Tags"), JsonStringEnumMemberName("Tags")]
    Tags,
    [EnumMember(Value = "UseTimeReceivedForForwardedEvents"), JsonStringEnumMemberName("UseTimeReceivedForForwardedEvents")]
    UseTimeReceivedForForwardedEvents
}

/// <summary>A setting used to control an agent behavior on a host machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecAgentSettingsLogs
{
    /// <summary>
    /// Name: The name of the setting.
    /// Must be part of the list of supported settings
    /// </summary>
    [JsonPropertyName("name")]
    public V1api20240311DataCollectionRuleSpecAgentSettingsLogsNameEnum? Name { get; set; }

    /// <summary>Value: The value of the setting</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>AgentSettings: Agent settings used to modify agent behavior on a given host</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecAgentSettings
{
    /// <summary>Logs: All the settings that are applicable to the logs agent (AMA)</summary>
    [JsonPropertyName("logs")]
    public IList<V1api20240311DataCollectionRuleSpecAgentSettingsLogs>? Logs { get; set; }
}

/// <summary>DataCollectionEndpointReference: The resource ID of the data collection endpoint that this rule can be used with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataCollectionEndpointReference
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

/// <summary>Definition of which streams are sent to which destinations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataFlows
{
    /// <summary>BuiltInTransform: The builtIn transform to transform stream data</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>CaptureOverflow: Flag to enable overflow column in LA destinations</summary>
    [JsonPropertyName("captureOverflow")]
    public bool? CaptureOverflow { get; set; }

    /// <summary>Destinations: List of destinations for this data flow.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>OutputStream: The output stream of the transform. Only required if the transform changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Streams: List of streams for this data flow.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>TransformKql: The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>EventHub: Definition of Event Hub configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesDataImportsEventHub
{
    /// <summary>ConsumerGroup: Event Hub consumer group name</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Stream: The stream to collect from EventHub</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>DataImports: Specifications of pull based data sources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesDataImports
{
    /// <summary>EventHub: Definition of Event Hub configuration.</summary>
    [JsonPropertyName("eventHub")]
    public V1api20240311DataCollectionRuleSpecDataSourcesDataImportsEventHub? EventHub { get; set; }
}

/// <summary>LogLevel: Minimal level of detail to be logged</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersLogLevelEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersLogLevelEnum
{
    [EnumMember(Value = "Critical"), JsonStringEnumMemberName("Critical")]
    Critical,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Informational"), JsonStringEnumMemberName("Informational")]
    Informational,
    [EnumMember(Value = "Verbose"), JsonStringEnumMemberName("Verbose")]
    Verbose,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning
}

/// <summary>ProviderType: Provider type specification: By Manifest GUID or by Event Source name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersProviderTypeEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersProviderTypeEnum
{
    [EnumMember(Value = "EventSource"), JsonStringEnumMemberName("EventSource")]
    EventSource,
    [EnumMember(Value = "Manifest"), JsonStringEnumMemberName("Manifest")]
    Manifest
}

/// <summary>Enables an ETW provider logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesEtwProviders
{
    /// <summary>EventIds: Events Ids to collect</summary>
    [JsonPropertyName("eventIds")]
    public IList<string>? EventIds { get; set; }

    /// <summary>Keyword: Event&apos;s membership in a set of event categories</summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>LogLevel: Minimal level of detail to be logged</summary>
    [JsonPropertyName("logLevel")]
    public V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersLogLevelEnum? LogLevel { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Provider: The provider GUID or class name for event source</summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>ProviderType: Provider type specification: By Manifest GUID or by Event Source name</summary>
    [JsonPropertyName("providerType")]
    public required V1api20240311DataCollectionRuleSpecDataSourcesEtwProvidersProviderTypeEnum ProviderType { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }
}

/// <summary>
/// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor
/// Agent.
/// Collected from either Windows and Linux machines, depending on which extension is defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesExtensions
{
    /// <summary>ExtensionName: The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public required string ExtensionName { get; set; }

    /// <summary>ExtensionSettings: The extension settings. The format is specific for particular extension.</summary>
    [JsonPropertyName("extensionSettings")]
    public IDictionary<string, JsonNode>? ExtensionSettings { get; set; }

    /// <summary>InputDataSources: The list of data sources this extension needs data from.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Enables IIS logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesIisLogs
{
    /// <summary>LogDirectories: Absolute paths file location</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: IIS streams</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>Format: The data format of the log files</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesLogFilesFormatEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesLogFilesFormatEnum
{
    [EnumMember(Value = "json"), JsonStringEnumMemberName("json")]
    Json,
    [EnumMember(Value = "text"), JsonStringEnumMemberName("text")]
    Text
}

/// <summary>RecordStartTimestampFormat: One of the supported timestamp formats</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettingsTextRecordStartTimestampFormatEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettingsTextRecordStartTimestampFormatEnum
{
    [EnumMember(Value = "dd/MMM/yyyy:HH:mm:ss zzz"), JsonStringEnumMemberName("dd/MMM/yyyy:HH:mm:ss zzz")]
    DdMMMYyyyHHMmSsZzz,
    [EnumMember(Value = "ddMMyy HH:mm:ss"), JsonStringEnumMemberName("ddMMyy HH:mm:ss")]
    DdMMyyHHMmSs,
    [EnumMember(Value = "ISO 8601"), JsonStringEnumMemberName("ISO 8601")]
    ISO8601,
    [EnumMember(Value = "M/D/YYYY HH:MM:SS AM/PM"), JsonStringEnumMemberName("M/D/YYYY HH:MM:SS AM/PM")]
    MDYYYYHhMmSsAmPm,
    [EnumMember(Value = "MMM d hh:mm:ss"), JsonStringEnumMemberName("MMM d hh:mm:ss")]
    MMMDHhMmSs,
    [EnumMember(Value = "Mon DD, YYYY HH:MM:SS"), JsonStringEnumMemberName("Mon DD, YYYY HH:MM:SS")]
    MonDdYYYYHhMmSs,
    [EnumMember(Value = "YYYY-MM-DD HH:MM:SS"), JsonStringEnumMemberName("YYYY-MM-DD HH:MM:SS")]
    YYYYMMDDHhMmSs,
    [EnumMember(Value = "yyMMdd HH:mm:ss"), JsonStringEnumMemberName("yyMMdd HH:mm:ss")]
    YyMMddHHMmSs,
    [EnumMember(Value = "yyyy-MM-ddTHH:mm:ssK"), JsonStringEnumMemberName("yyyy-MM-ddTHH:mm:ssK")]
    YyyyMMDdTHHmmssK
}

/// <summary>Text: Text settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettingsText
{
    /// <summary>RecordStartTimestampFormat: One of the supported timestamp formats</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public required V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettingsTextRecordStartTimestampFormatEnum RecordStartTimestampFormat { get; set; }
}

/// <summary>Settings: The log files specific settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettings
{
    /// <summary>Text: Text settings</summary>
    [JsonPropertyName("text")]
    public V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettingsText? Text { get; set; }
}

/// <summary>Definition of which custom log files will be collected by this data collection rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesLogFiles
{
    /// <summary>FilePatterns: File Patterns where the log files are located</summary>
    [JsonPropertyName("filePatterns")]
    public required IList<string> FilePatterns { get; set; }

    /// <summary>Format: The data format of the log files</summary>
    [JsonPropertyName("format")]
    public required V1api20240311DataCollectionRuleSpecDataSourcesLogFilesFormatEnum Format { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings: The log files specific settings.</summary>
    [JsonPropertyName("settings")]
    public V1api20240311DataCollectionRuleSpecDataSourcesLogFilesSettings? Settings { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data source
    /// </summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelLogsResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesOtelLogsStreamsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesOtelLogsStreamsEnum
{
    [EnumMember(Value = "Microsoft-OTel-Logs"), JsonStringEnumMemberName("Microsoft-OTel-Logs")]
    MicrosoftOTelLogs
}

/// <summary>Enables Otel logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelLogs
{
    /// <summary>EnrichWithReference: Specifies the reference alias to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleSpecDataSourcesOtelLogsResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public required IList<V1api20240311DataCollectionRuleSpecDataSourcesOtelLogsStreamsEnum> Streams { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelMetricsResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

/// <summary>Definition of OTel metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelMetrics
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleSpecDataSourcesOtelMetricsResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelTracesResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesOtelTracesStreamsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesOtelTracesStreamsEnum
{
    [EnumMember(Value = "Microsoft-OTel-Traces-Events"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Events")]
    MicrosoftOTelTracesEvents,
    [EnumMember(Value = "Microsoft-OTel-Traces-Resources"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Resources")]
    MicrosoftOTelTracesResources,
    [EnumMember(Value = "Microsoft-OTel-Traces-Spans"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Spans")]
    MicrosoftOTelTracesSpans
}

/// <summary>Enables Otel Traces to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesOtelTraces
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleSpecDataSourcesOtelTracesResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public required IList<V1api20240311DataCollectionRuleSpecDataSourcesOtelTracesStreamsEnum> Streams { get; set; }
}

/// <summary>
/// Definition of which performance counters will be collected and how they will be collected by this data collection
/// rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCounters
{
    /// <summary>
    /// CounterSpecifiers: A list of specifier names of the performance counters you want to collect.
    /// Use a wildcard (*) to collect a counter for all instances.
    /// To get a list of performance counters on Windows, run the command &apos;typeperf&apos;.
    /// </summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SamplingFrequencyInSeconds: The number of seconds between consecutive counter measurements (samples).</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCountersOTelStreamsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCountersOTelStreamsEnum
{
    [EnumMember(Value = "Microsoft-OtelPerfMetrics"), JsonStringEnumMemberName("Microsoft-OtelPerfMetrics")]
    MicrosoftOtelPerfMetrics
}

/// <summary>
/// Definition of which Open Telemetry performance counters will be collected and how they will be collected by this data
/// collection rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCountersOTel
{
    /// <summary>CounterSpecifiers: A list of specifier names of the performance counters you want to collect.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SamplingFrequencyInSeconds: The number of seconds between consecutive counter measurements (samples).</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCountersOTelStreamsEnum>? Streams { get; set; }
}

/// <summary>Definition of platform telemetry data source configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesPlatformTelemetry
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of platform telemetry streams to collect</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }
}

/// <summary>Definition of Prometheus metrics forwarding configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesPrometheusForwarder
{
    /// <summary>CustomVMScrapeConfig: Custom VM Scrape Config that defines scrape jobs</summary>
    [JsonPropertyName("customVMScrapeConfig")]
    public IList<IDictionary<string, JsonNode>>? CustomVMScrapeConfig { get; set; }

    /// <summary>
    /// LabelIncludeFilter: The list of label inclusion filters in the form of label &quot;name-value&quot; pairs.
    /// Currently only one label is supported: &apos;microsoft_metrics_include_label&apos;.
    /// Label values are matched case-insensitively.
    /// </summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IDictionary<string, string>? LabelIncludeFilter { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesSyslogFacilityNamesEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesSyslogFacilityNamesEnum
{
    [EnumMember(Value = "alert"), JsonStringEnumMemberName("alert")]
    Alert,
    [EnumMember(Value = "audit"), JsonStringEnumMemberName("audit")]
    Audit,
    [EnumMember(Value = "auth"), JsonStringEnumMemberName("auth")]
    Auth,
    [EnumMember(Value = "authpriv"), JsonStringEnumMemberName("authpriv")]
    Authpriv,
    [EnumMember(Value = "clock"), JsonStringEnumMemberName("clock")]
    Clock,
    [EnumMember(Value = "cron"), JsonStringEnumMemberName("cron")]
    Cron,
    [EnumMember(Value = "daemon"), JsonStringEnumMemberName("daemon")]
    Daemon,
    [EnumMember(Value = "ftp"), JsonStringEnumMemberName("ftp")]
    Ftp,
    [EnumMember(Value = "kern"), JsonStringEnumMemberName("kern")]
    Kern,
    [EnumMember(Value = "local0"), JsonStringEnumMemberName("local0")]
    Local0,
    [EnumMember(Value = "local1"), JsonStringEnumMemberName("local1")]
    Local1,
    [EnumMember(Value = "local2"), JsonStringEnumMemberName("local2")]
    Local2,
    [EnumMember(Value = "local3"), JsonStringEnumMemberName("local3")]
    Local3,
    [EnumMember(Value = "local4"), JsonStringEnumMemberName("local4")]
    Local4,
    [EnumMember(Value = "local5"), JsonStringEnumMemberName("local5")]
    Local5,
    [EnumMember(Value = "local6"), JsonStringEnumMemberName("local6")]
    Local6,
    [EnumMember(Value = "local7"), JsonStringEnumMemberName("local7")]
    Local7,
    [EnumMember(Value = "lpr"), JsonStringEnumMemberName("lpr")]
    Lpr,
    [EnumMember(Value = "mail"), JsonStringEnumMemberName("mail")]
    Mail,
    [EnumMember(Value = "mark"), JsonStringEnumMemberName("mark")]
    Mark,
    [EnumMember(Value = "news"), JsonStringEnumMemberName("news")]
    News,
    [EnumMember(Value = "nopri"), JsonStringEnumMemberName("nopri")]
    Nopri,
    [EnumMember(Value = "ntp"), JsonStringEnumMemberName("ntp")]
    Ntp,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option23,
    [EnumMember(Value = "syslog"), JsonStringEnumMemberName("syslog")]
    Syslog,
    [EnumMember(Value = "user"), JsonStringEnumMemberName("user")]
    User,
    [EnumMember(Value = "uucp"), JsonStringEnumMemberName("uucp")]
    Uucp
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesSyslogLogLevelsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesSyslogLogLevelsEnum
{
    [EnumMember(Value = "Alert"), JsonStringEnumMemberName("Alert")]
    Alert,
    [EnumMember(Value = "Critical"), JsonStringEnumMemberName("Critical")]
    Critical,
    [EnumMember(Value = "Debug"), JsonStringEnumMemberName("Debug")]
    Debug,
    [EnumMember(Value = "Emergency"), JsonStringEnumMemberName("Emergency")]
    Emergency,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Notice"), JsonStringEnumMemberName("Notice")]
    Notice,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option7,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning
}

/// <summary>
/// Definition of which syslog data will be collected and how it will be collected.
/// Only collected from Linux machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesSyslog
{
    /// <summary>FacilityNames: The list of facility names.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesSyslogFacilityNamesEnum>? FacilityNames { get; set; }

    /// <summary>LogLevels: The log levels to collect.</summary>
    [JsonPropertyName("logLevels")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesSyslogLogLevelsEnum>? LogLevels { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Definition of which Windows Event Log events will be collected and how they will be collected.
/// Only collected from
/// Windows machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesWindowsEventLogs
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }

    /// <summary>XPathQueries: A list of Windows Event Log queries in XPATH format.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDataSourcesWindowsFirewallLogsProfileFilterEnum>))]
public enum V1api20240311DataCollectionRuleSpecDataSourcesWindowsFirewallLogsProfileFilterEnum
{
    [EnumMember(Value = "Domain"), JsonStringEnumMemberName("Domain")]
    Domain,
    [EnumMember(Value = "Private"), JsonStringEnumMemberName("Private")]
    Private,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>Enables Firewall logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSourcesWindowsFirewallLogs
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProfileFilter: Firewall logs profile filter</summary>
    [JsonPropertyName("profileFilter")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesWindowsFirewallLogsProfileFilterEnum>? ProfileFilter { get; set; }

    /// <summary>Streams: Firewall logs streams</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }
}

/// <summary>
/// DataSources: The specification of data sources.
/// This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDataSources
{
    /// <summary>DataImports: Specifications of pull based data sources</summary>
    [JsonPropertyName("dataImports")]
    public V1api20240311DataCollectionRuleSpecDataSourcesDataImports? DataImports { get; set; }

    /// <summary>EtwProviders: The list of ETW providers data source configurations.</summary>
    [JsonPropertyName("etwProviders")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesEtwProviders>? EtwProviders { get; set; }

    /// <summary>Extensions: The list of Azure VM extension data source configurations.</summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesExtensions>? Extensions { get; set; }

    /// <summary>IisLogs: The list of IIS logs source configurations.</summary>
    [JsonPropertyName("iisLogs")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesIisLogs>? IisLogs { get; set; }

    /// <summary>LogFiles: The list of Log files source configurations.</summary>
    [JsonPropertyName("logFiles")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesLogFiles>? LogFiles { get; set; }

    /// <summary>OtelLogs: The list of Otel Logs data source configurations.</summary>
    [JsonPropertyName("otelLogs")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesOtelLogs>? OtelLogs { get; set; }

    /// <summary>OtelMetrics: The list of OTel metrics data source configurations.</summary>
    [JsonPropertyName("otelMetrics")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesOtelMetrics>? OtelMetrics { get; set; }

    /// <summary>OtelTraces: The list of Otel traces data source configurations.</summary>
    [JsonPropertyName("otelTraces")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesOtelTraces>? OtelTraces { get; set; }

    /// <summary>PerformanceCounters: The list of performance counter data source configurations.</summary>
    [JsonPropertyName("performanceCounters")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCounters>? PerformanceCounters { get; set; }

    /// <summary>PerformanceCountersOTel: The list of Open Telemetry performance counter data source configurations.</summary>
    [JsonPropertyName("performanceCountersOTel")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesPerformanceCountersOTel>? PerformanceCountersOTel { get; set; }

    /// <summary>PlatformTelemetry: The list of platform telemetry configurations</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>PrometheusForwarder: The list of Prometheus forwarder data source configurations.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>Syslog: The list of Syslog data source configurations.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>WindowsEventLogs: The list of Windows Event Log data source configurations.</summary>
    [JsonPropertyName("windowsEventLogs")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesWindowsEventLogs>? WindowsEventLogs { get; set; }

    /// <summary>WindowsFirewallLogs: The list of Windows Firewall logs source configurations.</summary>
    [JsonPropertyName("windowsFirewallLogs")]
    public IList<V1api20240311DataCollectionRuleSpecDataSourcesWindowsFirewallLogs>? WindowsFirewallLogs { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the Adx resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsAzureDataExplorerResourceReference
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

/// <summary>Azure Data Explorer (Adx) destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsAzureDataExplorer
{
    /// <summary>DatabaseName: The name of the database to which data will be ingested.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the Adx resource.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsAzureDataExplorerResourceReference? ResourceReference { get; set; }
}

/// <summary>AzureMonitorMetrics: Azure Monitor Metrics destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsAzureMonitorMetrics
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsEventHubsEventHubResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsEventHubs
{
    /// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsEventHubsEventHubResourceReference? EventHubResourceReference { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsEventHubsDirectEventHubResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsEventHubsDirect
{
    /// <summary>EventHubResourceReference: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsEventHubsDirectEventHubResourceReference? EventHubResourceReference { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>WorkspaceResourceReference: The resource ID of the Log Analytics workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsLogAnalyticsWorkspaceResourceReference
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

/// <summary>Log Analytics destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsLogAnalytics
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WorkspaceResourceReference: The resource ID of the Log Analytics workspace.</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsLogAnalyticsWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>Microsoft Fabric destination (non-Azure).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsMicrosoftFabric
{
    /// <summary>ArtifactId: The artifact id of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>DatabaseName: The name of the database to which data will be ingested.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>IngestionUri: The ingestion uri of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>TenantId: The tenant id of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>AccountResourceReference: The resource ID of the monitoring account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsMonitoringAccountsAccountResourceReference
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

/// <summary>Monitoring account destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsMonitoringAccounts
{
    /// <summary>AccountResourceReference: The resource ID of the monitoring account.</summary>
    [JsonPropertyName("accountResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsMonitoringAccountsAccountResourceReference? AccountResourceReference { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageAccountsStorageAccountResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageAccounts
{
    /// <summary>ContainerName: The container name of the Storage Blob.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsStorageAccountsStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageBlobsDirectStorageAccountResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageBlobsDirect
{
    /// <summary>ContainerName: The container name of the Storage Blob.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsStorageBlobsDirectStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageTablesDirectStorageAccountResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinationsStorageTablesDirect
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20240311DataCollectionRuleSpecDestinationsStorageTablesDirectStorageAccountResourceReference? StorageAccountResourceReference { get; set; }

    /// <summary>TableName: The name of the Storage Table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Destinations: The specification of destinations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDestinations
{
    /// <summary>AzureDataExplorer: List of Azure Data Explorer destinations.</summary>
    [JsonPropertyName("azureDataExplorer")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsAzureDataExplorer>? AzureDataExplorer { get; set; }

    /// <summary>AzureMonitorMetrics: Azure Monitor Metrics destination.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1api20240311DataCollectionRuleSpecDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>EventHubs: List of Event Hubs destinations.</summary>
    [JsonPropertyName("eventHubs")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsEventHubs>? EventHubs { get; set; }

    /// <summary>EventHubsDirect: List of Event Hubs Direct destinations.</summary>
    [JsonPropertyName("eventHubsDirect")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsEventHubsDirect>? EventHubsDirect { get; set; }

    /// <summary>LogAnalytics: List of Log Analytics destinations.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>MicrosoftFabric: List of Microsoft Fabric destinations.</summary>
    [JsonPropertyName("microsoftFabric")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsMicrosoftFabric>? MicrosoftFabric { get; set; }

    /// <summary>MonitoringAccounts: List of monitoring account destinations.</summary>
    [JsonPropertyName("monitoringAccounts")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsMonitoringAccounts>? MonitoringAccounts { get; set; }

    /// <summary>StorageAccounts: List of storage accounts destinations.</summary>
    [JsonPropertyName("storageAccounts")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsStorageAccounts>? StorageAccounts { get; set; }

    /// <summary>
    /// StorageBlobsDirect: List of Storage Blob Direct destinations. To be used only for sending data directly to store from
    /// the agent.
    /// </summary>
    [JsonPropertyName("storageBlobsDirect")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsStorageBlobsDirect>? StorageBlobsDirect { get; set; }

    /// <summary>StorageTablesDirect: List of Storage Table Direct destinations.</summary>
    [JsonPropertyName("storageTablesDirect")]
    public IList<V1api20240311DataCollectionRuleSpecDestinationsStorageTablesDirect>? StorageTablesDirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelLogsStreamsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelLogsStreamsEnum
{
    [EnumMember(Value = "Microsoft-OTel-Logs"), JsonStringEnumMemberName("Microsoft-OTel-Logs")]
    MicrosoftOTelLogs
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelLogs
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public required IList<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelLogsStreamsEnum> Streams { get; set; }
}

/// <summary>Definition of OTel metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelMetrics
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public required IList<string> Streams { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelTracesStreamsEnum>))]
public enum V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelTracesStreamsEnum
{
    [EnumMember(Value = "Microsoft-OTel-Traces-Events"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Events")]
    MicrosoftOTelTracesEvents,
    [EnumMember(Value = "Microsoft-OTel-Traces-Resources"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Resources")]
    MicrosoftOTelTracesResources,
    [EnumMember(Value = "Microsoft-OTel-Traces-Spans"), JsonStringEnumMemberName("Microsoft-OTel-Traces-Spans")]
    MicrosoftOTelTracesSpans
}

/// <summary>Enables Otel Traces to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelTraces
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public required IList<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelTracesStreamsEnum> Streams { get; set; }
}

/// <summary>
/// DirectDataSources: The specification of direct data sources.
/// This property is optional and can be omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecDirectDataSources
{
    /// <summary>OtelLogs: The list of OTel logs data source configurations.</summary>
    [JsonPropertyName("otelLogs")]
    public IList<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelLogs>? OtelLogs { get; set; }

    /// <summary>OtelMetrics: The list of OTel metrics data source configurations.</summary>
    [JsonPropertyName("otelMetrics")]
    public IList<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelMetrics>? OtelMetrics { get; set; }

    /// <summary>OtelTraces: The list of OTel traces data source configurations.</summary>
    [JsonPropertyName("otelTraces")]
    public IList<V1api20240311DataCollectionRuleSpecDirectDataSourcesOtelTraces>? OtelTraces { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecIdentityTypeEnum>))]
public enum V1api20240311DataCollectionRuleSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240311DataCollectionRuleSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V1api20240311DataCollectionRuleSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240311DataCollectionRuleSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Kind: The kind of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecKindEnum>))]
public enum V1api20240311DataCollectionRuleSpecKindEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecOperatorSpecSecretExpressions
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
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240311DataCollectionRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240311DataCollectionRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference: Id of the application insights resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferencesApplicationInsightsResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferencesApplicationInsights
{
    /// <summary>Name: The name of the reference used as an alias when referencing this application insights in Otel data sources</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>ResourceReference: Id of the application insights resource</summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20240311DataCollectionRuleSpecReferencesApplicationInsightsResourceReference ResourceReference { get; set; }
}

/// <summary>LookupType: The type of lookup to perform on the blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsLookupTypeEnum>))]
public enum V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsLookupTypeEnum
{
    [EnumMember(Value = "Cidr"), JsonStringEnumMemberName("Cidr")]
    Cidr,
    [EnumMember(Value = "String"), JsonStringEnumMemberName("String")]
    String
}

/// <summary>ResourceReference: Resource Id of the storage account that hosts the blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobs
{
    /// <summary>BlobUrl: Url of the storage blob</summary>
    [JsonPropertyName("blobUrl")]
    public string? BlobUrl { get; set; }

    /// <summary>LookupType: The type of lookup to perform on the blob</summary>
    [JsonPropertyName("lookupType")]
    public V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsLookupTypeEnum? LookupType { get; set; }

    /// <summary>Name: The name of the enrichment data source used as an alias when referencing this data source in data flows</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceReference: Resource Id of the storage account that hosts the blob</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobsResourceReference? ResourceReference { get; set; }
}

/// <summary>EnrichmentData: All the enrichment data sources referenced in data flows</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferencesEnrichmentData
{
    /// <summary>StorageBlobs: All the storage blobs used as enrichment data sources</summary>
    [JsonPropertyName("storageBlobs")]
    public IList<V1api20240311DataCollectionRuleSpecReferencesEnrichmentDataStorageBlobs>? StorageBlobs { get; set; }
}

/// <summary>References: Defines all the references that may be used in other sections of the DCR</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecReferences
{
    /// <summary>ApplicationInsights: Application Insights references to be used on OTel metrics/logs enrichment</summary>
    [JsonPropertyName("applicationInsights")]
    public IList<V1api20240311DataCollectionRuleSpecReferencesApplicationInsights>? ApplicationInsights { get; set; }

    /// <summary>EnrichmentData: All the enrichment data sources referenced in data flows</summary>
    [JsonPropertyName("enrichmentData")]
    public V1api20240311DataCollectionRuleSpecReferencesEnrichmentData? EnrichmentData { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not  required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecSkuTierEnum>))]
public enum V1api20240311DataCollectionRuleSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The SKU of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. E.g. P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20240311DataCollectionRuleSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>Type: The type of the column data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240311DataCollectionRuleSpecStreamDeclarationsColumnsTypeEnum>))]
public enum V1api20240311DataCollectionRuleSpecStreamDeclarationsColumnsTypeEnum
{
    [EnumMember(Value = "boolean"), JsonStringEnumMemberName("boolean")]
    Boolean,
    [EnumMember(Value = "datetime"), JsonStringEnumMemberName("datetime")]
    Datetime,
    [EnumMember(Value = "dynamic"), JsonStringEnumMemberName("dynamic")]
    Dynamic,
    [EnumMember(Value = "int"), JsonStringEnumMemberName("int")]
    Int,
    [EnumMember(Value = "long"), JsonStringEnumMemberName("long")]
    Long,
    [EnumMember(Value = "real"), JsonStringEnumMemberName("real")]
    Real,
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    String
}

/// <summary>Definition of custom data column.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecStreamDeclarationsColumns
{
    /// <summary>Name: The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the column data.</summary>
    [JsonPropertyName("type")]
    public V1api20240311DataCollectionRuleSpecStreamDeclarationsColumnsTypeEnum? Type { get; set; }
}

/// <summary>Declaration of a custom stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpecStreamDeclarations
{
    /// <summary>Columns: List of columns used by data in this stream.</summary>
    [JsonPropertyName("columns")]
    public IList<V1api20240311DataCollectionRuleSpecStreamDeclarationsColumns>? Columns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleSpec
{
    /// <summary>AgentSettings: Agent settings used to modify agent behavior on a given host</summary>
    [JsonPropertyName("agentSettings")]
    public V1api20240311DataCollectionRuleSpecAgentSettings? AgentSettings { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DataCollectionEndpointReference: The resource ID of the data collection endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointReference")]
    public V1api20240311DataCollectionRuleSpecDataCollectionEndpointReference? DataCollectionEndpointReference { get; set; }

    /// <summary>DataFlows: The specification of data flows.</summary>
    [JsonPropertyName("dataFlows")]
    public IList<V1api20240311DataCollectionRuleSpecDataFlows>? DataFlows { get; set; }

    /// <summary>
    /// DataSources: The specification of data sources.
    /// This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned
    /// endpoint.
    /// </summary>
    [JsonPropertyName("dataSources")]
    public V1api20240311DataCollectionRuleSpecDataSources? DataSources { get; set; }

    /// <summary>Description: Description of the data collection rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destinations: The specification of destinations.</summary>
    [JsonPropertyName("destinations")]
    public V1api20240311DataCollectionRuleSpecDestinations? Destinations { get; set; }

    /// <summary>
    /// DirectDataSources: The specification of direct data sources.
    /// This property is optional and can be omitted.
    /// </summary>
    [JsonPropertyName("directDataSources")]
    public V1api20240311DataCollectionRuleSpecDirectDataSources? DirectDataSources { get; set; }

    /// <summary>Identity: Managed service identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240311DataCollectionRuleSpecIdentity? Identity { get; set; }

    /// <summary>Kind: The kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public V1api20240311DataCollectionRuleSpecKindEnum? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240311DataCollectionRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240311DataCollectionRuleSpecOwner Owner { get; set; }

    /// <summary>References: Defines all the references that may be used in other sections of the DCR</summary>
    [JsonPropertyName("references")]
    public V1api20240311DataCollectionRuleSpecReferences? References { get; set; }

    /// <summary>Sku: The SKU of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20240311DataCollectionRuleSpecSku? Sku { get; set; }

    /// <summary>StreamDeclarations: Declaration of custom streams used in this rule.</summary>
    [JsonPropertyName("streamDeclarations")]
    public IDictionary<string, V1api20240311DataCollectionRuleSpecStreamDeclarations>? StreamDeclarations { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A setting used to control an agent behavior on a host machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusAgentSettingsLogs
{
    /// <summary>
    /// Name: The name of the setting.
    /// Must be part of the list of supported settings
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The value of the setting</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>AgentSettings: Agent settings used to modify agent behavior on a given host</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusAgentSettings
{
    /// <summary>Logs: All the settings that are applicable to the logs agent (AMA)</summary>
    [JsonPropertyName("logs")]
    public IList<V1api20240311DataCollectionRuleStatusAgentSettingsLogs>? Logs { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusConditions
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

/// <summary>Definition of which streams are sent to which destinations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataFlows
{
    /// <summary>BuiltInTransform: The builtIn transform to transform stream data</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>CaptureOverflow: Flag to enable overflow column in LA destinations</summary>
    [JsonPropertyName("captureOverflow")]
    public bool? CaptureOverflow { get; set; }

    /// <summary>Destinations: List of destinations for this data flow.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>OutputStream: The output stream of the transform. Only required if the transform changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Streams: List of streams for this data flow.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>TransformKql: The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>EventHub: Definition of Event Hub configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesDataImportsEventHub
{
    /// <summary>ConsumerGroup: Event Hub consumer group name</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Stream: The stream to collect from EventHub</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>DataImports: Specifications of pull based data sources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesDataImports
{
    /// <summary>EventHub: Definition of Event Hub configuration.</summary>
    [JsonPropertyName("eventHub")]
    public V1api20240311DataCollectionRuleStatusDataSourcesDataImportsEventHub? EventHub { get; set; }
}

/// <summary>Enables an ETW provider logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesEtwProviders
{
    /// <summary>EventIds: Events Ids to collect</summary>
    [JsonPropertyName("eventIds")]
    public IList<string>? EventIds { get; set; }

    /// <summary>Keyword: Event&apos;s membership in a set of event categories</summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>LogLevel: Minimal level of detail to be logged</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Provider: The provider GUID or class name for event source</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>ProviderType: Provider type specification: By Manifest GUID or by Event Source name</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor
/// Agent.
/// Collected from either Windows and Linux machines, depending on which extension is defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesExtensions
{
    /// <summary>ExtensionName: The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>ExtensionSettings: The extension settings. The format is specific for particular extension.</summary>
    [JsonPropertyName("extensionSettings")]
    public IDictionary<string, JsonNode>? ExtensionSettings { get; set; }

    /// <summary>InputDataSources: The list of data sources this extension needs data from.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Enables IIS logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesIisLogs
{
    /// <summary>LogDirectories: Absolute paths file location</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: IIS streams</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>Text: Text settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesLogFilesSettingsText
{
    /// <summary>RecordStartTimestampFormat: One of the supported timestamp formats</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>Settings: The log files specific settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesLogFilesSettings
{
    /// <summary>Text: Text settings</summary>
    [JsonPropertyName("text")]
    public V1api20240311DataCollectionRuleStatusDataSourcesLogFilesSettingsText? Text { get; set; }
}

/// <summary>Definition of which custom log files will be collected by this data collection rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesLogFiles
{
    /// <summary>FilePatterns: File Patterns where the log files are located</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>Format: The data format of the log files</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings: The log files specific settings.</summary>
    [JsonPropertyName("settings")]
    public V1api20240311DataCollectionRuleStatusDataSourcesLogFilesSettings? Settings { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data source
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelLogsResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

/// <summary>Enables Otel logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelLogs
{
    /// <summary>EnrichWithReference: Specifies the reference alias to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleStatusDataSourcesOtelLogsResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelMetricsResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

/// <summary>Definition of OTel metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelMetrics
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleStatusDataSourcesOtelMetricsResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
/// payload according to matching resource attribute.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelTracesResourceAttributeRouting
{
    /// <summary>AttributeName: The name of the resource attribute to match.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>AttributeValue: The value of the resource attribute to match.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

/// <summary>Enables Otel Traces to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesOtelTraces
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// ResourceAttributeRouting: Specifies the routing policy based on OTLP payload resource attributes to route subset of the
    /// payload according to matching resource attribute.
    /// </summary>
    [JsonPropertyName("resourceAttributeRouting")]
    public V1api20240311DataCollectionRuleStatusDataSourcesOtelTracesResourceAttributeRouting? ResourceAttributeRouting { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Definition of which performance counters will be collected and how they will be collected by this data collection
/// rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesPerformanceCounters
{
    /// <summary>
    /// CounterSpecifiers: A list of specifier names of the performance counters you want to collect.
    /// Use a wildcard (*) to collect a counter for all instances.
    /// To get a list of performance counters on Windows, run the command &apos;typeperf&apos;.
    /// </summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SamplingFrequencyInSeconds: The number of seconds between consecutive counter measurements (samples).</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Definition of which Open Telemetry performance counters will be collected and how they will be collected by this data
/// collection rule.
/// Collected from both Windows and Linux machines where the counter is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesPerformanceCountersOTel
{
    /// <summary>CounterSpecifiers: A list of specifier names of the performance counters you want to collect.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SamplingFrequencyInSeconds: The number of seconds between consecutive counter measurements (samples).</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public int? SamplingFrequencyInSeconds { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Definition of platform telemetry data source configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesPlatformTelemetry
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of platform telemetry streams to collect</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Definition of Prometheus metrics forwarding configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesPrometheusForwarder
{
    /// <summary>CustomVMScrapeConfig: Custom VM Scrape Config that defines scrape jobs</summary>
    [JsonPropertyName("customVMScrapeConfig")]
    public IList<IDictionary<string, JsonNode>>? CustomVMScrapeConfig { get; set; }

    /// <summary>
    /// LabelIncludeFilter: The list of label inclusion filters in the form of label &quot;name-value&quot; pairs.
    /// Currently only one label is supported: &apos;microsoft_metrics_include_label&apos;.
    /// Label values are matched case-insensitively.
    /// </summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IDictionary<string, string>? LabelIncludeFilter { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// Definition of which syslog data will be collected and how it will be collected.
/// Only collected from Linux machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesSyslog
{
    /// <summary>FacilityNames: The list of facility names.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>LogLevels: The log levels to collect.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary>
/// Definition of which Windows Event Log events will be collected and how they will be collected.
/// Only collected from
/// Windows machines.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesWindowsEventLogs
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>
    /// TransformKql: The KQL query to transform the data source. This is a deprecated property and will be removed in future
    /// versions.
    /// </summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }

    /// <summary>XPathQueries: A list of Windows Event Log queries in XPATH format.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary>Enables Firewall logs to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSourcesWindowsFirewallLogs
{
    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProfileFilter: Firewall logs profile filter</summary>
    [JsonPropertyName("profileFilter")]
    public IList<string>? ProfileFilter { get; set; }

    /// <summary>Streams: Firewall logs streams</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// DataSources: The specification of data sources.
/// This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDataSources
{
    /// <summary>DataImports: Specifications of pull based data sources</summary>
    [JsonPropertyName("dataImports")]
    public V1api20240311DataCollectionRuleStatusDataSourcesDataImports? DataImports { get; set; }

    /// <summary>EtwProviders: The list of ETW providers data source configurations.</summary>
    [JsonPropertyName("etwProviders")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesEtwProviders>? EtwProviders { get; set; }

    /// <summary>Extensions: The list of Azure VM extension data source configurations.</summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesExtensions>? Extensions { get; set; }

    /// <summary>IisLogs: The list of IIS logs source configurations.</summary>
    [JsonPropertyName("iisLogs")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesIisLogs>? IisLogs { get; set; }

    /// <summary>LogFiles: The list of Log files source configurations.</summary>
    [JsonPropertyName("logFiles")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesLogFiles>? LogFiles { get; set; }

    /// <summary>OtelLogs: The list of Otel Logs data source configurations.</summary>
    [JsonPropertyName("otelLogs")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesOtelLogs>? OtelLogs { get; set; }

    /// <summary>OtelMetrics: The list of OTel metrics data source configurations.</summary>
    [JsonPropertyName("otelMetrics")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesOtelMetrics>? OtelMetrics { get; set; }

    /// <summary>OtelTraces: The list of Otel traces data source configurations.</summary>
    [JsonPropertyName("otelTraces")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesOtelTraces>? OtelTraces { get; set; }

    /// <summary>PerformanceCounters: The list of performance counter data source configurations.</summary>
    [JsonPropertyName("performanceCounters")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesPerformanceCounters>? PerformanceCounters { get; set; }

    /// <summary>PerformanceCountersOTel: The list of Open Telemetry performance counter data source configurations.</summary>
    [JsonPropertyName("performanceCountersOTel")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesPerformanceCountersOTel>? PerformanceCountersOTel { get; set; }

    /// <summary>PlatformTelemetry: The list of platform telemetry configurations</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>PrometheusForwarder: The list of Prometheus forwarder data source configurations.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>Syslog: The list of Syslog data source configurations.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>WindowsEventLogs: The list of Windows Event Log data source configurations.</summary>
    [JsonPropertyName("windowsEventLogs")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesWindowsEventLogs>? WindowsEventLogs { get; set; }

    /// <summary>WindowsFirewallLogs: The list of Windows Firewall logs source configurations.</summary>
    [JsonPropertyName("windowsFirewallLogs")]
    public IList<V1api20240311DataCollectionRuleStatusDataSourcesWindowsFirewallLogs>? WindowsFirewallLogs { get; set; }
}

/// <summary>Azure Data Explorer (Adx) destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsAzureDataExplorer
{
    /// <summary>DatabaseName: The name of the database to which data will be ingested.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>IngestionUri: The ingestion uri of the Adx resource.</summary>
    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceId: The ARM resource id of the Adx resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>AzureMonitorMetrics: Azure Monitor Metrics destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsAzureMonitorMetrics
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsEventHubs
{
    /// <summary>EventHubResourceId: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsEventHubsDirect
{
    /// <summary>EventHubResourceId: The resource ID of the event hub.</summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Log Analytics destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsLogAnalytics
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WorkspaceId: The Customer ID of the Log Analytics workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>WorkspaceResourceId: The resource ID of the Log Analytics workspace.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }
}

/// <summary>Microsoft Fabric destination (non-Azure).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsMicrosoftFabric
{
    /// <summary>ArtifactId: The artifact id of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>DatabaseName: The name of the database to which data will be ingested.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>IngestionUri: The ingestion uri of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("ingestionUri")]
    public string? IngestionUri { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>TenantId: The tenant id of the Microsoft Fabric resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Monitoring account destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsMonitoringAccounts
{
    /// <summary>AccountId: The immutable ID of the account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>AccountResourceId: The resource ID of the monitoring account.</summary>
    [JsonPropertyName("accountResourceId")]
    public string? AccountResourceId { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsStorageAccounts
{
    /// <summary>ContainerName: The container name of the Storage Blob.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceId: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsStorageBlobsDirect
{
    /// <summary>ContainerName: The container name of the Storage Blob.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceId: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinationsStorageTablesDirect
{
    /// <summary>
    /// Name: A friendly name for the destination.
    /// This name should be unique across all destinations (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceId: The resource ID of the storage account.</summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }

    /// <summary>TableName: The name of the Storage Table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Destinations: The specification of destinations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDestinations
{
    /// <summary>AzureDataExplorer: List of Azure Data Explorer destinations.</summary>
    [JsonPropertyName("azureDataExplorer")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsAzureDataExplorer>? AzureDataExplorer { get; set; }

    /// <summary>AzureMonitorMetrics: Azure Monitor Metrics destination.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1api20240311DataCollectionRuleStatusDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>EventHubs: List of Event Hubs destinations.</summary>
    [JsonPropertyName("eventHubs")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsEventHubs>? EventHubs { get; set; }

    /// <summary>EventHubsDirect: List of Event Hubs Direct destinations.</summary>
    [JsonPropertyName("eventHubsDirect")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsEventHubsDirect>? EventHubsDirect { get; set; }

    /// <summary>LogAnalytics: List of Log Analytics destinations.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>MicrosoftFabric: List of Microsoft Fabric destinations.</summary>
    [JsonPropertyName("microsoftFabric")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsMicrosoftFabric>? MicrosoftFabric { get; set; }

    /// <summary>MonitoringAccounts: List of monitoring account destinations.</summary>
    [JsonPropertyName("monitoringAccounts")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsMonitoringAccounts>? MonitoringAccounts { get; set; }

    /// <summary>StorageAccounts: List of storage accounts destinations.</summary>
    [JsonPropertyName("storageAccounts")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsStorageAccounts>? StorageAccounts { get; set; }

    /// <summary>
    /// StorageBlobsDirect: List of Storage Blob Direct destinations. To be used only for sending data directly to store from
    /// the agent.
    /// </summary>
    [JsonPropertyName("storageBlobsDirect")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsStorageBlobsDirect>? StorageBlobsDirect { get; set; }

    /// <summary>StorageTablesDirect: List of Storage Table Direct destinations.</summary>
    [JsonPropertyName("storageTablesDirect")]
    public IList<V1api20240311DataCollectionRuleStatusDestinationsStorageTablesDirect>? StorageTablesDirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelLogs
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Definition of OTel metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelMetrics
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Streams: List of streams that this data source will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>Enables Otel Traces to be collected by this data collection rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelTraces
{
    /// <summary>EnrichWithReference: Specifies the reference to enrich the telemetry signal with.</summary>
    [JsonPropertyName("enrichWithReference")]
    public string? EnrichWithReference { get; set; }

    [JsonPropertyName("enrichWithResourceAttributes")]
    public IList<string>? EnrichWithResourceAttributes { get; set; }

    /// <summary>
    /// Name: A friendly name for the data source.
    /// This name should be unique across all data sources (regardless of type) within the data collection rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ReplaceResourceIdWithReference: Specifies whether to replace the default resourceId in the log record with the
    /// resourceId of the referenced resource being used for enrichment.
    /// </summary>
    [JsonPropertyName("replaceResourceIdWithReference")]
    public bool? ReplaceResourceIdWithReference { get; set; }

    /// <summary>
    /// Streams: List of streams that this data source will be sent to.
    /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent
    /// to.
    /// </summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>
/// DirectDataSources: The specification of direct data sources.
/// This property is optional and can be omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusDirectDataSources
{
    /// <summary>OtelLogs: The list of OTel logs data source configurations.</summary>
    [JsonPropertyName("otelLogs")]
    public IList<V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelLogs>? OtelLogs { get; set; }

    /// <summary>OtelMetrics: The list of OTel metrics data source configurations.</summary>
    [JsonPropertyName("otelMetrics")]
    public IList<V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelMetrics>? OtelMetrics { get; set; }

    /// <summary>OtelTraces: The list of OTel traces data source configurations.</summary>
    [JsonPropertyName("otelTraces")]
    public IList<V1api20240311DataCollectionRuleStatusDirectDataSourcesOtelTraces>? OtelTraces { get; set; }
}

/// <summary>Endpoints: Defines the ingestion endpoints to send data to via this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusEndpoints
{
    /// <summary>LogsIngestion: The ingestion endpoint for logs</summary>
    [JsonPropertyName("logsIngestion")]
    public string? LogsIngestion { get; set; }

    /// <summary>MetricsIngestion: The ingestion endpoint for metrics</summary>
    [JsonPropertyName("metricsIngestion")]
    public string? MetricsIngestion { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Managed service identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240311DataCollectionRuleStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusIngestionQuotasLogs
{
    [JsonPropertyName("maxRequestsPerMinute")]
    public string? MaxRequestsPerMinute { get; set; }

    [JsonPropertyName("maxSizePerMinuteInGB")]
    public string? MaxSizePerMinuteInGB { get; set; }
}

/// <summary>IngestionQuotas: The specification for ingestion limits</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusIngestionQuotas
{
    [JsonPropertyName("logs")]
    public V1api20240311DataCollectionRuleStatusIngestionQuotasLogs? Logs { get; set; }
}

/// <summary>Metadata: Metadata about the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusMetadata
{
    /// <summary>ProvisionedBy: Azure offering managing this resource on-behalf-of customer.</summary>
    [JsonPropertyName("provisionedBy")]
    public string? ProvisionedBy { get; set; }

    /// <summary>ProvisionedByImmutableId: Immutable Id of azure offering managing this resource on-behalf-of customer.</summary>
    [JsonPropertyName("provisionedByImmutableId")]
    public string? ProvisionedByImmutableId { get; set; }

    /// <summary>ProvisionedByResourceId: Resource Id of azure offering managing this resource on-behalf-of customer.</summary>
    [JsonPropertyName("provisionedByResourceId")]
    public string? ProvisionedByResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusReferencesApplicationInsights
{
    /// <summary>Name: The name of the reference used as an alias when referencing this application insights in Otel data sources</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceId: Id of the application insights resource</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusReferencesEnrichmentDataStorageBlobs
{
    /// <summary>BlobUrl: Url of the storage blob</summary>
    [JsonPropertyName("blobUrl")]
    public string? BlobUrl { get; set; }

    /// <summary>LookupType: The type of lookup to perform on the blob</summary>
    [JsonPropertyName("lookupType")]
    public string? LookupType { get; set; }

    /// <summary>Name: The name of the enrichment data source used as an alias when referencing this data source in data flows</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceId: Resource Id of the storage account that hosts the blob</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>EnrichmentData: All the enrichment data sources referenced in data flows</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusReferencesEnrichmentData
{
    /// <summary>StorageBlobs: All the storage blobs used as enrichment data sources</summary>
    [JsonPropertyName("storageBlobs")]
    public IList<V1api20240311DataCollectionRuleStatusReferencesEnrichmentDataStorageBlobs>? StorageBlobs { get; set; }
}

/// <summary>References: Defines all the references that may be used in other sections of the DCR</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusReferences
{
    /// <summary>ApplicationInsights: Application Insights references to be used on OTel metrics/logs enrichment</summary>
    [JsonPropertyName("applicationInsights")]
    public IList<V1api20240311DataCollectionRuleStatusReferencesApplicationInsights>? ApplicationInsights { get; set; }

    /// <summary>EnrichmentData: All the enrichment data sources referenced in data flows</summary>
    [JsonPropertyName("enrichmentData")]
    public V1api20240311DataCollectionRuleStatusReferencesEnrichmentData? EnrichmentData { get; set; }
}

/// <summary>Sku: The SKU of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. E.g. P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Definition of custom data column.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusStreamDeclarationsColumns
{
    /// <summary>Name: The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the column data.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Declaration of a custom stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusStreamDeclarations
{
    /// <summary>Columns: List of columns used by data in this stream.</summary>
    [JsonPropertyName("columns")]
    public IList<V1api20240311DataCollectionRuleStatusStreamDeclarationsColumns>? Columns { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Definition of ARM tracked top level resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240311DataCollectionRuleStatus
{
    /// <summary>AgentSettings: Agent settings used to modify agent behavior on a given host</summary>
    [JsonPropertyName("agentSettings")]
    public V1api20240311DataCollectionRuleStatusAgentSettings? AgentSettings { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240311DataCollectionRuleStatusConditions>? Conditions { get; set; }

    /// <summary>DataCollectionEndpointId: The resource ID of the data collection endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>DataFlows: The specification of data flows.</summary>
    [JsonPropertyName("dataFlows")]
    public IList<V1api20240311DataCollectionRuleStatusDataFlows>? DataFlows { get; set; }

    /// <summary>
    /// DataSources: The specification of data sources.
    /// This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned
    /// endpoint.
    /// </summary>
    [JsonPropertyName("dataSources")]
    public V1api20240311DataCollectionRuleStatusDataSources? DataSources { get; set; }

    /// <summary>Description: Description of the data collection rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destinations: The specification of destinations.</summary>
    [JsonPropertyName("destinations")]
    public V1api20240311DataCollectionRuleStatusDestinations? Destinations { get; set; }

    /// <summary>
    /// DirectDataSources: The specification of direct data sources.
    /// This property is optional and can be omitted.
    /// </summary>
    [JsonPropertyName("directDataSources")]
    public V1api20240311DataCollectionRuleStatusDirectDataSources? DirectDataSources { get; set; }

    /// <summary>Endpoints: Defines the ingestion endpoints to send data to via this rule.</summary>
    [JsonPropertyName("endpoints")]
    public V1api20240311DataCollectionRuleStatusEndpoints? Endpoints { get; set; }

    /// <summary>Etag: Resource entity tag (ETag).</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Fully qualified ID of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240311DataCollectionRuleStatusIdentity? Identity { get; set; }

    /// <summary>ImmutableId: The immutable ID of this data collection rule. This property is READ-ONLY.</summary>
    [JsonPropertyName("immutableId")]
    public string? ImmutableId { get; set; }

    /// <summary>IngestionQuotas: The specification for ingestion limits</summary>
    [JsonPropertyName("ingestionQuotas")]
    public V1api20240311DataCollectionRuleStatusIngestionQuotas? IngestionQuotas { get; set; }

    /// <summary>Kind: The kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Metadata: Metadata about the resource</summary>
    [JsonPropertyName("metadata")]
    public V1api20240311DataCollectionRuleStatusMetadata? Metadata { get; set; }

    /// <summary>Name: The name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The resource provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>References: Defines all the references that may be used in other sections of the DCR</summary>
    [JsonPropertyName("references")]
    public V1api20240311DataCollectionRuleStatusReferences? References { get; set; }

    /// <summary>Sku: The SKU of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20240311DataCollectionRuleStatusSku? Sku { get; set; }

    /// <summary>StreamDeclarations: Declaration of custom streams used in this rule.</summary>
    [JsonPropertyName("streamDeclarations")]
    public IDictionary<string, V1api20240311DataCollectionRuleStatusStreamDeclarations>? StreamDeclarations { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240311DataCollectionRuleStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2024-03-11/dataCollectionRules_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240311DataCollectionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240311DataCollectionRuleSpec?>, IStatus<V1api20240311DataCollectionRuleStatus?>
{
    public const string KubeApiVersion = "v1api20240311";
    public const string KubeKind = "DataCollectionRule";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "datacollectionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20240311";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCollectionRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240311DataCollectionRuleSpec? Spec { get; set; }

    /// <summary>Definition of ARM tracked top level resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240311DataCollectionRuleStatus? Status { get; set; }
}