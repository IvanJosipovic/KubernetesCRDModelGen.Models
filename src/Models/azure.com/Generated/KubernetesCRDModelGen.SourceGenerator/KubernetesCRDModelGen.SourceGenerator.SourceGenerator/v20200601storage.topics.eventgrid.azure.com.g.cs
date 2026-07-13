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
/// Storage version of v20200601.Topic
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20200601storageTopicList : IKubernetesObject<V1ListMeta>, IItems<V20200601storageTopic>
{
    public const string KubeApiVersion = "v20200601storage";
    public const string KubeKind = "TopicList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20200601storageTopic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20200601storageTopic> Items { get; set; }
}

/// <summary>Storage version of v20200601.InboundIpRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInboundIpRules
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
/// Storage version of v20200601.JsonFieldWithDefault
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
public partial class V20200601storageTopicSpecInputSchemaMappingJsonDataVersion
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
/// Storage version of v20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInputSchemaMappingJsonEventTime
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
/// Storage version of v20200601.JsonFieldWithDefault
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
public partial class V20200601storageTopicSpecInputSchemaMappingJsonEventType
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
/// Storage version of v20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInputSchemaMappingJsonId
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
/// Storage version of v20200601.JsonFieldWithDefault
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
public partial class V20200601storageTopicSpecInputSchemaMappingJsonSubject
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
/// Storage version of v20200601.JsonField
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInputSchemaMappingJsonTopic
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

/// <summary>Storage version of v20200601.JsonInputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V20200601storageTopicSpecInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V20200601storageTopicSpecInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V20200601storageTopicSpecInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V20200601storageTopicSpecInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V20200601storageTopicSpecInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V20200601storageTopicSpecInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v20200601.InputSchemaMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.JsonInputSchemaMapping</summary>
    [JsonPropertyName("json")]
    public V20200601storageTopicSpecInputSchemaMappingJson? Json { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecConfigMapExpressions
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
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecConfigMapsEndpoint
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

/// <summary>Storage version of v20200601.TopicOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public V20200601storageTopicSpecOperatorSpecConfigMapsEndpoint? Endpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecSecretsKey1
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

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecSecretsKey2
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

/// <summary>Storage version of v20200601.TopicOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key1")]
    public V20200601storageTopicSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key2")]
    public V20200601storageTopicSpecOperatorSpecSecretsKey2? Key2 { get; set; }
}

/// <summary>
/// Storage version of v20200601.TopicOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20200601storageTopicSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v20200601.TopicOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V20200601storageTopicSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20200601storageTopicSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v20200601.TopicOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V20200601storageTopicSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.Topic_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicSpec
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
    public IList<V20200601storageTopicSpecInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v20200601.InputSchemaMapping</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20200601storageTopicSpecInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20200601.TopicOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20200601storageTopicSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20200601storageTopicSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusConditions
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

/// <summary>Storage version of v20200601.InboundIpRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInboundIpRules
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
/// Storage version of v20200601.JsonFieldWithDefault_STATUS
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
public partial class V20200601storageTopicStatusInputSchemaMappingJsonDataVersion
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
/// Storage version of v20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInputSchemaMappingJsonEventTime
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
/// Storage version of v20200601.JsonFieldWithDefault_STATUS
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
public partial class V20200601storageTopicStatusInputSchemaMappingJsonEventType
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
/// Storage version of v20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInputSchemaMappingJsonId
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
/// Storage version of v20200601.JsonFieldWithDefault_STATUS
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
public partial class V20200601storageTopicStatusInputSchemaMappingJsonSubject
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
/// Storage version of v20200601.JsonField_STATUS
/// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
/// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
/// input event schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInputSchemaMappingJsonTopic
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

/// <summary>Storage version of v20200601.JsonInputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInputSchemaMappingJson
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("dataVersion")]
    public V20200601storageTopicStatusInputSchemaMappingJsonDataVersion? DataVersion { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("eventTime")]
    public V20200601storageTopicStatusInputSchemaMappingJsonEventTime? EventTime { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("eventType")]
    public V20200601storageTopicStatusInputSchemaMappingJsonEventType? EventType { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("id")]
    public V20200601storageTopicStatusInputSchemaMappingJsonId? Id { get; set; }

    [JsonPropertyName("inputSchemaMappingType")]
    public string? InputSchemaMappingType { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonFieldWithDefault_STATUS
    /// This is used to express the source of an input schema mapping for a single target field
    /// in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;subject&apos;,
    /// &apos;eventtype&apos; and &apos;dataversion&apos; properties. This represents a
    /// field in the input event schema
    /// along with a default value to be used, and at least one of these two properties should
    /// be provided.
    /// </summary>
    [JsonPropertyName("subject")]
    public V20200601storageTopicStatusInputSchemaMappingJsonSubject? Subject { get; set; }

    /// <summary>
    /// Storage version of v20200601.JsonField_STATUS
    /// This is used to express the source of an input schema mapping for a single target field in the Event Grid Event schema.
    /// This is currently used in the mappings for the &apos;id&apos;, &apos;topic&apos; and &apos;eventtime&apos; properties. This represents a field in the
    /// input event schema.
    /// </summary>
    [JsonPropertyName("topic")]
    public V20200601storageTopicStatusInputSchemaMappingJsonTopic? Topic { get; set; }
}

/// <summary>Storage version of v20200601.InputSchemaMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusInputSchemaMapping
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.JsonInputSchemaMapping_STATUS</summary>
    [JsonPropertyName("json")]
    public V20200601storageTopicStatusInputSchemaMappingJson? Json { get; set; }
}

/// <summary>Storage version of v20200601.PrivateEndpointConnection_STATUS_Topic_SubResourceEmbedded</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusPrivateEndpointConnections
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
/// Storage version of v20200601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatusSystemData
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
/// Storage version of v20200601.Topic_STATUS
/// EventGrid Topic
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageTopicStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20200601storageTopicStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("inboundIpRules")]
    public IList<V20200601storageTopicStatusInboundIpRules>? InboundIpRules { get; set; }

    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Storage version of v20200601.InputSchemaMapping_STATUS</summary>
    [JsonPropertyName("inputSchemaMapping")]
    public V20200601storageTopicStatusInputSchemaMapping? InputSchemaMapping { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20200601storageTopicStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20200601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20200601storageTopicStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20200601.Topic
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20200601storageTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V20200601storageTopicSpec?>, IStatus<V20200601storageTopicStatus?>
{
    public const string KubeApiVersion = "v20200601storage";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "topics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Topic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20200601.Topic_Spec</summary>
    [JsonPropertyName("spec")]
    public V20200601storageTopicSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20200601.Topic_STATUS
    /// EventGrid Topic
    /// </summary>
    [JsonPropertyName("status")]
    public V20200601storageTopicStatus? Status { get; set; }
}