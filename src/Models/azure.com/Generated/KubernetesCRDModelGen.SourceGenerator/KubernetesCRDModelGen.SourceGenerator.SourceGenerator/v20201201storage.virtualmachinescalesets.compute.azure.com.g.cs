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
/// Storage version of v20201201.VirtualMachineScaleSet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201storageVirtualMachineScaleSetList : IKubernetesObject<V1ListMeta>, IItems<V20201201storageVirtualMachineScaleSet>
{
    public const string KubeApiVersion = "v20201201storage";
    public const string KubeKind = "VirtualMachineScaleSetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20201201storageVirtualMachineScaleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20201201storageVirtualMachineScaleSet> Items { get; set; }
}

/// <summary>
/// Storage version of v20201201.AdditionalCapabilities
/// Enables or disables a capability on the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecAdditionalCapabilities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.AutomaticRepairsPolicy
/// Specifies the configuration parameters for automatic repairs on the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecAutomaticRepairsPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>
/// Storage version of v20201201.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecHostGroupReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecHostGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecHostGroupReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20201201.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetIdentity
/// Identity for the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecIdentity
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
    public IList<V20201201storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions
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
public partial class V20201201storageVirtualMachineScaleSetSpecOperatorSpecSecretExpressions
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
/// Storage version of v20201201.VirtualMachineScaleSetOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20201201storageVirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20201201storageVirtualMachineScaleSetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20201201.Plan
/// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
/// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
/// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
/// Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecPlan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecProximityPlacementGroupReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecProximityPlacementGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.ScaleInPolicy
/// Describes a scale-in policy for a virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecScaleInPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary>
/// Storage version of v20201201.Sku
/// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
/// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecSku
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
/// Storage version of v20201201.AutomaticOSUpgradePolicy
/// The configuration parameters used for performing automatic OS upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }
}

/// <summary>
/// Storage version of v20201201.RollingUpgradePolicy
/// The configuration parameters used while performing a rolling upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>
/// Storage version of v20201201.UpgradePolicy
/// Describes an upgrade policy - automatic, manual, or rolling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.AutomaticOSUpgradePolicy
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20201201storageVirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Storage version of v20201201.RollingUpgradePolicy
    /// The configuration parameters used while performing a rolling upgrade.
    /// </summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V20201201storageVirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>
/// Storage version of v20201201.BillingProfile
/// Specifies the billing related details of a Azure Spot VM or VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>
/// Storage version of v20201201.BootDiagnostics
/// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the
/// VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>
/// Storage version of v20201201.DiagnosticsProfile
/// Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.BootDiagnostics
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the
    /// VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetExtension
/// Describes a Virtual Machine Scale Set Extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("protectedSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings? ProtectedSettings { get; set; }

    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetExtensionProfile
/// Describes a virtual machine scale set extension profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("extensions")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference
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
/// Storage version of v20201201.ApiEntityReference
/// The API entity reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetNetworkConfigurationDnsSettings
/// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
/// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetIpTag
/// Contains the IP tag associated with the public IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfiguration
/// Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
    /// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("ipTags")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference
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

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
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
/// Storage version of v20201201.ApiEntityReference
/// The API entity reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetIPConfiguration
/// Describes a virtual machine scale set network profile&apos;s IP configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfiguration
    /// Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration
    /// </summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference? Reference { get; set; }

    /// <summary>
    /// Storage version of v20201201.ApiEntityReference
    /// The API entity reference.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference
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
/// Storage version of v20201201.VirtualMachineScaleSetNetworkConfiguration
/// Describes a virtual machine scale set network profile&apos;s network configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetNetworkConfigurationDnsSettings
    /// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    [JsonPropertyName("ipConfigurations")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetNetworkProfile
/// Describes a virtual machine scale set network profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.ApiEntityReference
    /// The API entity reference.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20201201.LinuxPatchSettings
/// Specifies settings related to VM Guest Patching on Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>
/// Storage version of v20201201.SshPublicKeySpec
/// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Storage version of v20201201.SshConfiguration
/// SSH configuration for Linux based VMs running on Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v20201201.LinuxConfiguration
/// Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux
/// distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>
    /// Storage version of v20201201.LinuxPatchSettings
    /// Specifies settings related to VM Guest Patching on Linux.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// Storage version of v20201201.SshConfiguration
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    [JsonPropertyName("ssh")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VaultCertificate
/// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>
/// Storage version of v20201201.VaultSecretGroup
/// Describes a set of certificates which are all in the same Key Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    [JsonPropertyName("vaultCertificates")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Storage version of v20201201.AdditionalUnattendContent
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("componentName")]
    public string? ComponentName { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("passName")]
    public string? PassName { get; set; }

    [JsonPropertyName("settingName")]
    public string? SettingName { get; set; }
}

/// <summary>
/// Storage version of v20201201.PatchSettings
/// Specifies settings related to VM Guest Patching on Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>
/// Storage version of v20201201.WinRMListener
/// Describes Protocol and thumbprint of Windows Remote Management listener
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Storage version of v20201201.WinRMConfiguration
/// Describes Windows Remote Management configuration of the VM
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("listeners")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>
/// Storage version of v20201201.WindowsConfiguration
/// Specifies Windows operating system settings on the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// Storage version of v20201201.PatchSettings
    /// Specifies settings related to VM Guest Patching on Windows.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Storage version of v20201201.WinRMConfiguration
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    [JsonPropertyName("winRM")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetOSProfile
/// Describes a virtual machine scale set OS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("adminPassword")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword? AdminPassword { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// Storage version of v20201201.LinuxConfiguration
    /// Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux
    /// distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>
    /// Storage version of v20201201.WindowsConfiguration
    /// Specifies Windows operating system settings on the virtual machine.
    /// </summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>Storage version of v20201201.TerminateNotificationProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>Storage version of v20201201.ScheduledEventsProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.TerminateNotificationProfile</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// Storage version of v20201201.UefiSettings
/// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum
/// api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.SecurityProfile
/// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>
    /// Storage version of v20201201.UefiSettings
    /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum
    /// api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters
/// Describes the parameters of a ScaleSet managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetDataDisk
/// Describes a virtual machine scale set data disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters
    /// Describes the parameters of a ScaleSet managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference
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
/// Storage version of v20201201.ImageReference
/// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
/// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
/// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
/// when you create the scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference? Reference { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20201201.DiffDiskSettings
/// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
/// NOTE: The
/// ephemeral disk settings can only be specified for managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("option")]
    public string? Option { get; set; }

    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualHardDisk
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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

/// <summary>Storage version of v20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters
/// Describes the parameters of a ScaleSet managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetOSDisk
/// Describes a virtual machine scale set operating system disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// Storage version of v20201201.DiffDiskSettings
    /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
    /// NOTE: The
    /// ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualHardDisk
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters
    /// Describes the parameters of a ScaleSet managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetStorageProfile
/// Describes a virtual machine scale set storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataDisks")]
    public IList<V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// Storage version of v20201201.ImageReference
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetOSDisk
    /// Describes a virtual machine scale set operating system disk.
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetVMProfile
/// Describes a virtual machine scale set virtual machine profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.BillingProfile
    /// Specifies the billing related details of a Azure Spot VM or VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.DiagnosticsProfile
    /// Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetExtensionProfile
    /// Describes a virtual machine scale set extension profile.
    /// </summary>
    [JsonPropertyName("extensionProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetNetworkProfile
    /// Describes a virtual machine scale set network profile.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetOSProfile
    /// Describes a virtual machine scale set OS profile.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfile? OsProfile { get; set; }

    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v20201201.ScheduledEventsProfile</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.SecurityProfile
    /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetStorageProfile
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile? StorageProfile { get; set; }
}

/// <summary>Storage version of v20201201.VirtualMachineScaleSet_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.AdditionalCapabilities
    /// Enables or disables a capability on the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20201201storageVirtualMachineScaleSetSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Storage version of v20201201.AutomaticRepairsPolicy
    /// Specifies the configuration parameters for automatic repairs on the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20201201storageVirtualMachineScaleSetSpecAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>
    /// Storage version of v20201201.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20201201storageVirtualMachineScaleSetSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("hostGroup")]
    public V20201201storageVirtualMachineScaleSetSpecHostGroup? HostGroup { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetIdentity
    /// Identity for the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20201201storageVirtualMachineScaleSetSpecIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20201201storageVirtualMachineScaleSetSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("orchestrationMode")]
    public string? OrchestrationMode { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20201201storageVirtualMachineScaleSetSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20201201.Plan
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
    /// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
    /// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
    /// Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V20201201storageVirtualMachineScaleSetSpecPlan? Plan { get; set; }

    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>Storage version of v20201201.SubResource</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V20201201storageVirtualMachineScaleSetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v20201201.ScaleInPolicy
    /// Describes a scale-in policy for a virtual machine scale set.
    /// </summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20201201storageVirtualMachineScaleSetSpecScaleInPolicy? ScaleInPolicy { get; set; }

    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v20201201.Sku
    /// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
    /// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20201201storageVirtualMachineScaleSetSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v20201201.UpgradePolicy
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// </summary>
    [JsonPropertyName("upgradePolicy")]
    public V20201201storageVirtualMachineScaleSetSpecUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetVMProfile
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20201201storageVirtualMachineScaleSetSpecVirtualMachineProfile? VirtualMachineProfile { get; set; }

    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v20201201.AdditionalCapabilities_STATUS
/// Enables or disables a capability on the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusAdditionalCapabilities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.AutomaticRepairsPolicy_STATUS
/// Specifies the configuration parameters for automatic repairs on the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusAutomaticRepairsPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusConditions
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
/// Storage version of v20201201.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusHostGroup
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

/// <summary>Storage version of v20201201.VirtualMachineScaleSetIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusIdentityUserAssignedIdentities
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
/// Storage version of v20201201.VirtualMachineScaleSetIdentity_STATUS
/// Identity for the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusIdentity
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
    public IDictionary<string, V20201201storageVirtualMachineScaleSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20201201.Plan_STATUS
/// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
/// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
/// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
/// Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusPlan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusProximityPlacementGroup
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
/// Storage version of v20201201.ScaleInPolicy_STATUS
/// Describes a scale-in policy for a virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusScaleInPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary>
/// Storage version of v20201201.Sku_STATUS
/// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
/// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusSku
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
/// Storage version of v20201201.AutomaticOSUpgradePolicy_STATUS
/// The configuration parameters used for performing automatic OS upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }
}

/// <summary>
/// Storage version of v20201201.RollingUpgradePolicy_STATUS
/// The configuration parameters used while performing a rolling upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>
/// Storage version of v20201201.UpgradePolicy_STATUS
/// Describes an upgrade policy - automatic, manual, or rolling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.AutomaticOSUpgradePolicy_STATUS
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20201201storageVirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Storage version of v20201201.RollingUpgradePolicy_STATUS
    /// The configuration parameters used while performing a rolling upgrade.
    /// </summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V20201201storageVirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>
/// Storage version of v20201201.BillingProfile_STATUS
/// Specifies the billing related details of a Azure Spot VM or VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>
/// Storage version of v20201201.BootDiagnostics_STATUS
/// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the
/// VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>
/// Storage version of v20201201.DiagnosticsProfile_STATUS
/// Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.BootDiagnostics_STATUS
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the
    /// VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetExtension_STATUS
/// Describes a Virtual Machine Scale Set Extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetExtensionProfile_STATUS
/// Describes a virtual machine scale set extension profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("extensions")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>
/// Storage version of v20201201.ApiEntityReference_STATUS
/// The API entity reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe
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
/// Storage version of v20201201.VirtualMachineScaleSetNetworkConfigurationDnsSettings_STATUS
/// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
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

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
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

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
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

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
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
/// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings_STATUS
/// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetIpTag_STATUS
/// Contains the IP tag associated with the public IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
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
/// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfiguration_STATUS
/// Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings_STATUS
    /// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("ipTags")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }
}

/// <summary>
/// Storage version of v20201201.ApiEntityReference_STATUS
/// The API entity reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
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
/// Storage version of v20201201.VirtualMachineScaleSetIPConfiguration_STATUS
/// Describes a virtual machine scale set network profile&apos;s IP configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetPublicIPAddressConfiguration_STATUS
    /// Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration
    /// </summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>
    /// Storage version of v20201201.ApiEntityReference_STATUS
    /// The API entity reference.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
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
/// Storage version of v20201201.VirtualMachineScaleSetNetworkConfiguration_STATUS
/// Describes a virtual machine scale set network profile&apos;s network configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetNetworkConfigurationDnsSettings_STATUS
    /// Describes a virtual machines scale sets network configuration&apos;s DNS settings.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("ipConfigurations")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetNetworkProfile_STATUS
/// Describes a virtual machine scale set network profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.ApiEntityReference_STATUS
    /// The API entity reference.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>
/// Storage version of v20201201.LinuxPatchSettings_STATUS
/// Specifies settings related to VM Guest Patching on Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>
/// Storage version of v20201201.SshPublicKey_STATUS
/// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Storage version of v20201201.SshConfiguration_STATUS
/// SSH configuration for Linux based VMs running on Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v20201201.LinuxConfiguration_STATUS
/// Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux
/// distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>
    /// Storage version of v20201201.LinuxPatchSettings_STATUS
    /// Specifies settings related to VM Guest Patching on Linux.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// Storage version of v20201201.SshConfiguration_STATUS
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    [JsonPropertyName("ssh")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault
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
/// Storage version of v20201201.VaultCertificate_STATUS
/// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>
/// Storage version of v20201201.VaultSecretGroup_STATUS
/// Describes a set of certificates which are all in the same Key Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    [JsonPropertyName("vaultCertificates")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Storage version of v20201201.AdditionalUnattendContent_STATUS
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("componentName")]
    public string? ComponentName { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("passName")]
    public string? PassName { get; set; }

    [JsonPropertyName("settingName")]
    public string? SettingName { get; set; }
}

/// <summary>
/// Storage version of v20201201.PatchSettings_STATUS
/// Specifies settings related to VM Guest Patching on Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>
/// Storage version of v20201201.WinRMListener_STATUS
/// Describes Protocol and thumbprint of Windows Remote Management listener
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Storage version of v20201201.WinRMConfiguration_STATUS
/// Describes Windows Remote Management configuration of the VM
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("listeners")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>
/// Storage version of v20201201.WindowsConfiguration_STATUS
/// Specifies Windows operating system settings on the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// Storage version of v20201201.PatchSettings_STATUS
    /// Specifies settings related to VM Guest Patching on Windows.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Storage version of v20201201.WinRMConfiguration_STATUS
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    [JsonPropertyName("winRM")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetOSProfile_STATUS
/// Describes a virtual machine scale set OS profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// Storage version of v20201201.LinuxConfiguration_STATUS
    /// Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux
    /// distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>
    /// Storage version of v20201201.WindowsConfiguration_STATUS
    /// Specifies Windows operating system settings on the virtual machine.
    /// </summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>Storage version of v20201201.TerminateNotificationProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>Storage version of v20201201.ScheduledEventsProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.TerminateNotificationProfile_STATUS</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// Storage version of v20201201.UefiSettings_STATUS
/// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum
/// api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.SecurityProfile_STATUS
/// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>
    /// Storage version of v20201201.UefiSettings_STATUS
    /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum
    /// api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
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
/// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters_STATUS
/// Describes the parameters of a ScaleSet managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetDataDisk_STATUS
/// Describes a virtual machine scale set data disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters_STATUS
    /// Describes the parameters of a ScaleSet managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.ImageReference_STATUS
/// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
/// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
/// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
/// when you create the scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exactVersion")]
    public string? ExactVersion { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20201201.DiffDiskSettings_STATUS
/// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
/// NOTE: The
/// ephemeral disk settings can only be specified for managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("option")]
    public string? Option { get; set; }

    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualHardDisk_STATUS
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Storage version of v20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
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
/// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters_STATUS
/// Describes the parameters of a ScaleSet managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetOSDisk_STATUS
/// Describes a virtual machine scale set operating system disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// Storage version of v20201201.DiffDiskSettings_STATUS
    /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
    /// NOTE: The
    /// ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualHardDisk_STATUS
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetManagedDiskParameters_STATUS
    /// Describes the parameters of a ScaleSet managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetStorageProfile_STATUS
/// Describes a virtual machine scale set storage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataDisks")]
    public IList<V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// Storage version of v20201201.ImageReference_STATUS
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetOSDisk_STATUS
    /// Describes a virtual machine scale set operating system disk.
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSetVMProfile_STATUS
/// Describes a virtual machine scale set virtual machine profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.BillingProfile_STATUS
    /// Specifies the billing related details of a Azure Spot VM or VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.DiagnosticsProfile_STATUS
    /// Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetExtensionProfile_STATUS
    /// Describes a virtual machine scale set extension profile.
    /// </summary>
    [JsonPropertyName("extensionProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetNetworkProfile_STATUS
    /// Describes a virtual machine scale set network profile.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetOSProfile_STATUS
    /// Describes a virtual machine scale set OS profile.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfile? OsProfile { get; set; }

    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v20201201.ScheduledEventsProfile_STATUS</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.SecurityProfile_STATUS
    /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetStorageProfile_STATUS
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile? StorageProfile { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSet_STATUS
/// Describes a Virtual Machine Scale Set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201storageVirtualMachineScaleSetStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20201201.AdditionalCapabilities_STATUS
    /// Enables or disables a capability on the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20201201storageVirtualMachineScaleSetStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Storage version of v20201201.AutomaticRepairsPolicy_STATUS
    /// Specifies the configuration parameters for automatic repairs on the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20201201storageVirtualMachineScaleSetStatusAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20201201storageVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>
    /// Storage version of v20201201.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20201201storageVirtualMachineScaleSetStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("hostGroup")]
    public V20201201storageVirtualMachineScaleSetStatusHostGroup? HostGroup { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetIdentity_STATUS
    /// Identity for the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20201201storageVirtualMachineScaleSetStatusIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("orchestrationMode")]
    public string? OrchestrationMode { get; set; }

    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>
    /// Storage version of v20201201.Plan_STATUS
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
    /// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
    /// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
    /// Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V20201201storageVirtualMachineScaleSetStatusPlan? Plan { get; set; }

    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v20201201.SubResource_STATUS</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V20201201storageVirtualMachineScaleSetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v20201201.ScaleInPolicy_STATUS
    /// Describes a scale-in policy for a virtual machine scale set.
    /// </summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20201201storageVirtualMachineScaleSetStatusScaleInPolicy? ScaleInPolicy { get; set; }

    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v20201201.Sku_STATUS
    /// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is
    /// currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20201201storageVirtualMachineScaleSetStatusSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>
    /// Storage version of v20201201.UpgradePolicy_STATUS
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// </summary>
    [JsonPropertyName("upgradePolicy")]
    public V20201201storageVirtualMachineScaleSetStatusUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSetVMProfile_STATUS
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20201201storageVirtualMachineScaleSetStatusVirtualMachineProfile? VirtualMachineProfile { get; set; }

    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v20201201.VirtualMachineScaleSet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201storageVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V20201201storageVirtualMachineScaleSetSpec?>, IStatus<V20201201storageVirtualMachineScaleSetStatus?>
{
    public const string KubeApiVersion = "v20201201storage";
    public const string KubeKind = "VirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20201201.VirtualMachineScaleSet_Spec</summary>
    [JsonPropertyName("spec")]
    public V20201201storageVirtualMachineScaleSetSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20201201.VirtualMachineScaleSet_STATUS
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [JsonPropertyName("status")]
    public V20201201storageVirtualMachineScaleSetStatus? Status { get; set; }
}