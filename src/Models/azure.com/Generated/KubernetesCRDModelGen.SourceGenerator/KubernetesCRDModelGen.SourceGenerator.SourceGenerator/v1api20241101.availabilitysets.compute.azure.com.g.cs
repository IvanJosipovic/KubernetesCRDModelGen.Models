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
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101AvailabilitySetList : IKubernetesObject<V1ListMeta>, IItems<V1api20241101AvailabilitySet>
{
    public const string KubeApiVersion = "v1api20241101";
    public const string KubeKind = "AvailabilitySetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "availabilitysets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20241101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AvailabilitySetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20241101AvailabilitySet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20241101AvailabilitySet> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20241101AvailabilitySetSpecOperatorSpecSecretExpressions
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
public partial class V1api20241101AvailabilitySetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20241101AvailabilitySetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20241101AvailabilitySetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecProximityPlacementGroupReference
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
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the availability set should be
/// assigned to. Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecProximityPlacementGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20241101AvailabilitySetSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>
/// EventGridAndResourceGraph: The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event
/// setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph
{
    /// <summary>Enable: Specifies if event grid and resource graph is enabled for Scheduled event related configurations.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>
/// ScheduledEventsAdditionalPublishingTargets: The configuration parameters used while publishing
/// scheduledEventsAdditionalPublishingTargets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets
{
    /// <summary>
    /// EventGridAndResourceGraph: The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event
    /// setting.
    /// </summary>
    [JsonPropertyName("eventGridAndResourceGraph")]
    public V1api20241101AvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph? EventGridAndResourceGraph { get; set; }
}

/// <summary>
/// UserInitiatedReboot: The configuration parameters used while creating userInitiatedReboot scheduled event setting
/// creation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecScheduledEventsPolicyUserInitiatedReboot
{
    /// <summary>AutomaticallyApprove: Specifies Reboot Scheduled Event related configurations.</summary>
    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// UserInitiatedRedeploy: The configuration parameters used while creating userInitiatedRedeploy scheduled event setting
/// creation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecScheduledEventsPolicyUserInitiatedRedeploy
{
    /// <summary>AutomaticallyApprove: Specifies Redeploy Scheduled Event related configurations.</summary>
    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// ScheduledEventsPolicy: Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related
/// configurations for the availability set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecScheduledEventsPolicy
{
    /// <summary>
    /// ScheduledEventsAdditionalPublishingTargets: The configuration parameters used while publishing
    /// scheduledEventsAdditionalPublishingTargets.
    /// </summary>
    [JsonPropertyName("scheduledEventsAdditionalPublishingTargets")]
    public V1api20241101AvailabilitySetSpecScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets? ScheduledEventsAdditionalPublishingTargets { get; set; }

    /// <summary>
    /// UserInitiatedReboot: The configuration parameters used while creating userInitiatedReboot scheduled event setting
    /// creation.
    /// </summary>
    [JsonPropertyName("userInitiatedReboot")]
    public V1api20241101AvailabilitySetSpecScheduledEventsPolicyUserInitiatedReboot? UserInitiatedReboot { get; set; }

    /// <summary>
    /// UserInitiatedRedeploy: The configuration parameters used while creating userInitiatedRedeploy scheduled event setting
    /// creation.
    /// </summary>
    [JsonPropertyName("userInitiatedRedeploy")]
    public V1api20241101AvailabilitySetSpecScheduledEventsPolicyUserInitiatedRedeploy? UserInitiatedRedeploy { get; set; }
}

/// <summary>
/// Sku: Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of
/// values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks.
/// Default value is &apos;Classic&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpecSku
{
    /// <summary>Capacity: Specifies the number of virtual machines in the scale set.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Tier: Specifies the tier of virtual machines in a scale set.
    /// Possible Values:
    /// Standard
    /// Basic
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20241101AvailabilitySetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20241101AvailabilitySetSpecOwner Owner { get; set; }

    /// <summary>PlatformFaultDomainCount: Fault Domain count.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>PlatformUpdateDomainCount: Update Domain count.</summary>
    [JsonPropertyName("platformUpdateDomainCount")]
    public int? PlatformUpdateDomainCount { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the availability set should be
    /// assigned to. Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20241101AvailabilitySetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// ScheduledEventsPolicy: Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related
    /// configurations for the availability set.
    /// </summary>
    [JsonPropertyName("scheduledEventsPolicy")]
    public V1api20241101AvailabilitySetSpecScheduledEventsPolicy? ScheduledEventsPolicy { get; set; }

    /// <summary>
    /// Sku: Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of
    /// values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks.
    /// Default value is &apos;Classic&apos;.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20241101AvailabilitySetSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusConditions
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
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the availability set should be
/// assigned to. Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusProximityPlacementGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// EventGridAndResourceGraph: The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event
/// setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph
{
    /// <summary>Enable: Specifies if event grid and resource graph is enabled for Scheduled event related configurations.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary>
/// ScheduledEventsAdditionalPublishingTargets: The configuration parameters used while publishing
/// scheduledEventsAdditionalPublishingTargets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets
{
    /// <summary>
    /// EventGridAndResourceGraph: The configuration parameters used while creating eventGridAndResourceGraph Scheduled Event
    /// setting.
    /// </summary>
    [JsonPropertyName("eventGridAndResourceGraph")]
    public V1api20241101AvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargetsEventGridAndResourceGraph? EventGridAndResourceGraph { get; set; }
}

/// <summary>
/// UserInitiatedReboot: The configuration parameters used while creating userInitiatedReboot scheduled event setting
/// creation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusScheduledEventsPolicyUserInitiatedReboot
{
    /// <summary>AutomaticallyApprove: Specifies Reboot Scheduled Event related configurations.</summary>
    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// UserInitiatedRedeploy: The configuration parameters used while creating userInitiatedRedeploy scheduled event setting
/// creation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusScheduledEventsPolicyUserInitiatedRedeploy
{
    /// <summary>AutomaticallyApprove: Specifies Redeploy Scheduled Event related configurations.</summary>
    [JsonPropertyName("automaticallyApprove")]
    public bool? AutomaticallyApprove { get; set; }
}

/// <summary>
/// ScheduledEventsPolicy: Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related
/// configurations for the availability set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusScheduledEventsPolicy
{
    /// <summary>
    /// ScheduledEventsAdditionalPublishingTargets: The configuration parameters used while publishing
    /// scheduledEventsAdditionalPublishingTargets.
    /// </summary>
    [JsonPropertyName("scheduledEventsAdditionalPublishingTargets")]
    public V1api20241101AvailabilitySetStatusScheduledEventsPolicyScheduledEventsAdditionalPublishingTargets? ScheduledEventsAdditionalPublishingTargets { get; set; }

    /// <summary>
    /// UserInitiatedReboot: The configuration parameters used while creating userInitiatedReboot scheduled event setting
    /// creation.
    /// </summary>
    [JsonPropertyName("userInitiatedReboot")]
    public V1api20241101AvailabilitySetStatusScheduledEventsPolicyUserInitiatedReboot? UserInitiatedReboot { get; set; }

    /// <summary>
    /// UserInitiatedRedeploy: The configuration parameters used while creating userInitiatedRedeploy scheduled event setting
    /// creation.
    /// </summary>
    [JsonPropertyName("userInitiatedRedeploy")]
    public V1api20241101AvailabilitySetStatusScheduledEventsPolicyUserInitiatedRedeploy? UserInitiatedRedeploy { get; set; }
}

/// <summary>
/// Sku: Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of
/// values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks.
/// Default value is &apos;Classic&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusSku
{
    /// <summary>Capacity: Specifies the number of virtual machines in the scale set.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Tier: Specifies the tier of virtual machines in a scale set.
    /// Possible Values:
    /// Standard
    /// Basic
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusStatuses
{
    /// <summary>Code: The status code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: The short localizable label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: The level code.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Message: The detailed status message, including for alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: The time of the status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusSystemData
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

/// <summary>
/// DefaultVirtualMachineScaleSet: The default Virtual Machine ScaleSet Uri that the Availability Set will be moved to upon
/// triggering a seamless migration via the ConvertToVirtualMachineScaleSet API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfoDefaultVirtualMachineScaleSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// DefaultVirtualMachineScaleSetInfo: Indicates the target Virtual Machine ScaleSet properties upon triggering a seamless
/// migration without downtime of the VMs via the ConvertToVirtualMachineScaleSet API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfo
{
    /// <summary>
    /// ConstrainedMaximumCapacity: Indicates if the the maximum capacity of the default migrated Virtual Machine Scale Set
    /// after its migration will be constrained to a limited number of VMs.
    /// </summary>
    [JsonPropertyName("constrainedMaximumCapacity")]
    public bool? ConstrainedMaximumCapacity { get; set; }

    /// <summary>
    /// DefaultVirtualMachineScaleSet: The default Virtual Machine ScaleSet Uri that the Availability Set will be moved to upon
    /// triggering a seamless migration via the ConvertToVirtualMachineScaleSet API.
    /// </summary>
    [JsonPropertyName("defaultVirtualMachineScaleSet")]
    public V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfoDefaultVirtualMachineScaleSet? DefaultVirtualMachineScaleSet { get; set; }
}

/// <summary>MigrateToVirtualMachineScaleSet: Specifies the Virtual Machine Scale Set that the Availability Set is migrated to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoMigrateToVirtualMachineScaleSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>VirtualMachineScaleSetMigrationInfo: Describes the migration properties on the Availability Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfo
{
    /// <summary>
    /// DefaultVirtualMachineScaleSetInfo: Indicates the target Virtual Machine ScaleSet properties upon triggering a seamless
    /// migration without downtime of the VMs via the ConvertToVirtualMachineScaleSet API.
    /// </summary>
    [JsonPropertyName("defaultVirtualMachineScaleSetInfo")]
    public V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoDefaultVirtualMachineScaleSetInfo? DefaultVirtualMachineScaleSetInfo { get; set; }

    /// <summary>MigrateToVirtualMachineScaleSet: Specifies the Virtual Machine Scale Set that the Availability Set is migrated to.</summary>
    [JsonPropertyName("migrateToVirtualMachineScaleSet")]
    public V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfoMigrateToVirtualMachineScaleSet? MigrateToVirtualMachineScaleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatusVirtualMachines
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines
/// specified in the same availability set are allocated to different nodes to maximize availability. For more information
/// about availability sets, see [Availability sets
/// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure
/// planned maintenance, see [Maintenance and updates for Virtual Machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to
/// an availability set at creation time. An existing VM cannot be added to an availability set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241101AvailabilitySetStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20241101AvailabilitySetStatusConditions>? Conditions { get; set; }

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

    /// <summary>PlatformFaultDomainCount: Fault Domain count.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>PlatformUpdateDomainCount: Update Domain count.</summary>
    [JsonPropertyName("platformUpdateDomainCount")]
    public int? PlatformUpdateDomainCount { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the availability set should be
    /// assigned to. Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20241101AvailabilitySetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// ScheduledEventsPolicy: Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related
    /// configurations for the availability set.
    /// </summary>
    [JsonPropertyName("scheduledEventsPolicy")]
    public V1api20241101AvailabilitySetStatusScheduledEventsPolicy? ScheduledEventsPolicy { get; set; }

    /// <summary>
    /// Sku: Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of
    /// values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks.
    /// Default value is &apos;Classic&apos;.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20241101AvailabilitySetStatusSku? Sku { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20241101AvailabilitySetStatusStatuses>? Statuses { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20241101AvailabilitySetStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualMachineScaleSetMigrationInfo: Describes the migration properties on the Availability Set.</summary>
    [JsonPropertyName("virtualMachineScaleSetMigrationInfo")]
    public V1api20241101AvailabilitySetStatusVirtualMachineScaleSetMigrationInfo? VirtualMachineScaleSetMigrationInfo { get; set; }

    /// <summary>VirtualMachines: A list of references to all virtual machines in the availability set.</summary>
    [JsonPropertyName("virtualMachines")]
    public IList<V1api20241101AvailabilitySetStatusVirtualMachines>? VirtualMachines { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241101AvailabilitySet : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20241101AvailabilitySetSpec?>, IStatus<V1api20241101AvailabilitySetStatus?>
{
    public const string KubeApiVersion = "v1api20241101";
    public const string KubeKind = "AvailabilitySet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "availabilitysets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20241101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AvailabilitySet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20241101AvailabilitySetSpec? Spec { get; set; }

    /// <summary>
    /// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines
    /// specified in the same availability set are allocated to different nodes to maximize availability. For more information
    /// about availability sets, see [Availability sets
    /// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure
    /// planned maintenance, see [Maintenance and updates for Virtual Machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to
    /// an availability set at creation time. An existing VM cannot be added to an availability set.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20241101AvailabilitySetStatus? Status { get; set; }
}