#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601TopicList : IKubernetesObject<V1ListMeta>, IItems<V1api20200601Topic>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "TopicList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200601Topic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200601Topic> Items { get; set; }
}

/// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601TopicSpecInboundIpRulesActionEnum>))]
public enum V1api20200601TopicSpecInboundIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInboundIpRules
{
    /// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
    [JsonPropertyName("action")]
    public V1api20200601TopicSpecInboundIpRulesActionEnum? Action { get; set; }

    /// <summary>IpMask: IP Address in CIDR notation e.g., 10.0.0.0/8.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>InputSchema: This determines the format that Event Grid should expect for incoming events published to the topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601TopicSpecInputSchemaEnum>))]
public enum V1api20200601TopicSpecInputSchemaEnum
{
    [EnumMember(Value = "CloudEventSchemaV1_0"), JsonStringEnumMemberName("CloudEventSchemaV1_0")]
    CloudEventSchemaV10,
    [EnumMember(Value = "CustomEventSchema"), JsonStringEnumMemberName("CustomEventSchema")]
    CustomEventSchema,
    [EnumMember(Value = "EventGridSchema"), JsonStringEnumMemberName("EventGridSchema")]
    EventGridSchema
}

/// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonDataVersion
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonEventTime
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonEventType
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonId
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601TopicSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum>))]
public enum V1api20200601TopicSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum
{
    [EnumMember(Value = "Json"), JsonStringEnumMemberName("Json")]
    Json
}

/// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonSubject
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJsonTopic
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Json: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMappingJson
{
    /// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601TopicSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601TopicSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
    [JsonPropertyName("eventType")]
    public V1api20200601TopicSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
    [JsonPropertyName("id")]
    public V1api20200601TopicSpecInputSchemaMappingJsonId? Id { get; set; }

    /// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public required V1api20200601TopicSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum InputSchemaMappingType { get; set; }

    /// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
    [JsonPropertyName("subject")]
    public V1api20200601TopicSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
    [JsonPropertyName("topic")]
    public V1api20200601TopicSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>
/// InputSchemaMapping: This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map
/// various properties of a source schema to various required properties of the EventGridEvent schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecInputSchemaMapping
{
    /// <summary>Json: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("json")]
    public V1api20200601TopicSpecInputSchemaMappingJson? Json { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecConfigMapExpressions
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

/// <summary>Endpoint: indicates where the Endpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecConfigMapsEndpoint
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
public partial class V1api20200601TopicSpecOperatorSpecConfigMaps
{
    /// <summary>Endpoint: indicates where the Endpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("endpoint")]
    public V1api20200601TopicSpecOperatorSpecConfigMapsEndpoint? Endpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecSecretExpressions
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

/// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecSecretsKey1
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecSecretsKey2
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpecSecrets
{
    /// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key1")]
    public V1api20200601TopicSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key2")]
    public V1api20200601TopicSpecOperatorSpecSecretsKey2? Key2 { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200601TopicSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20200601TopicSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200601TopicSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20200601TopicSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PublicNetworkAccess: This determines if traffic is allowed over public network. By default it is enabled.
/// You can further restrict to specific IPs by configuring &lt;seealso
/// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules&quot; /&gt;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601TopicSpecPublicNetworkAccessEnum>))]
public enum V1api20200601TopicSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// InboundIpRules: This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered
    /// only if PublicNetworkAccess is enabled.
    /// </summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601TopicSpecInboundIpRules>? InboundIpRules { get; set; }

    /// <summary>InputSchema: This determines the format that Event Grid should expect for incoming events published to the topic.</summary>
    [JsonPropertyName("inputSchema")]
    public V1api20200601TopicSpecInputSchemaEnum? InputSchema { get; set; }

    /// <summary>
    /// InputSchemaMapping: This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map
    /// various properties of a source schema to various required properties of the EventGridEvent schema.
    /// </summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601TopicSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary>Location: Location of the resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200601TopicSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200601TopicSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This determines if traffic is allowed over public network. By default it is enabled.
    /// You can further restrict to specific IPs by configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules&quot; /&gt;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20200601TopicSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>Tags: Tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusConditions
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
public partial class V1api20200601TopicStatusInboundIpRules
{
    /// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>IpMask: IP Address in CIDR notation e.g., 10.0.0.0/8.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonDataVersion
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonEventTime
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonEventType
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonId
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonSubject
{
    /// <summary>
    /// DefaultValue: The default value to be used for mapping when a SourceField is not provided or if there&apos;s no property with
    /// the specified name in the published JSON event payload.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJsonTopic
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Json: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMappingJson
{
    /// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601TopicStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601TopicStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
    [JsonPropertyName("eventType")]
    public V1api20200601TopicStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
    [JsonPropertyName("id")]
    public V1api20200601TopicStatusInputSchemaMappingJsonId? Id { get; set; }

    /// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
    [JsonPropertyName("subject")]
    public V1api20200601TopicStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
    [JsonPropertyName("topic")]
    public V1api20200601TopicStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>
/// InputSchemaMapping: This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map
/// various properties of a source schema to various required properties of the EventGridEvent schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusInputSchemaMapping
{
    /// <summary>Json: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("json")]
    public V1api20200601TopicStatusInputSchemaMappingJson? Json { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusPrivateEndpointConnections
{
    /// <summary>Id: Fully qualified identifier of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SystemData: The system metadata relating to Topic resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatusSystemData
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

/// <summary>EventGrid Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601TopicStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200601TopicStatusConditions>? Conditions { get; set; }

    /// <summary>Endpoint: Endpoint for the topic.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Id: Fully qualified identifier of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// InboundIpRules: This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered
    /// only if PublicNetworkAccess is enabled.
    /// </summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601TopicStatusInboundIpRules>? InboundIpRules { get; set; }

    /// <summary>InputSchema: This determines the format that Event Grid should expect for incoming events published to the topic.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>
    /// InputSchemaMapping: This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map
    /// various properties of a source schema to various required properties of the EventGridEvent schema.
    /// </summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601TopicStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary>Location: Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MetricResourceId: Metric resource id for the topic.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Name: Name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20200601TopicStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the topic.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This determines if traffic is allowed over public network. By default it is enabled.
    /// You can further restrict to specific IPs by configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules&quot; /&gt;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>SystemData: The system metadata relating to Topic resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20200601TopicStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601Topic : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601TopicSpec?>, IStatus<V1api20200601TopicStatus?>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Topic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20200601TopicSpec? Spec { get; set; }

    /// <summary>EventGrid Topic</summary>
    [JsonPropertyName("status")]
    public V1api20200601TopicStatus? Status { get; set; }
}