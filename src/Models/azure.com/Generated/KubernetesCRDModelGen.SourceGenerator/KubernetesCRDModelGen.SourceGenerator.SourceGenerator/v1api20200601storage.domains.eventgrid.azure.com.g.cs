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
/// Storage version of v1api20200601.Domain
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601storageDomainList : IKubernetesObject<V1ListMeta>, IItems<V1api20200601storageDomain>
{
    public const string KubeApiVersion = "v1api20200601storage";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200601storageDomain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200601storageDomain> Items { get; set; }
}

/// <summary>Storage version of v1api20200601.InboundIpRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInboundIpRules
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
/// Storage version of v1api20200601.JsonFieldWithDefault
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
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonDataVersion
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
/// Storage version of v1api20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonEventTime
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
/// Storage version of v1api20200601.JsonFieldWithDefault
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
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonEventType
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
/// Storage version of v1api20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonId
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
/// Storage version of v1api20200601.JsonFieldWithDefault
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
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonSubject
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
/// Storage version of v1api20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInputSchemaMappingJsonTopic
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

/// <summary>Storage version of v1api20200601.JsonInputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V1api20200601storageDomainSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v1api20200601.InputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonInputSchemaMapping</summary>
    [JsonPropertyName("json")]
    public V1api20200601storageDomainSpecInputSchemaMappingJson? Json { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20200601storageDomainSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20200601.DomainOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200601storageDomainSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200601storageDomainSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20200601.Domain_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601storageDomainSpecInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v1api20200601.InputSchemaMapping</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601storageDomainSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.DomainOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200601storageDomainSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200601storageDomainSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusConditions
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

/// <summary>Storage version of v1api20200601.InboundIpRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInboundIpRules
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
/// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
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
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonDataVersion
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
/// Storage version of v1api20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonEventTime
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
/// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
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
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonEventType
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
/// Storage version of v1api20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonId
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
/// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
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
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonSubject
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
/// Storage version of v1api20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInputSchemaMappingJsonTopic
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

/// <summary>Storage version of v1api20200601.JsonInputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V1api20200601storageDomainStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v1api20200601.InputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20200601.JsonInputSchemaMapping_STATUS</summary>
    [JsonPropertyName("json")]
    public V1api20200601storageDomainStatusInputSchemaMappingJson? Json { get; set; }
}

/// <summary>Storage version of v1api20200601.PrivateEndpointConnection_STATUS_Domain_SubResourceEmbedded</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusPrivateEndpointConnections
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
/// Storage version of v1api20200601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatusSystemData
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
/// Storage version of v1api20200601.Domain_STATUS
/// EventGrid Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601storageDomainStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20200601storageDomainStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("inboundIpRules")]
    public IList<V1api20200601storageDomainStatusInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v1api20200601.InputSchemaMapping_STATUS</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V1api20200601storageDomainStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20200601storageDomainStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20200601storageDomainStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20200601.Domain
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601storageDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601storageDomainSpec?>, IStatus<V1api20200601storageDomainStatus?>
{
    public const string KubeApiVersion = "v1api20200601storage";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20200601.Domain_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20200601storageDomainSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20200601.Domain_STATUS
    /// EventGrid Domain.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20200601storageDomainStatus? Status { get; set; }
}