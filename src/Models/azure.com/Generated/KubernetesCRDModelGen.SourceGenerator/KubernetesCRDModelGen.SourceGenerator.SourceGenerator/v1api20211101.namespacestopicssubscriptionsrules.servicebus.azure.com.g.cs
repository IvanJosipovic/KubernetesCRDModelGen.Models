#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2021-11-01/Rules.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101NamespacesTopicsSubscriptionsRule>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "NamespacesTopicsSubscriptionsRuleList";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptionsrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscriptionsRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101NamespacesTopicsSubscriptionsRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101NamespacesTopicsSubscriptionsRule> Items { get; set; }
}

/// <summary>
/// Action: Represents the filter actions which are allowed for the transformation of a message that have been matched by a
/// filter expression.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecAction
{
    /// <summary>
    /// CompatibilityLevel: This property is reserved for future use. An integer value showing the compatibility level,
    /// currently hard-coded to 20.
    /// </summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SqlExpression: SQL expression. e.g. MyProperty=&apos;ABC&apos;</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>CorrelationFilter: Properties of correlationFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecCorrelationFilter
{
    /// <summary>ContentType: Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>CorrelationId: Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Label: Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>MessageId: Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>Properties: dictionary object for custom filters</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>ReplyTo: Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>ReplyToSessionId: Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SessionId: Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>To: Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>FilterType: Filter type that is evaluated against a BrokeredMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101NamespacesTopicsSubscriptionsRuleSpecFilterTypeEnum>))]
public enum V1api20211101NamespacesTopicsSubscriptionsRuleSpecFilterTypeEnum
{
    [EnumMember(Value = "CorrelationFilter"), JsonStringEnumMemberName("CorrelationFilter")]
    CorrelationFilter,
    [EnumMember(Value = "SqlFilter"), JsonStringEnumMemberName("SqlFilter")]
    SqlFilter
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpecSecretExpressions
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
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a servicebus.azure.com/NamespacesTopicsSubscription resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SqlFilter: Properties of sqlFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpecSqlFilter
{
    /// <summary>
    /// CompatibilityLevel: This property is reserved for future use. An integer value showing the compatibility level,
    /// currently hard-coded to 20.
    /// </summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SqlExpression: The SQL expression. e.g. MyProperty=&apos;ABC&apos;</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleSpec
{
    /// <summary>
    /// Action: Represents the filter actions which are allowed for the transformation of a message that have been matched by a
    /// filter expression.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpecAction? Action { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CorrelationFilter: Properties of correlationFilter</summary>
    [JsonPropertyName("correlationFilter")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpecCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary>FilterType: Filter type that is evaluated against a BrokeredMessage.</summary>
    [JsonPropertyName("filterType")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpecFilterTypeEnum? FilterType { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a servicebus.azure.com/NamespacesTopicsSubscription resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101NamespacesTopicsSubscriptionsRuleSpecOwner Owner { get; set; }

    /// <summary>SqlFilter: Properties of sqlFilter</summary>
    [JsonPropertyName("sqlFilter")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpecSqlFilter? SqlFilter { get; set; }
}

/// <summary>
/// Action: Represents the filter actions which are allowed for the transformation of a message that have been matched by a
/// filter expression.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatusAction
{
    /// <summary>
    /// CompatibilityLevel: This property is reserved for future use. An integer value showing the compatibility level,
    /// currently hard-coded to 20.
    /// </summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SqlExpression: SQL expression. e.g. MyProperty=&apos;ABC&apos;</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatusConditions
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

/// <summary>CorrelationFilter: Properties of correlationFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatusCorrelationFilter
{
    /// <summary>ContentType: Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>CorrelationId: Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Label: Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>MessageId: Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>Properties: dictionary object for custom filters</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>ReplyTo: Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>ReplyToSessionId: Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SessionId: Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>To: Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>SqlFilter: Properties of sqlFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatusSqlFilter
{
    /// <summary>
    /// CompatibilityLevel: This property is reserved for future use. An integer value showing the compatibility level,
    /// currently hard-coded to 20.
    /// </summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary>RequiresPreprocessing: Value that indicates whether the rule action requires preprocessing.</summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary>SqlExpression: The SQL expression. e.g. MyProperty=&apos;ABC&apos;</summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>SystemData: The system meta data relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatusSystemData
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

    /// <summary>LastModifiedAt: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesTopicsSubscriptionsRuleStatus
{
    /// <summary>
    /// Action: Represents the filter actions which are allowed for the transformation of a message that have been matched by a
    /// filter expression.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleStatusAction? Action { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101NamespacesTopicsSubscriptionsRuleStatusConditions>? Conditions { get; set; }

    /// <summary>CorrelationFilter: Properties of correlationFilter</summary>
    [JsonPropertyName("correlationFilter")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleStatusCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary>FilterType: Filter type that is evaluated against a BrokeredMessage.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SqlFilter: Properties of sqlFilter</summary>
    [JsonPropertyName("sqlFilter")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleStatusSqlFilter? SqlFilter { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.EventHub/Namespaces&quot; or &quot;Microsoft.EventHub/Namespaces/EventHubs&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2021-11-01/Rules.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101NamespacesTopicsSubscriptionsRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101NamespacesTopicsSubscriptionsRuleSpec?>, IStatus<V1api20211101NamespacesTopicsSubscriptionsRuleStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "NamespacesTopicsSubscriptionsRule";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptionsrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscriptionsRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211101NamespacesTopicsSubscriptionsRuleStatus? Status { get; set; }
}