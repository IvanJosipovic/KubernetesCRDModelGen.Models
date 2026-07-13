#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>
/// Storage version of v1api20241101.AvailabilitySet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101storageAvailabilitySetList : IKubernetesObject<V1ListMeta>, IItems<V1api20241101storageAvailabilitySet>
{
    public const string KubeApiVersion = "v1api20241101storage";
    public const string KubeKind = "AvailabilitySetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "availabilitysets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20241101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AvailabilitySetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20241101storageAvailabilitySet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20241101storageAvailabilitySet> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20241101storageAvailabilitySetSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20241101.AvailabilitySetOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20241101storageAvailabilitySetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20241101storageAvailabilitySetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecProximityPlacementGroupReference
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

/// <summary>Storage version of v1api20241101.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecProximityPlacementGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20241101storageAvailabilitySetSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.EventGridAndResourceGraph
/// Specifies eventGridAndResourceGraph related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>Storage version of v1api20241101.ScheduledEventsAdditionalPublishingTargets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.EventGridAndResourceGraph
    /// Specifies eventGridAndResourceGraph related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("eventGridAndResourceGraph")]
    public V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph? EventGridAndResourceGraph { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.UserInitiatedReboot
/// Specifies Reboot related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyUserInitiatedReboot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.UserInitiatedRedeploy
/// Specifies Redeploy related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyUserInitiatedRedeploy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.ScheduledEventsPolicy
/// Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecScheduledEventsPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20241101.ScheduledEventsAdditionalPublishingTargets</summary>
    [JsonPropertyName("scheduledEventsAdditionalPublishingTargets")]
    public V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets? ScheduledEventsAdditionalPublishingTargets { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.UserInitiatedReboot
    /// Specifies Reboot related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("userInitiatedReboot")]
    public V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyUserInitiatedReboot? UserInitiatedReboot { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.UserInitiatedRedeploy
    /// Specifies Redeploy related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("userInitiatedRedeploy")]
    public V1api20241101storageAvailabilitySetSpecScheduledEventsPolicyUserInitiatedRedeploy? UserInitiatedRedeploy { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.Sku
/// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
/// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20241101.AvailabilitySet_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetSpec
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

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.AvailabilitySetOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20241101storageAvailabilitySetSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20241101storageAvailabilitySetSpecOwner Owner { get; set; }

    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    [JsonPropertyName("platformUpdateDomainCount")]
    public int? PlatformUpdateDomainCount { get; set; }

    /// <summary>Storage version of v1api20241101.SubResource</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20241101storageAvailabilitySetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.ScheduledEventsPolicy
    /// Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("scheduledEventsPolicy")]
    public V1api20241101storageAvailabilitySetSpecScheduledEventsPolicy? ScheduledEventsPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.Sku
    /// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
    /// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20241101storageAvailabilitySetSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusConditions
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

/// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusProximityPlacementGroup
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
/// Storage version of v1api20241101.EventGridAndResourceGraph_STATUS
/// Specifies eventGridAndResourceGraph related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>Storage version of v1api20241101.ScheduledEventsAdditionalPublishingTargets_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.EventGridAndResourceGraph_STATUS
    /// Specifies eventGridAndResourceGraph related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("eventGridAndResourceGraph")]
    public V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph? EventGridAndResourceGraph { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.UserInitiatedReboot_STATUS
/// Specifies Reboot related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyUserInitiatedReboot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.UserInitiatedRedeploy_STATUS
/// Specifies Redeploy related Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyUserInitiatedRedeploy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.ScheduledEventsPolicy_STATUS
/// Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusScheduledEventsPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20241101.ScheduledEventsAdditionalPublishingTargets_STATUS</summary>
    [JsonPropertyName("scheduledEventsAdditionalPublishingTargets")]
    public V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets? ScheduledEventsAdditionalPublishingTargets { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.UserInitiatedReboot_STATUS
    /// Specifies Reboot related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("userInitiatedReboot")]
    public V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyUserInitiatedReboot? UserInitiatedReboot { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.UserInitiatedRedeploy_STATUS
    /// Specifies Redeploy related Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("userInitiatedRedeploy")]
    public V1api20241101storageAvailabilitySetStatusScheduledEventsPolicyUserInitiatedRedeploy? UserInitiatedRedeploy { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.Sku_STATUS
/// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
/// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusStatuses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusSystemData
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

/// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfoDefaultVirtualMachineScaleSet
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
/// Storage version of v1api20241101.DefaultVirtualMachineScaleSetInfo_STATUS
/// Indicates the target Virtual Machine ScaleSet properties upon triggering a seamless migration without downtime of the
/// VMs via the ConvertToVirtualMachineScaleSet API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("constrainedMaximumCapacity")]
    public bool? ConstrainedMaximumCapacity { get; set; }

    /// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
    [JsonPropertyName("defaultVirtualMachineScaleSet")]
    public V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfoDefaultVirtualMachineScaleSet? DefaultVirtualMachineScaleSet { get; set; }
}

/// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoMigrateToVirtualMachineScaleSet
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
/// Storage version of v1api20241101.VirtualMachineScaleSetMigrationInfo_STATUS
/// Describes the Availability Set properties related to migration to Flexible Virtual Machine Scale Set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.DefaultVirtualMachineScaleSetInfo_STATUS
    /// Indicates the target Virtual Machine ScaleSet properties upon triggering a seamless migration without downtime of the
    /// VMs via the ConvertToVirtualMachineScaleSet API.
    /// </summary>
    [JsonPropertyName("defaultVirtualMachineScaleSetInfo")]
    public V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfo? DefaultVirtualMachineScaleSetInfo { get; set; }

    /// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
    [JsonPropertyName("migrateToVirtualMachineScaleSet")]
    public V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfoMigrateToVirtualMachineScaleSet? MigrateToVirtualMachineScaleSet { get; set; }
}

/// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatusVirtualMachines
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
/// Storage version of v1api20241101.AvailabilitySet_STATUS
/// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines
/// specified in the same availability set are allocated to different nodes to maximize availability. For more information
/// about availability sets, see [Availability sets
/// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure
/// planned maintenance, see [Maintenance and updates for Virtual Machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to
/// an availability set at creation time. An existing VM cannot be added to an availability set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101storageAvailabilitySetStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20241101storageAvailabilitySetStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    [JsonPropertyName("platformUpdateDomainCount")]
    public int? PlatformUpdateDomainCount { get; set; }

    /// <summary>Storage version of v1api20241101.SubResource_STATUS</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20241101storageAvailabilitySetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.ScheduledEventsPolicy_STATUS
    /// Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations.
    /// </summary>
    [JsonPropertyName("scheduledEventsPolicy")]
    public V1api20241101storageAvailabilitySetStatusScheduledEventsPolicy? ScheduledEventsPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.Sku_STATUS
    /// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
    /// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20241101storageAvailabilitySetStatusSku? Sku { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20241101storageAvailabilitySetStatusStatuses>? Statuses { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20241101storageAvailabilitySetStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.VirtualMachineScaleSetMigrationInfo_STATUS
    /// Describes the Availability Set properties related to migration to Flexible Virtual Machine Scale Set.
    /// </summary>
    [JsonPropertyName("virtualMachineScaleSetMigrationInfo")]
    public V1api20241101storageAvailabilitySetStatusVirtualMachineScaleSetMigrationInfo? VirtualMachineScaleSetMigrationInfo { get; set; }

    [JsonPropertyName("virtualMachines")]
    public IList<V1api20241101storageAvailabilitySetStatusVirtualMachines>? VirtualMachines { get; set; }
}

/// <summary>
/// Storage version of v1api20241101.AvailabilitySet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101storageAvailabilitySet : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20241101storageAvailabilitySetSpec?>, IStatus<V1api20241101storageAvailabilitySetStatus?>
{
    public const string KubeApiVersion = "v1api20241101storage";
    public const string KubeKind = "AvailabilitySet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "availabilitysets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20241101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AvailabilitySet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20241101.AvailabilitySet_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20241101storageAvailabilitySetSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20241101.AvailabilitySet_STATUS
    /// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines
    /// specified in the same availability set are allocated to different nodes to maximize availability. For more information
    /// about availability sets, see [Availability sets
    /// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure
    /// planned maintenance, see [Maintenance and updates for Virtual Machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to
    /// an availability set at creation time. An existing VM cannot be added to an availability set.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20241101storageAvailabilitySetStatus? Status { get; set; }
}