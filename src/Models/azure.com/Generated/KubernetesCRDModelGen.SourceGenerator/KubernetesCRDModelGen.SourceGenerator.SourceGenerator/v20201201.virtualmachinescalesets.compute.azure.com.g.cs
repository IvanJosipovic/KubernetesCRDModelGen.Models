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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201VirtualMachineScaleSetList : IKubernetesObject<V1ListMeta>, IItems<V20201201VirtualMachineScaleSet>
{
    public const string KubeApiVersion = "v20201201";
    public const string KubeKind = "VirtualMachineScaleSetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20201201VirtualMachineScaleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20201201VirtualMachineScaleSet> Items { get; set; }
}

/// <summary>
/// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
/// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
/// disks with UltraSSD_LRS storage account type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecAdditionalCapabilities
{
    /// <summary>
    /// UltraSSDEnabled: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS
    /// storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual
    /// machine or virtual machine scale set only if this property is enabled.
    /// </summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecAutomaticRepairsPolicy
{
    /// <summary>
    /// Enabled: Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is
    /// false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// GracePeriod: The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time
    /// starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should
    /// be specified in ISO 8601 format. The minimum allowed grace period is 30 minutes (PT30M), which is also the default
    /// value. The maximum allowed grace period is 90 minutes (PT90M).
    /// </summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecExtendedLocationTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20201201VirtualMachineScaleSetSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecHostGroupReference
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
/// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
/// Minimum api-version: 2020-06-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecHostGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecHostGroupReference? Reference { get; set; }
}

/// <summary>
/// Type: The type of identity used for the virtual machine scale set. The type &apos;SystemAssigned, UserAssigned&apos; includes both
/// an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from
/// the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecIdentityTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecIdentityTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the virtual machine scale set. The type &apos;SystemAssigned, UserAssigned&apos; includes both
    /// an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from
    /// the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("type")]
    public V20201201VirtualMachineScaleSetSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the virtual machine scale set. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20201201VirtualMachineScaleSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions
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
public partial class V20201201VirtualMachineScaleSetSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20201201VirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20201201VirtualMachineScaleSetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OrchestrationMode: Specifies the orchestration mode for the virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecOrchestrationModeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecOrchestrationModeEnum
{
    [EnumMember(Value = "Flexible"), JsonStringEnumMemberName("Flexible")]
    Flexible,
    [EnumMember(Value = "Uniform"), JsonStringEnumMemberName("Uniform")]
    Uniform
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
/// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
/// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
/// programmatically, Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecPlan
{
    /// <summary>Name: The plan ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Product: Specifies the product of the image from the marketplace. This is the same value as Offer under the
    /// imageReference element.
    /// </summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>PromotionCode: The promotion code.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher ID.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecProximityPlacementGroupReference
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
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine scale set
/// should be assigned to.
/// Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecProximityPlacementGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecProximityPlacementGroupReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecScaleInPolicyRulesEnum>))]
public enum V20201201VirtualMachineScaleSetSpecScaleInPolicyRulesEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "NewestVM"), JsonStringEnumMemberName("NewestVM")]
    NewestVM,
    [EnumMember(Value = "OldestVM"), JsonStringEnumMemberName("OldestVM")]
    OldestVM
}

/// <summary>
/// ScaleInPolicy: Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual
/// Machine Scale Set is scaled-in.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecScaleInPolicy
{
    /// <summary>
    /// Rules: The rules to be followed when scaling-in a virtual machine scale set.
    /// Possible values are:
    /// Default When a virtual machine scale set is scaled in, the scale set will first be balanced across zones if it is a
    /// zonal scale set. Then, it will be balanced across Fault Domains as far as possible. Within each Fault Domain, the
    /// virtual machines chosen for removal will be the newest ones that are not protected from scale-in.
    /// OldestVM When a virtual machine scale set is being scaled-in, the oldest virtual machines that are not protected from
    /// scale-in will be chosen for removal. For zonal virtual machine scale sets, the scale set will first be balanced across
    /// zones. Within each zone, the oldest virtual machines that are not protected will be chosen for removal.
    /// NewestVM When a virtual machine scale set is being scaled-in, the newest virtual machines that are not protected from
    /// scale-in will be chosen for removal. For zonal virtual machine scale sets, the scale set will first be balanced across
    /// zones. Within each zone, the newest virtual machines that are not protected will be chosen for removal.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V20201201VirtualMachineScaleSetSpecScaleInPolicyRulesEnum>? Rules { get; set; }
}

/// <summary>Sku: The virtual machine scale set sku.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecSku
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

/// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>DisableAutomaticRollback: Whether OS image rollback feature should be disabled. Default value is false.</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>
    /// EnableAutomaticOSUpgrade: Indicates whether OS upgrades should automatically be applied to scale set instances in a
    /// rolling fashion when a newer version of the OS image becomes available. Default value is false.
    /// If this is set to true for Windows based scale sets,
    /// [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet)
    /// is automatically set to false and cannot be set to true.
    /// </summary>
    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }
}

/// <summary>
/// Mode: Specifies the mode of an upgrade to virtual machines in the scale set.
/// Possible values are:
/// Manual - You  control the application of updates to virtual machines in the scale set. You do this by using the
/// manualUpgrade action.
/// Automatic - All virtual machines in the scale set are  automatically updated at the same time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecUpgradePolicyModeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecUpgradePolicyModeEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "Rolling"), JsonStringEnumMemberName("Rolling")]
    Rolling
}

/// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy
{
    /// <summary>
    /// EnableCrossZoneUpgrade: Allow VMSS to ignore AZ boundaries when constructing upgrade batches. Take into consideration
    /// the Update Domain and maxBatchInstancePercent to determine the batch size.
    /// </summary>
    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    /// <summary>
    /// MaxBatchInstancePercent: The maximum percent of total virtual machine instances that will be upgraded simultaneously by
    /// the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the
    /// percentage of instances in a batch to decrease to ensure higher reliability. The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// MaxUnhealthyInstancePercent: The maximum percentage of the total virtual machine instances in the scale set that can be
    /// simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual
    /// machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.
    /// The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// MaxUnhealthyUpgradedInstancePercent: The maximum percentage of upgraded virtual machine instances that can be found to
    /// be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the
    /// rolling update aborts. The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// PauseTimeBetweenBatches: The wait time between completing the update for all virtual machines in one batch and starting
    /// the next batch. The time duration should be specified in ISO 8601 format. The default value is 0 seconds (PT0S).
    /// </summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>PrioritizeUnhealthyInstances: Upgrade all unhealthy instances in a scale set before any healthy instances.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>UpgradePolicy: The upgrade policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecUpgradePolicy
{
    /// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20201201VirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    /// <summary>
    /// Mode: Specifies the mode of an upgrade to virtual machines in the scale set.
    /// Possible values are:
    /// Manual - You  control the application of updates to virtual machines in the scale set. You do this by using the
    /// manualUpgrade action.
    /// Automatic - All virtual machines in the scale set are  automatically updated at the same time.
    /// </summary>
    [JsonPropertyName("mode")]
    public V20201201VirtualMachineScaleSetSpecUpgradePolicyModeEnum? Mode { get; set; }

    /// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V20201201VirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile
{
    /// <summary>
    /// MaxPrice: Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS. This price is in US Dollars.
    /// This price will be compared with the current Azure Spot price for the VM size. Also, the prices are compared at the time
    /// of create/update of Azure Spot VM/VMSS and the operation will only succeed if  the maxPrice is greater than the current
    /// Azure Spot price.
    /// The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the
    /// maxPrice after creation of VM/VMSS.
    /// Possible values are:
    /// - Any decimal value greater than zero. Example: 0.01538
    /// -1 – indicates default price to be up-to on-demand.
    /// You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons. Also,
    /// the default max price is -1 if it is not provided by you.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>Enabled: Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// StorageUri: Uri of the storage account to use for placing the console output and screenshot.
    /// If storageUri is not specified while enabling boot diagnostics, managed storage will be used.
    /// </summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>
/// DiagnosticsProfile: Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
/// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
/// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
/// 2017-10-30-preview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// ProtectedSettings: The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected
/// settings at all.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>
    /// AutoUpgradeMinorVersion: Indicates whether the extension should use a newer minor version if one is available at
    /// deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this
    /// property set to true.
    /// </summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: Indicates whether the extension should be automatically upgraded by the platform if there is a
    /// newer version of the extension available.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>
    /// ForceUpdateTag: If a value is provided and is different from the previous value, the extension handler will be forced to
    /// update even if the extension configuration has not changed.
    /// </summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>Name: The name of the extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ProtectedSettings: The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected
    /// settings at all.
    /// </summary>
    [JsonPropertyName("protectedSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings? ProtectedSettings { get; set; }

    /// <summary>ProvisionAfterExtensions: Collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>ExtensionProfile: Specifies a collection of settings for extensions installed on virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile
{
    /// <summary>Extensions: The virtual machine scale set child extension resources.</summary>
    [JsonPropertyName("extensions")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    /// <summary>
    /// ExtensionsTimeBudget: Specifies the time alloted for all extensions to start. The time duration should be between 15
    /// minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes
    /// (PT1H30M).
    /// Minimum api-version: 2020-06-01
    /// </summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference
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
/// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
/// scale set. The reference will be in the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference? Reference { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference? Reference { get; set; }
}

/// <summary>
/// PrivateIPAddressVersion: Available from Api-Version 2017-03-30 onwards, it represents whether the specific
/// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The Domain name label.The concatenation of the domain name label and vm index will be the domain name
    /// labels of the PublicIPAddress resources that will be created
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public required string DomainNameLabel { get; set; }
}

/// <summary>Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>IpTagType: IP tag type. Example: FirstPartyUsage.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
/// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
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

/// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary>Name: The publicIP address configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
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

/// <summary>Subnet: Specifies the identifier of the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot
    /// use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A scale
    /// set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the
    /// same basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>
    /// LoadBalancerInboundNatPools: Specifies an array of references to inbound Nat pools of the load balancers. A scale set
    /// can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same
    /// basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    /// <summary>Name: The IP configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// PrivateIPAddressVersion: Available from Api-Version 2017-03-30 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference? Reference { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
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

/// <summary>NetworkSecurityGroup: The network security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference
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

/// <summary>Describes a virtual machine scale set network profile&apos;s network configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary>EnableAcceleratedNetworking: Specifies whether the network interface is accelerated networking-enabled.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>EnableFpga: Specifies whether the network interface is FPGA networking-enabled.</summary>
    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    /// <summary>EnableIPForwarding: Whether IP forwarding enabled on this NIC.</summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary>IpConfigurations: Specifies the IP configurations of the network interface.</summary>
    [JsonPropertyName("ipConfigurations")]
    public required IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations> IpConfigurations { get; set; }

    /// <summary>Name: The network configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference? Reference { get; set; }
}

/// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
    /// scale set. The reference will be in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary>NetworkInterfaceConfigurations: The list of network configurations.</summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>
/// AdminPassword: Specifies the password of the administrator account.
/// Minimum-length (Windows): 8 characters
/// Minimum-length (Linux): 6 characters
/// Max-length (Windows): 123 characters
/// Max-length (Linux): 72 characters
/// Complexity requirements: 3 out of 4 conditions below need to be fulfilled
/// Has lower characters
/// Has upper characters
/// Has a digit
/// Has a special character (Regex match [\W_])
/// Disallowed values: &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;,
/// &quot;Password22&quot;, &quot;iloveyou!&quot;
/// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows
/// VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
/// For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
/// Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword
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
/// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
/// Possible values are:
/// ImageDefault - The virtual machine&apos;s default patching configuration is used.
/// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
/// must be true
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - The virtual machine&apos;s default patching configuration is used.
    /// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
    /// must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// KeyData: SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit
    /// and in ssh-rsa format.
    /// For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in
    /// Azure](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/mac-create-ssh-keys?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    /// <summary>
    /// Path: Specifies the full path on the created VM where ssh public key is stored. If the file already exists, the
    /// specified key is appended to the file. Example: /home/user/.ssh/authorized_keys
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference
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

/// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>
    /// CertificateStore: For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate
    /// should be added. The specified certificate store is implicitly in the LocalMachine account.
    /// For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name
    /// &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509 certificate file and &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both
    /// of these files are .pem formatted.
    /// </summary>
    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    /// <summary>
    /// CertificateUrl: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to
    /// the Key Vault, see [Add a key or secret to the key
    /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to
    /// be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:
    /// {
    /// &quot;data&quot;:&quot; &lt;Base64-encoded-certificate&gt; &quot;,
    /// &quot;dataType&quot;:&quot;pfx&quot;,
    /// &quot;password&quot;:&quot; &lt;pfx-file-password&gt; &quot;
    /// }
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum
{
    [EnumMember(Value = "Microsoft-Windows-Shell-Setup"), JsonStringEnumMemberName("Microsoft-Windows-Shell-Setup")]
    MicrosoftWindowsShellSetup
}

/// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum
{
    [EnumMember(Value = "OobeSystem"), JsonStringEnumMemberName("OobeSystem")]
    OobeSystem
}

/// <summary>
/// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
/// AutoLogon.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum
{
    [EnumMember(Value = "AutoLogon"), JsonStringEnumMemberName("AutoLogon")]
    AutoLogon,
    [EnumMember(Value = "FirstLogonCommands"), JsonStringEnumMemberName("FirstLogonCommands")]
    FirstLogonCommands
}

/// <summary>
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
    [JsonPropertyName("componentName")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum? ComponentName { get; set; }

    /// <summary>
    /// Content: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and
    /// component. The XML must be less than 4KB and must include the root element for the setting or feature that is being
    /// inserted.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
    [JsonPropertyName("passName")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum? PassName { get; set; }

    /// <summary>
    /// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
    /// AutoLogon.
    /// </summary>
    [JsonPropertyName("settingName")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum? SettingName { get; set; }
}

/// <summary>
/// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
/// Possible values are:
/// Manual - You  control the application of patches to a virtual machine. You do this by applying patches manually inside
/// the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
/// false
/// AutomaticByOS - The virtual machine will automatically be updated by the OS. The property
/// WindowsConfiguration.enableAutomaticUpdates must be true.
/// AutomaticByPlatform - the virtual machine will automatically updated by the platform. The properties provisionVMAgent
/// and WindowsConfiguration.enableAutomaticUpdates must be true
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByOS"), JsonStringEnumMemberName("AutomaticByOS")]
    AutomaticByOS,
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// EnableHotpatching: Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the
    /// &apos;provisionVMAgent&apos; must be set to true and &apos;patchMode&apos; must be set to &apos;AutomaticByPlatform&apos;.
    /// </summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
    /// Possible values are:
    /// Manual - You  control the application of patches to a virtual machine. You do this by applying patches manually inside
    /// the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
    /// false
    /// AutomaticByOS - The virtual machine will automatically be updated by the OS. The property
    /// WindowsConfiguration.enableAutomaticUpdates must be true.
    /// AutomaticByPlatform - the virtual machine will automatically updated by the platform. The properties provisionVMAgent
    /// and WindowsConfiguration.enableAutomaticUpdates must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>
/// Protocol: Specifies the protocol of WinRM listener.
/// Possible values are:
/// http
/// https
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>
    /// CertificateUrl: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to
    /// the Key Vault, see [Add a key or secret to the key
    /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to
    /// be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:
    /// {
    /// &quot;data&quot;:&quot; &lt;Base64-encoded-certificate&gt; &quot;,
    /// &quot;dataType&quot;:&quot;pfx&quot;,
    /// &quot;password&quot;:&quot; &lt;pfx-file-password&gt; &quot;
    /// }
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>
    /// Protocol: Specifies the protocol of WinRM listener.
    /// Possible values are:
    /// http
    /// https
    /// </summary>
    [JsonPropertyName("protocol")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum? Protocol { get; set; }
}

/// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// TimeZone: Specifies the time zone of the virtual machine. e.g. &quot;Pacific Standard Time&quot;.
    /// Possible values can be
    /// [TimeZoneInfo.Id](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from
    /// time zones returned by
    /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.getsystemtimezones).
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
    [JsonPropertyName("winRM")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfile
{
    /// <summary>
    /// AdminPassword: Specifies the password of the administrator account.
    /// Minimum-length (Windows): 8 characters
    /// Minimum-length (Linux): 6 characters
    /// Max-length (Windows): 123 characters
    /// Max-length (Linux): 72 characters
    /// Complexity requirements: 3 out of 4 conditions below need to be fulfilled
    /// Has lower characters
    /// Has upper characters
    /// Has a digit
    /// Has a special character (Regex match [\W_])
    /// Disallowed values: &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;,
    /// &quot;Password22&quot;, &quot;iloveyou!&quot;
    /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows
    /// VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
    /// For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
    /// Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password)
    /// </summary>
    [JsonPropertyName("adminPassword")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// Windows-only restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length (Linux): 1  character
    /// Max-length (Linux): 64 characters
    /// Max-length (Windows): 20 characters
    /// &lt;li&gt; For root access to the Linux VM, see [Using root privileges on Linux virtual machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// &lt;li&gt; For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for
    /// Linux on
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// ComputerNamePrefix: Specifies the computer name prefix for all of the virtual machines in the scale set. Computer name
    /// prefixes must be 1 to 15 characters long.
    /// </summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// For using cloud-init for your VM, see [Using cloud-init to customize a Linux VM during
    /// creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// </summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>Secrets: Specifies set of certificates that should be installed onto the virtual machines in the scale set.</summary>
    [JsonPropertyName("secrets")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Priority: Specifies the priority for the virtual machines in the scale set.
/// Minimum api-version: 2017-10-30-preview
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum
{
    [EnumMember(Value = "Low"), JsonStringEnumMemberName("Low")]
    Low,
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>Enable: Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// NotBeforeTimeout: Configurable length of time a Virtual Machine being deleted will have to potentially approve the
    /// Terminate Scheduled Event before the event is auto approved (timed out). The configuration must be specified in ISO 8601
    /// format, the default value is 5 minutes (PT5M)
    /// </summary>
    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// SecurityType: Specifies the SecurityType of the virtual machine. It is set as TrustedLaunch to enable UefiSettings.
/// Default: UefiSettings will not be enabled unless this property is set as TrustedLaunch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum
{
    [EnumMember(Value = "TrustedLaunch"), JsonStringEnumMemberName("TrustedLaunch")]
    TrustedLaunch
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>
    /// SecureBootEnabled: Specifies whether secure boot should be enabled on the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>
    /// VTpmEnabled: Specifies whether vTPM should be enabled on the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile
{
    /// <summary>
    /// EncryptionAtHost: This property can be used by user in the request to enable or disable the Host Encryption for the
    /// virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp
    /// disk at host itself.
    /// Default: The Encryption at host will be disabled unless this property is set to true for the resource.
    /// </summary>
    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    /// <summary>
    /// SecurityType: Specifies the SecurityType of the virtual machine. It is set as TrustedLaunch to enable UefiSettings.
    /// Default: UefiSettings will not be enabled unless this property is set as TrustedLaunch.
    /// </summary>
    [JsonPropertyName("securityType")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Caching: Specifies the caching requirements.
/// Possible values are:
/// None
/// ReadOnly
/// ReadWrite
/// Default: None for Standard storage. ReadOnly for Premium storage
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>CreateOption: The create option.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum
{
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Premium_ZRS"), JsonStringEnumMemberName("Premium_ZRS")]
    PremiumZRS,
    [EnumMember(Value = "StandardSSD_LRS"), JsonStringEnumMemberName("StandardSSD_LRS")]
    StandardSSDLRS,
    [EnumMember(Value = "StandardSSD_ZRS"), JsonStringEnumMemberName("StandardSSD_ZRS")]
    StandardSSDZRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "UltraSSD_LRS"), JsonStringEnumMemberName("UltraSSD_LRS")]
    UltraSSDLRS
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>Describes a virtual machine scale set data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum? Caching { get; set; }

    /// <summary>CreateOption: The create option.</summary>
    [JsonPropertyName("createOption")]
    public required V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DiskIOPSReadWrite: Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is
    /// UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
    /// </summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary>
    /// DiskMBpsReadWrite: Specifies the bandwidth in MB per second for the managed disk. Should be used only when
    /// StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
    /// </summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public required int Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference
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
/// ImageReference: Specifies information about the image to use. You can specify information about platform images,
/// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
/// marketplace image, or virtual machine image, but is not used in other creation operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>Offer: Specifies the offer of the platform image or marketplace image used to create the virtual machine.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Publisher: The image publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference? Reference { get; set; }

    /// <summary>Sku: The image SKU.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// Version: Specifies the version of the platform image or marketplace image used to create the virtual machine. The
    /// allowed formats are Major.Minor.Build or &apos;latest&apos;. Major, Minor, and Build are decimal numbers. Specify &apos;latest&apos; to use
    /// the latest version of an image available at deploy time. Even if you use &apos;latest&apos;, the VM image will not automatically
    /// update after deploy time even if a new version becomes available.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Caching: Specifies the caching requirements.
/// Possible values are:
/// None
/// ReadOnly
/// ReadWrite
/// Default: None for Standard storage. ReadOnly for Premium storage
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>
/// CreateOption: Specifies how the virtual machines in the scale set should be created.
/// The only allowed value is: FromImage \u2013 This value is used when you are using an image to create the virtual
/// machine. If you are using a platform image, you also use the imageReference element described above. If you are using a
/// marketplace image, you  also use the plan element previously described.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum
{
    [EnumMember(Value = "Local"), JsonStringEnumMemberName("Local")]
    Local
}

/// <summary>
/// Placement: Specifies the ephemeral disk placement for operating system disk.
/// Possible values are:
/// CacheDisk
/// ResourceDisk
/// Default: CacheDisk if one is configured for the VM size otherwise ResourceDisk is used.
/// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes
/// and Linux VM at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/sizes to check which VM sizes exposes a
/// cache disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum
{
    [EnumMember(Value = "CacheDisk"), JsonStringEnumMemberName("CacheDisk")]
    CacheDisk,
    [EnumMember(Value = "ResourceDisk"), JsonStringEnumMemberName("ResourceDisk")]
    ResourceDisk
}

/// <summary>
/// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
/// set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
    [JsonPropertyName("option")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum? Option { get; set; }

    /// <summary>
    /// Placement: Specifies the ephemeral disk placement for operating system disk.
    /// Possible values are:
    /// CacheDisk
    /// ResourceDisk
    /// Default: CacheDisk if one is configured for the VM size otherwise ResourceDisk is used.
    /// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes
    /// and Linux VM at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/sizes to check which VM sizes exposes a
    /// cache disk.
    /// </summary>
    [JsonPropertyName("placement")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum? Placement { get; set; }
}

/// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum
{
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Premium_ZRS"), JsonStringEnumMemberName("Premium_ZRS")]
    PremiumZRS,
    [EnumMember(Value = "StandardSSD_LRS"), JsonStringEnumMemberName("StandardSSD_LRS")]
    StandardSSDLRS,
    [EnumMember(Value = "StandardSSD_ZRS"), JsonStringEnumMemberName("StandardSSD_ZRS")]
    StandardSSDZRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "UltraSSD_LRS"), JsonStringEnumMemberName("UltraSSD_LRS")]
    UltraSSDLRS
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>
/// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
/// user-image or a specialized VHD.
/// Possible values are:
/// Windows
/// Linux
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum>))]
public enum V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machines in the scale set should be created.
    /// The only allowed value is: FromImage \u2013 This value is used when you are using an image to create the virtual
    /// machine. If you are using a platform image, you also use the imageReference element described above. If you are using a
    /// marketplace image, you  also use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
    /// set.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size
    /// of the disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
    [JsonPropertyName("image")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
    /// user-image or a specialized VHD.
    /// Possible values are:
    /// Windows
    /// Linux
    /// </summary>
    [JsonPropertyName("osType")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum? OsType { get; set; }

    /// <summary>VhdContainers: Specifies the container urls that are used to store operating system disks for the scale set.</summary>
    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add data disks to the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpecVirtualMachineProfile
{
    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>ExtensionProfile: Specifies a collection of settings for extensions installed on virtual machines in the scale set.</summary>
    [JsonPropertyName("extensionProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>
    /// LicenseType: Specifies that the image or disk that is being used was licensed on-premises.
    /// Possible values for Windows Server operating system are:
    /// Windows_Client
    /// Windows_Server
    /// Possible values for Linux Server operating system are:
    /// RHEL_BYOS (for RHEL)
    /// SLES_BYOS (for SUSE)
    /// For more information, see [Azure Hybrid Use Benefit for Windows
    /// Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)
    /// [Azure Hybrid Use Benefit for Linux
    /// Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
    [JsonPropertyName("networkProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("osProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machines in the scale set.
    /// Minimum api-version: 2017-10-30-preview
    /// </summary>
    [JsonPropertyName("priority")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum? Priority { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile? StorageProfile { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetSpec
{
    /// <summary>
    /// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
    /// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
    /// disks with UltraSSD_LRS storage account type.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20201201VirtualMachineScaleSetSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20201201VirtualMachineScaleSetSpecAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// DoNotRunExtensionsOnOverprovisionedVMs: When Overprovision is enabled, extensions are launched only on the requested
    /// number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra
    /// overprovisioned VMs.
    /// </summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20201201VirtualMachineScaleSetSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
    /// Minimum api-version: 2020-06-01.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V20201201VirtualMachineScaleSetSpecHostGroup? HostGroup { get; set; }

    /// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20201201VirtualMachineScaleSetSpecIdentity? Identity { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20201201VirtualMachineScaleSetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OrchestrationMode: Specifies the orchestration mode for the virtual machine scale set.</summary>
    [JsonPropertyName("orchestrationMode")]
    public V20201201VirtualMachineScaleSetSpecOrchestrationModeEnum? OrchestrationMode { get; set; }

    /// <summary>Overprovision: Specifies whether the Virtual Machine Scale Set should be overprovisioned.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20201201VirtualMachineScaleSetSpecOwner Owner { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V20201201VirtualMachineScaleSetSpecPlan? Plan { get; set; }

    /// <summary>PlatformFaultDomainCount: Fault Domain count for each placement group.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine scale set
    /// should be assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V20201201VirtualMachineScaleSetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// ScaleInPolicy: Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual
    /// Machine Scale Set is scaled-in.
    /// </summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20201201VirtualMachineScaleSetSpecScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>
    /// SinglePlacementGroup: When true this limits the scale set to a single placement group, of max size 100 virtual machines.
    /// NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may
    /// not be modified to true.
    /// </summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Sku: The virtual machine scale set sku.</summary>
    [JsonPropertyName("sku")]
    public V20201201VirtualMachineScaleSetSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UpgradePolicy: The upgrade policy.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V20201201VirtualMachineScaleSetSpecUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20201201VirtualMachineScaleSetSpecVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary>ZoneBalance: Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Zones: The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
/// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
/// disks with UltraSSD_LRS storage account type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusAdditionalCapabilities
{
    /// <summary>
    /// UltraSSDEnabled: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS
    /// storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual
    /// machine or virtual machine scale set only if this property is enabled.
    /// </summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusAutomaticRepairsPolicy
{
    /// <summary>
    /// Enabled: Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is
    /// false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// GracePeriod: The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time
    /// starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should
    /// be specified in ISO 8601 format. The minimum allowed grace period is 30 minutes (PT30M), which is also the default
    /// value. The maximum allowed grace period is 90 minutes (PT90M).
    /// </summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusConditions
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

/// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
/// Minimum api-version: 2020-06-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusHostGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of virtual machine scale set identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id associated with the virtual machine scale set. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the virtual machine scale set. The type &apos;SystemAssigned, UserAssigned&apos; includes both
    /// an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from
    /// the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the virtual machine scale set. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20201201VirtualMachineScaleSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
/// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
/// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
/// programmatically, Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusPlan
{
    /// <summary>Name: The plan ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Product: Specifies the product of the image from the marketplace. This is the same value as Offer under the
    /// imageReference element.
    /// </summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>PromotionCode: The promotion code.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher ID.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine scale set
/// should be assigned to.
/// Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusProximityPlacementGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// ScaleInPolicy: Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual
/// Machine Scale Set is scaled-in.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusScaleInPolicy
{
    /// <summary>
    /// Rules: The rules to be followed when scaling-in a virtual machine scale set.
    /// Possible values are:
    /// Default When a virtual machine scale set is scaled in, the scale set will first be balanced across zones if it is a
    /// zonal scale set. Then, it will be balanced across Fault Domains as far as possible. Within each Fault Domain, the
    /// virtual machines chosen for removal will be the newest ones that are not protected from scale-in.
    /// OldestVM When a virtual machine scale set is being scaled-in, the oldest virtual machines that are not protected from
    /// scale-in will be chosen for removal. For zonal virtual machine scale sets, the scale set will first be balanced across
    /// zones. Within each zone, the oldest virtual machines that are not protected will be chosen for removal.
    /// NewestVM When a virtual machine scale set is being scaled-in, the newest virtual machines that are not protected from
    /// scale-in will be chosen for removal. For zonal virtual machine scale sets, the scale set will first be balanced across
    /// zones. Within each zone, the newest virtual machines that are not protected will be chosen for removal.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary>Sku: The virtual machine scale set sku.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusSku
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

/// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>DisableAutomaticRollback: Whether OS image rollback feature should be disabled. Default value is false.</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>
    /// EnableAutomaticOSUpgrade: Indicates whether OS upgrades should automatically be applied to scale set instances in a
    /// rolling fashion when a newer version of the OS image becomes available. Default value is false.
    /// If this is set to true for Windows based scale sets,
    /// [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet)
    /// is automatically set to false and cannot be set to true.
    /// </summary>
    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }
}

/// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy
{
    /// <summary>
    /// EnableCrossZoneUpgrade: Allow VMSS to ignore AZ boundaries when constructing upgrade batches. Take into consideration
    /// the Update Domain and maxBatchInstancePercent to determine the batch size.
    /// </summary>
    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    /// <summary>
    /// MaxBatchInstancePercent: The maximum percent of total virtual machine instances that will be upgraded simultaneously by
    /// the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the
    /// percentage of instances in a batch to decrease to ensure higher reliability. The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// MaxUnhealthyInstancePercent: The maximum percentage of the total virtual machine instances in the scale set that can be
    /// simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual
    /// machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.
    /// The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// MaxUnhealthyUpgradedInstancePercent: The maximum percentage of upgraded virtual machine instances that can be found to
    /// be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the
    /// rolling update aborts. The default value for this parameter is 20%.
    /// </summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// PauseTimeBetweenBatches: The wait time between completing the update for all virtual machines in one batch and starting
    /// the next batch. The time duration should be specified in ISO 8601 format. The default value is 0 seconds (PT0S).
    /// </summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>PrioritizeUnhealthyInstances: Upgrade all unhealthy instances in a scale set before any healthy instances.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>UpgradePolicy: The upgrade policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusUpgradePolicy
{
    /// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20201201VirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    /// <summary>
    /// Mode: Specifies the mode of an upgrade to virtual machines in the scale set.
    /// Possible values are:
    /// Manual - You  control the application of updates to virtual machines in the scale set. You do this by using the
    /// manualUpgrade action.
    /// Automatic - All virtual machines in the scale set are  automatically updated at the same time.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V20201201VirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile
{
    /// <summary>
    /// MaxPrice: Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS. This price is in US Dollars.
    /// This price will be compared with the current Azure Spot price for the VM size. Also, the prices are compared at the time
    /// of create/update of Azure Spot VM/VMSS and the operation will only succeed if  the maxPrice is greater than the current
    /// Azure Spot price.
    /// The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the
    /// maxPrice after creation of VM/VMSS.
    /// Possible values are:
    /// - Any decimal value greater than zero. Example: 0.01538
    /// -1 – indicates default price to be up-to on-demand.
    /// You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons. Also,
    /// the default max price is -1 if it is not provided by you.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>Enabled: Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// StorageUri: Uri of the storage account to use for placing the console output and screenshot.
    /// If storageUri is not specified while enabling boot diagnostics, managed storage will be used.
    /// </summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>
/// DiagnosticsProfile: Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>
    /// AutoUpgradeMinorVersion: Indicates whether the extension should use a newer minor version if one is available at
    /// deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this
    /// property set to true.
    /// </summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: Indicates whether the extension should be automatically upgraded by the platform if there is a
    /// newer version of the extension available.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>
    /// ForceUpdateTag: If a value is provided and is different from the previous value, the extension handler will be forced to
    /// update even if the extension configuration has not changed.
    /// </summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesType: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>ProvisionAfterExtensions: Collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>ExtensionProfile: Specifies a collection of settings for extensions installed on virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile
{
    /// <summary>Extensions: The virtual machine scale set child extension resources.</summary>
    [JsonPropertyName("extensions")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    /// <summary>
    /// ExtensionsTimeBudget: Specifies the time alloted for all extensions to start. The time duration should be between 15
    /// minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes
    /// (PT1H30M).
    /// Minimum api-version: 2020-06-01
    /// </summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>
/// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
/// scale set. The reference will be in the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>Id: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The Domain name label.The concatenation of the domain name label and vm index will be the domain name
    /// labels of the PublicIPAddress resources that will be created
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>IpTagType: IP tag type. Example: FirstPartyUsage.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary>Name: The publicIP address configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }
}

/// <summary>Subnet: Specifies the identifier of the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Id: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot
    /// use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A scale
    /// set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the
    /// same basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>
    /// LoadBalancerInboundNatPools: Specifies an array of references to inbound Nat pools of the load balancers. A scale set
    /// can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same
    /// basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    /// <summary>Name: The IP configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// PrivateIPAddressVersion: Available from Api-Version 2017-03-30 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>NetworkSecurityGroup: The network security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s network configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary>EnableAcceleratedNetworking: Specifies whether the network interface is accelerated networking-enabled.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>EnableFpga: Specifies whether the network interface is FPGA networking-enabled.</summary>
    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    /// <summary>EnableIPForwarding: Whether IP forwarding enabled on this NIC.</summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IpConfigurations: Specifies the IP configurations of the network interface.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Name: The network configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
    /// scale set. The reference will be in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary>NetworkInterfaceConfigurations: The list of network configurations.</summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - The virtual machine&apos;s default patching configuration is used.
    /// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
    /// must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// KeyData: SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit
    /// and in ssh-rsa format.
    /// For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in
    /// Azure](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/mac-create-ssh-keys?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    /// <summary>
    /// Path: Specifies the full path on the created VM where ssh public key is stored. If the file already exists, the
    /// specified key is appended to the file. Example: /home/user/.ssh/authorized_keys
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>
    /// CertificateStore: For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate
    /// should be added. The specified certificate store is implicitly in the LocalMachine account.
    /// For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name
    /// &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509 certificate file and &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both
    /// of these files are .pem formatted.
    /// </summary>
    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    /// <summary>
    /// CertificateUrl: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to
    /// the Key Vault, see [Add a key or secret to the key
    /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to
    /// be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:
    /// {
    /// &quot;data&quot;:&quot; &lt;Base64-encoded-certificate&gt; &quot;,
    /// &quot;dataType&quot;:&quot;pfx&quot;,
    /// &quot;password&quot;:&quot; &lt;pfx-file-password&gt; &quot;
    /// }
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
    [JsonPropertyName("componentName")]
    public string? ComponentName { get; set; }

    /// <summary>
    /// Content: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and
    /// component. The XML must be less than 4KB and must include the root element for the setting or feature that is being
    /// inserted.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
    [JsonPropertyName("passName")]
    public string? PassName { get; set; }

    /// <summary>
    /// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
    /// AutoLogon.
    /// </summary>
    [JsonPropertyName("settingName")]
    public string? SettingName { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// EnableHotpatching: Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the
    /// &apos;provisionVMAgent&apos; must be set to true and &apos;patchMode&apos; must be set to &apos;AutomaticByPlatform&apos;.
    /// </summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
    /// Possible values are:
    /// Manual - You  control the application of patches to a virtual machine. You do this by applying patches manually inside
    /// the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
    /// false
    /// AutomaticByOS - The virtual machine will automatically be updated by the OS. The property
    /// WindowsConfiguration.enableAutomaticUpdates must be true.
    /// AutomaticByPlatform - the virtual machine will automatically updated by the platform. The properties provisionVMAgent
    /// and WindowsConfiguration.enableAutomaticUpdates must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>
    /// CertificateUrl: This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to
    /// the Key Vault, see [Add a key or secret to the key
    /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to
    /// be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8:
    /// {
    /// &quot;data&quot;:&quot; &lt;Base64-encoded-certificate&gt; &quot;,
    /// &quot;dataType&quot;:&quot;pfx&quot;,
    /// &quot;password&quot;:&quot; &lt;pfx-file-password&gt; &quot;
    /// }
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>
    /// Protocol: Specifies the protocol of WinRM listener.
    /// Possible values are:
    /// http
    /// https
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// TimeZone: Specifies the time zone of the virtual machine. e.g. &quot;Pacific Standard Time&quot;.
    /// Possible values can be
    /// [TimeZoneInfo.Id](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from
    /// time zones returned by
    /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.getsystemtimezones).
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
    [JsonPropertyName("winRM")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfile
{
    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// Windows-only restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length (Linux): 1  character
    /// Max-length (Linux): 64 characters
    /// Max-length (Windows): 20 characters
    /// &lt;li&gt; For root access to the Linux VM, see [Using root privileges on Linux virtual machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// &lt;li&gt; For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for
    /// Linux on
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// ComputerNamePrefix: Specifies the computer name prefix for all of the virtual machines in the scale set. Computer name
    /// prefixes must be 1 to 15 characters long.
    /// </summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// For using cloud-init for your VM, see [Using cloud-init to customize a Linux VM during
    /// creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// </summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>Secrets: Specifies set of certificates that should be installed onto the virtual machines in the scale set.</summary>
    [JsonPropertyName("secrets")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>Enable: Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// NotBeforeTimeout: Configurable length of time a Virtual Machine being deleted will have to potentially approve the
    /// Terminate Scheduled Event before the event is auto approved (timed out). The configuration must be specified in ISO 8601
    /// format, the default value is 5 minutes (PT5M)
    /// </summary>
    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>
    /// SecureBootEnabled: Specifies whether secure boot should be enabled on the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>
    /// VTpmEnabled: Specifies whether vTPM should be enabled on the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile
{
    /// <summary>
    /// EncryptionAtHost: This property can be used by user in the request to enable or disable the Host Encryption for the
    /// virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp
    /// disk at host itself.
    /// Default: The Encryption at host will be disabled unless this property is set to true for the resource.
    /// </summary>
    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    /// <summary>
    /// SecurityType: Specifies the SecurityType of the virtual machine. It is set as TrustedLaunch to enable UefiSettings.
    /// Default: UefiSettings will not be enabled unless this property is set as TrustedLaunch.
    /// </summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Describes a virtual machine scale set data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>CreateOption: The create option.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// DiskIOPSReadWrite: Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is
    /// UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
    /// </summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary>
    /// DiskMBpsReadWrite: Specifies the bandwidth in MB per second for the managed disk. Should be used only when
    /// StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
    /// </summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// ImageReference: Specifies information about the image to use. You can specify information about platform images,
/// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
/// marketplace image, or virtual machine image, but is not used in other creation operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>
    /// ExactVersion: Specifies in decimal numbers, the version of platform image or marketplace image used to create the
    /// virtual machine. This readonly field differs from &apos;version&apos;, only if the value specified in &apos;version&apos; field is &apos;latest&apos;.
    /// </summary>
    [JsonPropertyName("exactVersion")]
    public string? ExactVersion { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Offer: Specifies the offer of the platform image or marketplace image used to create the virtual machine.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Publisher: The image publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Sku: The image SKU.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// Version: Specifies the version of the platform image or marketplace image used to create the virtual machine. The
    /// allowed formats are Major.Minor.Build or &apos;latest&apos;. Major, Minor, and Build are decimal numbers. Specify &apos;latest&apos; to use
    /// the latest version of an image available at deploy time. Even if you use &apos;latest&apos;, the VM image will not automatically
    /// update after deploy time even if a new version becomes available.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
/// set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>
    /// Placement: Specifies the ephemeral disk placement for operating system disk.
    /// Possible values are:
    /// CacheDisk
    /// ResourceDisk
    /// Default: CacheDisk if one is configured for the VM size otherwise ResourceDisk is used.
    /// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes
    /// and Linux VM at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/sizes to check which VM sizes exposes a
    /// cache disk.
    /// </summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machines in the scale set should be created.
    /// The only allowed value is: FromImage \u2013 This value is used when you are using an image to create the virtual
    /// machine. If you are using a platform image, you also use the imageReference element described above. If you are using a
    /// marketplace image, you  also use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
    /// set.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size
    /// of the disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
    [JsonPropertyName("image")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
    /// user-image or a specialized VHD.
    /// Possible values are:
    /// Windows
    /// Linux
    /// </summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>VhdContainers: Specifies the container urls that are used to store operating system disks for the scale set.</summary>
    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add data disks to the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatusVirtualMachineProfile
{
    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>ExtensionProfile: Specifies a collection of settings for extensions installed on virtual machines in the scale set.</summary>
    [JsonPropertyName("extensionProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>
    /// LicenseType: Specifies that the image or disk that is being used was licensed on-premises.
    /// Possible values for Windows Server operating system are:
    /// Windows_Client
    /// Windows_Server
    /// Possible values for Linux Server operating system are:
    /// RHEL_BYOS (for RHEL)
    /// SLES_BYOS (for SUSE)
    /// For more information, see [Azure Hybrid Use Benefit for Windows
    /// Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)
    /// [Azure Hybrid Use Benefit for Linux
    /// Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
    [JsonPropertyName("networkProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("osProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machines in the scale set.
    /// Minimum api-version: 2017-10-30-preview
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile? StorageProfile { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachineScaleSetStatus
{
    /// <summary>
    /// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
    /// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
    /// disks with UltraSSD_LRS storage account type.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20201201VirtualMachineScaleSetStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20201201VirtualMachineScaleSetStatusAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20201201VirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DoNotRunExtensionsOnOverprovisionedVMs: When Overprovision is enabled, extensions are launched only on the requested
    /// number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra
    /// overprovisioned VMs.
    /// </summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20201201VirtualMachineScaleSetStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
    /// Minimum api-version: 2020-06-01.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V20201201VirtualMachineScaleSetStatusHostGroup? HostGroup { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20201201VirtualMachineScaleSetStatusIdentity? Identity { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OrchestrationMode: Specifies the orchestration mode for the virtual machine scale set.</summary>
    [JsonPropertyName("orchestrationMode")]
    public string? OrchestrationMode { get; set; }

    /// <summary>Overprovision: Specifies whether the Virtual Machine Scale Set should be overprovisioned.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V20201201VirtualMachineScaleSetStatusPlan? Plan { get; set; }

    /// <summary>PlatformFaultDomainCount: Fault Domain count for each placement group.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine scale set
    /// should be assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V20201201VirtualMachineScaleSetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// ScaleInPolicy: Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual
    /// Machine Scale Set is scaled-in.
    /// </summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20201201VirtualMachineScaleSetStatusScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>
    /// SinglePlacementGroup: When true this limits the scale set to a single placement group, of max size 100 virtual machines.
    /// NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may
    /// not be modified to true.
    /// </summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Sku: The virtual machine scale set sku.</summary>
    [JsonPropertyName("sku")]
    public V20201201VirtualMachineScaleSetStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UniqueId: Specifies the ID which uniquely identifies a Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>UpgradePolicy: The upgrade policy.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V20201201VirtualMachineScaleSetStatusUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20201201VirtualMachineScaleSetStatusVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary>ZoneBalance: Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Zones: The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201VirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V20201201VirtualMachineScaleSetSpec?>, IStatus<V20201201VirtualMachineScaleSetStatus?>
{
    public const string KubeApiVersion = "v20201201";
    public const string KubeKind = "VirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20201201VirtualMachineScaleSetSpec? Spec { get; set; }

    /// <summary>Describes a Virtual Machine Scale Set.</summary>
    [JsonPropertyName("status")]
    public V20201201VirtualMachineScaleSetStatus? Status { get; set; }
}