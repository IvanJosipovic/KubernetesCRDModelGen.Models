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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2025-04-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250401CapacityReservationList : IKubernetesObject<V1ListMeta>, IItems<V1api20250401CapacityReservation>
{
    public const string KubeApiVersion = "v1api20250401";
    public const string KubeKind = "CapacityReservationList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "capacityreservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20250401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityReservationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250401CapacityReservation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250401CapacityReservation> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250401CapacityReservationSpecOperatorSpecSecretExpressions
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
public partial class V1api20250401CapacityReservationSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250401CapacityReservationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250401CapacityReservationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a compute.azure.com/CapacityReservationGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ScheduleProfile: Defines the schedule for Block-type capacity reservations. Specifies the schedule during which capacity
/// reservation is active and VM or VMSS resource can be allocated using reservation. This property is required and only
/// supported when the capacity reservation group type is &apos;Block&apos;. The scheduleProfile, start, and end fields are immutable
/// after creation. Minimum API version: 2025-04-01. Please refer to https://aka.ms/blockcapacityreservation for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationSpecScheduleProfile
{
    /// <summary>
    /// End: The required end date for block capacity reservations. Must be after the start date, with a duration of either
    /// 1–14 whole days or 3–26 whole weeks. Example: 2025-06-28.
    /// </summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>
    /// Start: The required start date for block capacity reservations. Must be today or within 56 days in the future. For
    /// same-day scheduling, requests must be submitted before 11:30 AM UTC. Example: 2025-06-27.
    /// </summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// Sku: SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set.  For
/// Block capacity reservations, sku.capacity can only accept values 1, 2, 4, 8, 16, 32, 64. Currently VM Skus with the
/// capability called &apos;CapacityReservationSupported&apos; set to true are supported. When &apos;CapacityReservationSupported&apos; is true,
/// the SKU capability also specifies the &apos;SupportedCapacityReservationTypes&apos;, which lists the types of capacity
/// reservations (such as Targeted or Block) that the SKU supports. Refer to List Microsoft.Compute SKUs in a region
/// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationSpecSku
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
public partial class V1api20250401CapacityReservationSpec
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
    public V1api20250401CapacityReservationSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a compute.azure.com/CapacityReservationGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250401CapacityReservationSpecOwner Owner { get; set; }

    /// <summary>
    /// ScheduleProfile: Defines the schedule for Block-type capacity reservations. Specifies the schedule during which capacity
    /// reservation is active and VM or VMSS resource can be allocated using reservation. This property is required and only
    /// supported when the capacity reservation group type is &apos;Block&apos;. The scheduleProfile, start, and end fields are immutable
    /// after creation. Minimum API version: 2025-04-01. Please refer to https://aka.ms/blockcapacityreservation for more
    /// details.
    /// </summary>
    [JsonPropertyName("scheduleProfile")]
    public V1api20250401CapacityReservationSpecScheduleProfile? ScheduleProfile { get; set; }

    /// <summary>
    /// Sku: SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set.  For
    /// Block capacity reservations, sku.capacity can only accept values 1, 2, 4, 8, 16, 32, 64. Currently VM Skus with the
    /// capability called &apos;CapacityReservationSupported&apos; set to true are supported. When &apos;CapacityReservationSupported&apos; is true,
    /// the SKU capability also specifies the &apos;SupportedCapacityReservationTypes&apos;, which lists the types of capacity
    /// reservations (such as Targeted or Block) that the SKU supports. Refer to List Microsoft.Compute SKUs in a region
    /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values.
    /// </summary>
    [JsonPropertyName("sku")]
    public required V1api20250401CapacityReservationSpecSku Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Zones: The availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusConditions
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

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusInstanceViewStatuses
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusInstanceViewUtilizationInfoVirtualMachinesAllocated
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>UtilizationInfo: Unutilized capacity of the capacity reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusInstanceViewUtilizationInfo
{
    /// <summary>
    /// CurrentCapacity: The value provides the current capacity of the VM size which was reserved successfully and for which
    /// the customer is getting billed. Minimum api-version: 2022-08-01.
    /// </summary>
    [JsonPropertyName("currentCapacity")]
    public int? CurrentCapacity { get; set; }

    /// <summary>VirtualMachinesAllocated: A list of all virtual machines resource ids allocated against the capacity reservation.</summary>
    [JsonPropertyName("virtualMachinesAllocated")]
    public IList<V1api20250401CapacityReservationStatusInstanceViewUtilizationInfoVirtualMachinesAllocated>? VirtualMachinesAllocated { get; set; }
}

/// <summary>InstanceView: The Capacity reservation instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusInstanceView
{
    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20250401CapacityReservationStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>UtilizationInfo: Unutilized capacity of the capacity reservation.</summary>
    [JsonPropertyName("utilizationInfo")]
    public V1api20250401CapacityReservationStatusInstanceViewUtilizationInfo? UtilizationInfo { get; set; }
}

/// <summary>
/// ScheduleProfile: Defines the schedule for Block-type capacity reservations. Specifies the schedule during which capacity
/// reservation is active and VM or VMSS resource can be allocated using reservation. This property is required and only
/// supported when the capacity reservation group type is &apos;Block&apos;. The scheduleProfile, start, and end fields are immutable
/// after creation. Minimum API version: 2025-04-01. Please refer to https://aka.ms/blockcapacityreservation for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusScheduleProfile
{
    /// <summary>
    /// End: The required end date for block capacity reservations. Must be after the start date, with a duration of either
    /// 1–14 whole days or 3–26 whole weeks. Example: 2025-06-28.
    /// </summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>
    /// Start: The required start date for block capacity reservations. Must be today or within 56 days in the future. For
    /// same-day scheduling, requests must be submitted before 11:30 AM UTC. Example: 2025-06-27.
    /// </summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// Sku: SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set.  For
/// Block capacity reservations, sku.capacity can only accept values 1, 2, 4, 8, 16, 32, 64. Currently VM Skus with the
/// capability called &apos;CapacityReservationSupported&apos; set to true are supported. When &apos;CapacityReservationSupported&apos; is true,
/// the SKU capability also specifies the &apos;SupportedCapacityReservationTypes&apos;, which lists the types of capacity
/// reservations (such as Targeted or Block) that the SKU supports. Refer to List Microsoft.Compute SKUs in a region
/// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusSku
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

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatusVirtualMachinesAssociated
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401CapacityReservationStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250401CapacityReservationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InstanceView: The Capacity reservation instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20250401CapacityReservationStatusInstanceView? InstanceView { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PlatformFaultDomainCount: Specifies the value of fault domain count that Capacity Reservation supports for requested VM
    /// size. Note: The fault domain count specified for a resource (like virtual machines scale set) must be less than or equal
    /// to this value if it deploys using capacity reservation. Minimum api-version: 2022-08-01.
    /// </summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ProvisioningTime: The date time when the capacity reservation was last updated.</summary>
    [JsonPropertyName("provisioningTime")]
    public string? ProvisioningTime { get; set; }

    /// <summary>
    /// ReservationId: A unique id generated and assigned to the capacity reservation by the platform which does not change
    /// throughout the lifetime of the resource.
    /// </summary>
    [JsonPropertyName("reservationId")]
    public string? ReservationId { get; set; }

    /// <summary>
    /// ScheduleProfile: Defines the schedule for Block-type capacity reservations. Specifies the schedule during which capacity
    /// reservation is active and VM or VMSS resource can be allocated using reservation. This property is required and only
    /// supported when the capacity reservation group type is &apos;Block&apos;. The scheduleProfile, start, and end fields are immutable
    /// after creation. Minimum API version: 2025-04-01. Please refer to https://aka.ms/blockcapacityreservation for more
    /// details.
    /// </summary>
    [JsonPropertyName("scheduleProfile")]
    public V1api20250401CapacityReservationStatusScheduleProfile? ScheduleProfile { get; set; }

    /// <summary>
    /// Sku: SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set.  For
    /// Block capacity reservations, sku.capacity can only accept values 1, 2, 4, 8, 16, 32, 64. Currently VM Skus with the
    /// capability called &apos;CapacityReservationSupported&apos; set to true are supported. When &apos;CapacityReservationSupported&apos; is true,
    /// the SKU capability also specifies the &apos;SupportedCapacityReservationTypes&apos;, which lists the types of capacity
    /// reservations (such as Targeted or Block) that the SKU supports. Refer to List Microsoft.Compute SKUs in a region
    /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20250401CapacityReservationStatusSku? Sku { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250401CapacityReservationStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TimeCreated: Specifies the time at which the Capacity Reservation resource was created. Minimum api-version: 2021-11-01.</summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualMachinesAssociated: A list of all virtual machine resource ids that are associated with the capacity reservation.</summary>
    [JsonPropertyName("virtualMachinesAssociated")]
    public IList<V1api20250401CapacityReservationStatusVirtualMachinesAssociated>? VirtualMachinesAssociated { get; set; }

    /// <summary>Zones: The availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2025-04-01/ComputeRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250401CapacityReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250401CapacityReservationSpec?>, IStatus<V1api20250401CapacityReservationStatus?>
{
    public const string KubeApiVersion = "v1api20250401";
    public const string KubeKind = "CapacityReservation";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "capacityreservations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20250401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityReservation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250401CapacityReservationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20250401CapacityReservationStatus? Status { get; set; }
}