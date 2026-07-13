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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachineScaleSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301VirtualMachineScaleSetList : IKubernetesObject<V1ListMeta>, IItems<V20220301VirtualMachineScaleSet>
{
    public const string KubeApiVersion = "v20220301";
    public const string KubeKind = "VirtualMachineScaleSetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220301VirtualMachineScaleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220301VirtualMachineScaleSet> Items { get; set; }
}

/// <summary>
/// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
/// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
/// disks with UltraSSD_LRS storage account type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecAdditionalCapabilities
{
    /// <summary>HibernationEnabled: The flag that enables or disables hibernation capability on the VM.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>
    /// UltraSSDEnabled: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS
    /// storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual
    /// machine or virtual machine scale set only if this property is enabled.
    /// </summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>
/// RepairAction: Type of repair action (replace, restart, reimage) that will be used for repairing unhealthy virtual
/// machines in the scale set. Default value is replace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecAutomaticRepairsPolicyRepairActionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecAutomaticRepairsPolicyRepairActionEnum
{
    [EnumMember(Value = "Reimage"), JsonStringEnumMemberName("Reimage")]
    Reimage,
    [EnumMember(Value = "Replace"), JsonStringEnumMemberName("Replace")]
    Replace,
    [EnumMember(Value = "Restart"), JsonStringEnumMemberName("Restart")]
    Restart
}

/// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecAutomaticRepairsPolicy
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
    /// be specified in ISO 8601 format. The minimum allowed grace period is 10 minutes (PT10M), which is also the default
    /// value. The maximum allowed grace period is 90 minutes (PT90M).
    /// </summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }

    /// <summary>
    /// RepairAction: Type of repair action (replace, restart, reimage) that will be used for repairing unhealthy virtual
    /// machines in the scale set. Default value is replace.
    /// </summary>
    [JsonPropertyName("repairAction")]
    public V20220301VirtualMachineScaleSetSpecAutomaticRepairsPolicyRepairActionEnum? RepairAction { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecExtendedLocationTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20220301VirtualMachineScaleSetSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecHostGroupReference
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
public partial class V20220301VirtualMachineScaleSetSpecHostGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecHostGroupReference? Reference { get; set; }
}

/// <summary>
/// Type: The type of identity used for the virtual machine scale set. The type &apos;SystemAssigned, UserAssigned&apos; includes both
/// an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from
/// the virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecIdentityTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecIdentityTypeEnum
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
public partial class V20220301VirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20220301VirtualMachineScaleSetSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the virtual machine scale set. The type &apos;SystemAssigned, UserAssigned&apos; includes both
    /// an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from
    /// the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("type")]
    public V20220301VirtualMachineScaleSetSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the virtual machine scale set. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20220301VirtualMachineScaleSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions
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
public partial class V20220301VirtualMachineScaleSetSpecOperatorSpecSecretExpressions
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
public partial class V20220301VirtualMachineScaleSetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220301VirtualMachineScaleSetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220301VirtualMachineScaleSetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OrchestrationMode: Specifies the orchestration mode for the virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecOrchestrationModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecOrchestrationModeEnum
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
public partial class V20220301VirtualMachineScaleSetSpecOwner
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
public partial class V20220301VirtualMachineScaleSetSpecPlan
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
public partial class V20220301VirtualMachineScaleSetSpecProximityPlacementGroupReference
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
public partial class V20220301VirtualMachineScaleSetSpecProximityPlacementGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecProximityPlacementGroupReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecScaleInPolicyRulesEnum>))]
public enum V20220301VirtualMachineScaleSetSpecScaleInPolicyRulesEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "NewestVM"), JsonStringEnumMemberName("NewestVM")]
    NewestVM,
    [EnumMember(Value = "OldestVM"), JsonStringEnumMemberName("OldestVM")]
    OldestVM
}

/// <summary>ScaleInPolicy: Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecScaleInPolicy
{
    /// <summary>
    /// ForceDeletion: This property allows you to specify if virtual machines chosen for removal have to be force deleted when
    /// a virtual machine scale set is being scaled-in.(Feature in Preview)
    /// </summary>
    [JsonPropertyName("forceDeletion")]
    public bool? ForceDeletion { get; set; }

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
    public IList<V20220301VirtualMachineScaleSetSpecScaleInPolicyRulesEnum>? Rules { get; set; }
}

/// <summary>Sku: The virtual machine scale set sku.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecSku
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

/// <summary>SpotRestorePolicy: Specifies the Spot Restore properties for the virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecSpotRestorePolicy
{
    /// <summary>
    /// Enabled: Enables the Spot-Try-Restore feature where evicted VMSS SPOT instances will be tried to be restored
    /// opportunistically based on capacity availability and pricing constraints
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RestoreTimeout: Timeout value expressed as an ISO 8601 time duration after which the platform will not try to restore
    /// the VMSS SPOT instances
    /// </summary>
    [JsonPropertyName("restoreTimeout")]
    public string? RestoreTimeout { get; set; }
}

/// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy
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

    /// <summary>
    /// UseRollingUpgradePolicy: Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value
    /// is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS.
    /// </summary>
    [JsonPropertyName("useRollingUpgradePolicy")]
    public bool? UseRollingUpgradePolicy { get; set; }
}

/// <summary>
/// Mode: Specifies the mode of an upgrade to virtual machines in the scale set.
/// Possible values are:
/// Manual - You  control the application of updates to virtual machines in the scale set. You do this by using the
/// manualUpgrade action.
/// Automatic - All virtual machines in the scale set are  automatically updated at the same time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecUpgradePolicyModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecUpgradePolicyModeEnum
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
public partial class V20220301VirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy
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
public partial class V20220301VirtualMachineScaleSetSpecUpgradePolicy
{
    /// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20220301VirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    /// <summary>
    /// Mode: Specifies the mode of an upgrade to virtual machines in the scale set.
    /// Possible values are:
    /// Manual - You  control the application of updates to virtual machines in the scale set. You do this by using the
    /// manualUpgrade action.
    /// Automatic - All virtual machines in the scale set are  automatically updated at the same time.
    /// </summary>
    [JsonPropertyName("mode")]
    public V20220301VirtualMachineScaleSetSpecUpgradePolicyModeEnum? Mode { get; set; }

    /// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V20220301VirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>
/// PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of
/// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplicationsPackageReferenceReference
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

/// <summary>Specifies the required information to reference a compute gallery application version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplications
{
    /// <summary>
    /// ConfigurationReference: Optional, Specifies the uri to an azure blob that will replace the default configuration for the
    /// package if provided
    /// </summary>
    [JsonPropertyName("configurationReference")]
    public string? ConfigurationReference { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: If set to true, when a new Gallery Application version is available in PIR/SIG, it will be
    /// automatically updated for the VM/VMSS
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>Order: Optional, Specifies the order in which the packages have to be installed</summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of
    /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
    /// </summary>
    [JsonPropertyName("packageReferenceReference")]
    public required V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplicationsPackageReferenceReference PackageReferenceReference { get; set; }

    /// <summary>Tags: Optional, Specifies a passthrough value for more generic context.</summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// TreatFailureAsDeploymentFailure: Optional, If true, any failure for any operation in the VmApplication will fail the
    /// deployment
    /// </summary>
    [JsonPropertyName("treatFailureAsDeploymentFailure")]
    public bool? TreatFailureAsDeploymentFailure { get; set; }
}

/// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfile
{
    /// <summary>GalleryApplications: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroupReference
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
/// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
/// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
/// https://aka.ms/CapacityReservation for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroupReference? Reference { get; set; }
}

/// <summary>
/// CapacityReservation: Specifies the capacity reservation related details of a scale set.
/// Minimum api-version: 2021-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservation
{
    /// <summary>
    /// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
    /// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
    /// https://aka.ms/CapacityReservation for more details.
    /// </summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}

/// <summary>
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// NOTE: If storageUri is being specified then ensure that the storage account is in the same region and subscription as
/// the VM.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// NOTE: If storageUri is being specified then ensure that the storage account is in the same region and subscription as
    /// the VM.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
/// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
/// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
/// 2017-10-30-preview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVaultReference
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

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVaultReference? Reference { get; set; }
}

/// <summary>
/// ProtectedSettingsFromKeyVault: The extensions protected settings that are passed by reference, and consumed from key
/// vault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public required V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault SourceVault { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions
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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings? ProtectedSettings { get; set; }

    /// <summary>
    /// ProtectedSettingsFromKeyVault: The extensions protected settings that are passed by reference, and consumed from key
    /// vault
    /// </summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>ProvisionAfterExtensions: Collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>
    /// SuppressFailures: Indicates whether failures stemming from the extension will be suppressed (Operational failures such
    /// as not connecting to the VM will not be suppressed regardless of this value). The default is false.
    /// </summary>
    [JsonPropertyName("suppressFailures")]
    public bool? SuppressFailures { get; set; }

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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile
{
    /// <summary>Extensions: The virtual machine scale set child extension resources.</summary>
    [JsonPropertyName("extensions")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

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
/// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
/// 2022-03-01.
/// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfileVmSizeProperties
{
    /// <summary>
    /// VCPUsAvailable: Specifies the number of vCPUs available for the VM.
    /// When this property is not specified in the request body the default behavior is to set it to the value of vCPUs
    /// available for that VM size exposed in api response of [List all available virtual machine sizes in a
    /// region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) .
    /// </summary>
    [JsonPropertyName("vCPUsAvailable")]
    public int? VCPUsAvailable { get; set; }

    /// <summary>
    /// VCPUsPerCore: Specifies the vCPU to physical core ratio.
    /// When this property is not specified in the request body the default behavior is set to the value of vCPUsPerCore for the
    /// VM Size exposed in api response of [List all available virtual machine sizes in a
    /// region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list)
    /// Setting this property to 1 also means that hyper-threading is disabled.
    /// </summary>
    [JsonPropertyName("vCPUsPerCore")]
    public int? VCPUsPerCore { get; set; }
}

/// <summary>
/// HardwareProfile: Specifies the hardware profile related details of a scale set.
/// Minimum api-version: 2022-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfile
{
    /// <summary>
    /// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
    /// 2022-03-01.
    /// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
    /// </summary>
    [JsonPropertyName("vmSizeProperties")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference? Reference { get; set; }
}

/// <summary>
/// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
/// Interface Configurations for Virtual Machine Scale Set with orchestration mode &apos;Flexible&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkApiVersionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkApiVersionEnum
{
    [EnumMember(Value = "2020-11-01"), JsonStringEnumMemberName("2020-11-01")]
    _20201101
}

/// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference? Reference { get; set; }
}

/// <summary>
/// PrivateIPAddressVersion: Available from Api-Version 2017-03-30 onwards, it represents whether the specific
/// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>DeleteOption: Specify what happens to the public IP when the VM is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Name: Specify public IP sku name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Tier: Specify public IP sku tier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum
{
    [EnumMember(Value = "Global"), JsonStringEnumMemberName("Global")]
    Global,
    [EnumMember(Value = "Regional"), JsonStringEnumMemberName("Regional")]
    Regional
}

/// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
{
    /// <summary>Name: Specify public IP sku name</summary>
    [JsonPropertyName("name")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Specify public IP sku tier</summary>
    [JsonPropertyName("tier")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum? Tier { get; set; }
}

/// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DeleteOption: Specify what happens to the public IP when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary>Name: The publicIP address configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot
    /// use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A scale
    /// set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the
    /// same basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>
    /// LoadBalancerInboundNatPools: Specifies an array of references to inbound Nat pools of the load balancers. A scale set
    /// can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same
    /// basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference? Reference { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

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
    public required IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations> IpConfigurations { get; set; }

    /// <summary>Name: The network configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference? Reference { get; set; }
}

/// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
    /// scale set. The reference will be in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary>
    /// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
    /// Interface Configurations for Virtual Machine Scale Set with orchestration mode &apos;Flexible&apos;
    /// </summary>
    [JsonPropertyName("networkApiVersion")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkApiVersionEnum? NetworkApiVersion { get; set; }

    /// <summary>NetworkInterfaceConfigurations: The list of network configurations.</summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
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
/// VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
/// For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
/// Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword
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
/// AssessmentMode: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.
/// Possible values are:
/// ImageDefault - You control the timing of patch assessments on a virtual machine.
/// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfRequired"), JsonStringEnumMemberName("IfRequired")]
    IfRequired,
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>
/// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
/// Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum? RebootSetting { get; set; }
}

/// <summary>
/// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
/// machine scale set with OrchestrationMode as Flexible.
/// Possible values are:
/// ImageDefault - The virtual machine&apos;s default patching configuration is used.
/// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
/// must be true
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Linux.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
    /// machine scale set with OrchestrationMode as Flexible.
    /// Possible values are:
    /// ImageDefault - The virtual machine&apos;s default patching configuration is used.
    /// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
    /// must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// KeyData: SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit
    /// and in ssh-rsa format.
    /// For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in
    /// Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates
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
    /// To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum
{
    [EnumMember(Value = "Microsoft-Windows-Shell-Setup"), JsonStringEnumMemberName("Microsoft-Windows-Shell-Setup")]
    MicrosoftWindowsShellSetup
}

/// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum
{
    [EnumMember(Value = "OobeSystem"), JsonStringEnumMemberName("OobeSystem")]
    OobeSystem
}

/// <summary>
/// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
/// AutoLogon.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
    [JsonPropertyName("componentName")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum? ComponentName { get; set; }

    /// <summary>
    /// Content: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and
    /// component. The XML must be less than 4KB and must include the root element for the setting or feature that is being
    /// inserted.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
    [JsonPropertyName("passName")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum? PassName { get; set; }

    /// <summary>
    /// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
    /// AutoLogon.
    /// </summary>
    [JsonPropertyName("settingName")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum? SettingName { get; set; }
}

/// <summary>
/// AssessmentMode: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.
/// Possible values are:
/// ImageDefault - You control the timing of patch assessments on a virtual machine.
/// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfRequired"), JsonStringEnumMemberName("IfRequired")]
    IfRequired,
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>
/// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
/// Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum? RebootSetting { get; set; }
}

/// <summary>
/// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
/// machine scale set with OrchestrationMode as Flexible.
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Windows.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary>
    /// EnableHotpatching: Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the
    /// &apos;provisionVMAgent&apos; must be set to true and &apos;patchMode&apos; must be set to &apos;AutomaticByPlatform&apos;.
    /// </summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
    /// machine scale set with OrchestrationMode as Flexible.
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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>
/// Protocol: Specifies the protocol of WinRM listener.
/// Possible values are:
/// http
/// https
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
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
    /// To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListenersProtocolEnum? Protocol { get; set; }
}

/// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    /// [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time
    /// zones returned by
    /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
    [JsonPropertyName("winRM")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfile
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
    /// VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
    /// For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
    /// Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
    /// </summary>
    [JsonPropertyName("adminPassword")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// Windows-only restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length (Linux): 1  character
    /// Max-length (Linux): 64 characters
    /// Max-length (Windows): 20 characters
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// AllowExtensionOperations: Specifies whether extension operations should be allowed on the virtual machine scale set.
    /// This may only be set to False when no extensions are present on the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

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
    /// creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
    /// </summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>
    /// Secrets: Specifies set of certificates that should be installed onto the virtual machines in the scale set. To install
    /// certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Priority: Specifies the priority for the virtual machines in the scale set.
/// Minimum api-version: 2017-10-30-preview
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// SecurityType: Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable
/// UefiSettings.
/// Default: UefiSettings will not be enabled unless this property is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum
{
    [EnumMember(Value = "ConfidentialVM"), JsonStringEnumMemberName("ConfidentialVM")]
    ConfidentialVM,
    [EnumMember(Value = "TrustedLaunch"), JsonStringEnumMemberName("TrustedLaunch")]
    TrustedLaunch
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile
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
    /// SecurityType: Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable
    /// UefiSettings.
    /// Default: UefiSettings will not be enabled unless this property is set.
    /// </summary>
    [JsonPropertyName("securityType")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileSecurityTypeEnum? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>
/// DeleteOption: Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is
/// available for VMSS with Flexible OrchestrationMode only).
/// Possible values:
/// Delete If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.
/// Detach If this value is used, the data disk is retained after VMSS Flex VM is deleted.
/// The default value is set to Delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksDeleteOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference
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
/// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
/// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
/// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
/// for encryption of just the VMGuestState blob.
/// NOTE: It can be set for only Confidential VMs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum
{
    [EnumMember(Value = "DiskWithVMGuestState"), JsonStringEnumMemberName("DiskWithVMGuestState")]
    DiskWithVMGuestState,
    [EnumMember(Value = "VMGuestStateOnly"), JsonStringEnumMemberName("VMGuestStateOnly")]
    VMGuestStateOnly
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum? SecurityEncryptionType { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>Describes a virtual machine scale set data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks
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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCachingEnum? Caching { get; set; }

    /// <summary>CreateOption: The create option.</summary>
    [JsonPropertyName("createOption")]
    public required V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DeleteOption: Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is
    /// available for VMSS with Flexible OrchestrationMode only).
    /// Possible values:
    /// Delete If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.
    /// Detach If this value is used, the data disk is retained after VMSS Flex VM is deleted.
    /// The default value is set to Delete.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksDeleteOptionEnum? DeleteOption { get; set; }

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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>
    /// CommunityGalleryImageId: Specified the community gallery image unique id for vm deployment. This can be fetched from
    /// community gallery image GET call.
    /// </summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary>Offer: Specifies the offer of the platform image or marketplace image used to create the virtual machine.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Publisher: The image publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference? Reference { get; set; }

    /// <summary>
    /// SharedGalleryImageId: Specified the shared gallery image unique id for vm deployment. This can be fetched from shared
    /// gallery image GET call.
    /// </summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }

    /// <summary>Sku: The image SKU.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// Version: Specifies the version of the platform image or marketplace image used to create the virtual machine. The
    /// allowed formats are Major.Minor.Build or &apos;latest&apos;. Major, Minor, and Build are decimal numbers. Specify &apos;latest&apos; to use
    /// the latest version of an image available at deploy time. Even if you use &apos;latest&apos;, the VM image will not automatically
    /// update after deploy time even if a new version becomes available. Please do not use field &apos;version&apos; for gallery image
    /// deployment, gallery image should always use &apos;id&apos; field for deployment, to use &apos;latest&apos; version of gallery image, just
    /// set
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}&apos;
    /// in the &apos;id&apos; field without version input.
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>
/// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available
/// for VMSS with Flexible OrchestrationMode only).
/// Possible values:
/// Delete If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.
/// Detach If this value is used, the OS disk is retained after VMSS Flex VM is deleted.
/// The default value is set to Delete. For an Ephemeral OS Disk, the default value is set to Delete. User cannot change the
/// delete option for Ephemeral OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDeleteOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum
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
/// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/sizes and
/// Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
    [JsonPropertyName("option")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsOptionEnum? Option { get; set; }

    /// <summary>
    /// Placement: Specifies the ephemeral disk placement for operating system disk.
    /// Possible values are:
    /// CacheDisk
    /// ResourceDisk
    /// Default: CacheDisk if one is configured for the VM size otherwise ResourceDisk is used.
    /// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/sizes and
    /// Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
    /// </summary>
    [JsonPropertyName("placement")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettingsPlacementEnum? Placement { get; set; }
}

/// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference
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
/// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
/// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
/// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
/// for encryption of just the VMGuestState blob.
/// NOTE: It can be set for only Confidential VMs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum
{
    [EnumMember(Value = "DiskWithVMGuestState"), JsonStringEnumMemberName("DiskWithVMGuestState")]
    DiskWithVMGuestState,
    [EnumMember(Value = "VMGuestStateOnly"), JsonStringEnumMemberName("VMGuestStateOnly")]
    VMGuestStateOnly
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum? SecurityEncryptionType { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>
/// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
/// user-image or a specialized VHD.
/// Possible values are:
/// Windows
/// Linux
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum>))]
public enum V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk
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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machines in the scale set should be created.
    /// The only allowed value is: FromImage \u2013 This value is used when you are using an image to create the virtual
    /// machine. If you are using a platform image, you also use the imageReference element described above. If you are using a
    /// marketplace image, you  also use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available
    /// for VMSS with Flexible OrchestrationMode only).
    /// Possible values:
    /// Delete If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.
    /// Detach If this value is used, the OS disk is retained after VMSS Flex VM is deleted.
    /// The default value is set to Delete. For an Ephemeral OS Disk, the default value is set to Delete. User cannot change the
    /// delete option for Ephemeral OS Disk.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>
    /// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
    /// set.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size
    /// of the disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
    [JsonPropertyName("image")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskOsTypeEnum? OsType { get; set; }

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
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add data disks to the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpecVirtualMachineProfile
{
    /// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// CapacityReservation: Specifies the capacity reservation related details of a scale set.
    /// Minimum api-version: 2021-04-01.
    /// </summary>
    [JsonPropertyName("capacityReservation")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservation? CapacityReservation { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>ExtensionProfile: Specifies a collection of settings for extensions installed on virtual machines in the scale set.</summary>
    [JsonPropertyName("extensionProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>
    /// HardwareProfile: Specifies the hardware profile related details of a scale set.
    /// Minimum api-version: 2022-03-01.
    /// </summary>
    [JsonPropertyName("hardwareProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfile? HardwareProfile { get; set; }

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
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("osProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machines in the scale set.
    /// Minimum api-version: 2017-10-30-preview
    /// </summary>
    [JsonPropertyName("priority")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfilePriorityEnum? Priority { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile? StorageProfile { get; set; }

    /// <summary>
    /// UserData: UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass
    /// any secrets in here.
    /// Minimum api-version: 2021-03-01
    /// </summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetSpec
{
    /// <summary>
    /// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
    /// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
    /// disks with UltraSSD_LRS storage account type.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20220301VirtualMachineScaleSetSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20220301VirtualMachineScaleSetSpecAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

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
    public V20220301VirtualMachineScaleSetSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
    /// Minimum api-version: 2020-06-01.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V20220301VirtualMachineScaleSetSpecHostGroup? HostGroup { get; set; }

    /// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20220301VirtualMachineScaleSetSpecIdentity? Identity { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220301VirtualMachineScaleSetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OrchestrationMode: Specifies the orchestration mode for the virtual machine scale set.</summary>
    [JsonPropertyName("orchestrationMode")]
    public V20220301VirtualMachineScaleSetSpecOrchestrationModeEnum? OrchestrationMode { get; set; }

    /// <summary>Overprovision: Specifies whether the Virtual Machine Scale Set should be overprovisioned.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220301VirtualMachineScaleSetSpecOwner Owner { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V20220301VirtualMachineScaleSetSpecPlan? Plan { get; set; }

    /// <summary>PlatformFaultDomainCount: Fault Domain count for each placement group.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine scale set
    /// should be assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V20220301VirtualMachineScaleSetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>ScaleInPolicy: Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20220301VirtualMachineScaleSetSpecScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>
    /// SinglePlacementGroup: When true this limits the scale set to a single placement group, of max size 100 virtual machines.
    /// NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may
    /// not be modified to true.
    /// </summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Sku: The virtual machine scale set sku.</summary>
    [JsonPropertyName("sku")]
    public V20220301VirtualMachineScaleSetSpecSku? Sku { get; set; }

    /// <summary>SpotRestorePolicy: Specifies the Spot Restore properties for the virtual machine scale set.</summary>
    [JsonPropertyName("spotRestorePolicy")]
    public V20220301VirtualMachineScaleSetSpecSpotRestorePolicy? SpotRestorePolicy { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UpgradePolicy: The upgrade policy.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V20220301VirtualMachineScaleSetSpecUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20220301VirtualMachineScaleSetSpecVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary>
    /// ZoneBalance: Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
    /// zoneBalance property can only be set if the zones property of the scale set contains more than one zone. If there are no
    /// zones or only one zone specified, then zoneBalance property should not be set.
    /// </summary>
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
public partial class V20220301VirtualMachineScaleSetStatusAdditionalCapabilities
{
    /// <summary>HibernationEnabled: The flag that enables or disables hibernation capability on the VM.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusAutomaticRepairsPolicy
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
    /// be specified in ISO 8601 format. The minimum allowed grace period is 10 minutes (PT10M), which is also the default
    /// value. The maximum allowed grace period is 90 minutes (PT90M).
    /// </summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }

    /// <summary>
    /// RepairAction: Type of repair action (replace, restart, reimage) that will be used for repairing unhealthy virtual
    /// machines in the scale set. Default value is replace.
    /// </summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusConditions
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
public partial class V20220301VirtualMachineScaleSetStatusExtendedLocation
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
public partial class V20220301VirtualMachineScaleSetStatusHostGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusIdentityUserAssignedIdentities
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
public partial class V20220301VirtualMachineScaleSetStatusIdentity
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
    public IDictionary<string, V20220301VirtualMachineScaleSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
/// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
/// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
/// programmatically, Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusPlan
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
public partial class V20220301VirtualMachineScaleSetStatusProximityPlacementGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ScaleInPolicy: Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusScaleInPolicy
{
    /// <summary>
    /// ForceDeletion: This property allows you to specify if virtual machines chosen for removal have to be force deleted when
    /// a virtual machine scale set is being scaled-in.(Feature in Preview)
    /// </summary>
    [JsonPropertyName("forceDeletion")]
    public bool? ForceDeletion { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusSku
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

/// <summary>SpotRestorePolicy: Specifies the Spot Restore properties for the virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusSpotRestorePolicy
{
    /// <summary>
    /// Enabled: Enables the Spot-Try-Restore feature where evicted VMSS SPOT instances will be tried to be restored
    /// opportunistically based on capacity availability and pricing constraints
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RestoreTimeout: Timeout value expressed as an ISO 8601 time duration after which the platform will not try to restore
    /// the VMSS SPOT instances
    /// </summary>
    [JsonPropertyName("restoreTimeout")]
    public string? RestoreTimeout { get; set; }
}

/// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy
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

    /// <summary>
    /// UseRollingUpgradePolicy: Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value
    /// is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS.
    /// </summary>
    [JsonPropertyName("useRollingUpgradePolicy")]
    public bool? UseRollingUpgradePolicy { get; set; }
}

/// <summary>RollingUpgradePolicy: The configuration parameters used while performing a rolling upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy
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
public partial class V20220301VirtualMachineScaleSetStatusUpgradePolicy
{
    /// <summary>AutomaticOSUpgradePolicy: Configuration parameters used for performing automatic OS Upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V20220301VirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>Specifies the required information to reference a compute gallery application version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfileGalleryApplications
{
    /// <summary>
    /// ConfigurationReference: Optional, Specifies the uri to an azure blob that will replace the default configuration for the
    /// package if provided
    /// </summary>
    [JsonPropertyName("configurationReference")]
    public string? ConfigurationReference { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: If set to true, when a new Gallery Application version is available in PIR/SIG, it will be
    /// automatically updated for the VM/VMSS
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>Order: Optional, Specifies the order in which the packages have to be installed</summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// PackageReferenceId: Specifies the GalleryApplicationVersion resource id on the form of
    /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
    /// </summary>
    [JsonPropertyName("packageReferenceId")]
    public string? PackageReferenceId { get; set; }

    /// <summary>Tags: Optional, Specifies a passthrough value for more generic context.</summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// TreatFailureAsDeploymentFailure: Optional, If true, any failure for any operation in the VmApplication will fail the
    /// deployment
    /// </summary>
    [JsonPropertyName("treatFailureAsDeploymentFailure")]
    public bool? TreatFailureAsDeploymentFailure { get; set; }
}

/// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfile
{
    /// <summary>GalleryApplications: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile
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
/// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
/// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
/// https://aka.ms/CapacityReservation for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservationCapacityReservationGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// CapacityReservation: Specifies the capacity reservation related details of a scale set.
/// Minimum api-version: 2021-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservation
{
    /// <summary>
    /// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
    /// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
    /// https://aka.ms/CapacityReservation for more details.
    /// </summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}

/// <summary>
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// NOTE: If storageUri is being specified then ensure that the storage account is in the same region and subscription as
/// the VM.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// NOTE: If storageUri is being specified then ensure that the storage account is in the same region and subscription as
    /// the VM.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// ProtectedSettingsFromKeyVault: The extensions protected settings that are passed by reference, and consumed from key
/// vault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault? SourceVault { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions
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

    /// <summary>
    /// ProtectedSettingsFromKeyVault: The extensions protected settings that are passed by reference, and consumed from key
    /// vault
    /// </summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

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

    /// <summary>
    /// SuppressFailures: Indicates whether failures stemming from the extension will be suppressed (Operational failures such
    /// as not connecting to the VM will not be suppressed regardless of this value). The default is false.
    /// </summary>
    [JsonPropertyName("suppressFailures")]
    public bool? SuppressFailures { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile
{
    /// <summary>Extensions: The virtual machine scale set child extension resources.</summary>
    [JsonPropertyName("extensions")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

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
/// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
/// 2022-03-01.
/// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfileVmSizeProperties
{
    /// <summary>
    /// VCPUsAvailable: Specifies the number of vCPUs available for the VM.
    /// When this property is not specified in the request body the default behavior is to set it to the value of vCPUs
    /// available for that VM size exposed in api response of [List all available virtual machine sizes in a
    /// region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) .
    /// </summary>
    [JsonPropertyName("vCPUsAvailable")]
    public int? VCPUsAvailable { get; set; }

    /// <summary>
    /// VCPUsPerCore: Specifies the vCPU to physical core ratio.
    /// When this property is not specified in the request body the default behavior is set to the value of vCPUsPerCore for the
    /// VM Size exposed in api response of [List all available virtual machine sizes in a
    /// region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list)
    /// Setting this property to 1 also means that hyper-threading is disabled.
    /// </summary>
    [JsonPropertyName("vCPUsPerCore")]
    public int? VCPUsPerCore { get; set; }
}

/// <summary>
/// HardwareProfile: Specifies the hardware profile related details of a scale set.
/// Minimum api-version: 2022-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfile
{
    /// <summary>
    /// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
    /// 2022-03-01.
    /// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
    /// </summary>
    [JsonPropertyName("vmSizeProperties")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>
/// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
/// scale set. The reference will be in the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>Id: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
{
    /// <summary>Name: Specify public IP sku name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Specify public IP sku tier</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DeleteOption: Specify what happens to the public IP when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Subnet: Specifies the identifier of the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Id: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot
    /// use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A scale
    /// set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the
    /// same basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>
    /// LoadBalancerInboundNatPools: Specifies an array of references to inbound Nat pools of the load balancers. A scale set
    /// can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same
    /// basic sku load balancer.
    /// </summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>NetworkSecurityGroup: The network security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine scale set network profile&apos;s network configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

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
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Name: The network configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>NetworkProfile: Specifies properties of the network interfaces of the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile
{
    /// <summary>
    /// HealthProbe: A reference to a load balancer probe used to determine the health of an instance in the virtual machine
    /// scale set. The reference will be in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;.
    /// </summary>
    [JsonPropertyName("healthProbe")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary>
    /// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
    /// Interface Configurations for Virtual Machine Scale Set with orchestration mode &apos;Flexible&apos;
    /// </summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary>NetworkInterfaceConfigurations: The list of network configurations.</summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>
/// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
/// Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Linux.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
    /// machine scale set with OrchestrationMode as Flexible.
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>
    /// KeyData: SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit
    /// and in ssh-rsa format.
    /// For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in
    /// Azure]https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates
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
    /// To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
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

/// <summary>
/// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
/// Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Windows.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary>
    /// EnableHotpatching: Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the
    /// &apos;provisionVMAgent&apos; must be set to true and &apos;patchMode&apos; must be set to &apos;AutomaticByPlatform&apos;.
    /// </summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
    /// machine scale set with OrchestrationMode as Flexible.
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
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
    /// To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    /// [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time
    /// zones returned by
    /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
    [JsonPropertyName("winRM")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfile
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
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// AllowExtensionOperations: Specifies whether extension operations should be allowed on the virtual machine scale set.
    /// This may only be set to False when no extensions are present on the virtual machine scale set.
    /// </summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

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
    /// creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
    /// </summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>
    /// Secrets: Specifies set of certificates that should be installed onto the virtual machines in the scale set. To install
    /// certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile
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
    /// SecurityType: Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable
    /// UefiSettings.
    /// Default: UefiSettings will not be enabled unless this property is set.
    /// </summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
/// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks
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
    /// DeleteOption: Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is
    /// available for VMSS with Flexible OrchestrationMode only).
    /// Possible values:
    /// Delete If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.
    /// Detach If this value is used, the data disk is retained after VMSS Flex VM is deleted.
    /// The default value is set to Delete.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>
    /// CommunityGalleryImageId: Specified the community gallery image unique id for vm deployment. This can be fetched from
    /// community gallery image GET call.
    /// </summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

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

    /// <summary>
    /// SharedGalleryImageId: Specified the shared gallery image unique id for vm deployment. This can be fetched from shared
    /// gallery image GET call.
    /// </summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }

    /// <summary>Sku: The image SKU.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// Version: Specifies the version of the platform image or marketplace image used to create the virtual machine. The
    /// allowed formats are Major.Minor.Build or &apos;latest&apos;. Major, Minor, and Build are decimal numbers. Specify &apos;latest&apos; to use
    /// the latest version of an image available at deploy time. Even if you use &apos;latest&apos;, the VM image will not automatically
    /// update after deploy time even if a new version becomes available. Please do not use field &apos;version&apos; for gallery image
    /// deployment, gallery image should always use &apos;id&apos; field for deployment, to use &apos;latest&apos; version of gallery image, just
    /// set
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}&apos;
    /// in the &apos;id&apos; field without version input.
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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
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
    /// Refer to VM size documentation for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/sizes and
    /// Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
    /// </summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
/// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

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
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk
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
    /// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available
    /// for VMSS with Flexible OrchestrationMode only).
    /// Possible values:
    /// Delete If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.
    /// Detach If this value is used, the OS disk is retained after VMSS Flex VM is deleted.
    /// The default value is set to Delete. For an Ephemeral OS Disk, the default value is set to Delete. User cannot change the
    /// delete option for Ephemeral OS Disk.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>
    /// DiffDiskSettings: Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale
    /// set.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size
    /// of the disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Image: Specifies information about the unmanaged user image to base the scale set on.</summary>
    [JsonPropertyName("image")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add data disks to the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machines in the scale set.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatusVirtualMachineProfile
{
    /// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// CapacityReservation: Specifies the capacity reservation related details of a scale set.
    /// Minimum api-version: 2021-04-01.
    /// </summary>
    [JsonPropertyName("capacityReservation")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservation? CapacityReservation { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>
    /// HardwareProfile: Specifies the hardware profile related details of a scale set.
    /// Minimum api-version: 2022-03-01.
    /// </summary>
    [JsonPropertyName("hardwareProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfile? HardwareProfile { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>OsProfile: Specifies the operating system settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("osProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machines in the scale set.
    /// Minimum api-version: 2017-10-30-preview
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machines in the scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile? StorageProfile { get; set; }

    /// <summary>
    /// UserData: UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass
    /// any secrets in here.
    /// Minimum api-version: 2021-03-01
    /// </summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

/// <summary>Describes a Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301VirtualMachineScaleSetStatus
{
    /// <summary>
    /// AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual
    /// Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data
    /// disks with UltraSSD_LRS storage account type.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V20220301VirtualMachineScaleSetStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>AutomaticRepairsPolicy: Policy for automatic repairs.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V20220301VirtualMachineScaleSetStatusAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220301VirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DoNotRunExtensionsOnOverprovisionedVMs: When Overprovision is enabled, extensions are launched only on the requested
    /// number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra
    /// overprovisioned VMs.
    /// </summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20220301VirtualMachineScaleSetStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine scale set resides in.
    /// Minimum api-version: 2020-06-01.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V20220301VirtualMachineScaleSetStatusHostGroup? HostGroup { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the virtual machine scale set, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20220301VirtualMachineScaleSetStatusIdentity? Identity { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusPlan? Plan { get; set; }

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
    public V20220301VirtualMachineScaleSetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>ScaleInPolicy: Specifies the policies applied when scaling in Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V20220301VirtualMachineScaleSetStatusScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>
    /// SinglePlacementGroup: When true this limits the scale set to a single placement group, of max size 100 virtual machines.
    /// NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may
    /// not be modified to true.
    /// </summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Sku: The virtual machine scale set sku.</summary>
    [JsonPropertyName("sku")]
    public V20220301VirtualMachineScaleSetStatusSku? Sku { get; set; }

    /// <summary>SpotRestorePolicy: Specifies the Spot Restore properties for the virtual machine scale set.</summary>
    [JsonPropertyName("spotRestorePolicy")]
    public V20220301VirtualMachineScaleSetStatusSpotRestorePolicy? SpotRestorePolicy { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TimeCreated: Specifies the time at which the Virtual Machine Scale Set resource was created.
    /// Minimum api-version: 2022-03-01.
    /// </summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UniqueId: Specifies the ID which uniquely identifies a Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>UpgradePolicy: The upgrade policy.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V20220301VirtualMachineScaleSetStatusUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>VirtualMachineProfile: The virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V20220301VirtualMachineScaleSetStatusVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary>
    /// ZoneBalance: Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
    /// zoneBalance property can only be set if the zones property of the scale set contains more than one zone. If there are no
    /// zones or only one zone specified, then zoneBalance property should not be set.
    /// </summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Zones: The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachineScaleSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301VirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V20220301VirtualMachineScaleSetSpec?>, IStatus<V20220301VirtualMachineScaleSetStatus?>
{
    public const string KubeApiVersion = "v20220301";
    public const string KubeKind = "VirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineScaleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220301VirtualMachineScaleSetSpec? Spec { get; set; }

    /// <summary>Describes a Virtual Machine Scale Set.</summary>
    [JsonPropertyName("status")]
    public V20220301VirtualMachineScaleSetStatus? Status { get; set; }
}