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
/// Storage version of v20250215.Domain
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215storageDomainList : IKubernetesObject<V1ListMeta>, IItems<V20250215storageDomain>
{
    public const string KubeApiVersion = "v20250215storage";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250215storageDomain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250215storageDomain> Items { get; set; }
}

/// <summary>
/// Storage version of v20250215.InlineEventProperties
/// Additional information about every inline event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecEventTypeInfoInlineEventTypes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataSchemaUrl")]
    public string? DataSchemaUrl { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventTypeInfo
/// The event type information for Channels.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecEventTypeInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("inlineEventTypes")]
    public IDictionary<string, V20250215storageDomainSpecEventTypeInfoInlineEventTypes>? InlineEventTypes { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20250215.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250215storageDomainSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250215.IdentityInfo
/// The identity information for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecIdentity
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
    public IList<V20250215storageDomainSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v20250215.InboundIpRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInboundIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonDataVersion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonEventTime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonEventType
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonSubject
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJsonTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Storage version of v20250215.JsonInputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V20250215storageDomainSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V20250215storageDomainSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V20250215storageDomainSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V20250215storageDomainSpecInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V20250215storageDomainSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V20250215storageDomainSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v20250215.InputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.JsonInputSchemaMapping</summary>
    [JsonPropertyName("json")]
    public V20250215storageDomainSpecInputSchemaMappingJson? Json { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecOperatorSpecConfigMapExpressions
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
public partial class V20250215storageDomainSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250215.DomainOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250215storageDomainSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250215storageDomainSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20250215.Domain_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("dataResidencyBoundary")]
    public string? DataResidencyBoundary { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventTypeInfo
    /// The event type information for Channels.
    /// </summary>
    [JsonPropertyName("eventTypeInfo")]
    public V20250215storageDomainSpecEventTypeInfo? EventTypeInfo { get; set; }

    /// <summary>
    /// Storage version of v20250215.IdentityInfo
    /// The identity information for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageDomainSpecIdentity? Identity { get; set; }

    [JsonPropertyName("inboundIpRules")]
    public IList<V20250215storageDomainSpecInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v20250215.InputSchemaMapping</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20250215storageDomainSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    /// <summary>
    /// Storage version of v20250215.DomainOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250215storageDomainSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250215storageDomainSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusConditions
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
/// Storage version of v20250215.InlineEventProperties_STATUS
/// Additional information about every inline event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusEventTypeInfoInlineEventTypes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataSchemaUrl")]
    public string? DataSchemaUrl { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventTypeInfo_STATUS
/// The event type information for Channels.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusEventTypeInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("inlineEventTypes")]
    public IDictionary<string, V20250215storageDomainStatusEventTypeInfoInlineEventTypes>? InlineEventTypes { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// Storage version of v20250215.UserIdentityProperties_STATUS
/// The information about the user identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusIdentityUserAssignedIdentities
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
/// Storage version of v20250215.IdentityInfo_STATUS
/// The identity information for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusIdentity
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
    public IDictionary<string, V20250215storageDomainStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v20250215.InboundIpRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInboundIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault_STATUS
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonDataVersion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonEventTime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault_STATUS
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonEventType
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonFieldWithDefault_STATUS
/// This is used to express the source of an input schema mapping for a single target field
/// in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;subject&apos;,
/// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
/// field in the input event schema
/// along with a default value to be used, and at least one of these two properties should
/// be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonSubject
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>
/// Storage version of v20250215.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJsonTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }
}

/// <summary>Storage version of v20250215.JsonInputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V20250215storageDomainStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V20250215storageDomainStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V20250215storageDomainStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V20250215storageDomainStatusInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V20250215storageDomainStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v20250215.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V20250215storageDomainStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v20250215.InputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.JsonInputSchemaMapping_STATUS</summary>
    [JsonPropertyName("json")]
    public V20250215storageDomainStatusInputSchemaMappingJson? Json { get; set; }
}

/// <summary>Storage version of v20250215.PrivateEndpointConnection_STATUS_Domain_SubResourceEmbedded</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusPrivateEndpointConnections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20250215.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatusSystemData
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
/// Storage version of v20250215.Domain_STATUS
/// EventGrid Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageDomainStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250215storageDomainStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("dataResidencyBoundary")]
    public string? DataResidencyBoundary { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventTypeInfo_STATUS
    /// The event type information for Channels.
    /// </summary>
    [JsonPropertyName("eventTypeInfo")]
    public V20250215storageDomainStatusEventTypeInfo? EventTypeInfo { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250215.IdentityInfo_STATUS
    /// The identity information for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageDomainStatusIdentity? Identity { get; set; }

    [JsonPropertyName("inboundIpRules")]
    public IList<V20250215storageDomainStatusInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v20250215.InputSchemaMapping_STATUS</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20250215storageDomainStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250215storageDomainStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20250215.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250215storageDomainStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250215.Domain
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215storageDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V20250215storageDomainSpec?>, IStatus<V20250215storageDomainStatus?>
{
    public const string KubeApiVersion = "v20250215storage";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250215.Domain_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250215storageDomainSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250215.Domain_STATUS
    /// EventGrid Domain.
    /// </summary>
    [JsonPropertyName("status")]
    public V20250215storageDomainStatus? Status { get; set; }
}