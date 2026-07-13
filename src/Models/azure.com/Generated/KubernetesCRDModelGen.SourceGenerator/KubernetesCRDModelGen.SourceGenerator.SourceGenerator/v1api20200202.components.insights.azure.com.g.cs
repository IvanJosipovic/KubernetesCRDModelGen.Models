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
/// - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/stable/2020-02-02/components_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/components/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200202ComponentList : IKubernetesObject<V1ListMeta>, IItems<V1api20200202Component>
{
    public const string KubeApiVersion = "v1api20200202";
    public const string KubeKind = "ComponentList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "components";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20200202";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComponentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200202Component objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200202Component> Items { get; set; }
}

/// <summary>Application_Type: Type of application being monitored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecApplicationTypeEnum>))]
public enum V1api20200202ComponentSpecApplicationTypeEnum
{
    [EnumMember(Value = "other"), JsonStringEnumMemberName("other")]
    Other,
    [EnumMember(Value = "web"), JsonStringEnumMemberName("web")]
    Web
}

/// <summary>
/// Flow_Type: Used by the Application Insights system to determine what kind of flow this component was created by. This is
/// to be set to &apos;Bluefield&apos; when creating/updating a component via the REST API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecFlowTypeEnum>))]
public enum V1api20200202ComponentSpecFlowTypeEnum
{
    [EnumMember(Value = "Bluefield"), JsonStringEnumMemberName("Bluefield")]
    Bluefield
}

/// <summary>IngestionMode: Indicates the flow of the ingestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecIngestionModeEnum>))]
public enum V1api20200202ComponentSpecIngestionModeEnum
{
    [EnumMember(Value = "ApplicationInsights"), JsonStringEnumMemberName("ApplicationInsights")]
    ApplicationInsights,
    [EnumMember(Value = "ApplicationInsightsWithDiagnosticSettings"), JsonStringEnumMemberName("ApplicationInsightsWithDiagnosticSettings")]
    ApplicationInsightsWithDiagnosticSettings,
    [EnumMember(Value = "LogAnalytics"), JsonStringEnumMemberName("LogAnalytics")]
    LogAnalytics
}

/// <summary>
/// Request_Source: Describes what tool created this Application Insights component. Customers using this API should set
/// this to the default &apos;rest&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecRequestSourceEnum>))]
public enum V1api20200202ComponentSpecRequestSourceEnum
{
    [EnumMember(Value = "rest"), JsonStringEnumMemberName("rest")]
    Rest
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOperatorSpecConfigMapExpressions
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
/// ConnectionString: indicates where the ConnectionString config map should be placed. If omitted, no config map will be
/// created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOperatorSpecConfigMapsConnectionString
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// InstrumentationKey: indicates where the InstrumentationKey config map should be placed. If omitted, no config map will
/// be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOperatorSpecConfigMapsInstrumentationKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// ConnectionString: indicates where the ConnectionString config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public V1api20200202ComponentSpecOperatorSpecConfigMapsConnectionString? ConnectionString { get; set; }

    /// <summary>
    /// InstrumentationKey: indicates where the InstrumentationKey config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("instrumentationKey")]
    public V1api20200202ComponentSpecOperatorSpecConfigMapsInstrumentationKey? InstrumentationKey { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOperatorSpecSecretExpressions
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
public partial class V1api20200202ComponentSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200202ComponentSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20200202ComponentSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200202ComponentSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Application Insights ingestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecPublicNetworkAccessForIngestionEnum>))]
public enum V1api20200202ComponentSpecPublicNetworkAccessForIngestionEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PublicNetworkAccessForQuery: The network access type for accessing Application Insights query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200202ComponentSpecPublicNetworkAccessForQueryEnum>))]
public enum V1api20200202ComponentSpecPublicNetworkAccessForQueryEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// WorkspaceResourceReference: Resource Id of the log analytics workspace which the data will be ingested to. This property
/// is required to create an application with this API version. Applications from older versions will not have this property.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentSpecWorkspaceResourceReference
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
public partial class V1api20200202ComponentSpec
{
    /// <summary>Application_Type: Type of application being monitored.</summary>
    [JsonPropertyName("Application_Type")]
    public required V1api20200202ComponentSpecApplicationTypeEnum ApplicationType { get; set; }

    /// <summary>DisableIpMasking: Disable IP masking.</summary>
    [JsonPropertyName("DisableIpMasking")]
    public bool? DisableIpMasking { get; set; }

    /// <summary>DisableLocalAuth: Disable Non-AAD based Auth.</summary>
    [JsonPropertyName("DisableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// Flow_Type: Used by the Application Insights system to determine what kind of flow this component was created by. This is
    /// to be set to &apos;Bluefield&apos; when creating/updating a component via the REST API.
    /// </summary>
    [JsonPropertyName("Flow_Type")]
    public V1api20200202ComponentSpecFlowTypeEnum? FlowType { get; set; }

    /// <summary>ForceCustomerStorageForProfiler: Force users to create their own storage account for profiler and debugger.</summary>
    [JsonPropertyName("ForceCustomerStorageForProfiler")]
    public bool? ForceCustomerStorageForProfiler { get; set; }

    /// <summary>
    /// HockeyAppId: The unique application ID created when a new application is added to HockeyApp, used for communications
    /// with HockeyApp.
    /// </summary>
    [JsonPropertyName("HockeyAppId")]
    public string? HockeyAppId { get; set; }

    /// <summary>ImmediatePurgeDataOn30Days: Purge data immediately after 30 days.</summary>
    [JsonPropertyName("ImmediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }

    /// <summary>IngestionMode: Indicates the flow of the ingestion.</summary>
    [JsonPropertyName("IngestionMode")]
    public V1api20200202ComponentSpecIngestionModeEnum? IngestionMode { get; set; }

    /// <summary>
    /// Request_Source: Describes what tool created this Application Insights component. Customers using this API should set
    /// this to the default &apos;rest&apos;.
    /// </summary>
    [JsonPropertyName("Request_Source")]
    public V1api20200202ComponentSpecRequestSourceEnum? RequestSource { get; set; }

    /// <summary>RetentionInDays: Retention period in days.</summary>
    [JsonPropertyName("RetentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary>
    /// SamplingPercentage: Percentage of the data produced by the application being monitored that is being sampled for
    /// Application Insights telemetry.
    /// </summary>
    [JsonPropertyName("SamplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Etag: Resource etag</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Kind: The kind of application that this component refers to, used to customize UI. This value is a freeform string,
    /// values should typically be one of the following: web, ios, other, store, java, phone.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200202ComponentSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200202ComponentSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Application Insights ingestion.</summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public V1api20200202ComponentSpecPublicNetworkAccessForIngestionEnum? PublicNetworkAccessForIngestion { get; set; }

    /// <summary>PublicNetworkAccessForQuery: The network access type for accessing Application Insights query.</summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public V1api20200202ComponentSpecPublicNetworkAccessForQueryEnum? PublicNetworkAccessForQuery { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// WorkspaceResourceReference: Resource Id of the log analytics workspace which the data will be ingested to. This property
    /// is required to create an application with this API version. Applications from older versions will not have this property.
    /// </summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20200202ComponentSpecWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>The private link scope resource reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentStatusPrivateLinkScopedResources
{
    /// <summary>ResourceId: The full resource Id of the private link scope resource.</summary>
    [JsonPropertyName("ResourceId")]
    public string? ResourceId { get; set; }

    /// <summary>ScopeId: The private link scope unique Identifier.</summary>
    [JsonPropertyName("ScopeId")]
    public string? ScopeId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200202ComponentStatus
{
    /// <summary>AppId: Application Insights Unique ID for your Application.</summary>
    [JsonPropertyName("AppId")]
    public string? AppId { get; set; }

    /// <summary>Application_Type: Type of application being monitored.</summary>
    [JsonPropertyName("Application_Type")]
    public string? ApplicationType { get; set; }

    /// <summary>ApplicationId: The unique ID of your application. This field mirrors the &apos;Name&apos; field and cannot be changed.</summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>ConnectionString: Application Insights component connection string.</summary>
    [JsonPropertyName("ConnectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>CreationDate: Creation Date for the Application Insights component, in ISO 8601 format.</summary>
    [JsonPropertyName("CreationDate")]
    public string? CreationDate { get; set; }

    /// <summary>DisableIpMasking: Disable IP masking.</summary>
    [JsonPropertyName("DisableIpMasking")]
    public bool? DisableIpMasking { get; set; }

    /// <summary>DisableLocalAuth: Disable Non-AAD based Auth.</summary>
    [JsonPropertyName("DisableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// Flow_Type: Used by the Application Insights system to determine what kind of flow this component was created by. This is
    /// to be set to &apos;Bluefield&apos; when creating/updating a component via the REST API.
    /// </summary>
    [JsonPropertyName("Flow_Type")]
    public string? FlowType { get; set; }

    /// <summary>ForceCustomerStorageForProfiler: Force users to create their own storage account for profiler and debugger.</summary>
    [JsonPropertyName("ForceCustomerStorageForProfiler")]
    public bool? ForceCustomerStorageForProfiler { get; set; }

    /// <summary>
    /// HockeyAppId: The unique application ID created when a new application is added to HockeyApp, used for communications
    /// with HockeyApp.
    /// </summary>
    [JsonPropertyName("HockeyAppId")]
    public string? HockeyAppId { get; set; }

    /// <summary>HockeyAppToken: Token used to authenticate communications with between Application Insights and HockeyApp.</summary>
    [JsonPropertyName("HockeyAppToken")]
    public string? HockeyAppToken { get; set; }

    /// <summary>ImmediatePurgeDataOn30Days: Purge data immediately after 30 days.</summary>
    [JsonPropertyName("ImmediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }

    /// <summary>IngestionMode: Indicates the flow of the ingestion.</summary>
    [JsonPropertyName("IngestionMode")]
    public string? IngestionMode { get; set; }

    /// <summary>
    /// InstrumentationKey: Application Insights Instrumentation key. A read-only value that applications can use to identify
    /// the destination for all telemetry sent to Azure Application Insights. This value will be supplied upon construction of
    /// each new Application Insights component.
    /// </summary>
    [JsonPropertyName("InstrumentationKey")]
    public string? InstrumentationKey { get; set; }

    /// <summary>LaMigrationDate: The date which the component got migrated to LA, in ISO 8601 format.</summary>
    [JsonPropertyName("LaMigrationDate")]
    public string? LaMigrationDate { get; set; }

    /// <summary>PrivateLinkScopedResources: List of linked private link scope resources.</summary>
    [JsonPropertyName("PrivateLinkScopedResources")]
    public IList<V1api20200202ComponentStatusPrivateLinkScopedResources>? PrivateLinkScopedResources { get; set; }

    /// <summary>
    /// Request_Source: Describes what tool created this Application Insights component. Customers using this API should set
    /// this to the default &apos;rest&apos;.
    /// </summary>
    [JsonPropertyName("Request_Source")]
    public string? RequestSource { get; set; }

    /// <summary>RetentionInDays: Retention period in days.</summary>
    [JsonPropertyName("RetentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary>
    /// SamplingPercentage: Percentage of the data produced by the application being monitored that is being sampled for
    /// Application Insights telemetry.
    /// </summary>
    [JsonPropertyName("SamplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>TenantId: Azure Tenant Id.</summary>
    [JsonPropertyName("TenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// WorkspaceResourceId: Resource Id of the log analytics workspace which the data will be ingested to. This property is
    /// required to create an application with this API version. Applications from older versions will not have this property.
    /// </summary>
    [JsonPropertyName("WorkspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200202ComponentStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: Resource etag</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Azure resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Kind: The kind of application that this component refers to, used to customize UI. This value is a freeform string,
    /// values should typically be one of the following: web, ios, other, store, java, phone.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Azure resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesName: Application name.</summary>
    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary>
    /// ProvisioningState: Current state of this component: whether or not is has been provisioned within the resource group it
    /// is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying,
    /// Canceled, and Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Application Insights ingestion.</summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public string? PublicNetworkAccessForIngestion { get; set; }

    /// <summary>PublicNetworkAccessForQuery: The network access type for accessing Application Insights query.</summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public string? PublicNetworkAccessForQuery { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Azure resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/stable/2020-02-02/components_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/components/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200202Component : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200202ComponentSpec?>, IStatus<V1api20200202ComponentStatus?>
{
    public const string KubeApiVersion = "v1api20200202";
    public const string KubeKind = "Component";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "components";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20200202";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Component";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20200202ComponentSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20200202ComponentStatus? Status { get; set; }
}