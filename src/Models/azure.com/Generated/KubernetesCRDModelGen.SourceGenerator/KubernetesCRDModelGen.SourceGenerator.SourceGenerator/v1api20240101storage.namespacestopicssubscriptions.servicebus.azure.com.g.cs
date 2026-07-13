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
/// Storage version of v1api20240101.NamespacesTopicsSubscription
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2024-01-01/subscriptions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageNamespacesTopicsSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240101storageNamespacesTopicsSubscription>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "NamespacesTopicsSubscriptionList";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20240101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240101storageNamespacesTopicsSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240101storageNamespacesTopicsSubscription> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.SBClientAffineProperties
/// Properties specific to client affine subscriptions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpecClientAffineProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("isDurable")]
    public bool? IsDurable { get; set; }

    [JsonPropertyName("isShared")]
    public bool? IsShared { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240101.NamespacesTopicsSubscriptionOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a servicebus.azure.com/NamespacesTopic resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscription_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.SBClientAffineProperties
    /// Properties specific to client affine subscriptions.
    /// </summary>
    [JsonPropertyName("clientAffineProperties")]
    public V1api20240101storageNamespacesTopicsSubscriptionSpecClientAffineProperties? ClientAffineProperties { get; set; }

    [JsonPropertyName("deadLetteringOnFilterEvaluationExceptions")]
    public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    [JsonPropertyName("isClientAffine")]
    public bool? IsClientAffine { get; set; }

    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.NamespacesTopicsSubscriptionOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240101storageNamespacesTopicsSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a servicebus.azure.com/NamespacesTopic resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240101storageNamespacesTopicsSubscriptionSpecOwner Owner { get; set; }

    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.SBClientAffineProperties_STATUS
/// Properties specific to client affine subscriptions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionStatusClientAffineProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("isDurable")]
    public bool? IsDurable { get; set; }

    [JsonPropertyName("isShared")]
    public bool? IsShared { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionStatusConditions
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
/// Storage version of v1api20240101.MessageCountDetails_STATUS
/// Message Count Details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionStatusCountDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("activeMessageCount")]
    public int? ActiveMessageCount { get; set; }

    [JsonPropertyName("deadLetterMessageCount")]
    public int? DeadLetterMessageCount { get; set; }

    [JsonPropertyName("scheduledMessageCount")]
    public int? ScheduledMessageCount { get; set; }

    [JsonPropertyName("transferDeadLetterMessageCount")]
    public int? TransferDeadLetterMessageCount { get; set; }

    [JsonPropertyName("transferMessageCount")]
    public int? TransferMessageCount { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionStatusSystemData
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

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscription_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accessedAt")]
    public string? AccessedAt { get; set; }

    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.SBClientAffineProperties_STATUS
    /// Properties specific to client affine subscriptions.
    /// </summary>
    [JsonPropertyName("clientAffineProperties")]
    public V1api20240101storageNamespacesTopicsSubscriptionStatusClientAffineProperties? ClientAffineProperties { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.MessageCountDetails_STATUS
    /// Message Count Details.
    /// </summary>
    [JsonPropertyName("countDetails")]
    public V1api20240101storageNamespacesTopicsSubscriptionStatusCountDetails? CountDetails { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("deadLetteringOnFilterEvaluationExceptions")]
    public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isClientAffine")]
    public bool? IsClientAffine { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    [JsonPropertyName("messageCount")]
    public int? MessageCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20240101storageNamespacesTopicsSubscriptionStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.NamespacesTopicsSubscription
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2024-01-01/subscriptions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageNamespacesTopicsSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101storageNamespacesTopicsSubscriptionSpec?>, IStatus<V1api20240101storageNamespacesTopicsSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "NamespacesTopicsSubscription";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20240101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240101.NamespacesTopicsSubscription_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240101storageNamespacesTopicsSubscriptionSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240101.NamespacesTopicsSubscription_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240101storageNamespacesTopicsSubscriptionStatus? Status { get; set; }
}