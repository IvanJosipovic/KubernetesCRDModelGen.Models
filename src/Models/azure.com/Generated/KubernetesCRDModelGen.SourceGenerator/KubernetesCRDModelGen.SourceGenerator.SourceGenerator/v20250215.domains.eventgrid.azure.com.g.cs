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
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215DomainList : IKubernetesObject<V1ListMeta>, IItems<V20250215Domain>
{
    public const string KubeApiVersion = "v20250215";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250215Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250215Domain> Items { get; set; }
}

/// <summary>DataResidencyBoundary: Data Residency Boundary of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecDataResidencyBoundaryEnum>))]
public enum V20250215DomainSpecDataResidencyBoundaryEnum
{
    [EnumMember(Value = "WithinGeopair"), JsonStringEnumMemberName("WithinGeopair")]
    WithinGeopair,
    [EnumMember(Value = "WithinRegion"), JsonStringEnumMemberName("WithinRegion")]
    WithinRegion
}

/// <summary>Additional information about every inline event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecEventTypeInfoInlineEventTypes
{
    /// <summary>DataSchemaUrl: The dataSchemaUrl for the inline event.</summary>
    [JsonPropertyName("dataSchemaUrl")]
    public string? DataSchemaUrl { get; set; }

    /// <summary>Description: The description for the inline event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The displayName for the inline event.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>DocumentationUrl: The documentationUrl for the inline event.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }
}

/// <summary>Kind: The kind of event type used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecEventTypeInfoKindEnum>))]
public enum V20250215DomainSpecEventTypeInfoKindEnum
{
    [EnumMember(Value = "Inline"), JsonStringEnumMemberName("Inline")]
    Inline
}

/// <summary>
/// EventTypeInfo: Event Type Information for the domain. This information is provided by the publisher and can be used by
/// the
/// subscriber to view different types of events that are published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecEventTypeInfo
{
    /// <summary>
    /// InlineEventTypes: A collection of inline event types for the resource. The inline event type keys are of type string
    /// which represents the name of the event.
    /// An example of a valid inline event name is &quot;Contoso.OrderCreated&quot;.
    /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
    /// event type.
    /// </summary>
    [JsonPropertyName("inlineEventTypes")]
    public IDictionary<string, V20250215DomainSpecEventTypeInfoInlineEventTypes>? InlineEventTypes { get; set; }

    /// <summary>Kind: The kind of event type used.</summary>
    [JsonPropertyName("kind")]
    public V20250215DomainSpecEventTypeInfoKindEnum? Kind { get; set; }
}

/// <summary>
/// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
/// identity and a set of user-assigned identities. The type &apos;None&apos; will remove any identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecIdentityTypeEnum>))]
public enum V20250215DomainSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250215DomainSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Identity information for the Event Grid Domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecIdentity
{
    /// <summary>
    /// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
    /// identity and a set of user-assigned identities. The type &apos;None&apos; will remove any identity.
    /// </summary>
    [JsonPropertyName("type")]
    public V20250215DomainSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// This property is currently not used and reserved for future usage.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250215DomainSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecInboundIpRulesActionEnum>))]
public enum V20250215DomainSpecInboundIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInboundIpRules
{
    /// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
    [JsonPropertyName("action")]
    public V20250215DomainSpecInboundIpRulesActionEnum? Action { get; set; }

    /// <summary>IpMask: IP Address in CIDR notation e.g., 10.0.0.0/8.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// InputSchema: This determines the format that Event Grid should expect for incoming events published to the Event Grid
/// Domain Resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecInputSchemaEnum>))]
public enum V20250215DomainSpecInputSchemaEnum
{
    [EnumMember(Value = "CloudEventSchemaV1_0"), JsonStringEnumMemberName("CloudEventSchemaV1_0")]
    CloudEventSchemaV10,
    [EnumMember(Value = "CustomEventSchema"), JsonStringEnumMemberName("CustomEventSchema")]
    CustomEventSchema,
    [EnumMember(Value = "EventGridSchema"), JsonStringEnumMemberName("EventGridSchema")]
    EventGridSchema
}

/// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonDataVersion
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonEventTime
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonEventType
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonId
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum>))]
public enum V20250215DomainSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum
{
    [EnumMember(Value = "Json"), JsonStringEnumMemberName("Json")]
    Json
}

/// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonSubject
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJsonTopic
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Json: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMappingJson
{
    /// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
    [JsonPropertyName("dataVersion")]
    public V20250215DomainSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
    [JsonPropertyName("eventTime")]
    public V20250215DomainSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
    [JsonPropertyName("eventType")]
    public V20250215DomainSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
    [JsonPropertyName("id")]
    public V20250215DomainSpecInputSchemaMappingJsonId? Id { get; set; }

    /// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public required V20250215DomainSpecInputSchemaMappingJsonInputSchemaMappingTypeEnum InputSchemaMappingType { get; set; }

    /// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
    [JsonPropertyName("subject")]
    public V20250215DomainSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
    [JsonPropertyName("topic")]
    public V20250215DomainSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>InputSchemaMapping: Information about the InputSchemaMapping which specified the info about mapping event payload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecInputSchemaMapping
{
    /// <summary>Json: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("json")]
    public V20250215DomainSpecInputSchemaMappingJson? Json { get; set; }
}

/// <summary>MinimumTlsVersionAllowed: Minimum TLS version of the publisher allowed to publish to this domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecMinimumTlsVersionAllowedEnum>))]
public enum V20250215DomainSpecMinimumTlsVersionAllowedEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecOperatorSpecConfigMapExpressions
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
public partial class V20250215DomainSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250215DomainSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250215DomainSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpecOwner
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
/// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215DomainSpecPublicNetworkAccessEnum>))]
public enum V20250215DomainSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainSpec
{
    /// <summary>
    /// AutoCreateTopicWithFirstSubscription: This Boolean is used to specify the creation mechanism for &apos;all&apos; the Event Grid
    /// Domain Topics associated with this Event Grid Domain resource.
    /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default
    /// value for this property is true.
    /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the
    /// first event subscription is
    /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription
    /// will require creating a domain topic
    /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created,
    /// while auto-managed mode provides the
    /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation
    /// mode, user is allowed to create the
    /// domain topic on demand if needed.
    /// </summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>
    /// AutoDeleteTopicWithLastSubscription: This Boolean is used to specify the deletion mechanism for &apos;all&apos; the Event Grid
    /// Domain Topics associated with this Event Grid Domain resource.
    /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default
    /// value for this property is true.
    /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last
    /// event subscription at the scope
    /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain
    /// topic when it is no longer needed
    /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be
    /// used if the user wants full
    /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less
    /// operations and manage fewer
    /// resources by the user.
    /// </summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DataResidencyBoundary: Data Residency Boundary of the resource.</summary>
    [JsonPropertyName("dataResidencyBoundary")]
    public V20250215DomainSpecDataResidencyBoundaryEnum? DataResidencyBoundary { get; set; }

    /// <summary>
    /// DisableLocalAuth: This boolean is used to enable or disable local auth. Default value is false. When the property is set
    /// to true, only AAD token will be used to authenticate if user is allowed to publish to the domain.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// EventTypeInfo: Event Type Information for the domain. This information is provided by the publisher and can be used by
    /// the
    /// subscriber to view different types of events that are published.
    /// </summary>
    [JsonPropertyName("eventTypeInfo")]
    public V20250215DomainSpecEventTypeInfo? EventTypeInfo { get; set; }

    /// <summary>Identity: Identity information for the Event Grid Domain resource.</summary>
    [JsonPropertyName("identity")]
    public V20250215DomainSpecIdentity? Identity { get; set; }

    /// <summary>
    /// InboundIpRules: This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered
    /// only if PublicNetworkAccess is enabled.
    /// </summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V20250215DomainSpecInboundIpRules>? InboundIpRules { get; set; }

    /// <summary>
    /// InputSchema: This determines the format that Event Grid should expect for incoming events published to the Event Grid
    /// Domain Resource.
    /// </summary>
    [JsonPropertyName("inputSchema")]
    public V20250215DomainSpecInputSchemaEnum? InputSchema { get; set; }

    /// <summary>InputSchemaMapping: Information about the InputSchemaMapping which specified the info about mapping event payload.</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20250215DomainSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary>Location: Location of the resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version of the publisher allowed to publish to this domain</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public V20250215DomainSpecMinimumTlsVersionAllowedEnum? MinimumTlsVersionAllowed { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250215DomainSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250215DomainSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This determines if traffic is allowed over public network. By default it is enabled.
    /// You can further restrict to specific IPs by configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20250215DomainSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>Tags: Tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusConditions
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

/// <summary>Additional information about every inline event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusEventTypeInfoInlineEventTypes
{
    /// <summary>DataSchemaUrl: The dataSchemaUrl for the inline event.</summary>
    [JsonPropertyName("dataSchemaUrl")]
    public string? DataSchemaUrl { get; set; }

    /// <summary>Description: The description for the inline event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The displayName for the inline event.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>DocumentationUrl: The documentationUrl for the inline event.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }
}

/// <summary>
/// EventTypeInfo: Event Type Information for the domain. This information is provided by the publisher and can be used by
/// the
/// subscriber to view different types of events that are published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusEventTypeInfo
{
    /// <summary>
    /// InlineEventTypes: A collection of inline event types for the resource. The inline event type keys are of type string
    /// which represents the name of the event.
    /// An example of a valid inline event name is &quot;Contoso.OrderCreated&quot;.
    /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
    /// event type.
    /// </summary>
    [JsonPropertyName("inlineEventTypes")]
    public IDictionary<string, V20250215DomainStatusEventTypeInfoInlineEventTypes>? InlineEventTypes { get; set; }

    /// <summary>Kind: The kind of event type used.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>The information about the user identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Identity information for the Event Grid Domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
    /// identity and a set of user-assigned identities. The type &apos;None&apos; will remove any identity.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// This property is currently not used and reserved for future usage.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250215DomainStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInboundIpRules
{
    /// <summary>Action: Action to perform based on the match or no match of the IpMask.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>IpMask: IP Address in CIDR notation e.g., 10.0.0.0/8.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonDataVersion
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonEventTime
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonEventType
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonId
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonSubject
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJsonTopic
{
    /// <summary>SourceField: Name of a field in the input event schema that&apos;s to be used as the source of a mapping.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Json: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMappingJson
{
    /// <summary>DataVersion: The mapping information for the DataVersion property of the Event Grid Event.</summary>
    [JsonPropertyName("dataVersion")]
    public V20250215DomainStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>EventTime: The mapping information for the EventTime property of the Event Grid Event.</summary>
    [JsonPropertyName("eventTime")]
    public V20250215DomainStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>EventType: The mapping information for the EventType property of the Event Grid Event.</summary>
    [JsonPropertyName("eventType")]
    public V20250215DomainStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>Id: The mapping information for the Id property of the Event Grid Event.</summary>
    [JsonPropertyName("id")]
    public V20250215DomainStatusInputSchemaMappingJsonId? Id { get; set; }

    /// <summary>InputSchemaMappingType: Type of the custom mapping</summary>
    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>Subject: The mapping information for the Subject property of the Event Grid Event.</summary>
    [JsonPropertyName("subject")]
    public V20250215DomainStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>Topic: The mapping information for the Topic property of the Event Grid Event.</summary>
    [JsonPropertyName("topic")]
    public V20250215DomainStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>InputSchemaMapping: Information about the InputSchemaMapping which specified the info about mapping event payload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusInputSchemaMapping
{
    /// <summary>Json: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("json")]
    public V20250215DomainStatusInputSchemaMappingJson? Json { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusPrivateEndpointConnections
{
    /// <summary>Id: Fully qualified identifier of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SystemData: The system metadata relating to the Event Grid resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatusSystemData
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

/// <summary>EventGrid Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215DomainStatus
{
    /// <summary>
    /// AutoCreateTopicWithFirstSubscription: This Boolean is used to specify the creation mechanism for &apos;all&apos; the Event Grid
    /// Domain Topics associated with this Event Grid Domain resource.
    /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default
    /// value for this property is true.
    /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the
    /// first event subscription is
    /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription
    /// will require creating a domain topic
    /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created,
    /// while auto-managed mode provides the
    /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation
    /// mode, user is allowed to create the
    /// domain topic on demand if needed.
    /// </summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>
    /// AutoDeleteTopicWithLastSubscription: This Boolean is used to specify the deletion mechanism for &apos;all&apos; the Event Grid
    /// Domain Topics associated with this Event Grid Domain resource.
    /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default
    /// value for this property is true.
    /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last
    /// event subscription at the scope
    /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain
    /// topic when it is no longer needed
    /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be
    /// used if the user wants full
    /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less
    /// operations and manage fewer
    /// resources by the user.
    /// </summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250215DomainStatusConditions>? Conditions { get; set; }

    /// <summary>DataResidencyBoundary: Data Residency Boundary of the resource.</summary>
    [JsonPropertyName("dataResidencyBoundary")]
    public string? DataResidencyBoundary { get; set; }

    /// <summary>
    /// DisableLocalAuth: This boolean is used to enable or disable local auth. Default value is false. When the property is set
    /// to true, only AAD token will be used to authenticate if user is allowed to publish to the domain.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Endpoint: Endpoint for the Event Grid Domain Resource which is used for publishing the events.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// EventTypeInfo: Event Type Information for the domain. This information is provided by the publisher and can be used by
    /// the
    /// subscriber to view different types of events that are published.
    /// </summary>
    [JsonPropertyName("eventTypeInfo")]
    public V20250215DomainStatusEventTypeInfo? EventTypeInfo { get; set; }

    /// <summary>Id: Fully qualified identifier of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity information for the Event Grid Domain resource.</summary>
    [JsonPropertyName("identity")]
    public V20250215DomainStatusIdentity? Identity { get; set; }

    /// <summary>
    /// InboundIpRules: This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered
    /// only if PublicNetworkAccess is enabled.
    /// </summary>
    [JsonPropertyName("inboundIpRules")]
    public IList<V20250215DomainStatusInboundIpRules>? InboundIpRules { get; set; }

    /// <summary>
    /// InputSchema: This determines the format that Event Grid should expect for incoming events published to the Event Grid
    /// Domain Resource.
    /// </summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>InputSchemaMapping: Information about the InputSchemaMapping which specified the info about mapping event payload.</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20250215DomainStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    /// <summary>Location: Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MetricResourceId: Metric resource id for the Event Grid Domain Resource.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version of the publisher allowed to publish to this domain</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    /// <summary>Name: Name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250215DomainStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the Event Grid Domain Resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This determines if traffic is allowed over public network. By default it is enabled.
    /// You can further restrict to specific IPs by configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>SystemData: The system metadata relating to the Event Grid resource.</summary>
    [JsonPropertyName("systemData")]
    public V20250215DomainStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V20250215DomainSpec?>, IStatus<V20250215DomainStatus?>
{
    public const string KubeApiVersion = "v20250215";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250215DomainSpec? Spec { get; set; }

    /// <summary>EventGrid Domain.</summary>
    [JsonPropertyName("status")]
    public V20250215DomainStatus? Status { get; set; }
}